
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
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Players();

        }

        private void slideFirst_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            int value = Convert.ToInt32(e.NewValue);
            string message = $"Bet: {value}";
            this.Text.Text = message;

        }

        private void FirstPlayerBet(object sender, RoutedEventArgs e)
        {
            var value = this.Text.Text;
        }
    }
}
