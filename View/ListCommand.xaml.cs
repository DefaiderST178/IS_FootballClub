using IS_FootballClub.Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для ListCommand.xaml
    /// </summary>
    public partial class ListCommand : Window
    {
        FootballClubEntities DB = new FootballClubEntities();
        public ListCommand()
        {
            InitializeComponent();
            TeamList.ItemsSource = DB.Teams.ToList();
        }

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

        private void TeamList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (TeamList.SelectedItem is Teams selectedTeam)
            {
                var playerIds = DB.TeamPlayers.Where(tp => tp.ID_Team == selectedTeam.ID_Team)
                             .Select(tp => tp.ID_Player)
                             .ToList();

                // Извлекаем данные игроков из таблицы Players по найденным ID_Player
                var players = DB.Players.Where(p => playerIds.Contains(p.ID_Player))
                                        .ToList();

                // Открываем новое окно с игроками
                var playersWindow = new PlayersWindow(players);
                this.Hide();
                playersWindow.Show();
                this.Close();
            }
        }
    }
}
