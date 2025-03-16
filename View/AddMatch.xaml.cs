using System;
using System.Windows;
using IS_FootballClub.Model;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для AddMatch.xaml
    /// </summary>
    public partial class AddMatch : Window
    {
        FootballClubEntities DB = new FootballClubEntities();
        public AddMatch()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // добавление матча
        private void AddMatchBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Match match = new Match();
                match.Name = MatchNameTB.Text;
                match.Location = StadionTB.Text;
                DateTime? selectedDate = DatePickTB.SelectedDate;
                match.DateOfMatch = selectedDate.Value;
                DB.Match.Add(match);
                DB.SaveChanges();
                MessageBox.Show("Матч успешно добавлен ", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
