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
    public partial class FrmInformes : Form
    {
        public FrmInformes()
        {
            InitializeComponent();
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var qConsulta1 = (from emp in objBD.EMPRESAS
                                  where emp.ERTES.Any()
                                  let numEmple = emp.EMPLEADOS.Count()
                                  orderby numEmple descending
                                  select new
                                  {
                                      emp.Nombre,
                                      emp.Cif,
                                      NumEmpleados = numEmple,
                                  }).ToList();

                if (qConsulta1.Any())
                {
                    int maxEmple = qConsulta1.Max(x => x.NumEmpleados);

                    var resultado = qConsulta1.Where(x => x.NumEmpleados == maxEmple).ToList();

                    dgvConsultas.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No hay empresas con ERTES registrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var qConsulta2 = (from emp in objBD.EMPRESAS
                                  let totalErtes = emp.ERTES.Count()
                                  orderby totalErtes descending
                                  select new
                                  {
                                      emp.Nombre,
                                      emp.Cif,
                                      TotalErtes = totalErtes
                                  }).ToList();
                if (qConsulta2.Any())
                {
                    int maxErtes = qConsulta2.Max(x => x.TotalErtes);

                    var resultado = qConsulta2.Where(x => x.TotalErtes == maxErtes).ToList();

                    dgvConsultas.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No hay registros de ERTES en ninguna empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var qConsulta3 = (from sect in objBD.SECTORES
                                  let totalEmpresas = sect.EMPRESAS.Count()
                                  orderby totalEmpresas descending
                                  select new
                                  {
                                      sect.Descripcion,
                                      TotalEmpresas = totalEmpresas
                                  }).ToList();

                if (qConsulta3.Any())
                {
                    int maxEmpresas = qConsulta3.Max(x => x.TotalEmpresas);

                    var resultado = qConsulta3.Where(x => x.TotalEmpresas == maxEmpresas).ToList();

                    dgvConsultas.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No hay registros de Empresas de ningún Sector.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var fechaMin = objBD.ERTES.Min(ert => ert.Fecha_inicio);

                var consulta4 = (from emp in objBD.EMPRESAS
                                 join ert in objBD.ERTES on emp.Cif equals ert.Empresa
                                 where ert.Fecha_inicio == fechaMin
                                 select new
                                 {
                                     emp.Nombre,
                                     emp.Cif,
                                 }).ToList();

                if (consulta4.Any())
                {
                    dgvConsultas.DataSource = consulta4;
                }
                else
                {
                    MessageBox.Show("No hay ERTES registrados en ninguna empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {

                var consulta5 = (from emp in objBD.EMPRESAS
                                 where emp.ERTES.Any(ert => ert.Fecha_fin == null)
                                 select new
                                 {
                                     numero_Empleados = emp.EMPLEADOS.Count(),
                                 }).ToList();


                if (consulta5.Any())
                {
                    int numTotalEmple= consulta5.Sum(x => x.numero_Empleados);
                    dgvConsultas.DataSource = new List<object>
                    {
                        new { TotalEmpleados = numTotalEmple }
                    };
                }
                else
                {
                    MessageBox.Show("No hay ERTES activos en ninguna empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
