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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
            InicializarMatriz((int)numSize.Value);
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            // Asegurarse de actualizar la matriz cuando cambie el tamaño
            InicializarMatriz((int)numSize.Value);
        }

        private void InicializarMatriz(int n)
        {
            // Configura el DataGridView con las filas y columnas correctas
            dgvSistema.ColumnCount = n + 1; // n columnas de incógnitas y una para el resultado
            dgvSistema.RowCount = n; // n filas para las ecuaciones

            // Asigna encabezados a las columnas
            for (int j = 0; j < n; j++)
            {
                dgvSistema.Columns[j].HeaderText = $"x{j + 1}";
            }
            dgvSistema.Columns[n].HeaderText = "Resultado"; // La última columna es para el resultado

            // Inicializa todas las celdas con el valor "0"
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    dgvSistema.Rows[i].Cells[j].Value = "0";
                }
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            int n = dgvSistema.RowCount;
            double[,] sistema = new double[n, n + 1]; // Matriz que contiene las ecuaciones y resultados

            // Leer los datos del DataGridView
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)  // Asegurarse de no acceder fuera de rango
                {
                    // Verificar si la celda contiene un valor válido
                    var cellValue = dgvSistema.Rows[i].Cells[j].Value;

                    if (cellValue != null)
                    {
                        // Intentamos convertir el valor a double
                        if (!double.TryParse(cellValue.ToString(), out sistema[i, j]))
                        {
                            MessageBox.Show($"Ingrese un valor numérico válido en la celda ({i + 1},{j + 1}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;  // Si no se puede convertir, salimos del método
                        }
                    }
                    else
                    {
                        MessageBox.Show($"La celda ({i + 1},{j + 1}) está vacía. Ingrese un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;  // Si la celda está vacía, salimos del método
                    }
                }
            }

            // Resolver el sistema
            double[] solucion = ResolverSistema(sistema);

            // Mostrar la solución
            if (solucion != null)
            {
                txtResultado.Text = "Solución del sistema:\r\n";
                for (int i = 0; i < solucion.Length; i++)
                {
                    txtResultado.AppendText($"x{i + 1} = {solucion[i]:F4}\r\n");
                }
            }
            else
            {
                txtResultado.Text = "El sistema no tiene solución única o tiene infinitas soluciones.";
            }
        }

        public double[] ResolverSistema(double[,] sistema)
        {
            int n = sistema.GetLength(0); // Número de ecuaciones

            // Aplicar eliminación de Gauss
            for (int i = 0; i < n; i++)
            {
                // Asegurarse de que el pivote no sea cero
                if (sistema[i, i] == 0)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (sistema[j, i] != 0)
                        {
                            // Intercambiar filas
                            for (int k = 0; k <= n; k++)
                            {
                                double temp = sistema[i, k];
                                sistema[i, k] = sistema[j, k];
                                sistema[j, k] = temp;
                            }
                            break;
                        }
                    }
                }

                // Eliminar los elementos debajo del pivote
                for (int j = i + 1; j < n; j++)
                {
                    double factor = sistema[j, i] / sistema[i, i];
                    for (int k = i; k <= n; k++)
                    {
                        sistema[j, k] -= factor * sistema[i, k];
                    }
                }
            }

            // Sustitución hacia atrás
            double[] solucion = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double suma = sistema[i, n];
                for (int j = i + 1; j < n; j++)
                {
                    suma -= sistema[i, j] * solucion[j];
                }
                solucion[i] = suma / sistema[i, i];
            }

            return solucion;
        }
    }


}
