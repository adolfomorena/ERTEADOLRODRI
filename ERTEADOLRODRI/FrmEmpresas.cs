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
    public partial class FrmEmpresas : Form
    {
        public FrmEmpresas()
        {
            InitializeComponent();
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
        }

        private void dataGridEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            abrirFrmModEmpresa();

            CargarEmpresas();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            FrmModAddEmpresas frmModEmpresa = new FrmModAddEmpresas();
            frmModEmpresa.ShowDialog();

            CargarEmpresas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirFrmModEmpresa();
            CargarEmpresas();

        }
        public void CargarEmpresas()
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var listaEmpresas = from emp in objBD.EMPRESAS
                                    join s in objBD.SECTORES on emp.Sector equals s.Id_sector
                                    orderby emp.Nombre
                                    select new
                                    {
                                        Nombre_Empresa = emp.Nombre,
                                        Nombre_Sector = s.Descripcion,
                                        CIF = emp.Cif
                                    };

                dataGridEmpresas.DataSource = listaEmpresas.ToList();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridEmpresas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No ha seleccionado ninguna empresa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var empresa = dataGridEmpresas.SelectedRows[0].Cells["CIF"].Value.ToString();
                using (bd_ertesEntities objBD = new bd_ertesEntities())
                {
                    var empresaSeleccionada = (from emp in objBD.EMPRESAS
                                               where emp.Cif == empresa
                                               select emp).FirstOrDefault();
                    if (empresaSeleccionada == null)
                    {
                        MessageBox.Show("No se ha encontrado la empresa seleccionada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    objBD.EMPRESAS.Remove(empresaSeleccionada);
                    objBD.SaveChanges();
                    MessageBox.Show("La empresa ha sido eliminada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpresas();
                }

            }
        }
        public void abrirFrmModEmpresa()
        {
            if (dataGridEmpresas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No ha seleccionado ninguna empresa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empresa = dataGridEmpresas.SelectedRows[0].Cells["CIF"].Value.ToString();

            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var empresaSeleccionada = (from emp in objBD.EMPRESAS
                                           where emp.Cif == empresa
                                           select emp).FirstOrDefault();
                if (empresaSeleccionada == null)
                {
                    MessageBox.Show("No se ha encontrado la empresa seleccionada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                FrmModAddEmpresas frmModEmpresa = new FrmModAddEmpresas(
                    empresaSeleccionada
                    );
                frmModEmpresa.ShowDialog();
            }
        }

       
    }
}
