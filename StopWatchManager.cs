using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace LineProgram
{
    // all the functions of the stopwatch
    public class StopwatchManager
    {
        public event EventHandler Elapsed; // knows when the stopwatch is started and ticking

        private Timer _timer;
        private DateTime _startTime; // start time of the stopwatch
        private List<double> _lapTimes; //how long a build takes

        public int PeopleCount { get; set; } // how many people on the line?
        public double TotalTime { get; private set; } // how long it took to do a build/ allows average and best time to be caculated
        public double AverageTime => _lapTimes.Count > 0 ? _lapTimes.Average() : 0; // the average time of the builds done
        public double BestTime => _lapTimes.Count > 0 ? _lapTimes.Min() : 60; // minium best time , we dont want the best time being any value lower than 0, its just unrealstic and all the data will be inrevelant 
        public int CompletedLaps { get; private set; } // total builds completed

        public StopwatchManager()
        {
            _timer = new Timer(1000); // 1second 
            _timer.Elapsed += OnTimerElapsed; 
            _lapTimes = new List<double>();
            Reset(); // starts when reset
        }

        
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            TotalTime = (DateTime.Now - _startTime).TotalSeconds; // how long its taking
            Elapsed?.Invoke(this, EventArgs.Empty); // listener so the lbls and everything updates
        }

        // Start  stopwatch
        public void Start()
        {
            _startTime = DateTime.Now; 
            _timer.Start(); 
        }

        // Pause  stopwatch
        public void Pause()
        {
            _timer.Stop();
        }

        // Unpause stopwatch and adjust the time
        public void Unpause()
        {
            _startTime = DateTime.Now.AddSeconds(-TotalTime); //if paused it will know
            _timer.Start();
        }

        // reset  stopwatch
        public void Reset()
        {
            Pause();
            TotalTime = 0; 
            _lapTimes.Clear(); 
            CompletedLaps = 0; 
            PeopleCount = 0; /
            Elapsed?.Invoke(this, EventArgs.Empty); // lables will update
        }

        // will complete build and record time
        public void CompleteLap()
        {
            _timer.Stop(); 
            double lapTime = TotalTime; 
            _lapTimes.Add(lapTime); 
            CompletedLaps++; 
            _startTime = DateTime.Now; 
            TotalTime = 0; 
            _timer.Start(); 
        }
    }
}
