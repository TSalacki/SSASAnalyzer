using System.Windows.Forms;

namespace SSASAnalyser
{
    public static class GuiExtensionMethods
    {
        public static void EnableDown(this Control con)
        {
            if (con != null)
            {
                foreach (Control c in con.Controls)
                {
                    c.EnableDown();
                }

                try
                {
                    con.Invoke((MethodInvoker)(() => con.Enabled = true));
                }
                catch
                {
                }

            }
        }

        public static void EnableUp(this Control con)
        {
            if (con != null)
            {
                con.Parent.EnableUp();

                try
                {
                    con.Invoke((MethodInvoker)(() => con.Enabled = true));
                }
                catch
                {
                }

            }
        }

        public static void DisableDown(this Control con)
        {
            if (con != null)
            {
                foreach (Control c in con.Controls)
                {
                    c.DisableDown();
                }

                try
                {
                    con.Invoke((MethodInvoker)(() => con.Enabled = false));
                }
                catch
                {
                }
            }
        }
    }
}
