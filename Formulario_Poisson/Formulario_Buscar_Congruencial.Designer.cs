namespace Formulario_Poisson
{
    partial class Formulario_Buscar_Congruencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Buscar_Congruencial));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgDatosCongruencial = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosCongruencial)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgDatosCongruencial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // dtgDatosCongruencial
            // 
            this.dtgDatosCongruencial.AllowUserToAddRows = false;
            this.dtgDatosCongruencial.AllowUserToDeleteRows = false;
            this.dtgDatosCongruencial.BackgroundColor = System.Drawing.Color.White;
            this.dtgDatosCongruencial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDatosCongruencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosCongruencial.Location = new System.Drawing.Point(6, 19);
            this.dtgDatosCongruencial.Name = "dtgDatosCongruencial";
            this.dtgDatosCongruencial.ReadOnly = true;
            this.dtgDatosCongruencial.Size = new System.Drawing.Size(651, 265);
            this.dtgDatosCongruencial.TabIndex = 1;
            this.dtgDatosCongruencial.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatosCongruencial_CellContentDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Autor: Cristhian Adrián López Mora";
            // 
            // Formulario_Buscar_Congruencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario_Buscar_Congruencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Congruencial";
            this.Load += new System.EventHandler(this.Formulario_Buscar_Congruencial_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosCongruencial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgDatosCongruencial;
        private System.Windows.Forms.Label label4;
    }
}