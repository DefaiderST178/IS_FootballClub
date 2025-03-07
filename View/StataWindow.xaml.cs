using IS_FootballClub.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для StataWindow.xaml
    /// </summary>
    public partial class StataWindow : Window
    {
        FootballClubEntities DB = new FootballClubEntities();
        public StataWindow()
        {
            InitializeComponent();
            LoadTeams();
        }

        // загрузка футбольных команд в список
        private void LoadTeams()
        {
            lstTeams.ItemsSource = DB.Teams.ToList();
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

        // Вывод после выбора
        private void lstTeams_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstTeams.SelectedItem is Teams selectedTeam)
            {
                var teamResults = DB.MatchResults.Where(r => r.ID_Team == selectedTeam.ID_Team);

                txtWins.Text = $"Победы: {teamResults.Count(r => r.Id_Result == "Победа")}";
                txtDraws.Text = $"Ничьи: {teamResults.Count(r => r.Id_Result == "Ничья")}";
                txtLosses.Text = $"Поражения: {teamResults.Count(r => r.Id_Result == "Поражение")}";
            }
        }
    }
}
