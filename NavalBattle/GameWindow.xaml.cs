﻿using System;
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

        private List<Rectangle> rectangles;

        public GameWindow()
        {
            InitializeComponent();
            rectangles = new List<Rectangle>();
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
        }
    }
}
