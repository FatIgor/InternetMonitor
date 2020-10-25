using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetMonitor
{
    public partial class Form1 : Form
    {
        private Timer _timer;
        private bool _internetOn;
        
        public Form1()
        {
            InitializeComponent();
            var startState = InternetCheck.CheckForInternetConnection();
            _internetOn = !startState;
            StateCheck(startState);
            StartTimer(1000);
        }

        private void StartTimer(int tickLength)
        {
            _timer = new Timer
            {
                Interval = tickLength
            };
            _timer.Enabled = true;
            _timer.Tick+=new System.EventHandler(OnTimerTick);
        }

        private void OnTimerTick(object source, EventArgs e)
        {
            StateCheck(InternetCheck.CheckForInternetConnection());
        }

        private DateTime _onStart;
        private DateTime _offStart;
        
        private void StateCheck(bool latestState)
        {
            if (_internetOn == latestState)
            {
                TimeSpan currentLength;
                if (_internetOn)
                {
                    currentLength = DateTime.Now - _onStart;
                }
                else
                {
                    currentLength = DateTime.Now - _offStart;
                }

                currentDurationLabel.Text = String.Format("{0:d2}:{1:d2}:{2:d2}", currentLength.Hours, currentLength.Minutes, currentLength.Seconds);
                return;
            }
            _internetOn = latestState;
            if (_internetOn)
            {
                _onStart=DateTime.Now;
                connectionStateLabel.Text = "Internet has a connection.";
            }
            else
            {
                _offStart=DateTime.Now;
                connectionStateLabel.Text = "Internet is not connected.";
            }
        }

    }
}