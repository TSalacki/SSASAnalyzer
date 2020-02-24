using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SSASAnalyser
{
    public class QueryModel
    {
        //name, query, repetitions
        public List<Tuple<string, string, int>> Queries { get; set; }
        public int CurrentQueryIndex { get; set; }

        public QueryModel()
        {
            this.CurrentQueryIndex = 0;
            this.Queries = new List<Tuple<string, string, int>>
            {
                new Tuple<string, string, int>("FirstQuery", "", 1)
            };
        }

        public List<string> GetQueryNames()
        {
            List<string> queryNames = new List<string>();
            foreach (var t in this.Queries)
            {
                queryNames.Add(t.Item1);
            }
            return queryNames;
        }

        public Tuple<string, string, int> FindQueryByTitle(string title)
        {
            foreach(var tuple in this.Queries)
            {
                if (tuple.Item1.Equals(title))
                    return tuple;
            }
            return null;
        }

        public void RemoveQueryByTitle(string title)
        {
            for(int i = 0; i < this.Queries.Count; i++)
            {
                if(this.Queries[i].Item1.Equals(title))
                {
                    this.Queries.RemoveAt(i);
                    return;
                }
            }
        }

        public void EditQueryByTitle(string title, string newTitle, string newQuery, int newRepetitions)
        {
            for (int i = 0; i < this.Queries.Count; i++)
            {
                if (this.Queries[i].Item1.Equals(title))
                {
                    this.Queries[i] = new Tuple<string, string, int>(newTitle, newQuery, newRepetitions);
                    return;
                }
            }
        }

        public void SaveQueryListToFile(string fileName)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName);
            string jsonString = JsonConvert.SerializeObject(this.Queries);

            writer.Write(jsonString);
            writer.Close();
        }

        public void LoadQueryListFromFile(string fileName)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(fileName);
            string jsonString = reader.ReadToEnd();
            try
            {
                this.Queries = JsonConvert.DeserializeObject<List<Tuple<string, string, int>>>(jsonString);

            }
            catch(JsonReaderException e)
            {
                reader.Close();
                throw new Exception(e.Message);
            }

            reader.Close();
        }

    }
}
