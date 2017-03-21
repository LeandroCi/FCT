using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.NewFolder1;

namespace WindowsFormsApplication1.Nego
{
    public class Negocio
    {
        Conex c;

        public Negocio() {
           c = new Conex();
        }

        public void Guardar(object sender, EventArgs e)
        {
            c.adaptador.Update(c.datos.Tables["alumnos"]);
            c.datos.Tables[0].AcceptChanges();
        }

        public void Descartar(object sender, EventArgs e)
        {
            c.datos.Tables[0].RejectChanges();
        }

        public void DGFill(DataGridView dgv)
        {
            dgv.DataSource = c.datos.Tables["alumnos"];
        }
    }    
}
