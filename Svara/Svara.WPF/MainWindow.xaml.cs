﻿
using Svara.WPF.ViewModels.FullTable;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Svara.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Players players = new Players();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this.players;
            

        }

        private void slideFirst_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            int value = Convert.ToInt32(e.NewValue);
            string message = $"Bet: {value}";
            this.Text.Text = message;

        }

        private void FirstPlayerBet(object sender, RoutedEventArgs e)
        {
            decimal bet = decimal.Parse(this.Slider.Value.ToString());

            decimal finalBet = Math.Floor(bet);

            if(bet == 0)
            {
                MessageBox.Show("You cannot bet 0");
            }
            else
            {
                this.players.FullBet += (int)finalBet;

                this.Bet.Content = $"Full Bet: {this.players.FullBet}";
            }
        }

        private void SecondPlayerBet(object sender, RoutedEventArgs e)
        {
            decimal bet = decimal.Parse(this.Slider1.Value.ToString());

            decimal finalBet = Math.Floor(bet);

            if (bet == 0)
            {
                MessageBox.Show("You cannot bet 0");
            }
            else
            {
                this.players.FullBet += (int)finalBet;

                this.Bet.Content = $"Full Bet: {this.players.FullBet}";
            }
        }

        private void SliderSecond_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = Convert.ToInt32(e.NewValue);
            string message = $"Bet: {value}";
            this.SecondText.Text = message;
        }
    }
}
