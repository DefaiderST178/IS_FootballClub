using IS_FootballClub.Model;
using System;
using System.Linq;
using System.Windows;

namespace IS_FootballClub.View
{
    /// <summary>
    /// Логика взаимодействия для TrainersInfo.xaml
    /// </summary>
    public partial class TrainersInfo : Window
    {
        FootballClubEntities DB = new FootballClubEntities();
        public TrainersInfo()
        {
            InitializeComponent();
            TrainersList.ItemsSource = DB.Trainers.ToList();
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
