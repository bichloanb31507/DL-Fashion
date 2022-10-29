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
using System.Windows.Threading;

namespace Yody
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public WelcomeWindow()
        {
            InitializeComponent();
            Loading();
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            media.Position = new TimeSpan(0, 0, 1);
            media.Play();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            timer.Stop();
            Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            Close();
        }

        void Loading()
        {
            timer.Tick += timer_tick;
            timer.Interval = new TimeSpan(0, 0, 8);
            timer.Start();
        }
    }
}
