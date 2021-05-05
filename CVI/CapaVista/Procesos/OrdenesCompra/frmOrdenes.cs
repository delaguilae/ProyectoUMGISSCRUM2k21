﻿using CapaControlador;
using CapaVista.Procesos.MovimientoInventarios;
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

namespace CapaVista.Procesos.Ordenes
{
    public partial class frmOrdenes : Form
    {
        clsMovInventariosCon Controlador = new clsMovInventariosCon();
        ControladorJM jm = new ControladorJM();
        VariableGlobal glo = new VariableGlobal();
        DataTable Dt = new DataTable();
        Controlador con = new Controlador();
        string user, idencabezado;
        string idproducto = "";
        string nombre = "";
        string descripcion = "";
        string precio = "";
        int validacion = 0;
        double preciotabla2 ,totalsuma,multiplicacion;
        int cantidad;


        

        public frmOrdenes(string usuario)
        {
            InitializeComponent();
            user = usuario;
            CargarCombobox();
        }
        public void funcBodegaDestino()
        {
            frmSeleccionBodega ConsultarBodega = new frmSeleccionBodega();
            if (ConsultarBodega.ShowDialog() == DialogResult.OK)
            {
                txtIdBodegaDestino.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[0].Value.ToString();
                txtIdEmpresaDestino.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[1].Value.ToString();
                txtIdSucursalDestino.Text = ConsultarBodega.dgvBodega.Rows[ConsultarBodega.dgvBodega.CurrentRow.Index].Cells[2].Value.ToString();     
            }
        }
        public void datosingresar() {                 
            if (dgvOrdenes.SelectedRows.Count > 0 && dgvOrdenes.CurrentRow.Cells[0].Value != null)
            {
                validacion = 0;
                idproducto = dgvOrdenes.CurrentRow.Cells[0].Value.ToString();
                nombre = dgvOrdenes.CurrentRow.Cells[1].Value.ToString();
                descripcion = dgvOrdenes.CurrentRow.Cells[2].Value.ToString();
                precio = dgvOrdenes.CurrentRow.Cells[3].Value.ToString();
                verificarcambio();
                if (validacion == 0)
                {
                    llenardgvcompras2();
                }
            }
        }
        public void verificarcambio() {
            foreach (DataGridViewRow Myrow in dgvcompras2.Rows)
            {
                if (Convert.ToString(Myrow.Cells[0].Value) == idproducto)
                {
                    validacion = 1;
                }               
            }
        }
        public void llenardgvcompras2() {

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvcompras2);
            row.Cells[0].Value = idproducto;
            row.Cells[1].Value = nombre;
            row.Cells[2].Value = descripcion;
            row.Cells[3].Value = precio;

            dgvcompras2.Rows.Add(row);

        }
        public void total() {
            totalsuma = 0;
            foreach (DataGridViewRow Myrow in dgvcompras2.Rows)
            {
               
                preciotabla2 = Convert.ToDouble(Myrow.Cells[2].Value);             
                cantidad = Convert.ToInt32(Myrow.Cells[4].Value);              
                multiplicacion = preciotabla2 * cantidad;
                totalsuma = multiplicacion + totalsuma;
            }
            txttotal.Text = Convert.ToString(totalsuma);

        }
        public void CargarCombobox()
        {
            //llenado de combobox de tipo compra
            cmbtipocompra.DisplayMember = "nombretipocompra";
            cmbtipocompra.ValueMember = "pktipocompra";
            cmbtipocompra.DataSource = con.funcObtenerCamposComboboxPais("pktipocompra", "nombretipocompra", "tipocompra", "estado");
            cmbtipocompra.SelectedIndex = -1;

            //llenado de combobox de metodo pago
            cmbmetodopago.DisplayMember = "descripcionMetodo";
            cmbmetodopago.ValueMember = "pkIdMetodoPago";
            cmbmetodopago.DataSource = con.funcObtenerCamposComboboxPais("pkIdMetodoPago", "descripcionMetodo", "metodopago", "estadoMetodo");
            cmbmetodopago.SelectedIndex = -1;

            //llenado de combobox de proveedor
            cmbproveedor.DisplayMember = "direccionProv";
            cmbproveedor.ValueMember = "pkIdProv";
            cmbproveedor.DataSource = con.funcObtenerCamposComboboxPais("pkIdProv", "direccionProv", "proveedor", "estadoProv");
            cmbproveedor.SelectedIndex = -1;

            //llenado de combobox de empleado
            cmbEmpleado.DisplayMember = "nombreEmpleado";
            cmbEmpleado.ValueMember = "pkIdEmpleado";
            cmbEmpleado.DataSource = con.funcObtenerCamposComboboxPais("pkIdEmpleado", "nombreEmpleado", "empleado", "estadoEmpleado");
            cmbEmpleado.SelectedIndex = -1;

        }

