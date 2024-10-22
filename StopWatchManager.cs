using System;
using System.Collections.Generic;
using System.Timers;
using System.Linq;

public class StopwatchManager
{
    public event EventHandler Elapsed;

    private Timer _timer;
    private List<double> _lapTimes;  // List to store lap times
    public double TotalTime { get; private set; } // Total elapsed time in seconds
    public double _targetTime; // Private target time in seconds
    private int _completedLaps; // Number of completed laps
    private AlarmManager _alarmManager;

    public int CompletedLaps
    {
        get { return _completedLaps; }
        set { _completedLaps = value; }
    }


    public StopwatchManager(AlarmManager alarmManager)
    {
        _alarmManager = alarmManager;
        _timer = new Timer(1000); // Timer fires every 1 second
        _timer.Elapsed += TimerElapsed;
        _timer.AutoReset = true;
        _lapTimes = new List<double>();
    }

    // Method to start countdown with a specific target time
    public void StartWithTarget(double targetTime)
    {
        _targetTime = targetTime;
        TotalTime = 0; // Reset total time to 0
        _timer.Start();
    }

    public void Start()
    {
        _timer.Start(); // Start the timer
    }

    public void Stop()
    {
        _timer.Stop(); // Stop the timer
    }

    public void Pause()
    {
        _timer.Stop(); // Pause the timer
    }

    public void Resume()
    {
        _timer.Start(); // Resume the timer
    }

    public void Reset()
    {
        _timer.Stop();     // Stop the timer
        TotalTime = 0;     // Reset the total elapsed time
        _lapTimes.Clear(); // Clear all recorded lap times
        _completedLaps = 0; // Reset completed laps count
    }

    public void ResetCompletedLaps()
    {
        _completedLaps = 0; // Reset the completed laps
        _lapTimes.Clear(); // Clear lap times if needed
    }

    // Method to manually set completed laps
    public void SetCompletedLaps(int value)
    {
        _completedLaps = value;
    }
    public string GetFormattedTime()
    {
        int hours = (int)(TotalTime / 3600);          // 3600 seconds in an hour
        int minutes = (int)((TotalTime % 3600) / 60); // 60 seconds in a minute
        int seconds = (int)(TotalTime % 60);          // Remaining seconds

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}"; // Format as 00:00:00
    }

    // Method to complete a lap and record the time
    public void CompleteLap()
    {
        if(TotalTime >=30)
        {
            _lapTimes.Add(TotalTime); // Record completed lap time
            TotalTime = 0; // Reset TotalTime
            _completedLaps++; 
        }
        else
        {
            //invalid time
            TotalTime = 0;
        }

        
    }

    //the average time of all completed laps
    public double AverageTime
    {
        get
        {
            if (_lapTimes.Count == 0)
                return 0;

            return _lapTimes.Average(); // Calculate the average of all lap times
        }
    }

    //best time of all completed laps
    public double BestTime
    {
        get
        {
            if (_lapTimes.Count == 0)
                return 0;

            return _lapTimes.Min(); // Return the best (minimum) time of all lap times
        }
    }

    // access the target time
    public double TargetTime
    {
        get { return _targetTime; }
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        TotalTime += 1; //  TotalTime by 1 second

        // Automatically check if the alarm should be triggered using current total time and target time
        _alarmManager.CheckAlarm(TotalTime, _targetTime);  // pass TotalTime and TargetTime here

        Elapsed?.Invoke(this, EventArgs.Empty); 
    }
}
