using IS_FootballClub.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Window
    {
        FootballClubEntities DB = new FootballClubEntities();
        public AddPlayer()
        {
            InitializeComponent();
            GroupCB.ItemsSource = DB.Groups.ToList();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // добавить игрока
        private void AddPlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Players players = new Players();
                players.Name = NameTB.Text;
                players.LastName = LastNameTB.Text;

                players.Id_Group = GroupCB.Text;
                players.Id_Role = RoleCB.Text;

                DateTime? selectedDate = DateBirthTB.SelectedDate;
                players.DateOfBirth = selectedDate.Value;

                DateTime thisDay = DateTime.Today;
                players.JoinDate = thisDay;
                // два нуля пока не прошел отборы в команду
                players.PlayerNumber = 00; 

                DB.Players.Add(players);
                DB.SaveChanges();
                MessageBox.Show("Игрок успешно добавлен ", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
