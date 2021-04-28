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
        public OdbcDataReader funcSelect(string Tabla)
        {
            string Consulta = "SELECT * FROM " + Tabla + ";";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectAll ()
        {
            string Consulta = "select pro.nombrePro as producto, em.nombreEmpresa as empresa, bo.descripcionBodega as bodega, ex.cantidad_existencia as existencia, ex.existenica_maxima as maxima, ex.existenica_minima as minima from (existencia ex inner join empresa em on em.pkIdEmpresa = ex.fkIdEmpresa inner join bodega bo on bo.pkIdBodega= ex.fkIdBodega inner join producto pro on pro.pkIdProducto= ex.fkIdPro) where estado_existencia = 1;";
            return Modelo.funcConsulta(Consulta);
        }
    }
}
