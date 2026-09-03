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

namespace WpfApp2
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

        private void cmbOblicz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem wybranaOperacja = (ComboBoxItem)cmbOblicz.SelectedItem;
            double a, b;
            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b))
            {
                txtWynik.Text = "Zły format danych!";
            }

            switch (wybranaOperacja.Content.ToString())
            {
                case "Pole":
                    txtWynik.Text = (a * b).ToString();
                    break;

                case "Obwod":
                    txtWynik.Text = ((a + b) * 2).ToString();
                    break;
            }
        }
    }
}