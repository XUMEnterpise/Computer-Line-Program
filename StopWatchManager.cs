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

    public double AverageTime
    {
        get
        {
            // Return 0 if there are no completed laps
            if (_lapTimes.Count == 0)
                return 0;

            // Calculate the average of all lap times
            return _lapTimes.Average();
        }
    }

    public double BestTime
    {
        get
        {
            // Return 0 if there are no completed laps
            if (_lapTimes.Count == 0)
                return 0;

            // Return the best (minimum) time of all lap times
            return _lapTimes.Min();
        }
    }

    public StopwatchManager(AlarmManager alarmManager)
    {
        _alarmManager = alarmManager;
        _timer = new Timer(1000); // Timer fires every 1 second
        _timer.Elapsed += TimerElapsed;
        _timer.AutoReset = true;
        _lapTimes = new List<double>();
    }

    public void StartWithTarget(double targetTime)
    {
        if (_timer.Enabled) // Prevent double-starts
        {
            Console.WriteLine("[DEBUG] Timer already running; ignoring duplicate ");
            return;
        }
        _targetTime = targetTime;
        TotalTime = 0;
        Console.WriteLine($"[DEBUG] StopwatchManager initialized with TargetTime: {_targetTime}s");
        _timer.Start();
    }

    public void Stop()
    {
        _timer.Stop();
    }

    public void Reset()
    {
        _timer.Stop();
        TotalTime = 0;
        _lapTimes.Clear();
    }

    public string GetFormattedTime()
    {
        int hours = (int)(TotalTime / 3600);          // 3600 seconds in an hour
        int minutes = (int)((TotalTime % 3600) / 60); // 60 seconds in a minute
        int seconds = (int)(TotalTime % 60);          // Remaining seconds

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}"; // Format as 00:00:00
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        Console.WriteLine($"[DEBUG] Timer Elapsed: TotalTime = {TotalTime}s, TargetTime = {_targetTime}s");

        TotalTime += 1; // Increment total time in seconds
        _alarmManager.CheckAlarm(TotalTime, _targetTime); // Check if the alarm should trigger

        Elapsed?.Invoke(this, EventArgs.Empty); // Notify listeners
    }

    public void Pause()
    {
        _timer.Stop(); // Pause the timer
        Console.WriteLine("[DEBUG] Stopwatch paused.");
    }

    public void ResetCompletedLaps()
    {
        _completedLaps = 0; // Reset the completed laps count
        _lapTimes.Clear(); // Clear all recorded lap times if necessary
        Console.WriteLine("[DEBUG] Completed laps reset.");
    }

    public void Resume()
    {
        _timer.Start(); // Resume the timer
        Console.WriteLine("[DEBUG] Stopwatch resumed.");
    }

    public void Start()
    {
        _timer.Start(); // Start the timer
        Console.WriteLine("[DEBUG] Stopwatch started.");
    }

    public void CompleteLap()
    {
        if (TotalTime >= 30) // Example validation for minimum lap time
        {
            _lapTimes.Add(TotalTime); // Record completed lap time
            TotalTime = 0; // Reset TotalTime
            _completedLaps++;
        }
        else
        {
            // Invalid lap
            TotalTime = 0;
        }
    }
}
