using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AnalysisServices;
using Microsoft.AnalysisServices.AdomdClient;
using Microsoft.AnalysisServices.Xmla;


namespace SSASAnalyser
{
    public enum SSASConnectionState
    {
        CLOSED = 1,
        TABULAR = 2,
        MULTIDIMENSIONAL = 0
    }
    public class Model
    {
        public AdomdConnection SSASConnection { get; set; }
        public SSASConnectionState ConnectionState { get; set; }
        public string DatabaseName { get; set; }
        private StringBuilder QueryResult { get; set; }
        public bool CacheClearing { get; set; }
        public List<int> RepetitionsToDoList { get; set; }
        public List<List<long>> QueryExecutionTimes { get; set; }
        public Server Srv { get; set; }
        private int CurrentQueryIndex { get; set; }

        public event EventHandler ReadyToDisplayChart;

        public Model()
        {
            this.Srv = new Server();
            this.QueryResult = new StringBuilder();
            this.CacheClearing = false;
            this.QueryExecutionTimes = new List<List<long>>();
            this.RepetitionsToDoList = new List<int>();
            this.CurrentQueryIndex = 0;
            this.SSASConnection = new AdomdConnection();
            this.ConnectionState = SSASConnectionState.CLOSED;
        }

        public void MakeConnection(string ConnectionString, SSASConnectionState state)
        {
            try
            {
                SSASConnection = new AdomdConnection
                {
                    ConnectionString = ConnectionString
                };
                Srv.Connect(ConnectionString);
                if ((int)Srv.ServerMode != (int)state)
                    throw new Exception("Wrong connection type! Server you've tried to connect is " + Srv.ServerMode.ToString());
                SSASConnection.SessionID = Srv.SessionID;
                SSASConnection.Open();
                ConnectionState = state;
                DatabaseName = SSASConnection.Database;
                PrepareTrace();
            }
            catch (Exception e)
            {
                if (SSASConnection.State == System.Data.ConnectionState.Open)
                    SSASConnection.Close();
                if (Srv.Connected)
                    Srv.Disconnect();
                throw new Exception(e.Message, e);
            }
        }

        public void PrepareTrace()
        {
            this.Srv.SessionTrace.OnEvent += this.Trace_OnEvent;
            this.Srv.SessionTrace.Stopped += this.Trace_Stopped;
        }


        public void Trace_OnEvent(object sender, TraceEventArgs e)
        {
            if (e.EventClass == TraceEventClass.QueryEnd)
            {
                this.QueryExecutionTimes[this.QueryExecutionTimes.Count-1].Add(e.Duration);
                if (this.QueryExecutionTimes[this.QueryExecutionTimes.Count - 1].Count == this.RepetitionsToDoList[CurrentQueryIndex])
                {
                    if(this.CurrentQueryIndex != this.RepetitionsToDoList.Count - 1)
                    {
                        this.QueryExecutionTimes.Add(new List<long>());
                        this.CurrentQueryIndex++;
                        return;
                    }
                    this.CurrentQueryIndex = 0;
                    this.ReadyToDisplayChart(this, null);
                }
            }
        }

        public void Trace_Stopped(ITrace sender, TraceStoppedEventArgs e)
        {
            switch (e.StopCause)
            {
                case TraceStopCause.StoppedByUser:
                    break;
                case TraceStopCause.Finished:
                    if (this.QueryExecutionTimes[this.QueryExecutionTimes.Count-1].Count < this.RepetitionsToDoList[CurrentQueryIndex])
                        this.QueryExecutionTimes.RemoveAt(this.QueryExecutionTimes.Count - 1);
                    break;

                case TraceStopCause.StoppedByException:
                    break;
            }
            this.CurrentQueryIndex = 0;
        }

        public void ClearCache()
        {
            XmlaClient clnt = new XmlaClient();
            string xmla;
            
            clnt.Connect(SSASConnection.ConnectionString);
            xmla = @"<ClearCache xmlns=""http://schemas.microsoft.com/analysisservices/2003/engine"">
                    <Object>
                    <DatabaseID>" + this.DatabaseName + @"</DatabaseID>
                    </Object>
                    </ClearCache>";
            try
            {
                clnt.Send(xmla, null);
            }
            catch (XmlaException e)
            {
                clnt.Disconnect();
                throw new Exception(e.Message, e);
            }
            
            clnt.Disconnect();
        }

        public void RunQuerry(string query)
        {
            this.QueryResult.Clear();
            AdomdCommand cmd = new AdomdCommand(query.ToString(), SSASConnection);
            try
            {
                cmd.ExecuteReader().Close();
                if (this.CacheClearing)
                    this.ClearCache();
            }
            catch (Exception e)
            {
                cmd.Dispose();
                throw new Exception(e.Message, e);
            }
        }
    }
}
