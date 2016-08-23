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

namespace _MyTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    
    public partial class MainWindow : Window
    {

        public MyTimer _MyTimer = new MyTimer();
        //public MyTimer MyTimer
        //{
        //    get { return sMyTimer; }
        //}

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _MyTimer;
            
            Title = "Timer";
        }

        private void Start_Pause_Click(object sender, RoutedEventArgs e)
        {
            _MyTimer.TimerStartPause();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            _MyTimer.TimerReset();
        }
    }
}
