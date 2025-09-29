private void calculate_Click(object sender, EventArgs e)
{
    double liczba1, liczba2, wynik = 0;
    string dzialanie = comboBox.SelectedItem.ToString();

    try
    {
        liczba1 = double.Parse(textBox1.Text);
        liczba2 = double.Parse(textBox2.Text);

        switch (dzialanie)
        {
            case "+":
                wynik = liczba1 + liczba2;
                break;
            case "-":
                wynik = liczba1 - liczba2;
                break;
            case "*":
                wynik = liczba1 * liczba2;
                break;
            case "/":
                if (liczba2 == 0)
                {
                    result.Text = "Nie można dzielić przez zero";
                    return;
                }
                wynik = liczba1 / liczba2;
                break;
        }

    result.Text = wynik.ToString();
    }
    catch (FormatException)
    {
        MessageBox.Show("Podaj poprawne liczby!", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Wystąpił nieoczekiwany błąd: " + ex.Message);
    }
}
