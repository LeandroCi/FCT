using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.NewFolder1;
using WindowsFormsApplication1.Nego;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Negocio n = new Negocio();

        public Form1()
        {
            InitializeComponent();
            n.DGFill(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n.Guardar(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n.Descartar(sender, e);
        }
    }
}
