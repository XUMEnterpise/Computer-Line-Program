using System.Windows.Forms;
using System;

public class AlarmManager
{
    private readonly SoundManager _soundManager;

    public AlarmManager(SoundManager soundManager)
    {
        _soundManager = soundManager ?? throw new ArgumentNullException(nameof(soundManager), "SoundManager cannot be null");
    }

    private bool _isAlarmTriggered = false;
    public void CheckAlarm(double totalTime, double targetTime)
    {
        Console.WriteLine($"Checking Alarm: CurrentTime = {totalTime}s, TargetTime = {targetTime}s, IsAlarmTriggered = {_isAlarmTriggered}");
        if (totalTime >= targetTime && !_isAlarmTriggered)
        {
            TriggerAlarm();
            _isAlarmTriggered = true;
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
