using System;
using System.Windows;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для TrainerWindow.xaml
    /// </summary>
    public partial class TrainerWindow : Window
    {
        public TrainerWindow()
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
                listOfMatches.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Переход к окну ститистики
        private void StataBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StataWindow stataWindow = new StataWindow();
                stataWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Переход к окну тренеров
        private void TrainersBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        // Переход к окну команд
        private void TeamsBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListCommand listCommand = new ListCommand();
                listCommand.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
