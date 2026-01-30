using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ListeDeNoms
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

        void OnEdtNomKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AddName(edtName.Text);
            }
        }

        void OnBtnAddNameClick(object sender, EventArgs e)
        {
            AddName(edtName.Text);
        }

        // Avoir un message box qui montre le nom
        void AddName(string name)
        {
                var tbNom = new TextBlock();
                tbNom.Margin = new Thickness(30, 0, 0, 0);
                gridNoms.Children.Add(tbNom);
                tbNom.Text = name;
                edtName.Text = "";
        }
    }
}