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
        public DataTable FieldComboboxCondition(string field1, string field2, string table, string conditionfield, string conditiondata, string status)
        {
            string Comando = string.Format("SELECT " + field1 + " ," + field2 + " FROM " + table + " WHERE "+ conditionfield +"=" + conditiondata + " AND " + status + "= 1;");
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
            string Consulta = "select pro.nombrePro as producto, em.nombreEmpresa as empresa, bo.descripcionBodega as bodega, ex.cantidad_existencia as existencia, ex.existencia_maxima as maxima, ex.existencia_minima as minima from (existencia ex inner join empresa em on em.pkIdEmpresa = ex.fkIdEmpresa inner join bodega bo on bo.pkIdBodega= ex.fkIdBodega inner join producto pro on pro.pkIdProducto= ex.fkIdPro) where estado_existencia = 1;";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectSearchInv(string empresa, string bodega)
        {
            string Consulta = "select pro.nombrePro as producto, em.nombreEmpresa as empresa, bo.descripcionBodega as bodega, ex.cantidad_existencia as existencia, ex.existencia_maxima as maxima, ex.existencia_minima as minima from (existencia ex inner join empresa em on em.pkIdEmpresa = ex.fkIdEmpresa inner join bodega bo on bo.pkIdBodega = ex.fkIdBodega inner join producto pro on pro.pkIdProducto = ex.fkIdPro)WHERE ex.fkidEmpresa = " + empresa+" AND bo.descripcionBodega = '"+bodega+"' AND ex.estado_existencia = 1;";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectSearchInvproduct(string empresa, string bodega, string product)
        {
            string Consulta = "select pro.nombrePro as producto, em.nombreEmpresa as empresa, bo.descripcionBodega as bodega, ex.cantidad_existencia as existencia, ex.existencia_maxima as maxima, ex.existencia_minima as minima from (existencia ex inner join empresa em on em.pkIdEmpresa = ex.fkIdEmpresa inner join bodega bo on bo.pkIdBodega = ex.fkIdBodega inner join producto pro on pro.pkIdProducto = ex.fkIdPro)WHERE ex.fkidEmpresa = " + empresa + " AND bo.descripcionBodega = '" + bodega + "' AND ex.estado_existencia = 1 AND pro.nombrePro LIKE '%"+product+"%';";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectSearchInvproductotal(string product)
        {
            string Consulta = "select pro.nombrePro as producto, em.nombreEmpresa as empresa, bo.descripcionBodega as bodega, ex.cantidad_existencia as existencia, ex.existencia_maxima as maxima, ex.existencia_minima as minima from (existencia ex inner join empresa em on em.pkIdEmpresa = ex.fkIdEmpresa inner join bodega bo on bo.pkIdBodega = ex.fkIdBodega inner join producto pro on pro.pkIdProducto = ex.fkIdPro)WHERE ex.estado_existencia = 1 AND pro.nombrePro LIKE '%" + product + "%';";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectSearchInvproductminima(string empresa, string bodega)
        {
            string Consulta = "select pro.nombrePro as producto, em.nombreEmpresa as empresa, bo.descripcionBodega as bodega, ex.cantidad_existencia as existencia, ex.existencia_maxima as maxima, ex.existencia_minima as minima from (existencia ex inner join empresa em on em.pkIdEmpresa = ex.fkIdEmpresa inner join bodega bo on bo.pkIdBodega = ex.fkIdBodega inner join producto pro on pro.pkIdProducto = ex.fkIdPro)WHERE ex.fkidEmpresa = " + empresa + " AND bo.descripcionBodega = '" + bodega + "' AND ex.estado_existencia = 1 AND ex.existencia_minima >= cantidad_existencia;";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectSearchInvproductotalminima()
        {
            string Consulta = "select pro.nombrePro as producto, em.nombreEmpresa as empresa, bo.descripcionBodega as bodega, ex.cantidad_existencia as existencia, ex.existencia_maxima as maxima, ex.existencia_minima as minima from (existencia ex inner join empresa em on em.pkIdEmpresa = ex.fkIdEmpresa inner join bodega bo on bo.pkIdBodega = ex.fkIdBodega inner join producto pro on pro.pkIdProducto = ex.fkIdPro)WHERE ex.estado_existencia = 1 AND ex.existencia_minima >= cantidad_existencia;";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectSearchInvproductmaxima(string empresa, string bodega)
        {
            string Consulta = "select pro.nombrePro as producto, em.nombreEmpresa as empresa, bo.descripcionBodega as bodega, ex.cantidad_existencia as existencia, ex.existencia_maxima as maxima, ex.existencia_minima as minima from (existencia ex inner join empresa em on em.pkIdEmpresa = ex.fkIdEmpresa inner join bodega bo on bo.pkIdBodega = ex.fkIdBodega inner join producto pro on pro.pkIdProducto = ex.fkIdPro)WHERE ex.fkidEmpresa = " + empresa + " AND bo.descripcionBodega = '" + bodega + "' AND ex.estado_existencia = 1 AND existencia_maxima < cantidad_existencia;";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectSearchInvproductotalmaxima()
        {
            string Consulta = "select pro.nombrePro as producto, em.nombreEmpresa as empresa, bo.descripcionBodega as bodega, ex.cantidad_existencia as existencia, ex.existencia_maxima as maxima, ex.existencia_minima as minima from (existencia ex inner join empresa em on em.pkIdEmpresa = ex.fkIdEmpresa inner join bodega bo on bo.pkIdBodega = ex.fkIdBodega inner join producto pro on pro.pkIdProducto = ex.fkIdPro)WHERE ex.estado_existencia = 1 AND existencia_maxima < cantidad_existencia;";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectllenardgvMovimiento()
        {
            string Consulta = "select MOV.PKMOVIMIENTO, fkidproducto, PROD.nombrePro, MOV.fkbodegaorigen, MOV.fkbodegadestino, MOV.cantidad, MOV.RAZON, LOGIN.usuario_login from MOVIMIENTOINVENTARIO MOV INNER JOIN producto PROD ON MOV.FKIDPRODUCTO = PROD.pkIdProducto INNER JOIN LOGIN ON LOGIN.pk_id_login = MOV.fkencargado;";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcSelectllenardgvMovimientofiltro(string campo, string dato)
        {
            string Consulta = "select MOV.PKMOVIMIENTO, fkidproducto, PROD.nombrePro, MOV.fkbodegaorigen, MOV.fkbodegadestino, MOV.cantidad, MOV.RAZON, LOGIN.usuario_login from MOVIMIENTOINVENTARIO MOV INNER JOIN producto PROD ON MOV.FKIDPRODUCTO = PROD.pkIdProducto INNER JOIN LOGIN ON LOGIN.pk_id_login = MOV.fkencargado WHERE "+campo+"= "+dato+";";
            return Modelo.funcConsulta(Consulta);
        }
    }
}
