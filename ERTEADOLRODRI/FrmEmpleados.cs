using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERTEADOLRODRI
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void eMPLEADOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea guardar los cambios?",
                "Confirmar guardado",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.eMPLEADOSBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dsBD);

                    MessageBox.Show("Los cambios se han guardado correctamente.",
                        "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                catch (Exception ex)
                {
                    MessageBox.Show("Revisa el DNI del empleado. Ya existe en la BD.",
                                "DNI duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.EMPRESAS' Puede moverla o quitarla según sea necesario.
            this.eMPRESASTableAdapter.Fill(this.dsBD.EMPRESAS);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.EMPLEADOS' Puede moverla o quitarla según sea necesario.
            this.eMPLEADOSTableAdapter.Fill(this.dsBD.EMPLEADOS);

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string expresion = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if(!Regex.IsMatch(email, expresion))
            {
                errorEmail.SetError(txtEmail, "El formato del correo electrónico no es válido.");
                e.Cancel = true;
            }
            else
            {
                errorEmail.SetError(txtEmail, "");
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            ofdFoto.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.bmp;*.png)|*.jpg;*.jpeg;*.bmp;*.png";
            ofdFoto.Title = "Seleccionar foto de empleado";

            if(ofdFoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbFoto.Image = Image.FromFile(ofdFoto.FileName);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    eMPLEADOSTableAdapter.DeleteById(txtDni.Text);
                    eMPLEADOSTableAdapter.Fill(dsBD.EMPLEADOS);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el empleado: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            if (!txtDni.MaskFull)
            {
                errorEmail.SetError(txtDni, "El DNI debe estar completamente rellenado.");
                e.Cancel = true;
            }
            else
            {
                errorEmail.SetError(txtDni, "");
            }
        }
    }
}
