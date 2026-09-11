using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            lblCalc.BackColor = Color.White;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblCalc.Text += "9";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblCalc.Text += " + ";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblCalc.Text += " - ";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblCalc.Text += " × ";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblCalc.Text += " ÷ ";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string strCalc = lblCalc.Text.Replace("÷", "/").Replace("×", "*");

            DataTable tabela = new DataTable();
            try
            {
                var resultado = tabela.Compute(strCalc, "");
                lblCalc.Text = resultado.ToString();
            }
            catch
            {
                lblCalc.ForeColor = Color.Red;
                lblCalc.Text = "ERRO DE SINTAXE";
            }

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblCalc.ForeColor = Color.Black;
            lblCalc.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCalc.Text))
            {
                lblCalc.Text = lblCalc.Text.Remove(lblCalc.Text.Length - 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
