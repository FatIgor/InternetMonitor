﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetMonitor
{
    public partial class Form1 : Form
    {
        private Timer _timer;
        private bool _internetOn;
        private List<string> _logfile;
        private string _logfileName = "internet_states.txt";
        private SoundPlayer _player;

        private int _outagesCount = 0;
        private TimeSpan _totalOnTime = new TimeSpan();
        private TimeSpan _totalOffTime = new TimeSpan();
        private TimeSpan _currentLength;

        public Form1()
        {
            InitializeComponent();
            InitializeSound();
            ReadLog();
            var startState = InternetCheck.CheckForInternetConnection();
            _internetOn = !startState;
            StateCheck(startState);
            StartTimer(10000);
        }

        private void StartTimer(int tickLength)
        {
            _timer = new Timer
            {
                Interval = tickLength
            };
            _timer.Enabled = true;
            _timer.Tick += new System.EventHandler(OnTimerTick);
        }

        private void OnTimerTick(object source, EventArgs e)
        {
            StateCheck(InternetCheck.CheckForInternetConnection());
        }

        private DateTime _onStart = new DateTime();
        private DateTime _offStart = new DateTime();

        private void StateCheck(bool latestState)
        {
            if (_internetOn == latestState)
            {
                if (_internetOn)
                {
                    _currentLength = DateTime.Now - _onStart;
                }
                else
                {
                    _currentLength = DateTime.Now - _offStart;
                }

                currentDurationLabel.Text = String.Format("{0:d2}:{1:d2}:{2:d2}", _currentLength.Hours,
                    _currentLength.Minutes, _currentLength.Seconds);
                UpdateCountsDisplay();
                return;
            }

            _internetOn = latestState;
            if (_internetOn)
            {
                connectionStateLabel.Text = "Internet has a connection.";
                PlaySound(Sounds.ComeOn);
                _onStart = DateTime.Now;
                if (_offStart.Year == 1)
                    return;
                var previousLength = DateTime.Now - _offStart;
                _totalOffTime += previousLength;
                var outputMsg = String.Format("{0:d2}:{1:d2}:{2:d2}", previousLength.Hours, previousLength.Minutes,
                    previousLength.Seconds);
                _onStart = DateTime.Now;
                DumpMessage("Was off for " + outputMsg);
            }
            else
            {
                _outagesCount++;
                connectionStateLabel.Text = "Internet is not connected.";
                PlaySound(Sounds.GoneOff);
                _offStart = DateTime.Now;
                if (_onStart.Year == 1)
                    return;
                var previousLength = DateTime.Now - _onStart;
                _totalOnTime += previousLength;
                var outputMsg = String.Format("{0:d2}:{1:d2}:{2:d2}", previousLength.Hours, previousLength.Minutes,
                    previousLength.Seconds);
                _onStart = DateTime.Now;
                DumpMessage("Was on for " + outputMsg);
            }
        }

        private void UpdateCountsDisplay()
        {
            outageCountLabel.Text = $"Outages: {_outagesCount}";
            var totalTime = _totalOffTime;
            if (!_internetOn)
                totalTime += _currentLength;
            var time1 = String.Format("{0:d2}:{1:d2}:{2:d2}", totalTime.Hours, totalTime.Minutes,
                totalTime.Seconds);
            totalTime = _totalOnTime;
            if (_internetOn)
                totalTime += _currentLength;
            var time2 = String.Format("{0:d2}:{1:d2}:{2:d2}", totalTime.Hours, totalTime.Minutes,
                totalTime.Seconds);
            percentagesLabel.Text = $"On: {time2} Off: {time1}";
        }

        private void ReadLog()
        {
            string line;
            _logfile = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(_logfileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        _logfile.Add(line);
                    }
                }
            }
            catch
            {
            }
        }

        private void DumpMessage(string msg)
        {
            msg = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " " + msg;
            _logfile.Add(msg);
            using (StreamWriter sw = new StreamWriter(_logfileName))
            {
                foreach (var line in _logfile)
                    sw.WriteLine(line);
            }
        }

        public enum Sounds
        {
            GoneOff,
            ComeOn
        }

        // Sets up the SoundPlayer object.
        private void InitializeSound()
        {
            // Create an instance of the SoundPlayer class.
            _player = new SoundPlayer();
        }

        private void PlaySound(Sounds whichSound)
        {
            string audiofile = "";
            switch (whichSound)
            {
                case Sounds.GoneOff:
                    audiofile = "c:\\off.wav";
                    break;
                case Sounds.ComeOn:
                    audiofile = "c:\\on.wav";
                    break;
            }

            _player.SoundLocation = audiofile;
            _player.LoadAsync();
            _player.Play();
        }
    }
}