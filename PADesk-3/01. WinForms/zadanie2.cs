private void add_Click(object sender, EventArgs e)
{
    int A, B;

    bool sukcesA = int.TryParse(inputA.Text, out A);
    bool sukcesB = int.TryParse(inputB.Text, out B);

    if (sukcesA && sukcesB)
    {
        int suma = A + B;
        result.Text = suma.ToString();
    }
    else
    {
        MessageBox.Show("Proszę wpisać poprawne liczby całkowite.", "Błąd danych", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}

private void odejmij_Click(object sender, EventArgs e)
{
    int A, B;

    bool sukcesA = int.TryParse(inputA.Text, out A);
    bool sukcesB = int.TryParse(inputB.Text, out B);

    if (sukcesA && sukcesB)
    {
        int odejmij = A - B;
        result.Text = odejmij.ToString();
    }
    else
    {
        MessageBox.Show("Proszę wpisać poprawne liczby całkowite.", "Błąd danych", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}

private void razy_Click(object sender, EventArgs e)
{
    int A, B;

    bool sukcesA = int.TryParse(inputA.Text, out A);
    bool sukcesB = int.TryParse(inputB.Text, out B);

    if (sukcesA && sukcesB)
    {
        int razy = A * B;
        result.Text = razy.ToString();
    }
    else
    {
        MessageBox.Show("Proszę wpisać poprawne liczby całkowite.", "Błąd danych", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}

private void podzielic_Click(object sender, EventArgs e)
{
    int A, B;

    bool sukcesA = int.TryParse(inputA.Text, out A);
    bool sukcesB = int.TryParse(inputB.Text, out B);

    if (sukcesA && sukcesB)
    {
        int przez = A / B;
        result.Text = przez.ToString();
    }
    else
    {
        MessageBox.Show("Proszę wpisać poprawne liczby całkowite.", "Błąd danych", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}
