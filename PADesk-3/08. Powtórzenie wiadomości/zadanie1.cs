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
            string wynik = "Wybrane usługi:\n";
            double cena = 0;
            int i = 1;

            foreach (var opcja in checkedListBox1.CheckedItems)
            {
                if (opcja.ToString() == "Wymiana oleju")
                {
                    wynik += $"{i}. Wymiana oleju\n";
                    cena += 300;
                }
                if (opcja.ToString() == "Zmiana opon")
                {
                    wynik += $"{i}. Zmiana opon\n";
                    cena += 100;
                }
                if (opcja.ToString() == "Wymiana klocków hamulcowych")
                {
                    wynik += $"{i}. Wymiana klocków hamulcowych\n";
                    cena += 400;
                }
                if (opcja.ToString() == "Sprawdzenie klimatyzacji")
                {
                    wynik += $"{i}. Sprawdzenie klimatyzacji\n";
                    cena += 120;
                }
                if (opcja.ToString() == "Diagnostyka komputerowa")
                {
                    wynik += $"{i}. Diagnostyka komputerowa\n";
                    cena += 90;
                }

                i++;
            }
            wynik += $"Łączny koszt usług: {cena}zł;
            richTextBox1.Text = wynik;
        }
    }
}
