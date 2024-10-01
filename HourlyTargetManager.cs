using LineProgram;
using System;
using System.Timers;

public class HourlyTargetManager
{
    public const int TargetCompletedPerHour = 15; // targets for how many pcs an hour
    public Timer _hourlyTimer;
    public StopwatchManager _stopwatchManager;
    public SoundManager _soundManager;

    public HourlyTargetManager(StopwatchManager stopwatchManager, SoundManager soundManager)
    {
        _stopwatchManager = stopwatchManager;
        _soundManager = soundManager;

        InitializeHourlyTimer();
    }

    private void InitializeHourlyTimer()
    {
        _hourlyTimer = new Timer(3600000); // 1hour in ms
        _hourlyTimer.Elapsed += HourlyCheck;
        _hourlyTimer.AutoReset = true; // making sure its running every hour
        _hourlyTimer.Enabled = true; 
    }

    private void HourlyCheck(object sender, ElapsedEventArgs e)
    {
        if (_stopwatchManager.CompletedLaps >= TargetCompletedPerHour)
        {
            _soundManager.PlaySuccessHourlyTargetSound(); // Play success
        }
        else
        {
            _soundManager.PlayFailHourlyTargetSound(); // Play fail
        }

        ResetHourlyTarget(); // Reset
    }

    private void ResetHourlyTarget()
    {
        _stopwatchManager.ResetCompletedLaps(); // Reset completed
    }



}
