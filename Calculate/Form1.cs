using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        double Numero1;
        double Numero2;
        string Operacion;
        public Form1()
        {
            InitializeComponent();
        }
        ClassSumar obj = new  ClassSumar();
        ClassRestar obj2 = new ClassRestar();
        ClassMultiplicar obj3 = new ClassMultiplicar();
        ClassDividir obj4 = new ClassDividir();
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Operacion = "/";
            Numero1  = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Operacion = "*";
            Numero1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            Operacion = "+";
            Numero1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            Operacion = "-";
            Numero1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            Numero2 = double.Parse(textBox1.Text);

            double Suma;
            double Resta;
            double Multiplicacion;
            double Division;

            switch (Operacion)
            {
                case "+":
                    Suma = obj.Suma((Numero1), (Numero2));
                    textBox1.Text = Suma.ToString();
                    break;
                case "-":
                    Resta = obj2.Resta((Numero1), (Numero2));
                    textBox1.Text = Resta.ToString();
                    break;
                case "*":
                    Multiplicacion = obj3.Multi((Numero1), (Numero2));
                    textBox1.Text = Multiplicacion.ToString();
                    break;
                case "/":
                    Division = obj4.Division((Numero1), (Numero2));
                    textBox1.Text = Division.ToString();
                    break;
            }
        }
    }
}
