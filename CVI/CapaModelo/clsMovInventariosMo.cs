using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{
    public class clsMovInventariosMo
    {
        Conexion cn = new Conexion();
        OdbcCommand Comm;
        OdbcTransaction transaction = null;
        string strSql = "";
        public int funcObtenerID(string strConsulta)
        {
            try
            {
                int intIdUsuario = 0;
                Comm = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                reader.Read();
                intIdUsuario = reader.GetInt32(0);
                reader.Close();
                return intIdUsuario;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error Consulta Id Usuario: " + Error);
                return 0;
            }
        }
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
        /*public bool InsertarMovmientos(List<clsDatosEncapsuladosMo> LstDetalletraslado)
        {
            int bandera = 0;
            var resultado = cn.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand cmd = resultado.Item1.CreateCommand();
            cmd.Transaction = transaction;
           
            foreach (clsDatosEncapsuladosMo detalleTraslado in LstDetalletraslado)
            {
                try
                {
                    strSql = "INSERT INTO movimientoinventario (fkidproducto, fkbodegaorigen, fkbodegadestino,cantidad,razon,fkencargado) " +
                            "VALUES ('" + detalleTraslado.StrIdProducto + "','" + detalleTraslado.StrIdBodegaOrigen + "','" + detalleTraslado.StrIdBodegaDestino + "','" + detalleTraslado.StrCantidad + "','" + detalleTraslado.StrRazonMov + "','" + detalleTraslado.StrEncargado + "');";
                    cmd.CommandText = strSql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movmientos Guardados guardado");
                }
                catch (OdbcException err)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error\n Rollback realizado en Movimientos" + err.Message);
                    Console.WriteLine("eroro", err.Message);
                    bandera = 1;
                    return false;
                }
            }           
            if (bandera == 0)
            {
                transaction.Commit();
                MessageBox.Show("realizando commit datos guardados");
            }
            else
            {
                bandera = 0;
            }
            return true;
        }*/
    }
}
