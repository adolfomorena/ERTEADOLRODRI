using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            using (bd_ertesEntities objBD=new bd_ertesEntities())
            {

                if(string.IsNullOrEmpty(textBoxDomicilio.Text)||
                    string.IsNullOrEmpty(textBoxCIF.Text)||
                        string.IsNullOrEmpty(textBoxNombre.Text)||
                        string.IsNullOrEmpty(comboBoxSector.Text)){

                    MessageBox.Show("Debe rellenar todos los campos", "Modificar empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (EsCIF(textBoxCIF.Text))
                {
                    MessageBox.Show("CIF Invalido", "El CIF solo puede contener nunmeros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var empresaExistente = objBD.EMPRESAS
                    .Where(x => x.Cif == textBoxCIF.Text).FirstOrDefault();

                if (empresaExistente != null && empresaSeleccionada == null)
                {
                    MessageBox.Show("Ya existe una empresa con ese CIF", "Modificar empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (empresaSeleccionada == null)
                {
                    var sectorSeleccionado = objBD.SECTORES
                                           .Where(x => x.Descripcion == comboBoxSector.Text).
                                           FirstOrDefault().Id_sector;

                    EMPRESAS nuevaEmpresa = new EMPRESAS();
                    nuevaEmpresa.Cif = textBoxCIF.Text;
                    nuevaEmpresa.Nombre=textBoxNombre.Text;
                    nuevaEmpresa.Domicilio = textBoxDomicilio.Text;
                    nuevaEmpresa.Sector = sectorSeleccionado;

                    objBD.EMPRESAS.Add(nuevaEmpresa);
                    objBD.SaveChanges();

                    MessageBox.Show("Empresa añadida correctamente", "Añadir empresa", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    this.Close();

                }else
                {
                    var sectorSeleccionado = objBD.SECTORES
                                           .Where(x => x.Descripcion == comboBoxSector.Text).
                                           FirstOrDefault().Id_sector;
                    empresaExistente = objBD.EMPRESAS.Where(x => x.Cif == textBoxCIF.Text).FirstOrDefault();
                    empresaExistente.Nombre = textBoxNombre.Text;
                    empresaExistente.Domicilio = textBoxDomicilio.Text;
                    empresaExistente.Sector = sectorSeleccionado;

                    objBD.SaveChanges();
                    MessageBox.Show("Empresa modificada correctamente", "Modificar empresa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }

            }
               
        }
        private bool EsCIF(string input)
        {
            return Regex.IsMatch(input, @"^[ABCDEFGHJKLMNPQRSUVW]\d{7}[0-9A-J]$");
        }

    }
}
