using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Procesos.MovimientoInventarios
{
    public partial class frmMovimientoInventarios : Form
    {
        clsMovInventariosCon Controlador = new clsMovInventariosCon();
        VariableGlobal glo = new VariableGlobal();
        DataTable Dt = new DataTable();
        int Contador = 0;
        int intReglon;
        int intIdUsuario;
        string strAcciones;
        public frmMovimientoInventarios()
        {
            InitializeComponent();
            ObtenerIdUsuario();
            LlenarDgv();
            ActualizarDGV();
        }
        public void LlenarDgv()
        {
            dgvMover.Rows.Clear();
            Dt.Columns.Add("pkmovimiento", typeof(string));
            Dt.Columns.Add("fkidproducto", typeof(string));
            Dt.Columns.Add("fkbodegaorigen", typeof(string));
            Dt.Columns.Add("fkbodegadestino", typeof(string));
            Dt.Columns.Add("cantidad", typeof(string));
            Dt.Columns.Add("razon", typeof(string));
            Dt.Columns.Add("fkencargado", typeof(string));
        }

        public void ActualizarDGV()
        {
            
            OdbcDataReader mostrar = Controlador.funcConsultaMov();
            try
            {
                while (mostrar.Read())
                {
                    DataRow row;
                    row = Dt.NewRow();
                    row["pkmovimiento"] = mostrar.GetString(0);
                    row["fkidproducto"] = mostrar.GetString(1);
                    row["fkbodegaorigen"] = mostrar.GetString(2);
                    row["fkbodegadestino"] = mostrar.GetString(3);
                    row["cantidad"] = mostrar.GetString(4);
                    row["razon"] = mostrar.GetString(5);
                    row["fkencargado"] = mostrar.GetString(6);
                    Dt.Rows.Add(row);
                }
                dgvMover.DataSource = Dt;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
        public void ObtenerIdUsuario()
        {
            intIdUsuario = Controlador.funcObtenerIDUsuario(glo.usuariog);
        }
        //funcion eliminar una fila
        public void funcEliminarFila()
        {
            if (dgvMover.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
            else
            {
                funcAplicarMove(2, 2);
                dgvMover.Rows.Remove(dgvMover.CurrentRow);
            }
        }
        //Funcion Consulta Bodega Destino
        public void funcBodegaDestino()
        {
            frmSeleccionBodega ConsultarBodega = new frmSeleccionBodega();
            if (ConsultarBodega.ShowDialog() == DialogResult.OK)
            {
                txtIdBodegaDestino.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[0].Value.ToString();
                txtIdEmpresaDestino.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[1].Value.ToString();
                txtIdSucursalDestino.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[2].Value.ToString();
                txtDireccBodegaDestino.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }
        //funcion consulta bodega origen
        public void funcBodegaOrigen()
        {
            frmSeleccionBodega ConsultarBodega = new frmSeleccionBodega();
            if (ConsultarBodega.ShowDialog() == DialogResult.OK)
            {
                txtCodBodegaOrigen.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[0].Value.ToString();
                txtIdEmpresaOrigen.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[1].Value.ToString();
                txtIdSucursalOrigen.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[2].Value.ToString();
                txtDirecBodegaOrigen.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }
        //funcion para buscar Productos
        public void funcBuscarProducto()
        {
            frmSeleccionProducto ConsultarProducto = new frmSeleccionProducto();
            if (ConsultarProducto.ShowDialog() == DialogResult.OK)
            {
                txtIdProducto.Text = ConsultarProducto.dgvProducto.Rows[ConsultarProducto.dgvProducto.CurrentRow.Index].Cells[0].Value.ToString();
                txtProducto.Text = ConsultarProducto.dgvProducto.Rows[ConsultarProducto.dgvProducto.CurrentRow.Index].Cells[1].Value.ToString();
                funcActualizarExist();
            }
            
        }
        //funcion Para Validar Bodega Destino
        public void funcValidarDestino()
        {
            if(txtIdEmpresaOrigen.Text.Equals(txtIdEmpresaDestino.Text) && txtIdSucursalOrigen.Text.Equals(txtIdSucursalDestino.Text) && txtCodBodegaOrigen.Text.Equals(txtIdBodegaDestino.Text))
            {
                txtIdEmpresaDestino.Text = "";
                txtIdSucursalDestino.Text = "";
                txtIdBodegaDestino.Text = "";
                txtDireccBodegaDestino.Text = "";
                DialogResult drResultadoMensaje;
                drResultadoMensaje = MessageBox.Show("Bodega Destino No Puede Ser Igual Al Origen\nSeleccione Otro Destino", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (drResultadoMensaje == DialogResult.OK)
                {
                    funcBodegaDestino();
                }
            }
        }
        //Actualizar Existencia
        public void funcActualizarExist()
        {
            txtCantidadDisponible.Text = existencia().ToString();
        }
        //Funcion Aplicar Movimientos
        public void funcAplicarMove(int intAccion, int intInserDelete)
        {
            int intIdMovimiento;
            int intIdEmpresaO;
            int intIdSucursalO;
            int intIdBodegaO;

            int intIdEmpresaD;
            int intIdSucursalD;
            int intIdBodegaD;

            int intIdProducto;
            string strRazon = "";
            int intCantidad;

            if (intInserDelete == 1)
            {
                intIdMovimiento = 1;
                intIdEmpresaO = Convert.ToInt32(txtIdEmpresaOrigen.Text);
                intIdSucursalO = Convert.ToInt32(txtIdSucursalOrigen.Text);
                intIdBodegaO = Convert.ToInt32(txtCodBodegaOrigen.Text);

                intIdEmpresaD = Convert.ToInt32(txtIdEmpresaDestino.Text);
                intIdSucursalD = Convert.ToInt32(txtIdSucursalDestino.Text);
                intIdBodegaD = Convert.ToInt32(txtIdBodegaDestino.Text);

                intIdProducto = Convert.ToInt32(txtIdProducto.Text);
                strRazon = txtAcciones.Text;
                intCantidad = Convert.ToInt32(txtCantMover.Text);
            }
            else
            {
                txtIdMovimiento.Text = dgvMover.Rows[intReglon].Cells["pkmovimiento"].Value.ToString();
                intIdMovimiento = Convert.ToInt32(txtIdMovimiento.Text);
                intIdEmpresaO = Convert.ToInt32(txtIdEmpresaOrigen.Text);
                intIdSucursalO = Convert.ToInt32(txtIdSucursalOrigen.Text);
                intIdBodegaO = Convert.ToInt32(txtCodBodegaOrigen.Text);

                intIdEmpresaD = Convert.ToInt32(txtIdEmpresaDestino.Text);
                intIdSucursalD = Convert.ToInt32(txtIdSucursalDestino.Text);
                intIdBodegaD = Convert.ToInt32(txtIdBodegaDestino.Text);

                txtIdProducto.Text = dgvMover.Rows[intReglon].Cells["fkidproducto"].Value.ToString();
                txtCantMover.Text = dgvMover.Rows[intReglon].Cells["cantidad"].Value.ToString();
                strRazon = txtAcciones.Text;
                intIdProducto = Convert.ToInt32(txtIdProducto.Text);
                intCantidad = Convert.ToInt32(txtCantMover.Text);
            }
            

            string Mensaje = Controlador.funcMovInventario(intIdMovimiento, intIdEmpresaO, intIdSucursalO, intIdBodegaO, intIdEmpresaD, intIdSucursalD, intIdBodegaD, intIdProducto, intCantidad, strRazon, intAccion, intIdUsuario);
            Console.WriteLine(Mensaje);
        }
        

       //func para verificar si hay existencia.
        int existencia()
        {
            return Controlador.funcConsExistencia(Int32.Parse(txtIdEmpresaOrigen.Text), Int32.Parse(txtIdSucursalOrigen.Text), Int32.Parse(txtCodBodegaOrigen.Text),Int32.Parse(txtIdProducto.Text));
        }
        //funcion para validar campos vacios.
        public int funcValidarCampos()
        {
            Contador = 0;
            if (txtIdEmpresaOrigen.Text.Equals(""))
            {
                
                DialogResult drResultadoMensaje;
                drResultadoMensaje = MessageBox.Show("Bodega De Origen No Esta Seleccionada\nSeleccione La Bodega De Origen", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (drResultadoMensaje == DialogResult.OK)
                {
                    Contador += 1;
                    funcBodegaOrigen();
                }
            }
            else { Contador += 0; }

            if (txtIdEmpresaDestino.Text.Equals(""))
            {
                DialogResult drResultadoMensaje;
                drResultadoMensaje = MessageBox.Show("Bodega Destino No Esta Seleccionada\nSeleccione La Bodega De Destino", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (drResultadoMensaje == DialogResult.OK)
                {
                    Contador += 1;
                    funcBodegaDestino();
                }
            }
            else { Contador += 0; }

            if (txtIdProducto.Text.Equals(""))
            {
                if (txtIdEmpresaOrigen.Text.Equals(""))
                {
                    DialogResult drResultadoMensaje;
                    drResultadoMensaje = MessageBox.Show("Bodega De Origen No Esta Seleccionada\nSeleccione La Bodega De Origen", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (drResultadoMensaje == DialogResult.OK)
                    {
                        Contador += 1;
                        funcBodegaOrigen();
                    }
                }
                else
                {
                    DialogResult drResultadoMensajes;
                    drResultadoMensajes = MessageBox.Show("Producto No Seleccionado\nSeleccione Un Producto", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (drResultadoMensajes == DialogResult.OK)
                    {
                        Contador += 1;
                        funcBuscarProducto();
                    }
                }

            }
            else { Contador += 0; }
            if (txtCantMover.Text.Equals(""))
            {
                DialogResult drResultadoMensaje;
                drResultadoMensaje = MessageBox.Show("No Ha Ingresado La Cantidad A Mover\nIngrese La Cantidad A Mover", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (drResultadoMensaje == DialogResult.OK)
                {
                    Contador += 1;
                    txtCantMover.Text = "";
                }
            }else if(Convert.ToInt32(txtCantMover.Text) > Convert.ToInt32(txtCantidadDisponible.Text))
            {
                DialogResult drResultadoMensaje;
                drResultadoMensaje = MessageBox.Show("La Cantidad A Mover Es Mayor A la disponible\nIngrese Una Cantidad Menor", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (drResultadoMensaje == DialogResult.OK)
                {
                    Contador += 1;
                    txtCantMover.Text = "";
                }
            }
            else
            {
                Contador += 0;
            }
            return Contador;
        }

        private void btnBuscarBodegaOrigen_Click(object sender, EventArgs e)
        {
            funcBodegaOrigen();
        }

        private void btnBuscarDestino_Click(object sender, EventArgs e)
        {
            funcBodegaDestino();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            funcBuscarProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (funcValidarCampos() == 0)
            {
                funcAplicarMove(1,1);
                ActualizarDGV();
            }
            else
            {
                return;
            }
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            funcEliminarFila();
            txtIdProducto.Text = "";
            txtProducto.Text = "";
            txtCantidadDisponible.Text = "";
            txtCantMover.Text = "";
        }

        private void frmMovimientoInventarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void frmMovimientoInventarios_Load(object sender, EventArgs e)
        {
        }

        private void btnRealizarCambios_Click(object sender, EventArgs e)
        {

        }
        private void txtDireccBodegaDestino_TextChanged(object sender, EventArgs e)
        {
            funcValidarDestino();
        }

        private void dgvMover_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            intReglon = e.RowIndex;
        }

        private void rbMovimientoBodegaBodega_CheckedChanged(object sender, EventArgs e)
        {
            txtAcciones.Text = "Movimiento De Bodega A Bodega";
        }

        private void rbDevClientes_CheckedChanged(object sender, EventArgs e)
        {
            txtAcciones.Text = "Devolucion De Clientes a Bodega";
        }

        private void rbVentas_CheckedChanged(object sender, EventArgs e)
        {
            txtAcciones.Text = "Accion por Ventas";
        }

        private void txtIdEmpresaOrigen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
