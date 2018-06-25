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
    /// Interaction logic for Draw4.xaml
    /// </summary>
    public partial class Draw4 : Window
    {
        public Draw4()
        {
            InitializeComponent();
            r16.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 12, g3 = 2, g4 = 3, g5 = 4, g6 = 5, g7 = 6});
            r16.Items.Add(new MyDraw { team = "Away Team", g1 = 13, g2 = 14, g3 = 11, g4 =10, g5 =9 , g6 = 8, g7 =  7});

            r17.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 10, g3 = 9, g4 = 8, g5 = 2, g6 = 3, g7 = 4});
            r17.Items.Add(new MyDraw { team = "Away Team", g1 = 11, g2 = 12, g3 = 13, g4 =14, g5 = 7, g6 = 6, g7 =  5});

            r18.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 =9 , g3 = 8, g4 = 7, g5 = 6, g6 = 2, g7 = 3});
            r18.Items.Add(new MyDraw { team = "Away Team", g1 = 10, g2 = 11, g3 = 12, g4 =13, g5 = 14, g6 =5, g7 =  4});
            
            r19.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 8, g3 = 7, g4 = 6, g5 = 5, g6 = 4, g7 = 2});
            r19.Items.Add(new MyDraw { team = "Away Team", g1 = 9, g2 = 10, g3 = 11, g4 =12, g5 = 13, g6 = 14, g7 =  3});

            r20.Items.Add(new MyDraw { team = "Home Team vs", g1 = 1, g2 = 7, g3 = 6, g4 = 5, g5 = 4, g6 = 3, g7 = 2});
            r20.Items.Add(new MyDraw { team = "Away Team", g1 = 8, g2 = 9, g3 = 10, g4 =11, g5 = 12, g6 = 13, g7 =  14});

        }
    }
}
