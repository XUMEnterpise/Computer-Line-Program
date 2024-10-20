using System;
using System.Media;
using System.IO;

public class SoundManager
{
    private SoundPlayer _alarmPlayer;
    private bool _isAlarmPlaying = false; 

    public void PlayAlarmSound()
    {
        try
        {
            if (_isAlarmPlaying)
                return; 

            string alarmPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "alarm.wav");

            if (!File.Exists(alarmPath))
            {
                throw new FileNotFoundException($"The alarm sound file was not found at path: {alarmPath}");
            }

            _alarmPlayer = new SoundPlayer(alarmPath);
            _alarmPlayer.PlayLooping();
            _isAlarmPlaying = true; 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to play alarm sound: {ex.Message}");
        }
    }

    public void StopAlarmSound()
    {
        if (_alarmPlayer != null && _isAlarmPlaying)
        {
            _alarmPlayer.Stop();
            _alarmPlayer.Dispose();
            _alarmPlayer = null;
            _isAlarmPlaying = false; // Reset g
        }
    }

    public void PlaySuccessLapSound()
    {
        PlaySound("success.wav");
    }

    public void PlayFailLapSound()
    {
        PlaySound("failwav");
    }

   
    public void PlaySuccessHourlyTargetSound()
    {
        PlaySound("hourly_success.wav");
    }

    // Play fail sound for hourly target
    public void PlayFailHourlyTargetSound()
    {
        PlaySound("hourly_fail.wav");
    }

    // play a specified sound file from the program directory
    private void PlaySound(string fileName)
    {
        try
        {
            string soundPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (!File.Exists(soundPath))
            {
                throw new FileNotFoundException($"The sound file '{fileName}' was not found at path: {soundPath}");
            }

            using (SoundPlayer player = new SoundPlayer(soundPath))
            {
                player.Play(); // Play the sound once
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to play sound '{fileName}': {ex.Message}");
        }
    }
}
