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
            wynik += "Długość boku a:" + a + "\n";
            wynik += "Długość boku b:" + b + "\n";


            foreach (var opcja in checkedListBox1.CheckedItems)
            {
                if (opcja.ToString() == "Pole")
                {
                    wynik += $"{a} * {b} = {a * b}\n";
                }
                if (opcja.ToString() == "Obwód")
                {
                    wynik += $"2 * {a} + 2 * {b} = {2 * a + 2 * b}\n";
                }
            }
            richTextBoxResult.Text = wynik;
        }
    }
}
