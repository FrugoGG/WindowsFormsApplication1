using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {

        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || (isOperationPerformed))
                textBox1_Result.Clear();

            isOperationPerformed = false;

            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox1_Result.Text.Contains("."))

                    textBox1_Result.Text = textBox1_Result + button.Text;

            }
            else
                textBox1_Result.Text = textBox1_Result.Text + button.Text;


        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button13.PerformClick();

                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;

            }
            else
            {



                operationPerformed = button.Text;
                resultValue = double.Parse(textBox1_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
            resultValue = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {//Wykonujemy polecenia tj dzielenie, mnorzenie, dodawanie itd
                case "+": textBox1_Result.Text = (resultValue + double.Parse(textBox1_Result.Text)).ToString(); break;
                case "-": textBox1_Result.Text = (resultValue - double.Parse(textBox1_Result.Text)).ToString(); break;
                case "÷": textBox1_Result.Text = (resultValue / double.Parse(textBox1_Result.Text)).ToString(); break;
                case "✕": textBox1_Result.Text = (resultValue * double.Parse(textBox1_Result.Text)).ToString(); break;
                case "%": textBox1_Result.Text = (resultValue % double.Parse(textBox1_Result.Text)).ToString(); break;
                case "√": textBox1_Result.Text = (resultValue % double.Parse(textBox1_Result.Text)).ToString(); break;
                case "x^2": textBox1_Result.Text = (resultValue % double.Parse(textBox1_Result.Text)).ToString(); break;
                case "1/x": textBox1_Result.Text = (resultValue % double.Parse(textBox1_Result.Text)).ToString(); break;
            
            }

            resultValue = double.Parse(textBox1_Result.Text);
            labelCurrentOperation.Text = "";

        }

        private void button20_DragOver(object sender, DragEventArgs e)
        {

        }

       

        private void button24_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.LightBlue;


        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Azure;
        }

        private void button24_MouseLeave_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.AliceBlue;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int textLength = textBox1_Result.Text.Length;
            if (textLength > 0)
                textBox1_Result.Text = textBox1_Result.Text.Substring(0, textLength - 1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int textLength = textBox1_Result.Text.Length;
            if (textLength > 0)
                if ((textBox1_Result.Text[0]).Equals('-'))

                    textBox1_Result.Text = textBox1_Result.Text.Substring(1, textLength - 1);

                else textBox1_Result.Text = "-" + textBox1_Result.Text;

            else textBox1_Result.Text = "-" + textBox1_Result.Text;
        }

        private void button24_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1_Result.Text += e.KeyChar;
        }
    }
}
//asdkhoaushdouhassd