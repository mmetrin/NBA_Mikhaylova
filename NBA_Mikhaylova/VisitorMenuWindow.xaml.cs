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
    /// Логика взаимодействия для VisitorMenuWindow.xaml
    /// </summary>
    public partial class VisitorMenuWindow : Window
    {
        public VisitorMenuWindow()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();
        }

        private void BtnTeams_Click(object sender, RoutedEventArgs e)
        {
            TeamsVisitorWindow teamsVisitorWindow = new TeamsVisitorWindow();
            this.Hide();
            teamsVisitorWindow.Show();
        }
    }
}
