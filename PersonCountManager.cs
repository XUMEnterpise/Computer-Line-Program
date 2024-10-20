using System;
using System.Windows.Forms;

public class PersonCountManager
{
    // Method to get the adjusted target time based on the step and person count
    public double GetAdjustedTargetTime(int step, int person, double baseTargetTime)
    {
        double extraTime = 0;

        switch (step)
        {
            case 1:
                if (person == 1 || person == 2)
                    extraTime = 20; // 20 seconds for person 1 and 2
                break;

            case 2:
                if (person == 1 || person == 2)
                    extraTime = 30; // 30 seconds for person 1 and 2
                break;

            case 3:
                if (person == 1)
                    extraTime = 60; // 1 minute for person 1
                else if (person == 2 || person == 3)
                    extraTime = 35; // 35 seconds for person 2 and 3
                break;

            case 4:
                if (person == 1)
                    extraTime = 30; // 30 seconds for person 1
                break;

            default:
                break;
        }
        

        // Return the base target time plus the extra time
        return baseTargetTime + extraTime;
    }
}
