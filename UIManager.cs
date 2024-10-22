using LineProgram;
using System.Drawing;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class UIManager
{
    private Form1 _form;
    

    public UIManager(Form1 form)
    {
        _form = form;
    }

    public void SetTargetText(string text)
    {
        _form.target.Text = text;
        
    }


    public void ResetPeopleSelection()
    {
        _form.people1.Enabled = false;
        _form.people2.Enabled = false;
        _form.people3.Enabled = false;
        _form.people4.Enabled = false; 
        SetTargetText("What step are you on?");
    }
    public void ResetPeopleOnline()
    {
        _form.person1.Enabled = true;
        _form.person2.Enabled = true;
        _form.person3.Enabled = true;
        _form.person4.Enabled = true;
    }

    public void SetPeopleSelectionButtons(int count)
    {
        _form.people1.Enabled = count == 1;
        _form.people2.Enabled = count == 2;
        _form.people3.Enabled = count == 3;
        _form.people4.Enabled = count == 4;
    }

    public void EnableCompleteButton(bool enable)
    {
        _form.CompleteBTN.Enabled = enable;
    }

    public void UpdateStopwatchDisplay(double totalTime, double averageTime, double bestTime)
    {

        if (_form.InvokeRequired)
        {
            _form.Invoke(new Action(() => UpdateStopwatchDisplay(totalTime, averageTime, bestTime)));
        }
        else
        {
            string formattedAverageTime = FormatTime(averageTime);
            string formattedBestTime = FormatTime(bestTime);//format

            _form.stopwatch.Text = _form._stopwatchManager.GetFormattedTime();
            _form.averageTimelbl.Text = $"Average Time: {formattedAverageTime}";
            _form.bestTimelbl.Text = $"Best Time: {formattedBestTime}"; //the new formatted times in 00:00:00
            _form.bestTimelbl.ForeColor = Color.Green;
        }
    }

    public string FormatTime(double totalSeconds) //format function so put the function "FormatTime(The Variable e.g. besttime) 
    {
        // Convert the total seconds to a TimeSpan
        TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

        // Format 
        return time.ToString(@"hh\:mm\:ss");
    }

    public void UpdateCompletedCount(int count)
    {
        _form.Completedlbl.Text = $"Completed: {count}";
    }

    public void DisableOtherPersonButtons(int selectedPerson)
    {
        // Enable only the selected person button, disable the rest
        switch (selectedPerson)
        {
            case 1:
                _form.person1.Enabled = true;
                _form.person2.Enabled = false;
                _form.person3.Enabled = false;
                _form.person4.Enabled = false;
                break;
            case 2:
                _form.person1.Enabled = false;
                _form.person2.Enabled = true;
                _form.person3.Enabled = false;
                _form.person4.Enabled = false;
                break;
            case 3:
                _form.person1.Enabled = false;
                _form.person2.Enabled = false;
                _form.person3.Enabled = true;
                _form.person4.Enabled = false;
                break;
            case 4:
                _form.person1.Enabled = false;
                _form.person2.Enabled = false;
                _form.person3.Enabled = false;
                _form.person4.Enabled = true;
                break;
        }
    }


}
