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
using System.Windows.Shapes;
using static EDSL.ResultsPage;

namespace EDSL
{
    /// <summary>
    /// Interaction logic for AddResults.xaml
    /// </summary>
    public partial class AddResults : Window
    { 
        public AddResults(IList game)
        {
            InitializeComponent();
            var newGame = game;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Check != null)
            {
                Check(int.Parse(HomeTb.Text));
            }
        }

        public event Action<int> Check;
    }
}
