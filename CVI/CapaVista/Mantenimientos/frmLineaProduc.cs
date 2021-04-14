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

namespace CapaVista.Mantenimientos
{
    public partial class frmLineaProduc : Form
    {
        string UsuarioAplicacion;
        Controlador con = new Controlador();
        public frmLineaProduc(string usuario)
        {
            InitializeComponent();
            rbHabilitado.Checked = true;
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            CargarCombobox();
        }
        public void CargarCombobox()
        {
            //llenado de combobox de producto
            cmbEmp.DisplayMember = "nombreEmpresa";
            cmbEmp.ValueMember = "pkIdEmpresa";
            cmbEmp.DataSource = con.funcObtenerCamposComboboxPais("pkIdEmpresa", "nombreEmpresa", "empresa", "estadoEmpresa");
            cmbEmp.SelectedIndex = -1;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //llenado de  parametros para la aplicacion 
            navegador1.aplicacion = 301;
            navegador1.tbl = "lineaproducto";
            navegador1.campoEstado = "estadoLineaPro";

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
            navegador1.DatosActualizar = dgvLineaP;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "HTML/Ayudas.chm";
            navegador1.ruta = "Ayuda_Mantenimiento_Centros.html";
            rbHabilitado.Checked = true;
            rbDeshabilitado.Checked = false;
        }

        private void rbHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void rbDeshabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "0";
        }

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmp.SelectedIndex != -1)
            {
                txtEmpresa.Text = cmbEmp.SelectedValue.ToString();
            }
        }

        private void dgvLineaP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
