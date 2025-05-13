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
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {

                var listaEmpresas = from emp in objBD.EMPRESAS
                                    join s in objBD.SECTORES on emp.Sector
                                    equals s.Id_sector
                                    orderby emp.Nombre
                                    select new
                                    {
                                        Nombre_Empresa = emp.Nombre,
                                        Nombre_Sector=s.Descripcion,
                                        CIF = emp.Cif
                                    };

                dataGridEmpresas.DataSource = listaEmpresas.ToList();

            }
        }

        private void dataGridEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmModAddEmpresas frmModEmpresa = new FrmModAddEmpresas();
            frmModEmpresa.ShowDialog();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            FrmModAddEmpresas frmModEmpresa = new FrmModAddEmpresas();
            frmModEmpresa.ShowDialog();
        }
        
    }
}
