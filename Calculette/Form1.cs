using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette
{
    public partial class Form1 : Form
    {
        double valeur = 0;
        string operateur = "";
        bool operation_click = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((ResultatText.Text == "0") || (operation_click))
                ResultatText.Clear();
            operation_click = false;

            Button chiffre = (Button)sender;
            if (chiffre.Text == ".")
            {
                if (!ResultatText.Text.Contains("."))
                    ResultatText.Text += chiffre.Text;
            }
            else
            {
                ResultatText.Text += chiffre.Text;
            }
        }

        private void operateur_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            valeur = Double.Parse(ResultatText.Text);
            operation_click = true;
            operateur = button.Text;
            ResultatText.Text += button.Text;
        }

        private void Egale_click(object sender, EventArgs e)
        {
            if (operateur == "+")
            {
                ResultatText.Text = (valeur + double.Parse(ResultatText.Text)).ToString();
            }
            else if (operateur == "-")
            {
                ResultatText.Text = (valeur - double.Parse(ResultatText.Text)).ToString();
            }
            else if (operateur == "x")
            {
                ResultatText.Text = (valeur * double.Parse(ResultatText.Text)).ToString();
            }
            else if (operateur == "/")
            {
                ResultatText.Text = (valeur / double.Parse(ResultatText.Text)).ToString();
            }
        }

        private void buttonCE_click(object sender, EventArgs e)
        {
            ResultatText.Text = "0";
        }

        private void buttonC_click(object sender, EventArgs e)
        {
            ResultatText.Text = "0";
            valeur = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (ResultatText.Text.Length > 0)
            {
                ResultatText.Text = ResultatText.Text.Remove(ResultatText.Text.Length - 1, 1);
            }
            if (ResultatText.Text == "")
            {
                ResultatText.Text = "0";
            }
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(ResultatText.Text);
            ResultatText.Text = Convert.ToString(-1 *q);
        }
    }
}
