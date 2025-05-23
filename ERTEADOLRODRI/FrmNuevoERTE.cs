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
    public partial class FrmNuevoERTE : Form
    {
        public FrmNuevoERTE()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNuevoERTE_Load(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var qEmpresas = from emp in objBD.EMPRESAS
                                where !(objBD.ERTES.Any(erte => erte.Empresa == emp.Cif && erte.Fecha_fin == null))
                                orderby emp.Nombre
                                select emp;

                foreach (var emp in qEmpresas)
                {
                    ComboItem item = new ComboItem();
                    item.Text = emp.Nombre;
                    item.Value = emp.Cif;

                    cmbEmpresas.Items.Add(item);
                }
            }
        }
    }
}
