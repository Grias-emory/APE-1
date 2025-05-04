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
    public partial class Ejercicio1 : Form
    {
        private int[,] matrizA;
        private int[,] matrizB;
        private int[,] matrizResultado;
        private int size;

        public Ejercicio1()
        {
            InitializeComponent();
        }

        // Generar matrices aleatorias
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                size = (int)numSize.Value;
                if (size < 1) throw new Exception("El tamaño debe ser mayor a 0.");

                matrizA = new int[size, size];
                matrizB = new int[size, size];
                matrizResultado = new int[size, size];

                LlenarMatrizAleatoria(matrizA);
                LlenarMatrizAleatoria(matrizB);

                MostrarMatriz(dgvMatrizA, matrizA);
                MostrarMatriz(dgvMatrizB, matrizB);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Multiplicar matrices con paralelismo
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizA == null || matrizB == null)
                    throw new Exception("Debe generar las matrices primero.");

                matrizResultado = MultiplicarMatrices(matrizA, matrizB);
                MostrarMatriz(dgvResultado, matrizResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método para llenar una matriz con números aleatorios
        private void LlenarMatrizAleatoria(int[,] matriz)
        {
            Random rand = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 10); // Números aleatorios entre 1 y 9
                }
            }
        }

        // Método para mostrar una matriz en un DataGridView
        private void MostrarMatriz(DataGridView dgv, int[,] matriz)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int size = matriz.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                dgv.Columns.Add("Col" + i, "");
            }

            for (int i = 0; i < size; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int j = 0; j < size; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = matriz[i, j] });
                }
                dgv.Rows.Add(row);
            }
        }

        // Método para multiplicar matrices con paralelismo
        private int[,] MultiplicarMatrices(int[,] matrizA, int[,] matrizB)
        {
            int size = matrizA.GetLength(0);
            int[,] resultado = new int[size, size];

            Parallel.For(0, size, i =>
            {
                for (int j = 0; j < size; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < size; k++)
                    {
                        suma += matrizA[i, k] * matrizB[k, j];
                    }
                    resultado[i, j] = suma;
                }
            });

            return resultado;
        }

        // Botón para limpiar las matrices
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvMatrizA.Rows.Clear();
            dgvMatrizB.Rows.Clear();
            dgvResultado.Rows.Clear();
        }
    }

}
