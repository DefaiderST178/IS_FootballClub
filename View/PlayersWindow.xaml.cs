using IS_FootballClub.Model;
using System;
using System.Collections.Generic;
using System.Windows;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для PlayersWindow.xaml
    /// </summary>
    public partial class PlayersWindow : Window
    {
        private int ID;
        FootballClubEntities DB = new FootballClubEntities();

        public PlayersWindow(List<Players> players)
        {
            InitializeComponent();
            lvPlayers.ItemsSource = players;
        }


        // Выход
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListCommand listCommand = new ListCommand();
                this.Hide();
                listCommand.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
