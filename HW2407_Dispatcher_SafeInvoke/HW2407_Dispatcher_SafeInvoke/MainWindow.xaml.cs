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

namespace HW2407_Dispatcher_SafeInvoke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        Timer timer = new Timer(1000);
        public MainWindow()
        {
            InitializeComponent();

            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Color randomColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
            if (Dispatcher.CheckAccess())
            {
                MyBorder.Background = new SolidColorBrush(randomColor);
            }
            else
            {
                Action a = () => { MyBorder.Background = new SolidColorBrush(randomColor); };
                Dispatcher.Invoke(a);
            }
        }
    }
}
