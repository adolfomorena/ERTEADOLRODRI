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
    public partial class FrmERTES : Form
    {
        public FrmERTES()
        {
            InitializeComponent();
        }

        private void FrmERTES_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarDatos();
        }

        private void btnNuevoErte_Click(object sender, EventArgs e)
        {
            FrmNuevoERTE nuevoERTE = new FrmNuevoERTE();
            nuevoERTE.ShowDialog();

        }

        private void btnFinERTE_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                if (dataGridERTE.SelectedRows.Count > 0)
                {
                    string cif = dataGridERTE.SelectedRows[0].Cells[1].Value.ToString();
                    var erteSeleccionado = (objBD.ERTES.Where(
                       x => x.Empresa.Equals(cif))).FirstOrDefault();

                    if (erteSeleccionado.Fecha_fin == null)
                    {
                        DialogResult resultado = MessageBox.Show("¿Está seguro de que desea finalizar el ERTE?", "Finalizar ERTE",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            erteSeleccionado.Fecha_fin = DateTime.Now;
                            objBD.SaveChanges();
                            MessageBox.Show("ERTE finalizado correctamente");

                            buscarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ERTE ya ha sido finalizado");
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione una fila para modificar");
                }
            }
        }

        private void buscarDatos()
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var qERTES = from erte in objBD.ERTES
                             join emp in objBD.EMPRESAS on erte.Empresa equals emp.Cif
                             join sect in objBD.SECTORES on emp.Sector equals sect.Id_sector
                             select new
                             {
                                 Empresa = emp.Nombre,
                                 CIF = emp.Cif,
                                 Sector = sect.Descripcion,
                                 NumEmpleados = objBD.EMPLEADOS.Count(x => x.Empresa == emp.Cif),
                                 FechaInicio = erte.Fecha_inicio,
                                 FechaFin = erte.Fecha_fin,
                             };

                if (!string.IsNullOrWhiteSpace(txtbxNombreEmpresa.Text))
                {
                    string nombre = txtbxNombreEmpresa.Text.ToUpper();
                    qERTES = qERTES.Where(x => x.Empresa.ToUpper().StartsWith(nombre));
                }

                if (!string.IsNullOrWhiteSpace(txtbxNombreSector.Text))
                {
                    string sector = txtbxNombreSector.Text.ToUpper();
                    qERTES = qERTES.Where(x => x.Sector.ToUpper().StartsWith(sector));
                }

                if (int.TryParse(txtbxEmpleadoDesde.Text, out int empDesde))
                {
                    qERTES = qERTES.Where(x => x.NumEmpleados >= empDesde);
                }

                if (int.TryParse(txtbxEmpleadoHasta.Text, out int empHasta))
                {
                    qERTES = qERTES.Where(x => x.NumEmpleados <= empHasta);
                }

                if (datepickerFechaInicioDesde.Checked)
                {
                    qERTES = qERTES.Where(x => x.FechaInicio >= datepickerFechaInicioDesde.Value.Date);
                }

                if (datepickerFechaInicioHasta.Checked)
                {
                    qERTES = qERTES.Where(x => x.FechaInicio <= datepickerFechaInicioHasta.Value.Date);
                }

                if (dtpFechaFinDesde.Checked)
                {
                    qERTES = qERTES.Where(x => x.FechaFin >= dtpFechaFinDesde.Value.Date);
                }

                if (dtpFechaFinHasta.Checked)
                {
                    qERTES = qERTES.Where(x => x.FechaFin <= dtpFechaFinHasta.Value.Date);
                }

                dataGridERTE.DataSource = qERTES.ToList();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }    
}


