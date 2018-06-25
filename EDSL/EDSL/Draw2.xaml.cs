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
    /// Interaction logic for Draw2.xaml
    /// </summary>
    public partial class Draw2 : Window
    {
        public Draw2()
        {
            InitializeComponent();

            r6.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 8, g3 = 7, g4 = 6, g5 = 5, g6 =4, g7 = 2});
            r6.Items.Add(new MyDraw { team = "Away Team", g1 = 9, g2 = 10, g3 = 11, g4 = 12, g5 = 13, g6 =14, g7 = 3});

            r7.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 7, g3 = 6, g4 = 5, g5 = 4, g6 =3, g7 = 2});
            r7.Items.Add(new MyDraw { team = "Away Team", g1 = 8, g2 = 9, g3 = 10, g4 = 11, g5 = 12, g6 =13, g7 = 14});

            r8.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 6, g3 = 5, g4 = 4, g5 = 3, g6 = 2, g7 = 13});
            r8.Items.Add(new MyDraw { team = "Away Team", g1 = 7, g2 =8 , g3 = 9, g4 = 10, g5 = 11, g6 =12, g7 = 14});

            r9.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 5, g3 = 4, g4 = 3, g5 = 2, g6 =11, g7 = 12});
            r9.Items.Add(new MyDraw { team = "Away Team", g1 = 6, g2 = 7, g3 = 8, g4 = 9, g5 = 10, g6 =14, g7 = 13});

            r10.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 4, g3 = 3, g4 = 2, g5 = 9, g6 =10, g7 = 11});
            r10.Items.Add(new MyDraw { team = "Away Team", g1 = 5, g2 = 6, g3 = 7, g4 = 8, g5 = 14, g6 =13, g7 = 12});
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var draw3 = new Draw3();
            draw3.Show();
            this.Close();
        }
    }
}