        public void guardardetalle() {
            string idproductodetalle, cantidaddetalle, costodetalle;
            
            foreach (DataGridViewRow Myrow in dgvcompras2.Rows)
            {              
                idproductodetalle = Convert.ToString(Myrow.Cells[0].Value);
                cantidaddetalle = Convert.ToString(Myrow.Cells[4].Value);
                costodetalle = Convert.ToString(Myrow.Cells[2].Value);
                OdbcDataReader consulta = jm.funcInsertarDetalleCompras(idencabezado, idproductodetalle,cantidaddetalle, costodetalle,"1");
            }
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            funcBodegaDestino();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {                   
                if (dgvcompras2.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una fila antes de eliminar");
                }
                else
                {               
                dgvcompras2.Rows.Remove(dgvcompras2.CurrentRow);
                }
                 total();

        }

        private void cmbtipocompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtipocompra.SelectedIndex != -1)
            {
                txttipocompra.Text = cmbtipocompra.SelectedValue.ToString();
            }
        }

        private void txttipocompra_TextChanged(object sender, EventArgs e)
        {
            if (txttipocompra.Text != "")
            {
                OdbcDataReader reader = jm.FieldComboboxtxt("nombretipocompra", "tipocompra", "estado", "pktipocompra", txttipocompra.Text);
                if (reader.Read())
                {
                    cmbtipocompra.Text = reader.GetString(0);
                }
                else
                {
                    cmbtipocompra.SelectedIndex = -1;
                }
            }
        }
        private void cmbmetodopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmetodopago.SelectedIndex != -1)
            {
                txtmetodopago.Text = cmbmetodopago.SelectedValue.ToString();
            }
        }
        private void txtmetodopago_TextChanged(object sender, EventArgs e)
        {
            if (txtmetodopago.Text != "")
            {
                OdbcDataReader reader = jm.FieldComboboxtxt( "descripcionMetodo", "metodopago", "estadoMetodo","pkIdMetodoPago", txtmetodopago.Text);
                if (reader.Read())
                {
                    cmbmetodopago.Text = reader.GetString(0);
                }
                else
                {
                    cmbmetodopago.SelectedIndex = -1;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbproveedor.SelectedIndex != -1)
            {
                txtproveedor.Text = cmbproveedor.SelectedValue.ToString();
            }
        }
        private void txtproveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtproveedor.Text != "")
            {
                OdbcDataReader reader = jm.FieldComboboxtxt( "direccionProv", "proveedor", "estadoProv","pkIdProv", txtproveedor.Text);
                if (reader.Read())
                {
                    cmbproveedor.Text = reader.GetString(0);
                }
                else
                {
                    cmbproveedor.SelectedIndex = -1;
                }
            }
        }
        private void llenarproveedor()
        {
                dgvOrdenes.Rows.Clear();
                OdbcDataReader mostrar = jm.funcSelectllenardgvProductosProveedor(txtproveedor.Text);
                try
                {
                    while (mostrar.Read())
                    {
                    dgvOrdenes.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3));
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
        }
        private void obtenerpk()
        {
            OdbcDataReader mostrar = jm.funConsultaobteneridEncabezadoCompras();
            try
            {
                while (mostrar.Read())
                {
                    idencabezado = mostrar.GetString(0);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void actualizarencabezado(){
            OdbcDataReader consulta = jm.funcActualizarencabezado(idencabezado, txttotal.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarproveedor();   
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OdbcDataReader consulta = jm.funcInsertarEncabezadoCompras(txtproveedor.Text, txtempledo.Text, txtIdEmpresaDestino.Text, txtIdSucursalDestino.Text, txtIdBodegaDestino.Text, txtfecha.Text, "0.00", txttipocompra.Text, txtmetodopago.Text, "1");           
            obtenerpk();
            guardardetalle();
            actualizarencabezado();



        }
        private void txtempledo_TextChanged(object sender, EventArgs e)
        {
            if (txtempledo.Text != "")
            {
                OdbcDataReader reader = jm.FieldComboboxtxt( "nombreEmpleado", "empleado", "estadoEmpleado","pkIdEmpleado", txtempledo.Text);
                if (reader.Read())
                {
                    cmbEmpleado.Text = reader.GetString(0);
                }
                else
                {
                    cmbEmpleado.SelectedIndex = -1;
                }
            }
        }

        private void dgvcompras2_KeyPress(object sender, KeyPressEventArgs e)
        {
            total();
        }

        private void dgvcompras2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            total();
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedIndex != -1)
            {
                txtempledo.Text = cmbEmpleado.SelectedValue.ToString();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            datosingresar();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
