using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.NewFolder1
{
    public class Conex
    {
        MySqlConnection conn;
        public MySqlDataAdapter adaptador;
        MySqlCommandBuilder comandbuilder;
        public DataSet datos;

        public Conex()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=root";
            datos = new DataSet();
            adaptador = new MySqlDataAdapter("select * from alumnos", conn);
            adaptador.Fill(datos, "alumnos");
            comandbuilder = new MySqlCommandBuilder(adaptador);
        }
    }
}
