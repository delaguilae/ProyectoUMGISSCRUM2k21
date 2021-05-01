using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Procesos.MovimientoInventarios
{
    public partial class frmMovimientoInventarios : Form
    {
        frmSeleccionProducto ConsultarProducto = new frmSeleccionProducto();
        clsMovInventariosCon Controlador = new clsMovInventariosCon();
        DataTable dt_Mover = new DataTable();
        int Contador = -1;
        //lista para movimientos
        List<clsMovInventariosCon> lisDetalle = new List<clsMovInventariosCon>();
        public frmMovimientoInventarios()
        {
            InitializeComponent();
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
        public void funcAplicarMove(int intAccion, int intInserDelete, int intContador)
        {
            int intIdEmpresaO;
            int intIdSucursalO;
            int intIdBodegaO;

            int intIdEmpresaD;
            int intIdSucursalD;
            int intIdBodegaD;

            int intIdProducto;
            int intCantidad;
            if (intInserDelete == 1)
            {
                intIdEmpresaO = Convert.ToInt32(txtIdEmpresaOrigen.Text);
                intIdSucursalO = Convert.ToInt32(txtIdSucursalOrigen.Text);
                intIdBodegaO = Convert.ToInt32(txtCodBodegaOrigen.Text);

                intIdEmpresaD = Convert.ToInt32(txtIdEmpresaDestino.Text);
                intIdSucursalD = Convert.ToInt32(txtIdSucursalDestino.Text);
                intIdBodegaD = Convert.ToInt32(txtIdBodegaDestino.Text);

                intIdProducto = Convert.ToInt32(txtIdProducto.Text);
                intCantidad = Convert.ToInt32(txtCantMover.Text);
            }
            else
            {
                intIdEmpresaO = Convert.ToInt32(txtIdEmpresaOrigen.Text);
                intIdSucursalO = Convert.ToInt32(txtIdSucursalOrigen.Text);
                intIdBodegaO = Convert.ToInt32(txtCodBodegaOrigen.Text);

                intIdEmpresaD = Convert.ToInt32(txtIdEmpresaDestino.Text);
                intIdSucursalD = Convert.ToInt32(txtIdSucursalDestino.Text);
                intIdBodegaD = Convert.ToInt32(txtIdBodegaDestino.Text);
                
                
            }
            

            //string Mensaje = Controlador.funcMovInventario(intIdEmpresaO, intIdSucursalO, intIdBodegaO, intIdEmpresaD, intIdSucursalD, intIdBodegaD, intIdProducto, intCantidad, intAccion);
           // Console.WriteLine(Mensaje);
        }
        //funcion para guardar los detalle del dgvMovimientos.
        public void detalles()
        {
            clsMovInventariosCon movimientos = new clsMovInventariosCon();
            for (int intContador = 0; intContador < dgvMover.Rows.Count - 1; intContador++)
            {
                movimientos.IntIdEmpresaOrigen = Convert.ToInt32(dgvMover.Rows[intContador].Cells[0].Value);
                movimientos.IntIdSucursalOrigen = Convert.ToInt32(dgvMover.Rows[intContador].Cells[1].Value);
                movimientos.IntIdBodegaOrigen = Convert.ToInt32(dgvMover.Rows[intContador].Cells[2].Value);

                movimientos.IntIdEmpresaDestino = Convert.ToInt32(dgvMover.Rows[intContador].Cells[3].Value);
                movimientos.IntIdSucursalDestino = Convert.ToInt32(dgvMover.Rows[intContador].Cells[4].Value);
                movimientos.IntIdBodegaDestino = Convert.ToInt32(dgvMover.Rows[intContador].Cells[5].Value);

                movimientos.IntIdProducto = Convert.ToInt32(dgvMover.Rows[intContador].Cells[6].Value);
                movimientos.IntCantidad = Convert.ToInt32(dgvMover.Rows[intContador].Cells[7].Value);
                movimientos.IntAccion = Convert.ToInt32(dgvMover.Rows[intContador].Cells[8].Value);
                lisDetalle.Add(movimientos);
            }
        }
       //func para verificar si hay existencia.
        int existencia()
        {
            return Controlador.funcConsExistencia(Int32.Parse(txtIdEmpresaOrigen.Text), Int32.Parse(txtIdSucursalOrigen.Text), Int32.Parse(txtCodBodegaOrigen.Text),Int32.Parse(txtIdProducto.Text));
        }

        private void btnBuscarBodegaOrigen_Click(object sender, EventArgs e)
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

        private void btnBuscarDestino_Click(object sender, EventArgs e)
        {
            funcBodegaDestino();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmSeleccionProducto ConsultarProducto = new frmSeleccionProducto();
            if (ConsultarProducto.ShowDialog() == DialogResult.OK)
            {
                txtIdProducto.Text = ConsultarProducto.dgvProducto.Rows[ConsultarProducto.dgvProducto.CurrentRow.Index].Cells[0].Value.ToString();
                txtProducto.Text = ConsultarProducto.dgvProducto.Rows[ConsultarProducto.dgvProducto.CurrentRow.Index].Cells[1].Value.ToString();               
            }
            funcActualizarExist();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Contador += 1;
            funcAplicarMove(1,1, Contador);
            DataRow dR_fila = dt_Mover.NewRow();
            dR_fila["IdProducto"] = txtIdProducto.Text;
            dR_fila["IdBodega_Origen"] = txtCodBodegaOrigen.Text;
            dR_fila["IdBodega_Destino"] = txtIdBodegaDestino.Text;
            dR_fila["Cantidad"] = txtCantMover.Text;
            dR_fila["Razon"] = "Transaccion de Bodega a Bodega";
            dt_Mover.Rows.Add(dR_fila);

            txtIdProducto.Text = "";
            txtProducto.Text = "";
            txtCantidadDisponible.Text = "";
            txtCantMover.Text = "";
            //funcActualizarExist();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            funcAplicarMove(2,2, Contador);
            //Contador -= 1;
            //funcActualizarExist();
            //funcEliminarFila();
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
            dt_Mover.Columns.Add("IdProducto");
            dt_Mover.Columns.Add("IdBodega_Origen");
            dt_Mover.Columns.Add("IdBodega_Destino");
            dt_Mover.Columns.Add("Cantidad");
            dt_Mover.Columns.Add("Razon");
            dgvMover.DataSource = dt_Mover;
        }

        private void btnRealizarCambios_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = Convert.ToString(dgvMover.Rows[0].Cells[0].Value);
            txtCantMover.Text = Convert.ToString(dgvMover.Rows[0].Cells[3].Value);
            /*txtIdProducto.Text = "";
            txtProducto.Text = "";
            txtCantidadDisponible.Text = "";
            txtCantMover.Text = "";*/
            /*string idP = Convert.ToString(dgvMover.Rows[Contador].Cells[0].Value);
            //int intIdProducto = (idP);
            string cant = Convert.ToString(dgvMover.Rows[Contador].Cells[3].Value);
            int intCantidad = Convert.ToInt32(cant);
            Console.WriteLine("Contador: " + Contador + "\n" + intIdProducto + "\n" + intCantidad);
            */
        }
        private void txtDireccBodegaDestino_TextChanged(object sender, EventArgs e)
        {
            funcValidarDestino();
        }       
    }
}
