using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo9_Ape1_ManejoDeArrays
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarMatrizAleatoria();
        }

        private void LlenarMatrizAleatoria()
        {
            Random rand = new Random();
            int filas = matrixGrid.RowCount;
            int columnas = matrixGrid.ColumnCount;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrixGrid.Rows[i].Cells[j].Value = rand.Next(1, 10); // Valores entre 1 y 10
                }
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int filas = matrixGrid.RowCount;
            int columnas = matrixGrid.ColumnCount;
            double[,] A = new double[filas, columnas];

            // Leer matriz A desde DataGridView
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    A[i, j] = Convert.ToDouble(matrixGrid.Rows[i].Cells[j].Value);
                }
            }

            // Aplicar descomposición QR usando Gram-Schmidt
            (double[,] Q, double[,] R) = GramSchmidtQR(A);

            // Mostrar Q en la tabla
            MostrarMatriz(qMatrixGrid, Q);

            // Mostrar R en la tabla
            MostrarMatriz(rMatrixGrid, R);
        }

        private (double[,], double[,]) GramSchmidtQR(double[,] A)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            double[,] Q = new double[m, n];
            double[,] R = new double[n, n];

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    Q[i, j] = A[i, j];
                }

                for (int k = 0; k < j; k++)
                {
                    double dotProduct = 0;
                    for (int i = 0; i < m; i++)
                    {
                        dotProduct += Q[i, k] * A[i, j];
                    }

                    R[k, j] = dotProduct;

                    for (int i = 0; i < m; i++)
                    {
                        Q[i, j] -= dotProduct * Q[i, k];
                    }
                }

                double norm = 0;
                for (int i = 0; i < m; i++)
                {
                    norm += Q[i, j] * Q[i, j];
                }
                norm = Math.Sqrt(norm);
                R[j, j] = norm;

                for (int i = 0; i < m; i++)
                {
                    Q[i, j] /= norm;
                }
            }

            return (Q, R);
        }

        private void MostrarMatriz(DataGridView grid, double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            grid.RowCount = filas;
            grid.ColumnCount = columnas;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    grid.Rows[i].Cells[j].Value = matriz[i, j].ToString("F4");
                }
            }
        }
    }

}
