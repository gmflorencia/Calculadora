using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_69
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            int Resultado = int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text);
            lblresultado.Text = Resultado.ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            int Resultado = int.Parse(txtnum1.Text) - int.Parse(txtnum2.Text);
            lblresultado.Text = Resultado.ToString();

        }

        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            int Resultado = int.Parse(txtnum1.Text) * int.Parse(txtnum2.Text);
            lblresultado.Text = Resultado.ToString();

        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            int Resultado = int.Parse(txtnum1.Text) / int.Parse(txtnum2.Text);
            lblresultado.Text = Resultado.ToString();

        }
        private void txtnum1_KeyPress(object sender, KeyPressEventArgs e) // sirve para bloquear el ingreso de datos que no son numeros
        {  
                
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
           e.Handled = true; //bloquea si el caracter ingresado no es numero
        }
            

        }

        private void txtnum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //bloquea si el caracter ingresado no es numero
            }


        }
    }
    
}
