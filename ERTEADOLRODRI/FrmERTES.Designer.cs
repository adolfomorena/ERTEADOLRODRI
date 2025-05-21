namespace ERTEADOLRODRI
{
    partial class FrmERTES
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
            this.txtbxNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxNombreSector = new System.Windows.Forms.TextBox();
            this.txtbxEmpleadoHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxEmpleadoDesde = new System.Windows.Forms.TextBox();
            this.datepickerFechaInicioDesde = new System.Windows.Forms.DateTimePicker();
            this.datepickerFechaInicioHasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridERTE = new System.Windows.Forms.DataGridView();
            this.btnNuevoErte = new System.Windows.Forms.Button();
            this.btnFinERTE = new System.Windows.Forms.Button();
            this.maskedTextBoxFechaFinDesde = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFechaFinHasta = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridERTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxNombreEmpresa
            // 
            this.txtbxNombreEmpresa.Location = new System.Drawing.Point(177, 33);
            this.txtbxNombreEmpresa.Name = "txtbxNombreEmpresa";
            this.txtbxNombreEmpresa.Size = new System.Drawing.Size(204, 22);
            this.txtbxNombreEmpresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre empresa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre sector:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbxNombreSector
            // 
            this.txtbxNombreSector.Location = new System.Drawing.Point(557, 35);
            this.txtbxNombreSector.Name = "txtbxNombreSector";
            this.txtbxNombreSector.Size = new System.Drawing.Size(204, 22);
            this.txtbxNombreSector.TabIndex = 4;
            // 
            // txtbxEmpleadoHasta
            // 
            this.txtbxEmpleadoHasta.Location = new System.Drawing.Point(596, 93);
            this.txtbxEmpleadoHasta.Name = "txtbxEmpleadoHasta";
            this.txtbxEmpleadoHasta.Size = new System.Drawing.Size(165, 22);
            this.txtbxEmpleadoHasta.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nº Empleados hasta:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "NºEmpleados desde:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbxEmpleadoDesde
            // 
            this.txtbxEmpleadoDesde.Location = new System.Drawing.Point(196, 91);
            this.txtbxEmpleadoDesde.Name = "txtbxEmpleadoDesde";
            this.txtbxEmpleadoDesde.Size = new System.Drawing.Size(185, 22);
            this.txtbxEmpleadoDesde.TabIndex = 5;
            // 
            // datepickerFechaInicioDesde
            // 
            this.datepickerFechaInicioDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerFechaInicioDesde.Location = new System.Drawing.Point(196, 147);
            this.datepickerFechaInicioDesde.Name = "datepickerFechaInicioDesde";
            this.datepickerFechaInicioDesde.Size = new System.Drawing.Size(185, 22);
            this.datepickerFechaInicioDesde.TabIndex = 9;
            this.datepickerFechaInicioDesde.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // datepickerFechaInicioHasta
            // 
            this.datepickerFechaInicioHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerFechaInicioHasta.Location = new System.Drawing.Point(596, 145);
            this.datepickerFechaInicioHasta.Name = "datepickerFechaInicioHasta";
            this.datepickerFechaInicioHasta.Size = new System.Drawing.Size(165, 22);
            this.datepickerFechaInicioHasta.TabIndex = 10;
            this.datepickerFechaInicioHasta.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha inicio desde:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha inicio hasta:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha fin hasta:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha fin desde:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(358, 230);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridERTE
            // 
            this.dataGridERTE.AllowUserToAddRows = false;
            this.dataGridERTE.AllowUserToDeleteRows = false;
            this.dataGridERTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridERTE.Location = new System.Drawing.Point(41, 259);
            this.dataGridERTE.MultiSelect = false;
            this.dataGridERTE.Name = "dataGridERTE";
            this.dataGridERTE.ReadOnly = true;
            this.dataGridERTE.RowHeadersWidth = 51;
            this.dataGridERTE.RowTemplate.Height = 24;
            this.dataGridERTE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridERTE.Size = new System.Drawing.Size(722, 150);
            this.dataGridERTE.TabIndex = 18;
            // 
            // btnNuevoErte
            // 
            this.btnNuevoErte.Location = new System.Drawing.Point(219, 415);
            this.btnNuevoErte.Name = "btnNuevoErte";
            this.btnNuevoErte.Size = new System.Drawing.Size(108, 23);
            this.btnNuevoErte.TabIndex = 19;
            this.btnNuevoErte.Text = "Nuevo ERTE";
            this.btnNuevoErte.UseVisualStyleBackColor = true;
            this.btnNuevoErte.Click += new System.EventHandler(this.btnNuevoErte_Click);
            // 
            // btnFinERTE
            // 
            this.btnFinERTE.Location = new System.Drawing.Point(477, 415);
            this.btnFinERTE.Name = "btnFinERTE";
            this.btnFinERTE.Size = new System.Drawing.Size(100, 23);
            this.btnFinERTE.TabIndex = 20;
            this.btnFinERTE.Text = "Fin ERTE";
            this.btnFinERTE.UseVisualStyleBackColor = true;
            this.btnFinERTE.Click += new System.EventHandler(this.btnFinERTE_Click);
            // 
            // maskedTextBoxFechaFinDesde
            // 
            this.maskedTextBoxFechaFinDesde.Location = new System.Drawing.Point(196, 192);
            this.maskedTextBoxFechaFinDesde.Mask = "00/00/0000";
            this.maskedTextBoxFechaFinDesde.Name = "maskedTextBoxFechaFinDesde";
            this.maskedTextBoxFechaFinDesde.Size = new System.Drawing.Size(185, 22);
            this.maskedTextBoxFechaFinDesde.TabIndex = 21;
            this.maskedTextBoxFechaFinDesde.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxFechaFinHasta
            // 
            this.maskedTextBoxFechaFinHasta.Location = new System.Drawing.Point(596, 192);
            this.maskedTextBoxFechaFinHasta.Mask = "00/00/0000";
            this.maskedTextBoxFechaFinHasta.Name = "maskedTextBoxFechaFinHasta";
            this.maskedTextBoxFechaFinHasta.Size = new System.Drawing.Size(167, 22);
            this.maskedTextBoxFechaFinHasta.TabIndex = 22;
            this.maskedTextBoxFechaFinHasta.ValidatingType = typeof(System.DateTime);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmERTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBoxFechaFinHasta);
            this.Controls.Add(this.maskedTextBoxFechaFinDesde);
            this.Controls.Add(this.btnFinERTE);
            this.Controls.Add(this.btnNuevoErte);
            this.Controls.Add(this.dataGridERTE);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datepickerFechaInicioHasta);
            this.Controls.Add(this.datepickerFechaInicioDesde);
            this.Controls.Add(this.txtbxEmpleadoHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxEmpleadoDesde);
            this.Controls.Add(this.txtbxNombreSector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxNombreEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmERTES";
            this.Text = "FrmERTES";
            this.Load += new System.EventHandler(this.FrmERTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridERTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxNombreEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxNombreSector;
        private System.Windows.Forms.TextBox txtbxEmpleadoHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxEmpleadoDesde;
        private System.Windows.Forms.DateTimePicker datepickerFechaInicioDesde;
        private System.Windows.Forms.DateTimePicker datepickerFechaInicioHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridERTE;
        private System.Windows.Forms.Button btnNuevoErte;
        private System.Windows.Forms.Button btnFinERTE;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaFinDesde;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaFinHasta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}