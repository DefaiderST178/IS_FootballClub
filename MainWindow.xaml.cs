using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using IS_FootballClub.Model;
using IS_FootballClub.View;

namespace IS_FootballClub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FootballClubEntities DB = new FootballClubEntities();
        String Login = ""; 
        String Password = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        // Авторизация
        private void AutorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Login = LogTB.Text;
                Password = PasTB.Password;
                var user = DB.Users.Where(i => i.Login == this.Login && i.Password == Password).FirstOrDefault();
                if (user != null)
                {
                    if (user.Id_Role.ToLower() == "менеджер")
                    {
                        MessageBox.Show("Вы вошли, как " + Login, "Вход успешный", MessageBoxButton.OK, MessageBoxImage.Information);
                        ManagerWindow managerWindow = new ManagerWindow();
                        this.Hide();
                        managerWindow.Show();
                        this.Close();
                    }
                    if (user.Id_Role.ToLower() == "главный тренер")
                    {
                        MessageBox.Show("Вы вошли, как " + Login, "Вход успешный", MessageBoxButton.OK, MessageBoxImage.Information);
                        TrainerWindow trainerWindow = new TrainerWindow();
                        this.Hide();
                        trainerWindow.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные корректно", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
