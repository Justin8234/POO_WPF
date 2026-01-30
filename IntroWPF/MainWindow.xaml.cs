using System.Configuration;
using System.Diagnostics.Eventing.Reader;
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

namespace IntroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _isOn = true;
        public MainWindow()
        {
            InitializeComponent();
           

            tbIntro.Text = "Salut le monde!";
            tbIntro.FontSize= 120;
            


            // Ensuite ajouter un bouton pour changer le texte (de type toggle)
        }

        private void OnOnOffClick(object sender, RoutedEventArgs e)
        {
           
            tbIntro.Text = _isOn ? "On" : "Off";
            _isOn = !_isOn;

        }
    }
}