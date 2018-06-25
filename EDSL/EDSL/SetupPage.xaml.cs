using System;
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
    /// Interaction logic for SetupPage.xaml
    /// </summary>
    public partial class SetupPage : Page
    {
        public SetupPage()
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

        private void selectDateBtn_Click(object sender, RoutedEventArgs e)
        {          
                var startDate = Convert.ToDateTime(startDatePicker.Text);
                var endDate = startDate.AddDays(20*7);
                endDateTb.Text = endDate.ToShortDateString();          
        }

        private void createDrawBtn_Click(object sender, RoutedEventArgs e)
        {
            var createDraw = new draw();
            createDraw.Show();
            
        }

        private void viewDrawBtn_Click(object sender, RoutedEventArgs e)
        {
            var createDraw = new draw();
            createDraw.Show();

        }
    }
}
