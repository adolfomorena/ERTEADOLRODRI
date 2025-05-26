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

        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {

        }
    }
}
