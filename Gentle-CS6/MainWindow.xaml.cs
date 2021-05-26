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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Gentle_CS6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            // Console.WriteLine("Hello World.");
            timer = CreateTimer();
        }

        private DispatcherTimer CreateTimer()
        {
            var t = new DispatcherTimer(DispatcherPriority.SystemIdle);
            t.Interval = TimeSpan.FromMilliseconds(300);
            t.Tick += (sender, e) =>
            {
                // process when the Timer created
                // apply current time to the text
                TextBlock.Text = DateTime.Now.ToString("hh:mm:ss");
            };
            
            return t;
        }

        private void textBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            timer.Start();
        }

        // public static void Main()
        // {
        //     Console.WriteLine("Hello World at MainWindow.");
        // }
    }
}