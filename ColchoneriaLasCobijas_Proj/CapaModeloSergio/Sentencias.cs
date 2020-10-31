using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModelo;

namespace CapaModeloSergio
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        public void procInsertar(string nombre, string mes, string year)
        {
           
            string sql = "SELECT MAX(codigo_producto) FROM productos ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {



                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }
        }
    }
}
