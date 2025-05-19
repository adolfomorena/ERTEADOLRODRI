namespace ERTEADOLRODRI
{
    partial class FrmEmpresas
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
            this.dataGridEmpresas = new System.Windows.Forms.DataGridView();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmpresas
            // 
            this.dataGridEmpresas.AllowUserToAddRows = false;
            this.dataGridEmpresas.AllowUserToDeleteRows = false;
            this.dataGridEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpresas.Location = new System.Drawing.Point(12, 12);
            this.dataGridEmpresas.MultiSelect = false;
            this.dataGridEmpresas.Name = "dataGridEmpresas";
            this.dataGridEmpresas.ReadOnly = true;
            this.dataGridEmpresas.RowHeadersWidth = 51;
            this.dataGridEmpresas.RowTemplate.Height = 24;
            this.dataGridEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpresas.Size = new System.Drawing.Size(776, 360);
            this.dataGridEmpresas.TabIndex = 0;
            this.dataGridEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmpresas_CellClick);
            this.dataGridEmpresas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmpresas_CellDoubleClick);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(51, 389);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(118, 38);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(338, 389);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 38);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(623, 389);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 38);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.dataGridEmpresas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpresas";
            this.Text = "FrmEmpresas";
            this.Load += new System.EventHandler(this.FrmEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmpresas;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}