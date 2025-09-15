int A, B;

bool sukcesA = int.TryParse(textBoxA.Text, out A);
bool sukcesB = int.TryParse(textBoxB.Text, out B);

if (sukcesA && sukcesB)
{
    int suma = A + B;
    int ruznica = A - B;
    int iloczyn = A * B;
    int iloraz = A / B;
    textBoxS.Text = suma.ToString();
    textBoxR.Text = ruznica.ToString();
    textBoxI.Text = iloczyn.ToString();
    textBoxIL.Text = iloraz.ToString();

}
else
{
    MessageBox.Show("Proszę wpisać poprawne liczby całkowite.", "Błąd danych", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
}
