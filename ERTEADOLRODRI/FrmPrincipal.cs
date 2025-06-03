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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Desea salir de la aplicacion?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void eMPRESASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmEmpresas));
        }
        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmEmpleados));
        }
        private void AbrirFormulario(Type formType)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].GetType() != formType)
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            Form form = (Form)Activator.CreateInstance(formType);
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void eRTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmERTES));
        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmInformes));
        }
    }
}
