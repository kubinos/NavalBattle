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

        public Hra hra = new Hra();

        private List<Rectangle> rectangles;

        public GameWindow()
        {
            InitializeComponent();
            rectangles = new List<Rectangle>();
            for (int x = 0; x < 10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    rectangles.Add(new Rectangle().);
                }
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void canvas_player_MouseMove(object sender, MouseEventArgs e)
        {
//            canvas_player.MouseDown();
        }

        private void canvas_player_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Point mouse = e.GetPosition(canvas_player);
            int polickoX = (int)Math.Floor(mouse.X / 3);
            int polickoY = (int)Math.Floor(mouse.Y / 3);

            int indexPolicko = polickoX + (polickoY * 10);

        }
    }
}
