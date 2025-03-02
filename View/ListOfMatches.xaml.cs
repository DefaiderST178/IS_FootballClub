using System.Windows;
using IS_FootballClub.View;
using IS_FootballClub.Model;
using System.Linq;
using System;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для ListOfMatches.xaml
    /// </summary>
    public partial class ListOfMatches : Window
    {
        FootballClubEntities DB = new FootballClubEntities();
        public ListOfMatches()
        {
            InitializeComponent();
            MatchesDG.ItemsSource = DB.Match.ToList();
            MatchCB.ItemsSource = DB.Match.ToList();
        }

        // Выбор матча
        private void SelectMatchBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(MatchCB.Text);
                MatchHistory matchHistory = new MatchHistory(id);
                this.Hide();
                matchHistory.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка - выберите матч перед нажатием на кнопку! " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
