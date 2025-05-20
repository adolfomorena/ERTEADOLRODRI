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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarDatos();
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
                    if (erteSeleccionado != null)
                    {
                        DialogResult resultado = MessageBox.Show("¿Está seguro de que desea finalizar el ERTE?", "Finalizar ERTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            erteSeleccionado.Fecha_fin = DateTime.Now;
                            objBD.SaveChanges();
                            MessageBox.Show("ERTE finalizado correctamente");
                            buscarDatos();
                        }
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
                var listaERTE = from ert in objBD.ERTES
                                join emp in objBD.EMPRESAS on ert.Empresa equals emp.Cif
                                join s in objBD.SECTORES on emp.Sector equals s.Id_sector
                                select new
                                {
                                    Nombre_Empresa = emp.Nombre,
                                    CIF = emp.Cif,
                                    Nombre_Sector = s.Descripcion,
                                    N_Empleados = objBD.EMPLEADOS.Where(x => x.Empresa.Equals(emp.Cif)).Count(),
                                    F_Inicio = ert.Fecha_inicio,
                                    F_Fin = ert.Fecha_fin,

                                };


                if (!string.IsNullOrEmpty(txtbxNombreEmpresa.Text))
                {
                    listaERTE = from res in listaERTE
                                where res.Nombre_Empresa.ToUpper().StartsWith(txtbxNombreEmpresa.Text)
                                select res;
                }
                if (!string.IsNullOrEmpty(txtbxNombreSector.Text))
                {
                    listaERTE = from res in listaERTE
                                where res.Nombre_Sector.ToUpper().StartsWith(txtbxNombreSector.Text)
                                select res;
                }
                if (!string.IsNullOrEmpty(txtbxEmpleadoHasta.Text))
                {
                    listaERTE = from res in listaERTE
                                where res.N_Empleados <= Convert.ToInt32(txtbxEmpleadoHasta.Text)
                                select res;
                }
                if (!string.IsNullOrEmpty(txtbxEmpleadoDesde.Text))
                {
                    listaERTE = from res in listaERTE
                                where res.N_Empleados >= Convert.ToInt32(txtbxEmpleadoDesde.Text)
                                select res;
                }
                if (datepickerFechaInicioDesde.Value != null)
                {
                    listaERTE = from res in listaERTE
                                where res.F_Inicio >= datepickerFechaInicioDesde.Value
                                select res;
                }
                if (datepickerFechaInicioHasta.Value != null)
                {
                    listaERTE = from res in listaERTE
                                where res.F_Inicio <= datepickerFechaInicioHasta.Value
                                select res;
                }
                if (!string.IsNullOrEmpty(maskedTextBoxFechaFinDesde.Text))
                {
                    if (EsFechaValida(maskedTextBoxFechaFinDesde.Text))
                    {
                        listaERTE = from res in listaERTE
                                    where res.F_Fin >= DateTime.Parse(maskedTextBoxFechaFinDesde.Text)
                                    select res;
                    }
                    else
                    {
                        errorProvider1.SetError(maskedTextBoxFechaFinDesde, "Fecha incorrecta");
                    }
                }
                if (!string.IsNullOrEmpty(maskedTextBoxFechaFinHasta.Text))
                {
                    if (EsFechaValida(maskedTextBoxFechaFinHasta.Text))
                    {
                        listaERTE = from res in listaERTE
                                    where res.F_Fin <= DateTime.Parse(maskedTextBoxFechaFinHasta.Text)
                                    select res;
                    }
                    else
                    {
                       errorProvider1.SetError(maskedTextBoxFechaFinHasta,"Fecha incorrecta");
                    }
                }
                
                dataGridERTE.DataSource = listaERTE.ToList();
            }

        }
        private bool EsFechaValida(string fecha)
        {
            string textoFecha = fecha;
            bool esValida = DateTime.TryParseExact(
                textoFecha,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime fechaParseada
            );
            if (!esValida)
            {
                return false;
            }
            if (fechaParseada > DateTime.Today)
            {
                return false;
            }
            if (fechaParseada.Year < 1900)
            {
                return false;
            }

            return true;
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

        private void FrmERTES_Load(object sender, EventArgs e)
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


