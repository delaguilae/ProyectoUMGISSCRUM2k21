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

namespace CapaVista.Procesos.Inventarios
{
    public partial class frmInventarioTotal : Form
    {
        ControladorJM con = new ControladorJM();
        public frmInventarioTotal()
        {
            InitializeComponent();
            CargarComboboxEmpresa();
            CargarDetalles();
            color();
        }
        public void CargarComboboxEmpresa()
        {
            //llenado de combobox de Empresa
            cmbEmpresa.DisplayMember = "nombreEmpresa";
            cmbEmpresa.ValueMember = "pkIdEmpresa";
            cmbEmpresa.DataSource = con.FieldCombobox("pkIdEmpresa", "nombreEmpresa", "empresa", "estadoEmpresa");
            cmbEmpresa.SelectedIndex = -1;
            //llenado de combobox de bodega
            cmbBodega.DisplayMember = "descripcionBodega";
            cmbBodega.ValueMember = "pkIdBodega";
            cmbBodega.DataSource = con.FieldCombobox("pkIdBodega", "descripcionBodega", "bodega", "estadoBodega");
            cmbBodega.SelectedIndex = -1;
        }
        public void CargarDetalles()
        {
                dgvInventarioT.Rows.Clear();

                OdbcDataReader mostrar = con.funcSelectAll();
                try
                {
                    while (mostrar.Read())
                    {
                        dgvInventarioT.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5));

                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
        }
        private void color()
        {
            foreach (DataGridViewRow Myrow in dgvInventarioT.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[3].Value) <= Convert.ToInt32(Myrow.Cells[5].Value))
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }
                if (Convert.ToInt32(Myrow.Cells[3].Value) >= Convert.ToInt32(Myrow.Cells[4].Value))
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Cyan;
                }
            }

        }
    }
}
