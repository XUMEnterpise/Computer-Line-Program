using LineProgram;
using System.Drawing;
using System;

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
        _form.people1.Enabled = true;
        _form.people2.Enabled = true;
        _form.people3.Enabled = true;
        _form.people4.Enabled = true;
        SetTargetText("What step are you on?");
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
            _form.stopwatch.Text = $"{totalTime:F2} seconds";
            _form.averageTimelbl.Text = $"Average Time:{averageTime:F2} seconds";
            _form.bestTimelbl.Text = $"Best Time: {bestTime:F2} seconds";
            _form.bestTimelbl.ForeColor = Color.Green;
        }
    }

    public void UpdateCompletedCount(int count)
    {
        _form.Completedlbl.Text = $"Completed: {count}";
    }
}
