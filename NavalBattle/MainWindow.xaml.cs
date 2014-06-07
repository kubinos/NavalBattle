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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavalBattle
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window gameWindow;

        public MainWindow()
        {
            InitializeComponent();

            gameWindow = new GameWindow();
        }

        private void button_start_game_Click(object sender, RoutedEventArgs e)
        {
            gameWindow.Show();
        }

    }
}
