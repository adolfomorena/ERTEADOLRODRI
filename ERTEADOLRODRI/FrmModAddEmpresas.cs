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
        public FrmModAddEmpresas()
        {
            InitializeComponent();
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
                comboBoxSector.DataSource = listaSectores.ToList();
            }
        }
    }
}
