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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Oculta Form1
            

            // Abre 
            Ejercicio1 form1 = new Ejercicio1();
            form1.ShowDialog();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abre 
            Ejercicio2 form1 = new Ejercicio2();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Abre 
            Ejercicio3 form1 = new Ejercicio3();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Abre 
            Ejercicio4 form1 = new Ejercicio4();
            form1.ShowDialog();
        }
    }
}
