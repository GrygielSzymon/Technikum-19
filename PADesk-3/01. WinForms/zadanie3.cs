private void calculate_Click(object sender, EventArgs e)
{
    int A, B;

    bool sukcesA = int.TryParse(inputA.Text, out A);
    bool sukcesB = int.TryParse(inputB.Text, out B);

    if (!sukcesA)
    {
        errorA.Text = "Proszę wpisać poprawne liczby całkowite.";
    }
    if (!sukcesB)
    {
        errorB.Text = "Proszę wpisać poprawne liczby całkowite.";
    }
    else
    {
        int suma = A + B;
        int ruznica = A - B;
        int iloczyn = A * B;
        int iloraz = A / B;
        resultS.Text = suma.ToString();
        resultR.Text = ruznica.ToString();
        resultI.Text = iloczyn.ToString();
        resultIl.Text = iloraz.ToString();
    }
    

}
