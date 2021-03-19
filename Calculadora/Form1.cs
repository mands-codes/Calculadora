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

        public string ValorAtual { get; set; } = "";
        public int Resultado { get; set; } = 0;

        public decimal ValorHistorico { get; set; } = 0;
        public string OperaçãoSelecionada { get; private set; }

   
        public Form1()
        {
            InitializeComponent();
        }


        private void boxNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.NumPad1:
                case Keys.NumPad2:
                case Keys.NumPad3:
                case Keys.NumPad4:
                case Keys.NumPad5:
                case Keys.NumPad6:
                case Keys.NumPad7:
                case Keys.NumPad8:
                case Keys.NumPad9:
                    var valorSelecionado = e.KeyCode.ToString().Replace("NumPad", "");
                    AcrescentaDígito(valorSelecionado);
                    break;
                case Keys.Oemcomma:
                    AcrescentaDígito(",");
                    break;
                case Keys.Add:
                    SelecionarOperação("+");
                    break;
                case Keys.Subtract:
                    SelecionarOperação("-");
                    break;
                case Keys.Divide:
                    SelecionarOperação("÷");
                    break;
                case Keys.Multiply:
                    SelecionarOperação("×");
                    break;
                case Keys.Oemplus:
                    if (e.Shift)//e.Alt//e.Control, etc
                    {
                        SelecionarOperação("+");
                    }
                    else
                    {
                        ResultadoCalculo();
                    }
                    break;
                case Keys.Back:
                    DeletaDigito();
                    break;
                case Keys.Enter:
                    ResultadoCalculo();
                    break;
            }
        }


        private void AcrescentaDígito(string valorSelecionado)
        {
            if (valorSelecionado == "," && ValorAtual.Contains(","))
            {
                return;
            }

            if (ValorAtual == "" && valorSelecionado == ",")
            {
                ValorAtual = "0";
            }

            ValorAtual = (ValorAtual) + valorSelecionado;
            textBoxValorAtual.Text = ValorAtual;
        }


        private void SelecionarOperação(string operação)
        {
            OperaçãoSelecionada = operação;
            //caso ele nao tenha um valor atual
            if (ValorAtual != "")
            {
                ValorHistorico = decimal.Parse(ValorAtual);

            }
            // se não tiver um valor atual, ele reaproveita o valor historico
            ValorAtual = "";

            textBoxHistorico.Text = ValorHistorico + " " + OperaçãoSelecionada + " ";
        }


        private void ResultadoCalculo()
        {
            decimal Resultado = 0;

            switch (OperaçãoSelecionada)
            {
                case "+":
                    Resultado = ValorHistorico + decimal.Parse(ValorAtual);
                    break;
                case "-":
                    Resultado = ValorHistorico - decimal.Parse(ValorAtual);
                    break;
                case "×":
                    Resultado = ValorHistorico * decimal.Parse(ValorAtual);
                    break;
                case "÷":
                    Resultado = ValorHistorico / decimal.Parse(ValorAtual);
                    break;
               // case "sqrt":
                    //var valor = decimal.Parse(ValorAtual);
                  //  Resultado = (decimal) Math.Sqrt((double) valor); 
                  //  break;
            }

            ValorHistorico = Resultado;
            ValorAtual = "";
            // passar os valores para o visor
            textBoxValorAtual.Text = Resultado.ToString();
            textBoxHistorico.Text = "";
        }
        private void DeletaDigito()
        {
            string visor = textBoxValorAtual.Text;
            if (visor.Length > 0)
            {
                visor = visor.Remove(visor.Length - 1);
                ValorAtual = visor;
                textBoxValorAtual.Text = ValorAtual.ToString();

                if (visor.Length == 0)
                {
                    textBoxValorAtual.Text = "0";
                }
            }
        }
        private void Limpar()
        {
            ValorAtual = "";
            ValorHistorico = 0;
            textBoxHistorico.Text = "";
            textBoxValorAtual.Text = "0";
        }

        private void buttonDig_Click(object sender, EventArgs e)
        {
            //informando que o sender é um botao(casting)
            var botão = (Button)sender;

            AcrescentaDígito(botão.Tag.ToString());
        }


        private void buttonEscolherOperação(object sender, EventArgs e)
        {
            var escolha = (Button)sender;
            var operação = escolha.Tag.ToString();

            SelecionarOperação(operação);
        }

        private void buttonDeletaDigito_Click(object sender, EventArgs e)
        {
            DeletaDigito();
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            ResultadoCalculo();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void buttonRaizQuadrada_Click(object sender, EventArgs e)
        {
            decimal Resultado = 0;
            var valor = decimal.Parse(ValorAtual);
            Resultado = (decimal)Math.Sqrt((double)valor);

            ValorHistorico = Resultado;
            // passar os valores para o visor
            textBoxValorAtual.Text = Resultado.ToString();
            textBoxHistorico.Text = "√(" + ValorAtual + ")";
            ValorAtual = "";
        }
    }
}

