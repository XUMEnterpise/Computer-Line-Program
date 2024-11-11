using System;
using System.Timers;

public class HourlyTargetManager
{
    private int _currentTargetPerHour; // Cumulative target
    private const int TargetIncrease = 15; // Increase target by this amount every hour
    private Timer _hourlyTimer;
    private StopwatchManager _stopwatchManager;
    private SoundManager _soundManager;
    private int _lapsAtLastHourlyCheck = 0; // Tracks laps completed at the last hourly check

    public int CurrentTarget => _currentTargetPerHour; // Expose current target for UI

    public HourlyTargetManager(StopwatchManager stopwatchManager, SoundManager soundManager)
    {
        _stopwatchManager = stopwatchManager;
        _soundManager = soundManager;

        _currentTargetPerHour = 15; // Initial hourly target

        InitializeHourlyTimer();
    }

    private void InitializeHourlyTimer()
    {
        _hourlyTimer = new Timer(3600000); // 1 hour in milliseconds
        _hourlyTimer.Elapsed += HourlyCheck;
        _hourlyTimer.AutoReset = true;
        _hourlyTimer.Start();
    }

    private void HourlyCheck(object sender, ElapsedEventArgs e)
    {
        try
        {
            // Calculate laps completed in the last hour
            int lapsCompletedThisHour = _stopwatchManager.CompletedLaps - _lapsAtLastHourlyCheck;

            if (lapsCompletedThisHour >= _currentTargetPerHour)
            {
                _soundManager.PlaySuccessHourlyTargetSound();
                Console.WriteLine("[DEBUG] On Target for the Hour");
            }
            else
            {
                _soundManager.PlayFailHourlyTargetSound();
                Console.WriteLine("[DEBUG] Behind Target for the Hour");
            }

            // Update for the next hourly check
            _lapsAtLastHourlyCheck = _stopwatchManager.CompletedLaps;

            // Increase target for the next hour
            _currentTargetPerHour += TargetIncrease;

            // Notify UI
            Console.WriteLine($"[DEBUG] Hourly Check - Completed: {_stopwatchManager.CompletedLaps}, New Target: {_currentTargetPerHour}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during hourly check: {ex.Message}");
        }
    }

    public void StopHourlyTimer()
    {
        _hourlyTimer.Stop();
        _hourlyTimer.Dispose();
    }
}
