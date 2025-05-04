namespace Grupo9_Ape1_ManejoDeArrays
{
    partial class Ejercicio2
    {
        /// <summary>
        /// Variable de diseño necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Requiere el diseño del componente.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSistema = new System.Windows.Forms.DataGridView();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.btnResolver = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSistema
            // 
            this.dgvSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSistema.Location = new System.Drawing.Point(12, 12);
            this.dgvSistema.Name = "dgvSistema";
            this.dgvSistema.Size = new System.Drawing.Size(400, 200);
            this.dgvSistema.TabIndex = 0;
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(12, 230);
            this.numSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(120, 20);
            this.numSize.TabIndex = 1;
            this.numSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(12, 260);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(120, 23);
            this.btnResolver.TabIndex = 2;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 290);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(400, 150);
            this.txtResultado.TabIndex = 3;
            // 
            // Ejercicio2
            // 
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.dgvSistema);
            this.Name = "Ejercicio2";
            this.Text = "Sistema de Ecuaciones Lineales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSistema;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.TextBox txtResultado;
    }

}