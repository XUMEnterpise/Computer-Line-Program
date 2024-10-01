public class PeopleManager
{
    public int PeopleCount { get; private set; }
    public double TargetTime { get; private set; }

    public void SetPeople(int count)
    {
        PeopleCount = count;
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
    public void SetTargetTimeForStep(int step)
    {
        switch (step)
        {
            case 1:
                TargetTime = 180; // step 1 3mins
                break;
            case 2:
                TargetTime = 180; // STEP 2 3mins
                break;
            case 3:
                TargetTime = 240; //step 3 4mins
                break;
            case 4:
                TargetTime = 180; //step 4 4min
                break;

            default:
                TargetTime = 0; // Default or reset value
                break;
        }
    }


        public void ResetPeopleCount()
    {
        PeopleCount = 0;
    }
}
