using System;
using System.Windows.Forms;

public class PeopleManager
{
    public int PeopleCount { get; private set; }
    public double TargetTime { get; private set; }

    private PersonCountManager personCountManager = new PersonCountManager();

    // Method to set the number of people working on a task
    public void SetPeople(int count)
    {
        PeopleCount = count;
    }

    // Reset the people count back to zero
    public void ResetPeopleCount()
    {
        PeopleCount = 0;
        TargetTime = 0;
       
    }
    public void ResetTargetTime()
    {
        TargetTime = 0;
    }

    // Method to calculate and set the target time for a specific step
    public void SetTargetTimeForStep(int step)
    {
        // Base target times for each step
        double baseTime = 0;

        switch (step)
        {
            case 1:
                baseTime = 180; // 3 minutes for step 1
                break;
            case 2:
                baseTime = 180; // 3 minutes for step 2
                break;
            case 3:
                baseTime = 180; // 3 minutes for step 3
                break;
            case 4:
                baseTime = 180; // 3 minutes for step 4
                break;
            default:
                baseTime = 180; // Default target time
                break;
        }

        // Apply extra time based on the number of people
        TargetTime = personCountManager.GetAdjustedTargetTime(step, PeopleCount, baseTime);
        

        
    }

    
    public string GetTargetTimeMessage()
    {
        switch (PeopleCount)
        {
            case 1:
                return "Target Time: 3Mins!";
            case 2:
                return "Target Time: 3Mins!";
            case 3:
                return "Target Time: 4Mins!";
            case 4:
                return "Target Time: 3Mins!";
            default:
                return "Click How Many People";
        }
    }

    
    public void ApplyTargetTimeToUI(UIManager uiManager)
    {
        // Convert TargetTime (seconds) into minutes and seconds format
        string formattedTime = $"{(int)(TargetTime / 60)} minutes, {TargetTime % 60} seconds";

        // Pass the formatted time to the UIManager to update the label
        uiManager.SetTargetText($"Target Time: {formattedTime}");

        
    }

    
    public void StartStopwatch(StopwatchManager stopwatchManager)
    {
        stopwatchManager.StartWithTarget(TargetTime);
    }
}
