
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
            this.playerTurn.Content = "Player 1 Turn";
            this.UpPlayer.Visibility = Visibility.Hidden;
            this.DownPlayer.Visibility = Visibility.Hidden;

        }

        private void slideFirst_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            int value = Convert.ToInt32(e.NewValue);
            string message = $"Bet: {value}";
            this.Text.Text = message;

        }

        private void FirstPlayerBet(object sender, RoutedEventArgs e)
        {

            bool isTurn = this.ReturnFirst();

            if (!isTurn)
            {
                return;
            }

            decimal bet = decimal.Parse(this.Slider.Value.ToString());

            decimal finalBet = Math.Floor(bet);

            if (bet == 0)
            {
                this.players.SecondPlayerTurn = false;
                this.players.FirstPlayerTurn = true;
                this.playerTurn.Content = "Player 1 turn";
                MessageBox.Show("You cannot bet 0");
            }
            else
            {
                this.players.FullBet += (int)finalBet;
                this.players.OldBet = this.players.FullBet - (int)finalBet;
                this.Bet.Content = $"Full Bet: {this.players.FullBet}";
            }
        }

        private void SecondPlayerBet(object sender, RoutedEventArgs e)
        {

            bool isTurn = this.ReturnSecond();

            if (!isTurn)
            {
                return;
            }

            decimal bet = decimal.Parse(this.Slider1.Value.ToString());

            decimal finalBet = Math.Floor(bet);

            if (bet == 0)
            {
                this.players.SecondPlayerTurn = true;
                this.players.FirstPlayerTurn = false;
                this.playerTurn.Content = "Player 2 turn";
                MessageBox.Show("You cannot bet 0");
            }
            else
            {
                this.players.FullBet += (int)finalBet;
                this.players.OldBet = this.players.FullBet - (int)finalBet;
                this.Bet.Content = $"Full Bet: {this.players.FullBet}";
            }
        }

        private void SliderSecond_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = Convert.ToInt32(e.NewValue);
            string message = $"Bet: {value}";
            this.SecondText.Text = message;
        }

        private void PaySecond(object sender, RoutedEventArgs e)
        {
            bool isTurn = this.ReturnSecond();

            if (!isTurn)
            {
                return;
            }

            this.CheckWhoWin();
        }

        private void PayFirst(object sender, RoutedEventArgs e)
        {
            bool isTurn = this.ReturnFirst();

            if (!isTurn)
            {
                return;
            }

            this.CheckWhoWin();
        }

        private void CheckWhoWin()
        {
            int firstPlayerScore = this.players.ScoreFirstPlayer;
            int secondPlayerScore = this.players.ScoreSecondPlayer;

            if (firstPlayerScore > secondPlayerScore)
            {
                MessageBox.Show("Player 1 win the game !");

            }
            else if (firstPlayerScore < secondPlayerScore)
            {
                MessageBox.Show("Player 2 win the game !");

            }
            else
            {
                //TODO SVARA GAME
            }
        }

        private void FoldFirst(object sender, RoutedEventArgs e)
        {

            bool isTurn = this.ReturnFirst();

            if (!isTurn)
            {
                return;
            }

            MessageBox.Show($"Player 1 drinks: {this.players.OldBet}");
        }

        private void FoldSecond(object sender, RoutedEventArgs e)
        {
            bool isTurn = this.ReturnSecond();

            if (!isTurn)
            {
                return;
            }
            MessageBox.Show($"Player 2 drinks: {this.players.OldBet}");

        }

        private bool ReturnFirst()
        {
            if (!this.players.FirstPlayerTurn)
            {
                MessageBox.Show("It's not your turn!");
                return false;
            }
            else
            {
                this.players.SecondPlayerTurn = true;
                this.players.FirstPlayerTurn = false;
                this.playerTurn.Content = "Player 2 turn";
                return true;
            }
        }

        private bool ReturnSecond()
        {
            if (!this.players.SecondPlayerTurn)
            {
                MessageBox.Show("It's not your turn!");
                return false;
            }
            else
            {
                this.players.SecondPlayerTurn = false;
                this.players.FirstPlayerTurn = true;
                this.playerTurn.Content = "Player 1 turn";
                return true;
            }
        }

        private void ShowFirstCards_Click(object sender, RoutedEventArgs e)
        {
            var buttonContent = this.ShowFirstCards.Content;

            if (buttonContent == "Show cards")
            {
                bool isTurn = this.IsYourTurnCheckCards();

                if (!isTurn)
                {
                    MessageBox.Show("It's not your turn!");
                    return;
                }

                this.UpPlayer.Visibility = Visibility.Visible;
                this.BackUp.Visibility = Visibility.Hidden;
                this.ShowFirstCards.Content = "Hide cards";
            }
            else
            {
                this.UpPlayer.Visibility = Visibility.Hidden;
                this.ShowFirstCards.Content = "Show cards";
                this.BackUp.Visibility = Visibility.Visible;
            }

        }

        private void ShowSecondCards_Click(object sender, RoutedEventArgs e)
        {
            var buttonContent = this.ShowSecondCards.Content;

            if (buttonContent == "Show cards")
            {
                bool isTurn = this.IsYourTurnCheckCards();

                if (isTurn)
                {
                    MessageBox.Show("It's not your turn!");
                    return;
                }

                this.DownPlayer.Visibility = Visibility.Visible;
                this.BackDown.Visibility = Visibility.Hidden;
                this.ShowSecondCards.Content = "Hide cards";
            }
            else
            {
                this.DownPlayer.Visibility = Visibility.Hidden;
                this.BackDown.Visibility = Visibility.Visible;
                this.ShowSecondCards.Content = "Show cards";
            }
        }

        private bool IsYourTurnCheckCards()
        {
            if (this.players.FirstPlayerTurn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
