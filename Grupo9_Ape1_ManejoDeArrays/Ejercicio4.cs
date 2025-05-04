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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
            dgvMatriz.AllowUserToAddRows = false; // Evitar filas en blanco
            GenerarMatrizAleatoria();
        }

        private void GenerarMatrizAleatoria()
        {
            int n = 3; // Matriz 3x3 por defecto
            dgvMatriz.RowCount = n;
            dgvMatriz.ColumnCount = n;

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dgvMatriz.Rows[i].Cells[j].Value = rand.Next(0, 1000); // Rango 0-999
                }
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int n = dgvMatriz.RowCount;
            int m = dgvMatriz.ColumnCount;

            if (n != m || n == 0)
            {
                MessageBox.Show("La matriz debe ser cuadrada y no estar vacía.");
                return;
            }

            double[,] matriz = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dgvMatriz.Rows[i].Cells[j].Value == null ||
                        string.IsNullOrWhiteSpace(dgvMatriz.Rows[i].Cells[j].Value.ToString()))
                    {
                        MessageBox.Show($"La celda [{i + 1}, {j + 1}] está vacía.");
                        return;
                    }

                    if (!double.TryParse(dgvMatriz.Rows[i].Cells[j].Value.ToString(), out matriz[i, j]))
                    {
                        MessageBox.Show($"Valor inválido en la celda [{i + 1}, {j + 1}]. Introduce un número válido.");
                        return;
                    }
                }
            }

            double[] autovalores = MetodoJacobi(matriz, n);
            lblAutovalores.Text = "Autovalores: " + string.Join(", ", autovalores.Select(x => x.ToString("F4")));
        }

        private double[] MetodoJacobi(double[,] matriz, int n)
        {
            double[] autovalores = new double[n];

            for (int i = 0; i < n; i++)
                autovalores[i] = matriz[i, i];

            for (int iter = 0; iter < 100; iter++)
            {
                double max = 0;
                int p = 0, q = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Abs(matriz[i, j]) > max)
                        {
                            max = Math.Abs(matriz[i, j]);
                            p = i;
                            q = j;
                        }
                    }
                }

                if (max < 1e-6)
                    break;

                double theta = 0.5 * Math.Atan2(2 * matriz[p, q], matriz[q, q] - matriz[p, p]);
                double cos = Math.Cos(theta);
                double sin = Math.Sin(theta);

                for (int i = 0; i < n; i++)
                {
                    double temp = matriz[i, p];
                    matriz[i, p] = cos * temp - sin * matriz[i, q];
                    matriz[i, q] = sin * temp + cos * matriz[i, q];
                }

                for (int j = 0; j < n; j++)
                {
                    double temp = matriz[p, j];
                    matriz[p, j] = cos * temp - sin * matriz[q, j];
                    matriz[q, j] = sin * temp + cos * matriz[q, j];
                }

                matriz[p, p] = cos * cos * matriz[p, p] - 2 * sin * cos * matriz[p, q] + sin * sin * matriz[q, q];
                matriz[q, q] = sin * sin * matriz[p, p] + 2 * sin * cos * matriz[p, q] + cos * cos * matriz[q, q];
                matriz[p, q] = matriz[q, p] = 0;

                autovalores[p] = matriz[p, p];
                autovalores[q] = matriz[q, q];
            }

            return autovalores;
        }
    }

}
