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
        public Form1()
        {
            InitializeComponent();
        }
        //metodo para apilar numero 
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
        private double EjecutaroOperacion(string operador   )
        {
            double resultado = 0;
            switch(operador){
                case "+":
                    resultado = valor1 + valor2;
                    break;  
            }
            return resultado;
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
            valor1 = Convert.ToDouble(textBox_Resultado.Text);
            lblHistorial.Text = textBox_Resultado.Text + " + ";
            textBox_Resultado.Text = "0";
          
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(textBox_Resultado.Text);
                lblHistorial.Text += valor2 + " = ";
                double resultado = EjecutaroOperacion("+");
                valor1 = 0;
                valor2 = 0;
                textBox_Resultado.Text = Convert.ToString(resultado);
            }
        }
        //boton para limpiar la calculadora
        private void btnAC_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text = "0";
            lblHistorial.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

   
        private void btnRestar_Click(object sender, EventArgs e)
        {

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

        }

        private void btnFactorial_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
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
