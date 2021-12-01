using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NBA_Mikhaylova
{
    /// <summary>
    /// Логика взаимодействия для TeamsVisitorWindow.xaml
    /// </summary>
    public partial class TeamsVisitorWindow : Window
    {
        public TeamsVisitorWindow()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            VisitorMenuWindow visitorMenuWindow = new VisitorMenuWindow();
            this.Hide();
            visitorMenuWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EasternPage());
        }

        private void BtnWestern_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new WesternPage());
            BtnWestern.Background = Brushes.White;
            BtnEastern.Background = Brushes.LightGray;
        }

        private void BtnEastern_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EasternPage());
            BtnEastern.Background = Brushes.White;
            BtnWestern.Background = Brushes.LightGray;
        }
    }
}
