using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace EDSL
{
    /// <summary>
    /// Interaction logic for ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        public class MyGame
        {
            public int Game { get; set; }
            public string Home { get; set; }
            public string HScore { get; set; }
            public string Away { get; set; }
            public string AScore { get; set; }

            public void AddResults(int hGoal, int aGoal)
            {
                HScore = hGoal.ToString();
                AScore = aGoal.ToString();
            }
        }

        public ResultsPage()
        {
            InitializeComponent();
            
        }

        private void seasonBtn_Click(object sender, RoutedEventArgs e)
        {
            SetupPage home = new SetupPage();
            NavigationService.Navigate(home);
        }

        private void resultsBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultsPage results = new ResultsPage();
            NavigationService.Navigate(results);
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            if (divisionCb.Text == "Division A" && roundCb.Text == "Round 1")
            {
                resultsTable.Items.Add(new MyGame { Game = 1, Home = "WANTIRNA-A", HScore = "1", Away = "MOUNT-WAVERLY-A", AScore = "0" });
                resultsTable.Items.Add(new MyGame { Game = 2, Home = "SCORESBY-A", HScore = "1", Away = "MITCHAM-A", AScore = "1" });
                resultsTable.Items.Add(new MyGame { Game = 3, Home = "RINGWOOD-A", HScore = "1", Away = "WONGA PARK-A", AScore = "2" });
                resultsTable.Items.Add(new MyGame { Game = 4, Home = "MOUNT EVERLYN-A", HScore = "0", Away = "LILYDALE-A", AScore = "1" });
                resultsTable.Items.Add(new MyGame { Game = 5, Home = "BELGRAVE-A", HScore = "3", Away = "BEACONSFIELD UPPER-A", AScore = "2" });
                resultsTable.Items.Add(new MyGame { Game = 6, Home = "MURRUMBEENA-A", Away = "FERNTREE GULLY-A" });

                dateTb.Text = "1/12/2018";
            }
            else
            {
                resultsTable.Items.Clear();
            }
        }  

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            var selected = new ArrayList(resultsTable.SelectedItems);
            foreach (var eachItem in selected)
            {
                resultsTable.Items.Remove(eachItem);
            }
            resultsTable.Items.Add(new MyGame { Game = 6, Home = "MURRUMBEENA-A", HScore = homeScoreTb.Text, Away = "FERNTREE GULLY-A", AScore = awayScoreTb.Text });           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(homeScoreTb.Text) && string.IsNullOrEmpty(awayScoreTb.Text))
            {
                var viewLadder = new Ladder();
                viewLadder.Show();
            }
            else
            {
                var upLadder = new UpdatedLadder(int.Parse(homeScoreTb.Text), int.Parse(awayScoreTb.Text));
                upLadder.Show();
            }
            
        }

        

        private void viewLadderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(homeScoreTb.Text) && string.IsNullOrEmpty(awayScoreTb.Text))
            {
                var viewLadder = new Ladder();
                viewLadder.Show();
            }

            else
            {
                var upLadder = new UpdatedLadder(int.Parse(homeScoreTb.Text), int.Parse(awayScoreTb.Text));
                upLadder.Show();
            }         
        }
    }
}
