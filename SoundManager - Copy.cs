using System;
using System.Media;
using System.IO;
using System.Windows.Forms;

public class SoundManager
{
    private readonly string _basePath;

    public SoundManager()
    {
        _basePath = AppDomain.CurrentDomain.BaseDirectory; // Base directory of the program
    }

    public void PlaySuccessLapSound()
    {
        PlaySound("success.wav");
    }

    public void PlayFailLapSound()
    {
        PlaySound("fail.wav");
    }

    public void PlaySuccessHourlyTargetSound()
    {
        PlaySound("hourly_success.wav");
    }

    public void PlayFailHourlyTargetSound()
    {
        PlaySound("hourly_fail.wav");
    }

    private void PlaySound(string soundFileName)
    {
        try
        {
            string soundFilePath = Path.Combine(_basePath, soundFileName);
            var player = new SoundPlayer(soundFilePath);
            player.Play();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error playing sound: {ex.Message}"); //error handling if theres sound issuee
        }
    }
}
