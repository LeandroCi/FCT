using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPrueb1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlDataAdapter adaptador;
        SqlCommandBuilder comandbuilder;
        DataSet datos;

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["cv"]);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String dni = DropDownList1.Text;
            conn = new SqlConnection();
            conn.ConnectionString = "Server=localhost\\SQLEXPRESS01;Database=Prueba;Trusted_Connection=True;";
            datos = new DataSet();
            adaptador = new SqlDataAdapter("select * from personas where dni like'"+dni+"'", conn);
            adaptador.Fill(datos, "personas");
            GridView1.DataSource = datos.Tables["personas"];
            GridView1.DataBind();
        }
    }
}