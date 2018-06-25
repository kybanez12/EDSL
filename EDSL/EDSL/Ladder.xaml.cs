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
    /// Interaction logic for Ladder.xaml
    /// </summary>
    public partial class Ladder : Window
    {
        public class MyLadder
        {
            public int Position { get; set; }
            public string Team { get; set; }
            public int Played { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Draw { get; set; }
            public int For { get; set; }
            public int Against { get; set; }
        }
        public Ladder()
        {
            InitializeComponent();

            ladderLv.Items.Add(new MyLadder { Position = 1, Team = "WANTIRNA-A", Played = 1, Wins = 1, Losses = 0, Draw = 0, For = 1, Against = 0});
            ladderLv.Items.Add(new MyLadder { Position = 2, Team = "WONGA PARK-A", Played = 1, Wins = 1, Losses = 0, Draw = 0, For = 2, Against = 1 });
            ladderLv.Items.Add(new MyLadder { Position = 3, Team = "LILYDALE-A", Played = 1, Wins = 1, Losses = 0, Draw = 0, For = 1, Against = 0});
            ladderLv.Items.Add(new MyLadder { Position = 4, Team = "BELGRAVE-A", Played = 1, Wins = 1,Losses = 1, Draw = 0, For = 3, Against = 2});
            ladderLv.Items.Add(new MyLadder { Position = 5, Team = "SCORESBY-A", Played = 1, Wins = 0, Losses = 0, Draw = 1, Against = 1, For = 1});
            ladderLv.Items.Add(new MyLadder { Position = 6, Team = "MITCHAM-A", Played = 1, Wins = 0, Losses = 0, Draw = 1, Against = 1, For = 1});
            ladderLv.Items.Add(new MyLadder { Position = 7, Team = "MOUNT WAVERLY-A", Played = 1, Wins = 0, Losses = 1, Draw = 0, For = 0, Against = 1});
            ladderLv.Items.Add(new MyLadder { Position = 8, Team = "RINGWOOD-A", Played = 1, Wins = 0, Losses = 1, Draw = 0, For = 1, Against = 2 });
            ladderLv.Items.Add(new MyLadder { Position = 9, Team = "MOUNT EVELYN-A", Played = 1, Wins = 0, Losses = 1, Draw = 0, For =0, Against = 1});
            ladderLv.Items.Add(new MyLadder { Position = 10, Team = "BECONSFIELD UPPER-A", Played = 1, Wins = 0, Losses = 1, Draw = 0, For = 2, Against = 3});
            ladderLv.Items.Add(new MyLadder { Position = 11, Team = "MURRUMBEENA-A", Played = 0, Wins = 0, Losses = 0, Draw = 0, For = 0, Against = 0 });
            ladderLv.Items.Add(new MyLadder { Position = 12, Team = "FERNTREEGULLY-A", Played = 0, Wins = 0, Losses = 0, Draw = 0, For = 0, Against = 0 });
            ladderLv.Items.Add(new MyLadder { Position = 13, Team = "OAKLIEGH-A", Played = 0, Wins = 0, Losses = 0, Draw = 0, For = 0, Against = 0 });
        }
    }
}
