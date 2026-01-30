using System.Windows;
using System.Windows.Controls;

namespace ChiffreSecret
{
    public partial class MainWindow : Window
    {
        int NumberOfAttempts;
        int NumberToFind;
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            PrepareButtons();
            // Va voir le menu!
        }

        private void PrepareButtons()
        {
            Button button = new Button();
            Random random = new Random();
           
          
            for (int i = 0; i <= 20; i++)
            {
                button = new Button();
                button.Click += OnBtnNumberClick;
                GridButtons.Children.Add(button);
                button.Content = i.ToString();
                button.Width = 40;
                button.Margin = new Thickness((i - 1) * 39, 0, 0, 0);
                button.HorizontalAlignment = HorizontalAlignment.Left;
            }

           

        }
        void OnBtnNumberClick(object sender, RoutedEventArgs e)
        {
            NumberToFind = random.Next(0, 21);
            int numberClicked = int.Parse((string)((Button)sender).Content);

           
            if (numberClicked <= NumberToFind)
            {
                tbHint.Text = "↑";
            }
            else if(numberClicked >= NumberToFind)
            {
                tbHint.Text = "↓";
            }else if(numberClicked == NumberToFind)
            {
                tbHint.Text = "Vous avez le bon nombre!!";
            }
    }
}}