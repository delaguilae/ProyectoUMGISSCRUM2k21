using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class clsMovInventariosMo
    {
        Conexion cn = new Conexion();
        OdbcCommand Comm;
        OdbcTransaction transaction = null;
        //Funcion Consulta General
        public OdbcDataReader funcConsulta(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                return reader;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en Consulta General: " + Error);
                return null;
            }
        }
        //Consulta para calcular existencia
        public int funcConsExistencia(string Consulta)
        {
            try
            {
                int intExistencia=0;
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                reader.Read();
                intExistencia = reader.GetInt32(0);
                reader.Close();
                return intExistencia;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error Consulta Existencia: " + Error);
                return 0;
            }
        }

        //Funcion Para ejecutar querrys
        public string funcEjeQuerry(string strConsulta)
        {
            try
            {
                Comm = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                reader.Read();
                reader.Close();
                return "Se Realizo el Movimiento";
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error Consulta Existencia: " + Error);
                return "No Se Realizo el Movimiento";
            }
        }
        //funcion Realizar la transaccion de movimientos
        public string funTransaccionMovimiento(string strConsulta)
        {
            int bandera = 0;
            var resultado = cn.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand cmd = resultado.Item1.CreateCommand();
            cmd.Transaction = transaction;
            try
            {
                
                Comm = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                reader.Read();
                reader.Close();
                return "Se Hizo La Accion";
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error Consulta Existencia: " + Error);
                return "No Se Pudo Hacer La Accion";
            }
        }
    }
}
