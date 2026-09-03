using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem wybranaOperacja = (ComboBoxItem)comboBoxDzialanie.SelectedItem;
            double a, b;
            if (!double.TryParse(liczba1.Text, out a) || !double.TryParse(liczba2.Text, out b))
            {
                MessageBox.Show("Błąd", "Zły format danych!");
                return;
            }

            switch (wybranaOperacja.Content.ToString())
            {
                case "-":
                    textBlockResult.Text = (a - b).ToString();
                    break;

                case "+":
                    textBlockResult.Text = (a + b).ToString();
                    break;

                case "*":
                    textBlockResult.Text = (a * b).ToString();
                    break;

                case "/":
                    if (b != 0)
                        textBlockResult.Text = (a / b).ToString();
                    else
                        textBlockResult.Text = "Nie można dzielić przez 0";
                    break;
            }
        }

    }
}