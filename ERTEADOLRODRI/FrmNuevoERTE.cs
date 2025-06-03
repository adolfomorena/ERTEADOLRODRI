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
                                // Filtra las empresas que no tienen al menos un ERTE activo
                                where !emp.ERTES.Any(x => x.Fecha_fin == null)
                                orderby emp.Nombre
                                select emp;

                cmbEmpresas.Items.Clear();

                foreach (var emp in qEmpresas)
                {
                    ComboItem item = new ComboItem();
                    item.Text = emp.Nombre;
                    item.Value = emp.Cif;

                    cmbEmpresas.Items.Add(item);
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbEmpresas.SelectedItem != null)
            {
                // Obtenemos el CIF de la empresa seleccionada desde ComboItem
                ComboItem itemSeleccionado = (ComboItem)cmbEmpresas.SelectedItem;
                string cifEmpresa = (string)itemSeleccionado.Value;

                using (bd_ertesEntities objBD = new bd_ertesEntities())
                {
                    var nuevoERTE = new ERTES
                    {
                        Empresa = cifEmpresa,
                        Fecha_inicio = DateTime.Now,
                        Fecha_fin = null
                    };
                    objBD.ERTES.Add(nuevoERTE);
                    objBD.SaveChanges();
                }

                MessageBox.Show("Nuevo ERTE creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se seleccionó ninguna Empresa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
