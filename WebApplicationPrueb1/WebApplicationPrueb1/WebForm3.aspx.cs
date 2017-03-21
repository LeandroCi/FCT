using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPrueb1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["cv"]);
            string fecha = Calendar1.TodaysDate.Day.ToString() +
              Calendar1.TodaysDate.Month.ToString() +
              Calendar1.TodaysDate.Year.ToString();
            if (File.Exists(Server.MapPath(".") + "/" + fecha))
            {
                StreamReader arch = new StreamReader(Server.MapPath(".") + "/" + fecha);
                TextBox1.Text = arch.ReadToEnd();
                arch.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fecha = Calendar1.SelectedDate.Day.ToString() +
                       Calendar1.SelectedDate.Month.ToString() +
                       Calendar1.SelectedDate.Year.ToString();
            StreamWriter arch = new StreamWriter(Server.MapPath(".") + "/" + fecha, true);
            arch.WriteLine(TextBox1.Text);
            arch.Close();
        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {
            string fecha = Calendar1.SelectedDate.Day.ToString() +
               Calendar1.SelectedDate.Month.ToString() +
               Calendar1.SelectedDate.Year.ToString();
            if (File.Exists(Server.MapPath(".") + "/" + fecha))
            {
                StreamReader arch = new StreamReader(Server.MapPath(".") + "/" + fecha);
                TextBox1.Text = arch.ReadToEnd();
                arch.Close();
            }
            else
                TextBox1.Text = "";
        }
    }
}