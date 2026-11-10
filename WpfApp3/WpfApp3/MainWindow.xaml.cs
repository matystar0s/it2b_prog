using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WpfApp3
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        Timer timer = new Timer();
        Random random = new Random();
        int clicks = 0;
        int clickAdd = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clicks += clickAdd;
            Bar.Value += clickAdd;
            Clicks.Text = "Clicks: " + clicks;
            if (Bar.Value == 10000000)
            {
                Bar.Value = 0;
                Bar.Foreground = new SolidColorBrush(
                    Color.FromRgb(
                        (byte)random.Next(256),
                        (byte)random.Next(256),
                        (byte)random.Next(256)
                    )
                );
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (clicks >= 100)
            {
                clickAdd += 1;
                Power.Text = "Click power: " + clickAdd;
                clicks -= 100;
                Clicks.Text = "Clicks: " + clicks;
            }
            else
            {
                _100.Text = "You don't have enough clicks!";

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);

                timer.Tick += (s, args) =>
                {
                    _100.Text = "";
                    timer.Stop();
                };

                timer.Start();

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (clicks >= 1000)
            {
                clickAdd += 10;
                Power.Text = "Click power: " + clickAdd;
                clicks -= 1000;
                Clicks.Text = "Clicks: " + clicks;
            }
            else
            {
                _1000.Text = "You don't have enough clicks!";

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);

                timer.Tick += (s, args) =>
                {
                    _1000.Text = "";
                    timer.Stop();
                };

                timer.Start();

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (clicks >= 10000)
            {
                clickAdd += 100;
                Power.Text = "Click power: " + clickAdd;
                clicks -= 10000;
                Clicks.Text = "Clicks: " + clicks;
            }
            else
            {
                _10000.Text = "You don't have enough clicks!";

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);

                timer.Tick += (s, args) =>
                {
                    _10000.Text = "";
                    timer.Stop();
                };

                timer.Start();

            }
        }
    }
}
