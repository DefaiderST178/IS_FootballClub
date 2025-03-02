using IS_FootballClub.Model;
using System.Linq;
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
            TeamCB.ItemsSource = DB.Teams.ToList();
        }

        private void SelectTeamBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
