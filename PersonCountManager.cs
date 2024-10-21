using System;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.Design;
using System.Windows.Forms;

public class PersonCountManager
{

    
    // Method to get the adjusted target time based on the step and person count
    public double GetAdjustedTargetTime(int step, int person, double baseTargetTime)
    {
        double extraTime = 0;

        switch (step)
        {
            case 1: //step 1
                if (person==1)
                {
                    extraTime = 540; //12mins total 
                    
                }
                if (person==2)
                {
                    extraTime = 180; //6mins total
                }
                if (person==3)
                {
                    extraTime = 60; //4mins total
                }
                if (person==4)
                {
                    extraTime = 0; //3mins total
                }
                break;


            case 2: //step 2
                if (person == 1)
                {
                    extraTime = 540; //12mins total 

                }
                if (person == 2)
                {
                    extraTime = 180; //6mins total
                }
                if (person == 3)
                {
                    extraTime = 60; //4mins total
                }
                if (person == 4)
                {
                    extraTime = 0; //3mins total
                }
                break;

            case 3: //step 3
                if (person == 1)
                {
                    extraTime = 540; //12mins total 

                }
                if (person == 2)
                {
                    extraTime = 180; //6mins total
                }
                if (person == 3)
                {
                    extraTime = 60; //4mins total
                }
                if (person == 4)
                {
                    extraTime = 30; //3mins 30 total
                }
                break;

            case 4: //step 4
                if (person == 1)
                {
                    extraTime = 540; //12mins total 

                }
                if (person == 2)
                {
                    extraTime = 180; //6mins total
                }
                if (person == 3)
                {
                    extraTime = 30; //4mins total
                }
                if (person == 4)
                {
                    extraTime = 0; //3mins 30 total
                }
                break;

            default:
                break;
        }

        
        

        // Return the base target time plus the extra time
        return baseTargetTime + extraTime;
    }
}
