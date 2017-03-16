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
    public partial class Calculadora : Form
    {

        public Calculadora()
        {
            InitializeComponent();
        }

        bool validar = false;

        String operador = "" ; 

        Double x = 0;

        private void btmNum_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "0") || (validar))
                txt.Clear();

            Button bt = (Button)sender;
            txt.Text = txt.Text + bt.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt.Text = "";
        }

        private void operador_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            operador = bt.Text;
            x = Double.Parse(txt.Text);
            validar = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":
                    txt.Text = (x + Double.Parse(txt.Text)).ToString();
                    break;
                case "-":
                    txt.Text = (x - Double.Parse(txt.Text)).ToString();
                    break;
                case "*":
                    txt.Text = (x * Double.Parse(txt.Text)).ToString();
                    break;
                case "/":
                    txt.Text = (x / Double.Parse(txt.Text)).ToString();
                    break;
                default:
                    break;
            }
            validar = false;
        }
    }
}
