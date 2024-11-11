using System;
using System.Windows.Forms;

public class PeopleManager
{
    public int PeopleCount { get; private set; }
    public double TargetTime { get; private set; }

    private PersonCountManager personCountManager = new PersonCountManager();
    private bool _hasHighEndGpu = false;

    public void SetPeople(int count)
    {
        PeopleCount = count;
    }

    public void ResetPeopleCount()
    {
        PeopleCount = 0;
        TargetTime = 0;
    }

    public void ResetTargetTime()
    {
        TargetTime = 0;
    }

    public void SetGpuAdjustment(bool hasGpu)
    {
        _hasHighEndGpu = hasGpu;
        Console.WriteLine($"[DEBUG] GPU Adjustment Set: {(_hasHighEndGpu ? "Enabled" : "Disabled")}");
    }

    public void SetTargetTimeForStep(int step)
    {
        double baseTime = 180; // Default base time (3 minutes)
        double extraTime = _hasHighEndGpu ? 60 : 0; // Add 1 minute if high-end GPU is present
        double totalBaseTime = baseTime + extraTime;

        TargetTime = personCountManager.GetAdjustedTargetTime(step, PeopleCount, totalBaseTime);

        Console.WriteLine($"[DEBUG] Step: {step}, PeopleCount: {PeopleCount}, GPU Adjustment: {extraTime}s, BaseTime with Adjustment: {totalBaseTime}s, Final TargetTime: {TargetTime}s");
    }



    public string GetTargetTimeMessage()
    {
        switch (PeopleCount)
        {
            case 1: return "Target Time: 3Mins!";
            case 2: return "Target Time: 3Mins!";
            case 3: return "Target Time: 4Mins!";
            case 4: return "Target Time: 3Mins!";
            default: return "Click How Many People";
        }
    }

    public void ApplyTargetTimeToUI(UIManager uiManager)
    {
        string formattedTime = $"{(int)(TargetTime / 60)} minutes, {TargetTime % 60} seconds";
        Console.WriteLine($"[DEBUG] Updating UI with TargetTime: {formattedTime}");
        uiManager.SetTargetText($"Target Time: {formattedTime}");
    }


    public void StartStopwatch(StopwatchManager stopwatchManager)
    {
        stopwatchManager.StartWithTarget(TargetTime);
        Console.WriteLine($"[DEBUG] Stopwatch started with TargetTime: {TargetTime}s");
    }
}
