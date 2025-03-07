using System;
using System.Windows;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
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

        // Переход к окну истории матчей
        private void StoryBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListOfMatches listOfMatches = new ListOfMatches();
                this.Hide();
                listOfMatches.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Переход к окну статистике
        private void StataBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StataWindow stataWindow = new StataWindow();
                this.Hide();
                stataWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Переход к окну добавления игроков
        private void AddPlayerBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        // Переход к окну добавления матча
        private void AddMatchBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
