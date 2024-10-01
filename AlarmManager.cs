using System.Windows.Forms;
using System;

public class AlarmManager
{
    private readonly SoundManager _soundManager;

    public AlarmManager(SoundManager soundManager)
    {
        _soundManager = soundManager ?? throw new ArgumentNullException(nameof(soundManager), "SoundManager cannot be null");
    }

    public void CheckAlarm(object sender, EventArgs e)
    {
        StopwatchManager stopwatchManager = sender as StopwatchManager;

        if (stopwatchManager != null && stopwatchManager.TotalTime >= stopwatchManager.TargetTime)
        {
            TriggerAlarm();  // when the target is reached
        }
    }

    private void TriggerAlarm()
    {
        try
        {
            _soundManager.PlayAlarmSound(); // play the alarm sound
            
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to play alarm sound: {ex.Message}", "Alarm Error"); //error handling
        }
    }
}
