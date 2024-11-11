using System;

public class PersonCountManager
{
    // Method to get the adjusted target time based on the step and person count
    public double GetAdjustedTargetTime(int step, int person, double baseTargetTime)
    {
        double extraTime = 0;

        switch (step)
        {
            case 1: // Step 1 logic
            case 2: // Step 2 logic
            case 3: // Step 3 logic
            case 4: // Step 4 logic
                switch (person)
                {
                    case 1:
                        extraTime = 540; // 12 minutes
                        break;
                    case 2:
                        extraTime = 180; // 6 minutes
                        break;
                    case 3:
                        extraTime = 60;  // 4 minutes
                        break;
                    case 4:
                        extraTime = 0;   // 3 minutes
                        break;
                    default:
                        extraTime = 0;
                        break;
                }
                break;
            default:
                extraTime = 0;
                break;
        }

        double adjustedTime = baseTargetTime + extraTime;
        Console.WriteLine($"[DEBUG] Step: {step}, Person: {person}, BaseTime: {baseTargetTime}s, ExtraTime: {extraTime}s, AdjustedTime: {adjustedTime}s");
        return adjustedTime;
    }
}
