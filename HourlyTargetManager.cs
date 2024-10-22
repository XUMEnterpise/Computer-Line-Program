using LineProgram;
using System;
using System.Timers;

public class HourlyTargetManager
{
    private int _currentTargetPerHour;  // increase every hour var
    private const int TargetIncrease = 15; // The amount by which the target increases each hour
    private Timer _hourlyTimer;
    private StopwatchManager _stopwatchManager;
    private SoundManager _soundManager;

    public HourlyTargetManager(StopwatchManager stopwatchManager, SoundManager soundManager)
    {
        _stopwatchManager = stopwatchManager;
        _soundManager = soundManager;

        //  current target as 15 (initial target)
        _currentTargetPerHour = 15;

        // Initialize and start the hourly timer
        InitializeHourlyTimer();
    }

    public void InitializeHourlyTimer() // Timer function for every hour
    {
        _hourlyTimer = new Timer(3600000);  // 1 hour in milliseconds

        
        _hourlyTimer.Elapsed += HourlyCheck;

        // Make sure the timer repeats every hour
        _hourlyTimer.AutoReset = true;

        // Start the timer 
        _hourlyTimer.Start();
    }

    private void HourlyCheck(object sender, ElapsedEventArgs e)
    {
        try
        {
            // Check if the current target was reached
            if (_stopwatchManager.CompletedLaps >= _currentTargetPerHour)
            {
                _soundManager.PlaySuccessHourlyTargetSound(); // Play success sound
                Console.WriteLine("Playing Ahead of Target Sound!"); //some debugging incase this doesnt work or any issues
            }
            else
            {
                _soundManager.PlayFailHourlyTargetSound(); // Play fail sound
                Console.WriteLine("Playing Behind of Target Sound!");
            }

            // Increase the target for the next hour
            _currentTargetPerHour += TargetIncrease;

            // Reset the hourly target
            ResetHourlyTarget();
        }
        catch (Exception ex)
        {
            // Handle any exceptions related to sound or timing
            Console.WriteLine($"Error during hourly check: {ex.Message}");
        }
    }

    private void ResetHourlyTarget()
    {
        _stopwatchManager.ResetCompletedLaps(); // Reset completed laps
    }

    public void StopHourlyTimer()
    {
        // Stop and dispose of the timer to avoid memory leaks if not needed further
        _hourlyTimer.Stop();
        _hourlyTimer.Dispose();
    }
}