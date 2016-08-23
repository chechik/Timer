using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.ComponentModel;

namespace _MyTimer
{
    public class MyTimer : INotifyPropertyChanged
    {
        private DispatcherTimer timer;
        private bool _isRunning;
        private DateTime _timeToDisplay;

        public DateTime TimeToDisplay
        {
            get { return _timeToDisplay; }
            set
            {
                _timeToDisplay = value;
                OnPropertyChanged("TimeToDisplay");
            }
        }

        public MyTimer()
        {
            timer = new DispatcherTimer();
            _timeToDisplay = new DateTime(1, 1, 1, 0, 0, 0, 0);
            timer.Tick += new EventHandler(dispatcherTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 50 );
            _isRunning = false;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            TimeToDisplay = _timeToDisplay.AddMilliseconds(50);
        }

        public void TimerStartPause()
        {
            if (!_isRunning)
            {
                timer.Start();
                _isRunning = true;
            }
            else
            {
                timer.Stop();
                _isRunning = false;
            }
        }

        public void TimerReset()
        {
            timer.Stop();
            TimeToDisplay = new DateTime(1, 1, 1, 0, 0, 0, 0);
            _isRunning = false;
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop)
        {
            if( PropertyChanged != null )
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        #endregion

    }
}
