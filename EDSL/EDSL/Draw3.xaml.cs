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
using System.Windows.Shapes;
using static EDSL.draw;

namespace EDSL
{
    /// <summary>
    /// Interaction logic for Draw3.xaml
    /// </summary>
    public partial class Draw3 : Window
    {
        public Draw3()
        {
            InitializeComponent();

            r11.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 3, g3 = 2, g4 = 7, g5 = 8, g6 = 9, g7 = 10 });
            r12.Items.Add(new MyDraw { team = "Away Team", g1 = 4, g2 = 5, g3 = 6, g4 =14 ,  g5 = 13, g6 = 12, g7 =  11});

            r12.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 =2 , g3 = 5, g4 = 6 , g5 =7 , g6 =8 , g7 = 9 });
            r12.Items.Add(new MyDraw { team = "Away Team", g1 = 3, g2 = 4, g3 = 14, g4 = 13,  g5=12 , g6 = 11, g7 =  10});

            r13.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 3, g3 = 4, g4 = 5, g5 = 6, g6 = 7, g7 =  8});
            r13.Items.Add(new MyDraw { team = "Away Team", g1 = 2, g2 = 14, g3 = 13, g4 = 12,  g5= 11, g6 = 10, g7 =  9});

            r14.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 2, g3 = 3, g4 = 4, g5 = 5, g6 = 6, g7 = 7 });
            r14.Items.Add(new MyDraw { team = "Away Team", g1 = 14, g2 = 13, g3 = 12, g4 = 11,  g5= 10, g6 = 9, g7 =  8});

            r15.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 12, g3 = 2, g4 = 3, g5 = 4, g6 = 5, g7 = 6 });
            r15.Items.Add(new MyDraw { team = "Away Team", g1 = 13, g2 = 14, g3 = 11, g4 = 10, g5 = 9, g6 = 8, g7 =  7});

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var draw4 = new Draw4();
            draw4.Show();
            this.Close();
        }
    }
}
