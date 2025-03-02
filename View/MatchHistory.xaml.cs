using IS_FootballClub.Model;
using System;
using System.Linq;
using System.Windows;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для MatchHistory.xaml
    /// </summary>
    public partial class MatchHistory : Window
    {
        private int ID;
        FootballClubEntities DB = new FootballClubEntities();
        public MatchHistory(int id)
        {
            InitializeComponent();
            ID = id;
            LoadingHistotyMatch();
        }


        public void LoadingHistotyMatch() // вывод данных при загрузке окна
        {
            var dateOfMatch = DB.Match.Where(i => i.ID_Match == ID).FirstOrDefault();
            var req = DB.MatchResults.Where(i => i.ID_Match == ID).FirstOrDefault();
            if (req != null)
            {
                ResultMatchTB.Text = req.Id_Result;
                EnemyTeamTB.Text = req.EnemyTeam;
                ScoreTB.Text = req.Score.ToString();
                EnemyScoreTB.Text = req.EnemyScore.ToString();
                
                DateMatchTB.Text = dateOfMatch.DateOfMatch.ToString();
                NameMatchTB.Text = dateOfMatch.Name.ToString();

                var homeTeamName = DB.Teams.FirstOrDefault(t => t.ID_Team == req.ID_Team)?.Name;
                TeamTB.Text = homeTeamName.ToString();

            }
        }

        private void BackNavBtn_Click(object sender, RoutedEventArgs e)
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
    }
}
