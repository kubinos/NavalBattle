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

namespace NavalBattle
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private const int COL = 10;
        private const int ROW = 10;


        public GameWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void canvas_player_MouseMove(object sender, MouseEventArgs e)
        {
//            canvas_player.MouseDown();
        }

        private void DrawDefaultLines(Canvas canvas)
        {
            double height = canvas.Height;
            double width = canvas.Width;

        }
    }
}
