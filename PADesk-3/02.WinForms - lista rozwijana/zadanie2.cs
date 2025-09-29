private void ComboBoxOperation(object sender, EventArgs e)
{
    if (comboBox.SelectedIndex == 0)
    {
        result.Text = "";
        return;
    }

    if (!double.TryParse(textBoxA.Text, out double a) || a <= 0)
    {
        result.Text = "Podaj poprawną liczbę (a > 0)";
        return;
    }

    if (!double.TryParse(textBoxB.Text, out double b) || b <= 0)
    {
        result.Text = "Podaj poprawną liczbę (b > 0)";
        return;
    }

    if (comboBox.SelectedItem.ToString() == "Pole")
    {
        double pole = a * b;
        result.Text = $"Pole prostokąta: {pole:F2}";
    }
    else if (comboBox.SelectedItem.ToString() == "Obwód")
    {
        double obwod = 2 * (a + b);
        result.Text = $"Obwód prostokąta: {obwod:F2}";
    }
}
