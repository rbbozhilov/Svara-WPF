
using Svara.WPF.ViewModels.FullTable;

using System.Windows;

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
    }
}
