namespace ERTEADOLRODRI
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label empresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.eMPLEADOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLEADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new ERTEADOLRODRI.dsBD();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLEADOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtDni = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.cmbEmpresas = new System.Windows.Forms.ComboBox();
            this.eMPRESASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFoto = new System.Windows.Forms.Button();
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.eMPLEADOSTableAdapter = new ERTEADOLRODRI.dsBDTableAdapters.EMPLEADOSTableAdapter();
            this.tableAdapterManager = new ERTEADOLRODRI.dsBDTableAdapters.TableAdapterManager();
            this.eMPLEADOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPRESASTableAdapter = new ERTEADOLRODRI.dsBDTableAdapters.EMPRESASTableAdapter();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingNavigator)).BeginInit();
            this.eMPLEADOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dniLabel.Location = new System.Drawing.Point(94, 119);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(44, 20);
            dniLabel.TabIndex = 1;
            dniLabel.Text = "Dni:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(94, 163);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(80, 20);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel.Location = new System.Drawing.Point(94, 213);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(92, 20);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "Apellidos:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(94, 257);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(62, 20);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            domicilioLabel.Location = new System.Drawing.Point(94, 303);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(94, 20);
            domicilioLabel.TabIndex = 9;
            domicilioLabel.Text = "Domicilio:";
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empresaLabel.Location = new System.Drawing.Point(94, 346);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(89, 20);
            empresaLabel.TabIndex = 13;
            empresaLabel.Text = "Empresa:";
            // 
            // eMPLEADOSBindingNavigator
            // 
            this.eMPLEADOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eMPLEADOSBindingNavigator.BindingSource = this.eMPLEADOSBindingSource;
            this.eMPLEADOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPLEADOSBindingNavigator.DeleteItem = null;
            this.eMPLEADOSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eMPLEADOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eMPLEADOSBindingNavigatorSaveItem});
            this.eMPLEADOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPLEADOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPLEADOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPLEADOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPLEADOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPLEADOSBindingNavigator.Name = "eMPLEADOSBindingNavigator";
            this.eMPLEADOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPLEADOSBindingNavigator.Size = new System.Drawing.Size(905, 27);
            this.eMPLEADOSBindingNavigator.TabIndex = 0;
            this.eMPLEADOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // eMPLEADOSBindingSource
            // 
            this.eMPLEADOSBindingSource.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource.DataSource = this.dsBD;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // eMPLEADOSBindingNavigatorSaveItem
            // 
            this.eMPLEADOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLEADOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLEADOSBindingNavigatorSaveItem.Image")));
            this.eMPLEADOSBindingNavigatorSaveItem.Name = "eMPLEADOSBindingNavigatorSaveItem";
            this.eMPLEADOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.eMPLEADOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.eMPLEADOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPLEADOSBindingNavigatorSaveItem_Click);
            // 
            // txtDni
            // 
            this.txtDni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Dni", true));
            this.txtDni.Location = new System.Drawing.Point(203, 115);
            this.txtDni.Mask = "00000000>L";
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(151, 22);
            this.txtDni.TabIndex = 2;
            this.txtDni.Validating += new System.ComponentModel.CancelEventHandler(this.txtDni_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(203, 159);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Apellidos", true));
            this.txtApellidos.Location = new System.Drawing.Point(203, 209);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(286, 22);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(203, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 22);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Domicilio", true));
            this.txtDomicilio.Location = new System.Drawing.Point(203, 299);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(286, 22);
            this.txtDomicilio.TabIndex = 10;
            // 
            // pbFoto
            // 
            this.pbFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eMPLEADOSBindingSource, "Foto", true));
            this.pbFoto.Location = new System.Drawing.Point(557, 115);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(294, 251);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 12;
            this.pbFoto.TabStop = false;
            // 
            // cmbEmpresas
            // 
            this.cmbEmpresas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eMPLEADOSBindingSource, "Empresa", true));
            this.cmbEmpresas.DataSource = this.eMPRESASBindingSource;
            this.cmbEmpresas.DisplayMember = "Nombre";
            this.cmbEmpresas.FormattingEnabled = true;
            this.cmbEmpresas.Location = new System.Drawing.Point(203, 342);
            this.cmbEmpresas.Name = "cmbEmpresas";
            this.cmbEmpresas.Size = new System.Drawing.Size(286, 24);
            this.cmbEmpresas.TabIndex = 14;
            this.cmbEmpresas.ValueMember = "Cif";
            // 
            // eMPRESASBindingSource
            // 
            this.eMPRESASBindingSource.DataMember = "EMPRESAS";
            this.eMPRESASBindingSource.DataSource = this.dsBD;
            // 
            // btnFoto
            // 
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.Location = new System.Drawing.Point(636, 405);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(137, 45);
            this.btnFoto.TabIndex = 15;
            this.btnFoto.Text = "CAMBAIR FOTO";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // eMPLEADOSTableAdapter
            // 
            this.eMPLEADOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLEADOSTableAdapter = this.eMPLEADOSTableAdapter;
            this.tableAdapterManager.EMPRESASTableAdapter = null;
            this.tableAdapterManager.ERTESTableAdapter = null;
            this.tableAdapterManager.SECTORESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ERTEADOLRODRI.dsBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPLEADOSBindingSource1
            // 
            this.eMPLEADOSBindingSource1.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource1.DataSource = this.dsBD;
            // 
            // eMPRESASTableAdapter
            // 
            this.eMPRESASTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 525);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(domicilioLabel);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.cmbEmpresas);
            this.Controls.Add(this.eMPLEADOSBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingNavigator)).EndInit();
            this.eMPLEADOSBindingNavigator.ResumeLayout(false);
            this.eMPLEADOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBD dsBD;
        private System.Windows.Forms.BindingSource eMPLEADOSBindingSource;
        private dsBDTableAdapters.EMPLEADOSTableAdapter eMPLEADOSTableAdapter;
        private dsBDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPLEADOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eMPLEADOSBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ComboBox cmbEmpresas;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.BindingSource eMPLEADOSBindingSource1;
        private System.Windows.Forms.BindingSource eMPRESASBindingSource;
        private dsBDTableAdapters.EMPRESASTableAdapter eMPRESASTableAdapter;
    }
}