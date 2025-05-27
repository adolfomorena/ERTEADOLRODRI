namespace ERTEADOLRODRI
{
    partial class FrmInformes
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
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.btnConsulta5 = new System.Windows.Forms.Button();
            this.btnConsulta4 = new System.Windows.Forms.Button();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.dsBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new ERTEADOLRODRI.dsBD();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta1.Location = new System.Drawing.Point(53, 50);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(118, 50);
            this.btnConsulta1.TabIndex = 0;
            this.btnConsulta1.Text = "CONSULTA 1";
            this.btnConsulta1.UseVisualStyleBackColor = true;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // btnConsulta5
            // 
            this.btnConsulta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta5.Location = new System.Drawing.Point(674, 50);
            this.btnConsulta5.Name = "btnConsulta5";
            this.btnConsulta5.Size = new System.Drawing.Size(118, 50);
            this.btnConsulta5.TabIndex = 1;
            this.btnConsulta5.Text = "CONSULTA 5";
            this.btnConsulta5.UseVisualStyleBackColor = true;
            this.btnConsulta5.Click += new System.EventHandler(this.btnConsulta5_Click);
            // 
            // btnConsulta4
            // 
            this.btnConsulta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta4.Location = new System.Drawing.Point(519, 50);
            this.btnConsulta4.Name = "btnConsulta4";
            this.btnConsulta4.Size = new System.Drawing.Size(118, 50);
            this.btnConsulta4.TabIndex = 2;
            this.btnConsulta4.Text = "CONSULTA 4";
            this.btnConsulta4.UseVisualStyleBackColor = true;
            this.btnConsulta4.Click += new System.EventHandler(this.btnConsulta4_Click);
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta3.Location = new System.Drawing.Point(360, 50);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Size = new System.Drawing.Size(118, 50);
            this.btnConsulta3.TabIndex = 3;
            this.btnConsulta3.Text = "CONSULTA 3";
            this.btnConsulta3.UseVisualStyleBackColor = true;
            this.btnConsulta3.Click += new System.EventHandler(this.btnConsulta3_Click);
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta2.Location = new System.Drawing.Point(208, 50);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(118, 50);
            this.btnConsulta2.TabIndex = 4;
            this.btnConsulta2.Text = "CONSULTA 2";
            this.btnConsulta2.UseVisualStyleBackColor = true;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(53, 132);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.Size = new System.Drawing.Size(739, 341);
            this.dgvConsultas.TabIndex = 5;
            // 
            // dsBDBindingSource
            // 
            this.dsBDBindingSource.DataSource = this.dsBD;
            this.dsBDBindingSource.Position = 0;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 500);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.btnConsulta3);
            this.Controls.Add(this.btnConsulta4);
            this.Controls.Add(this.btnConsulta5);
            this.Controls.Add(this.btnConsulta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformes";
            this.Text = "FrmInformes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Button btnConsulta5;
        private System.Windows.Forms.Button btnConsulta4;
        private System.Windows.Forms.Button btnConsulta3;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.BindingSource dsBDBindingSource;
        private dsBD dsBD;
    }
}