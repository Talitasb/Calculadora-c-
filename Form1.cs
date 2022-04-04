using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = Convert.ToInt16(textbox1.Text);
            num2 = Convert.ToInt16(textbox2.Text);
            resultado = num1 + num2;
            lbResultado.Text = Convert.ToString(resultado);

            MessageBox.Show("O valor é : " + Convert.ToString(resultado));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Valor1_Click(object sender, EventArgs e)
        {

        }
    }
}
