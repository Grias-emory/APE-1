namespace Grupo9_Ape1_ManejoDeArrays
{
    partial class Ejercicio3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView matrixGrid;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.DataGridView qMatrixGrid;
        private System.Windows.Forms.DataGridView rMatrixGrid;

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
            this.matrixGrid = new System.Windows.Forms.DataGridView();
            this.calculateButton = new System.Windows.Forms.Button();
            this.qMatrixGrid = new System.Windows.Forms.DataGridView();
            this.rMatrixGrid = new System.Windows.Forms.DataGridView();

            this.SuspendLayout();

            // 
            // matrixGrid (Matriz A)
            // 
            this.matrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGrid.Location = new System.Drawing.Point(20, 20);
            this.matrixGrid.Size = new System.Drawing.Size(300, 150);
            this.matrixGrid.ColumnCount = 3;
            this.matrixGrid.RowCount = 3;

            // 
            // calculateButton
            // 
            this.calculateButton.Text = "Calcular QR";
            this.calculateButton.Location = new System.Drawing.Point(350, 80);
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);

            // 
            // qMatrixGrid (Matriz Q)
            // 
            this.qMatrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qMatrixGrid.Location = new System.Drawing.Point(20, 200);
            this.qMatrixGrid.Size = new System.Drawing.Size(300, 150);
            this.qMatrixGrid.ColumnCount = 3;
            this.qMatrixGrid.RowCount = 3;

            // 
            // rMatrixGrid (Matriz R)
            // 
            this.rMatrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rMatrixGrid.Location = new System.Drawing.Point(350, 200);
            this.rMatrixGrid.Size = new System.Drawing.Size(300, 150);
            this.rMatrixGrid.ColumnCount = 3;
            this.rMatrixGrid.RowCount = 3;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.matrixGrid);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.qMatrixGrid);
            this.Controls.Add(this.rMatrixGrid);
            this.Text = "Descomposición QR - Gram-Schmidt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
    }
}