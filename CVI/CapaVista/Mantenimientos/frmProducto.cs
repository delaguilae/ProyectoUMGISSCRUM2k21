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

namespace CapaVista.Mantenimientos
{
    public partial class frmProducto : Form
    {
       string UsuarioAplicacion;
       ControladorJM con = new ControladorJM();
       clsValidaciones validaciones = new clsValidaciones();
        public frmProducto(string usuario)
        {
            InitializeComponent();
            CargarCombobox();
            rbHabilitado.Checked = true;
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            rbHabilitado.Checked = true;
            txtEstado.Text = "1";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtLinea.Text != "") 
            {
                OdbcDataReader reader = con.FieldComboboxtxt("nombreLineaPro", "lineaproducto", "estadoLineaPro", "pkIdLineaPro", txtLinea.Text);
                if (reader.Read())
                {
                    cmbLinea.Text = reader.GetString(0);
                }
                else
                {
                    cmbLinea.SelectedIndex = -1;
                }
            }
        }
        void CargarCombobox()
        {
            //fill cb Empresa
            cmbEmpresa.DisplayMember = "nombreEmpresa";
            cmbEmpresa.ValueMember = "pkIdEmpresa";
            cmbEmpresa.DataSource = con.FieldCombobox("pkIdEmpresa", "nombreEmpresa", "empresa", "estadoEmpresa");
            cmbEmpresa.SelectedIndex = -1;
            //fill cb Linea
            cmbLinea.DisplayMember = "nombreLineaPro";
            cmbLinea.ValueMember = "pkIdLineaPro";
            cmbLinea.DataSource = con.FieldCombobox("pkIdLineaPro", "nombreLineaPro", "lineaproducto", "estadoLineaPro");
            cmbLinea.SelectedIndex = -1;
            //fill cb Marca
            cmbMarca.DisplayMember = "nombreMarcaPro";
            cmbMarca.ValueMember = "pkIdMarcaPro";
            cmbMarca.DataSource = con.FieldCombobox("pkIdMarcaPro", "nombreMarcaPro", "marcaproducto", "estadoMarcaPro");
            cmbMarca.SelectedIndex = -1;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //llenado de  parametros para la aplicacion 
            navegador1.aplicacion = 303;
            navegador1.tbl = "producto";
            navegador1.campoEstado = "estadoPro";
            //se agregan los componentes del formulario a la lista tipo control
            foreach (Control C in this.Controls)
            {
                if (C.Tag != null)
                {
                    if (C.Tag.ToString() == "saltar")
                    {

                    }
                    else
                    {
                        if (C is TextBox)
                        {
                            lista.Add(C);
                        }
                        else if (C is ComboBox)
                        {
                            lista.Add(C);
                        }
                        else if (C is DateTimePicker)
                        {
                            lista.Add(C);
                        }
                    }
                }
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvProducto;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "Ayudas/MProducto.chm";
            navegador1.ruta = "Mantenimiento Producto.html";
            rbHabilitado.Checked = true;
            rbDeshabilitado.Checked = false;
            txtEstado.Text = "1";
        }
        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpresa.SelectedIndex != -1)
            {
                txtEmpresa.Text = cmbEmpresa.SelectedValue.ToString();
            }
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpresa.Text != "")
            {
               OdbcDataReader reader = con.FieldComboboxtxt("nombreEmpresa", "empresa", "estadoEmpresa", "pkIdEmpresa", txtEmpresa.Text);
                if (reader.Read())
                {
                    cmbEmpresa.Text = reader.GetString(0);
                }
                else
                {
                    cmbEmpresa.SelectedIndex = -1;
                }
            }
        }

        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLinea.SelectedIndex != -1)
            {
                txtLinea.Text = cmbLinea.SelectedValue.ToString();
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex != -1)
            {
                txtMarca.Text = cmbMarca.SelectedValue.ToString();
            }
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            if (txtMarca.Text != "")
            {
                OdbcDataReader reader = con.FieldComboboxtxt("nombreLineaPro", "lineaproducto", "estadoLineaPro", "pkIdLineaPro", txtMarca.Text);
                if (reader.Read())
                {
                    cmbMarca.Text = reader.GetString(0);
                }
                else
                {
                    cmbMarca.SelectedIndex = -1;
                }
            }
        }

        private void rbHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void rbDeshabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "0";
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.CamposLetrasTexto(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.Camposdecimales(e);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.CamposNumerosYLetras(e);
        }
    }
}
