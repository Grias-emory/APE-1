namespace Grupo9_Ape1_ManejoDeArrays
{
    partial class Ejercicio1
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
            this.dgvMatrizA = new System.Windows.Forms.DataGridView();
            this.dgvMatrizB = new System.Windows.Forms.DataGridView();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatrizA
            // 
            this.dgvMatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizA.Location = new System.Drawing.Point(12, 50);
            this.dgvMatrizA.Name = "dgvMatrizA";
            this.dgvMatrizA.Size = new System.Drawing.Size(240, 200);
            this.dgvMatrizA.TabIndex = 0;
            // 
            // dgvMatrizB
            // 
            this.dgvMatrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizB.Location = new System.Drawing.Point(270, 50);
            this.dgvMatrizB.Name = "dgvMatrizB";
            this.dgvMatrizB.Size = new System.Drawing.Size(240, 200);
            this.dgvMatrizB.TabIndex = 1;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(530, 50);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(240, 200);
            this.dgvResultado.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(50, 270);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 30);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Matrices";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(180, 270);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(100, 30);
            this.btnMultiplicar.TabIndex = 4;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(310, 270);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(110, 15);
            this.numSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(50, 20);
            this.numSize.TabIndex = 6;
            this.numSize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tamaño de matriz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.dgvMatrizB);
            this.Controls.Add(this.dgvMatrizA);
            this.Name = "Form1";
            this.Text = "Multiplicación de Matrices";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrizA;
        private System.Windows.Forms.DataGridView dgvMatrizB;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label1;
    }

}