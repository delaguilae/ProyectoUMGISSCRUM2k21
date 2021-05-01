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
        //Funcion Para Consultar Detalles de la bodega.
        public OdbcDataReader funcConsulta()
        {
            string Consulta = "SELECT pkIdBodega, fkIdEmpresa, fkIdSucursal, direccionBodega FROM bodega where estadoBodega = 1;";
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
        public string funcMovInventario(int idEmpresaO, int idSucursalO, int idBodegaO, int idEmpresaD, int idSucursalD, int idBodegaD, int idProducto, int Cantidad, int intAccion)
        {
            string strConsulta = "call sp_MovimientoInventario(" + idEmpresaO + "," + idSucursalO + ", " + idBodegaO + 
                "," + idEmpresaD + "," + idSucursalD + "," + idBodegaD + "," + idProducto + "," + Cantidad + "," + intAccion + ");";
            Console.WriteLine(strConsulta);
            return Modelo.funcEjeQuerry(strConsulta);
        }

        private int intIdEmpresaOrigen;
        private int intIdSucursalOrigen;
        private int intIdBodegaOrigen;

        private int intIdEmpresaDestino;
        private int intIdSucursalDestino;
        private int intIdBodegaDestino;

        private int intIdProducto;
        private int intCantidad;
        private int intAccion;

        public int IntIdEmpresaOrigen { get => intIdEmpresaOrigen; set => intIdEmpresaOrigen = value; }
        public int IntIdSucursalOrigen { get => intIdSucursalOrigen; set => intIdSucursalOrigen = value; }
        public int IntIdBodegaOrigen { get => intIdBodegaOrigen; set => intIdBodegaOrigen = value; }
        public int IntIdEmpresaDestino { get => intIdEmpresaDestino; set => intIdEmpresaDestino = value; }
        public int IntIdSucursalDestino { get => intIdSucursalDestino; set => intIdSucursalDestino = value; }
        public int IntIdBodegaDestino { get => intIdBodegaDestino; set => intIdBodegaDestino = value; }
        public int IntIdProducto { get => intIdProducto; set => intIdProducto = value; }
        public int IntCantidad { get => intCantidad; set => intCantidad = value; }
        public int IntAccion { get => intAccion; set => intAccion = value; }
    }
}
