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

namespace EDSL
{
    /// <summary>
    /// Interaction logic for Draw.xaml
    /// </summary>
    public partial class draw : Window
    {
        public class MyDraw
        {
            public string team { get; set; }
            public int g1 { get; set; }
            public int g2 { get; set; }
            public int g3 { get; set; }
            public int g4 { get; set; }
            public int g5 { get; set; }
            public int g6 { get; set; }
            public int g7 { get; set; }
        }
        public draw()
        {
            InitializeComponent();

            r1.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 2, g3 = 3, g4 = 4, g5 = 5, g6 =6, g7 = 7});
            r1.Items.Add(new MyDraw { team = "Away Team", g1 = 14, g2 = 13, g3 = 12, g4 = 11, g5 = 10, g6 =9, g7 = 8});

            r2.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 12, g3 = 2, g4 = 3, g5 = 4, g6 =5, g7 = 6});
            r2.Items.Add(new MyDraw { team = "Away Team", g1 = 13, g2 = 14, g3 = 11, g4 = 10, g5 = 9, g6 =8, g7 = 7});

            r3.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 11, g3 = 10, g4 = 3, g5 = 3, g6 =4, g7 = 5});
            r3.Items.Add(new MyDraw { team = "Away Team", g1 = 12, g2 = 13, g3 = 14, g4 = 9, g5 = 8, g6 =7, g7 = 6});

            r4.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 10, g3 = 9, g4 = 8, g5 = 2, g6 =3, g7 = 4});
            r4.Items.Add(new MyDraw { team = "Away Team", g1 = 11, g2 = 12, g3 = 13, g4 = 14, g5 = 7, g6 =6, g7 = 5});

            r5.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 9, g3 = 8, g4 = 7, g5 = 6, g6 =2, g7 = 3});
            r5.Items.Add(new MyDraw { team = "Away Team", g1 = 10, g2 = 11, g3 = 12, g4 = 13, g5 = 14, g6 =5, g7 =4 });

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var draw2 = new Draw2();
            draw2.Show();
            this.Close();
        }
    }
}
