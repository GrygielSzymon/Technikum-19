namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;

            if (!int.TryParse(textBoxA.Text, out a) || !int.TryParse(textBoxB.Text, out b))
            {
                MessageBox.Show("Nieprawidłowy format danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string wynik = "";

            foreach (var opcja in checkedListBox1.CheckedItems)
            {
                if (opcja.ToString() == "dodawanie")
                {
                    wynik += $"{a}+{b}={a + b}\n";
                }
                if (opcja.ToString() == "odejmowanie")
                {
                    wynik += $"{a}-{b}={a - b}\n";
                }
                if (opcja.ToString() == "mnożenie")
                {
                    wynik += $"{a}*{b}={a * b}\n";
                }
                if (opcja.ToString() == "dzielenie")
                {
                    if (a == 0 || b == 0)
                    {
                        wynik += "Nie można dzielić przez zero";
                    }
                    else
                    {
                        wynik += $"{a}/{b}={a / b}\n";
                    }
                }
            }
            richTextBoxResult.Text = wynik;
        }
    }
}
