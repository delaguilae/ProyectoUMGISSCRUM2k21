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
    public partial class frmMunicipio : Form
    {
        string UsuarioAplicacion;
        Controlador con = new Controlador();
        public frmMunicipio(string usuario)
        {
            InitializeComponent();
            CargarCombobox();
            rbHabilitado.Checked = true;
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
        }
        public void CargarCombobox()
        {
            //llenado de combobox de producto
            cmbDepar.DisplayMember = "nombreDepar";
            cmbDepar.ValueMember = "pkIdDepar";
            cmbDepar.DataSource = con.funcObtenerCamposComboboxPais("pkIdDepar", "nombreDepar", "departamento", "estadoDepar");
            cmbDepar.SelectedIndex = -1;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //llenado de  parametros para la aplicacion 
            navegador1.aplicacion = 301;
            navegador1.tbl = "municipio";
            navegador1.campoEstado = "estadoMuni";

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
            navegador1.DatosActualizar = dgvMunicipio;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "HTML/Ayudas.chm";
            navegador1.ruta = "Ayuda_Mantenimiento_Centros.html";
            rbHabilitado.Checked = true;
            rbDeshabilitado.Checked = false;
        }

        private void cmbDepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbDepar.SelectedIndex != -1)
            {
                txtDepar.Text = cmbDepar.SelectedValue.ToString();
            }
        }

        private void frmMunicipio_Load(object sender, EventArgs e)
        {

        }
    }
}
