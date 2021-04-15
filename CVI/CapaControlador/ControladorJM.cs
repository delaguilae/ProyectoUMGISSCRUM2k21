using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class ControladorJM
    {
        Sentencias Modelo = new Sentencias();
        //Get data from table to cb
        public DataTable FieldCombobox(string field1, string field2, string table, string status)
        {
            string Comando = string.Format("SELECT " + field1 + " ," + field2 + " FROM " + table + " WHERE " + status + "= 1;");
            return Modelo.funcObtenerCamposCombobox(Comando);
        }
        public OdbcDataReader FieldComboboxtxt(string field1, string table, string status, string field2, string condition)
        {
            string Comando = string.Format("SELECT " + field1 + " FROM " + table + " WHERE " + status + "= 1 AND "+ field2 +" = '"+condition+"';");
            return Modelo.funcConsulta(Comando);
        }
    }
}
