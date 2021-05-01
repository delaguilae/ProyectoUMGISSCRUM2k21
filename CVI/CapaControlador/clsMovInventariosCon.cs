using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class clsMovInventariosCon
    {
        clsMovInventariosMo Modelo = new clsMovInventariosMo();

        //Funcion obtener Id del suario
        public int funcObtenerIDUsuario(string Usuario)
        {
            string consulta = "SELECT pk_id_login from login where usuario_login = '" + Usuario + "' and estado_login = 1;";
            return Modelo.funcObtenerID(consulta);
        }
        //Funcion Para Consultar Detalles de la bodega.
        public OdbcDataReader funcConsulta()
        {
            string Consulta = "SELECT pkIdBodega, fkIdEmpresa, fkIdSucursal, direccionBodega FROM bodega where estadoBodega = 1;";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcConsultaMov()
        {
            string Consulta = "SELECT * FROM movimientoinventario;";
            return Modelo.funcConsulta(Consulta);
        }
        //Funcion Para Consultar Detalles del Producto.
        public OdbcDataReader funcConsultaProducto()
        {
            string Consulta = "SELECT pkIdProducto, fkIdEmpresa, fkIdLineaPro, fkIdMarcaPro, nombrePro FROM producto where estadoPro = 1;";
            return Modelo.funcConsulta(Consulta);
        }

        //funcion Para Consultar Total de existencia de un producto.
        public int funcConsExistencia(int idEmpresa, int idSucursal, int idBodega, int idProducto)
        {
            string strConsulta = "call sp_ExistenciaProducto(" + idEmpresa + "," + idSucursal + "," + idBodega + "," + idProducto + ");";
            return Modelo.funcConsExistencia(strConsulta);
        }
        
        //funcion para movimeinto inventario.
        public string funcMovInventario(int idMovimiento, int idEmpresaO, int idSucursalO, int idBodegaO, int idEmpresaD, int idSucursalD, int idBodegaD, int idProducto, int Cantidad, string strRazon, int intAccion, int idUsuario)
        {
            string strConsulta = "call sp_MovimientoInventario(" + idMovimiento + "," + idEmpresaO + "," + idSucursalO + ", " + idBodegaO + 
                "," + idEmpresaD + "," + idSucursalD + "," + idBodegaD + "," + idProducto + "," + Cantidad + ",'" + strRazon + "'," + idUsuario + "," + intAccion + ");";
            Console.WriteLine(strConsulta);
            return Modelo.funcEjeQuerry(strConsulta);
        }

        
        


    }
}
