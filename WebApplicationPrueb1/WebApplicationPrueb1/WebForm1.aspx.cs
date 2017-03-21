using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPrueb1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["cv"]);
            if (Session["User"] != null)
            {
                Label2.Text = "Usuario conectado: "+(Session["User"].ToString());
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool Autenticado = false;
            Autenticado = LoginCorrecto(Login1.UserName, Login1.Password); 
            e.Authenticated = Autenticado;
            if (Autenticado)
            {
                Session["User"] = Login1.UserName;
                Response.Redirect("WebForm1.aspx");
            }
            else { Session["User"] = null; Label2.Text = ""; }
        }
        private bool LoginCorrecto(string Usuario, string Contrasena) { 
            if (Usuario.Equals("prueba") && Contrasena.Equals("root"))
            return true; return false;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
