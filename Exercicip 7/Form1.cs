using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Exercicip_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(Interaction.InputBox("Insira o primeiro numero", "Inserir", "Inserir um número inteiro"));
            int Num2 = Convert.ToInt32(Interaction.InputBox("Insira o segundo numero", "Inserir", "Inserir um número inteiro"));
            int Result = 0;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Result = Num2 + Num1;
                    break;
                case 1:
                    Result = Num2 - Num1;
                    break;
                case 2:
                    Result = Num2 * Num1;
                    break;
                case 3:
                    Result = Num2 / Num1;
                    break;
            }
            textBox1.Text = ("O resultado da conta é: " + Result);
            if (comboBox1.Text == "")
            {
                textBox1.Text = ("Defina o tipo de operação");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}