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
        double valor1 = 0;
        double valor2 = 0;
        string operador = "";
        public Form1()
        {
            InitializeComponent();
        }
        //metodo para apilar numero en el textbox 
        private void LeerNumero (string numero)
        {
            if (textBox_Resultado.Text == "0" && textBox_Resultado.Text != null)
            {           
                textBox_Resultado.Text = numero;
            }
            else
            {
                textBox_Resultado.Text += numero;
            }
        }
        // Método que ejecuta la operación matemática según el operador
        private double EjecutaroOperacion(string operador)
        {
            double resultado = 0;
            switch(operador){
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero", "Error");
                        resultado = 0;
                    }
                    break;
                case "^":
                    resultado = Math.Pow(valor1, valor2);
                    break;
            }
            return resultado;
        }

        // Método para calcular el factorial de un número
        private double CalcularFactorial(double numero)
        {
            // El factorial solo funciona con números enteros positivos
            if (numero < 0)
            {
                MessageBox.Show("El factorial no está definido para números negativos", "Error");
                return 0;
            }

            if (numero > 170)
            {
                MessageBox.Show("Número demasiado grande para calcular factorial", "Error");
                return 0;
            }

            // Convertir a entero
            int n = (int)numero;
            double factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            LeerNumero("0");
        }
        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");

        }
        private void btnDos_Click(object sender, EventArgs e)
        {
           LeerNumero("2");

        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }
        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }
        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }
        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }
        private void btnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            valor1 = Convert.ToDouble(textBox_Resultado.Text);
            lblHistorial.Text = textBox_Resultado.Text + " + ";
            textBox_Resultado.Text = "0";
          
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Solo ejecutar si hay un operador seleccionado
            if (operador != "")
            {
                valor2 = Convert.ToDouble(textBox_Resultado.Text);
                lblHistorial.Text += valor2 + " = ";
                double resultado = EjecutaroOperacion(operador);
                textBox_Resultado.Text = Convert.ToString(resultado);

                // Reiniciar valores
                valor1 = 0;
                valor2 = 0;
                operador = "";
            }
        }

        //boton para limpiar la calculadora
        private void btnAC_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text = "0";
            lblHistorial.Text = "";
            valor1 = 0;
            valor2 = 0;
            operador = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            valor1 = Convert.ToDouble(textBox_Resultado.Text);
            lblHistorial.Text = textBox_Resultado.Text + " - ";
            textBox_Resultado.Text = "0";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "x";
            valor1 = Convert.ToDouble(textBox_Resultado.Text);
            lblHistorial.Text = textBox_Resultado.Text + " x ";
            textBox_Resultado.Text = "0";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            valor1 = Convert.ToDouble(textBox_Resultado.Text);
            lblHistorial.Text = textBox_Resultado.Text + " / ";
            textBox_Resultado.Text = "0";
        }

        private void btnFactorial_Click_1(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(textBox_Resultado.Text);
            lblHistorial.Text = textBox_Resultado.Text + "! = ";
            double resultado = CalcularFactorial(numero);
            textBox_Resultado.Text = Convert.ToString(resultado);
            valor1 = 0;
            valor2 = 0;
            operador = "";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            operador = "^";
            valor1 = Convert.ToDouble(textBox_Resultado.Text);
            lblHistorial.Text = textBox_Resultado.Text + " ^ ";
            textBox_Resultado.Text = "0";
        }

        // Botón de punto decimal 
        private void btnPunto_Click(object sender, EventArgs e)
        {
            // Solo agregar el punto si no existe ya en el número actual
            if (!textBox_Resultado.Text.Contains("."))
            {
                textBox_Resultado.Text += ".";
            }
        }
        private void textBox_Resultado_TextChanged(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío si no necesitas hacer nada cuando cambie el texto
        }
    }
}
