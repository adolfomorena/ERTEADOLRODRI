using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERTEADOLRODRI
{
    public partial class FrmModAddEmpresas : Form
    {
        private EMPRESAS empresaSeleccionada;
        public FrmModAddEmpresas()
        {
            InitializeComponent();
        }
        public FrmModAddEmpresas(EMPRESAS empresa)
        {
            InitializeComponent();
            empresaSeleccionada = empresa;
            textBoxCIF.Text = empresa.Cif;
            textBoxCIF.Enabled = false;
            textBoxNombre.Text = empresa.Nombre;
            textBoxDomicilio.Text = empresa.Domicilio;
            comboBoxSector.SelectedItem = empresa.Sector;
            


        }

        private void FrmModAddEmpresas_Load(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var listaSectores = from s in objBD.SECTORES
                                    orderby s.Descripcion
                                    select new
                                    {
                                        Id_Sector = s.Id_sector,
                                        Descripcion = s.Descripcion
                                    };
                foreach (var item in listaSectores)
                {
                    comboBoxSector.Items.Add(new ComboItem(item.Descripcion, item.Id_Sector));
                }
                if (empresaSeleccionada != null)
                {
                    var nombreEmpresaSeleccionada = objBD.SECTORES.
                    Where(
                    x => x.Id_sector == empresaSeleccionada.Sector)
                    .FirstOrDefault().Descripcion.ToString();
                    comboBoxSector.Text = nombreEmpresaSeleccionada;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
