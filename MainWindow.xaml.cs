using System;
using System.Windows;
using IS_FootballClub.View;

namespace IS_FootballClub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        // Авторизация
        private void AutorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = "";
                string password = "";

                ManagerWindow open = new ManagerWindow();
                this.Hide();
                open.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Выход
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
