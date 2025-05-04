namespace Grupo9_Ape1_ManejoDeArrays
{
    partial class Ejercicio4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblAutovalores;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAutovalores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();

            // DataGridView (Matriz)
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(12, 12);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(300, 200);
            this.dgvMatriz.TabIndex = 0;
            this.dgvMatriz.AllowUserToAddRows = false; // Evita filas en blanco
            this.dgvMatriz.AllowUserToDeleteRows = false; // Evita borrar filas
            this.dgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Ajustar tamaño de columnas
            this.dgvMatriz.ColumnHeadersVisible = false; // Oculta encabezados de columna

            // Botón Calcular
            this.btnCalcular.Location = new System.Drawing.Point(12, 220);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(300, 30);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular Autovalores";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);

            // Label para mostrar los autovalores
            this.lblAutovalores.AutoSize = true;
            this.lblAutovalores.Location = new System.Drawing.Point(12, 260);
            this.lblAutovalores.Name = "lblAutovalores";
            this.lblAutovalores.Size = new System.Drawing.Size(70, 15);
            this.lblAutovalores.TabIndex = 2;
            this.lblAutovalores.Text = "Autovalores:";

            // Configuración del Formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 300);
            this.Controls.Add(this.lblAutovalores);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvMatriz);
            this.Name = "Form1";
            this.Text = "Método de Jacobi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}