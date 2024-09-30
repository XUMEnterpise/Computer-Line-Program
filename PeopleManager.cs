public class PeopleManager
{
    public int PeopleCount { get; private set; }

    public void SetPeople(int count)
    {
        PeopleCount = count;
    }

    public string GetTargetTimeMessage()
    {
        switch (PeopleCount)
        {
            case 1:
                return "Target Time: 10Mins!";
            case 2:
                return "Target Time: 8Mins!";
            case 3:
                return "Target Time: 4.30Mins!";
            case 4:
                return "Target Time: 3Mins!";
            default:
                return "Click How Many People";
        }
    }


    public void ResetPeopleCount()
    {
        PeopleCount = 0;
    }
}
