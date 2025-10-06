namespace zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double number1, number2, result = 0;

            if (!double.TryParse(textBox1.Text, out number1) || !double.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Podaj poprawne liczby zmiennoprzecinkowe.", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButtonAdd.Checked)
            {
                result = number1 + number2;
            }
            else if (radioButtonSubtract.Checked)
            {
                result = number1 - number2;
            }
            else if (radioButtonMultiply.Checked)
            {
                result = number1 * number2;
            }
            else if (radioButtonDivide.Checked)
            {
                if (number2 == 0)
                {
                    textBoxResult.Text = "Nie można dzielić przez zero";
                    return;
                }
                else
                {
                    result = number1 / number2;
                }
            }
            else
            {
                MessageBox.Show("Wybierz działanie matematyczne.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxResult.Text = result.ToString();
        }
    }
}
