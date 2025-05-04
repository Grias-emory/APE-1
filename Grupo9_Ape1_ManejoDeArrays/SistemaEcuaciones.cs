using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo9_Ape1_ManejoDeArrays
{
    public class SistemaEcuaciones
    {
        private double[,] matriz; // Matriz aumentada del sistema de ecuaciones
        private int n; // Número de ecuaciones (y también el número de incógnitas)

        public SistemaEcuaciones(double[,] sistema)
        {
            this.matriz = sistema;
            this.n = sistema.GetLength(0); // Número de filas es el número de ecuaciones
        }

        // Método que realiza la eliminación de Gauss
        public bool EliminacionGaussiana()
        {
            for (int i = 0; i < n; i++)
            {
                // Encontrar el máximo en la columna i
                int filaMax = BuscarFilaMaxima(i);
                if (filaMax != i)
                {
                    // Intercambiar filas si es necesario
                    IntercambiarFilas(i, filaMax);
                }

                // Si el valor de la diagonal es cero, el sistema no tiene solución única
                if (Math.Abs(matriz[i, i]) < 1e-10)
                {
                    return false; // No tiene solución única (puede tener infinitas soluciones o ninguna)
                }

                // Hacer ceros debajo de la diagonal
                for (int j = i + 1; j < n; j++)
                {
                    double factor = matriz[j, i] / matriz[i, i];
                    for (int k = i; k <= n; k++)
                    {
                        matriz[j, k] -= factor * matriz[i, k];
                    }
                }
            }

            return true; // La matriz ha sido llevada a una forma escalonada
        }

        // Método para resolver el sistema usando sustitución hacia atrás
        public double[] ResolverSistema(double[,] sistema)
        {
            int n = sistema.GetLength(0); // Número de ecuaciones (filas)

            // Aplicar eliminación de Gauss para convertir la matriz en una forma escalonada
            for (int i = 0; i < n; i++)
            {
                // Buscar el pivote en la columna i
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

                // Hacer ceros en las filas debajo del pivote
                for (int j = i + 1; j < n; j++)
                {
                    double factor = sistema[j, i] / sistema[i, i];
                    for (int k = i; k <= n; k++)
                    {
                        sistema[j, k] -= factor * sistema[i, k];
                    }
                }
            }

            // Ahora resolver las incógnitas por sustitución hacia atrás
            double[] solucion = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double suma = sistema[i, n]; // La columna de resultados
                for (int j = i + 1; j < n; j++)
                {
                    suma -= sistema[i, j] * solucion[j];
                }
                solucion[i] = suma / sistema[i, i];
            }

            return solucion;
        }

        // Buscar la fila con el valor máximo en la columna i para mejorar la estabilidad numérica
        private int BuscarFilaMaxima(int col)
        {
            int filaMax = col;
            for (int i = col + 1; i < n; i++)
            {
                if (Math.Abs(matriz[i, col]) > Math.Abs(matriz[filaMax, col]))
                {
                    filaMax = i;
                }
            }
            return filaMax;
        }

        // Intercambiar dos filas en la matriz
        private void IntercambiarFilas(int fila1, int fila2)
        {
            for (int i = 0; i <= n; i++)
            {
                double temp = matriz[fila1, i];
                matriz[fila1, i] = matriz[fila2, i];
                matriz[fila2, i] = temp;
            }
        }

        // Método para verificar si el sistema tiene solución única
        public bool TieneSolucionUnica()
        {
            // Intentamos hacer la eliminación de Gauss y ver si falla (lo que indicaría infinitas soluciones o ninguna)
            return EliminacionGaussiana();
        }

        // Método que devuelve el sistema en formato de texto para mostrarlo
        public string ObtenerSistemaComoTexto()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(matriz[i, j].ToString("F2") + " ");
                }
                sb.Append("| " + matriz[i, n].ToString("F2"));
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
