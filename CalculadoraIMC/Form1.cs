using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso;
            double altura;
            double resultado = 0;


            // Validação e conversão do peso
            if (!double.TryParse(txbPeso.Text, out peso) || peso <= 0)
            {
                MessageBox.Show("Digite um peso válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação e conversão da altura
            if (!double.TryParse(txbAltura.Text, out altura) || altura <= 0)
            {
                MessageBox.Show("Digite uma altura válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cálculo do IMC
            resultado = peso / (altura * altura);

            // Exibir resultado no textbox
            txbIMC.Text = resultado.ToString("F2");// Formata para 2 casas decimais

            if (resultado < 18.5)
            {
                lblCondicao.Text = "Abaixo do Peso";
            }
            else if (resultado <= 24.9)
            {
                lblCondicao.Text = "Peso Ideal (PARABÉNS)";
            }
            else if (resultado <= 29.9)
            {
                lblCondicao.Text = "Levemente Acima do Peso";
            }
            else if (resultado <= 34.9)
            {
                lblCondicao.Text = "Obesidade grau 1";
            }
            else if (resultado <= 39.9)
            {
                lblCondicao.Text = "Obesidade grau 2 (Severa)";
            }
            else if (resultado >= 40)
            {
                lblCondicao.Text = "Obesidade 3 (Mórbida)";
            }
        }
        



    }
}
