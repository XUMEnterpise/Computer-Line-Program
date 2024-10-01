using System;
using System.Windows.Forms;
using LineProgram;
using Microsoft.VisualBasic;

public class ManualOverrideManager
{
    public StopwatchManager _stopwatchManager;
    public UIManager _uiManager;

    private Form1 _form;
    public ManualOverrideManager(StopwatchManager stopwatchManager, UIManager uiManager, Form1 form)
    {
        _stopwatchManager = stopwatchManager;
        _uiManager = uiManager;
        _form = form;
    }

    
    public void HandleManualOverride()
    {
        //ask user staff code
        string staffCode = Interaction.InputBox("Enter Staff Code", "Manual Override", "");

        // if staff code is what we allow
        if (IsValidStaffCode(staffCode))
        {
            // do they want to add or remove
            DialogResult result = MessageBox.Show("Yes for Add : No for Remove", "Manual Override",
                                                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes) // Add completed builds
            {
                PerformAddOperation();
            }
            else if (result == DialogResult.No) // Remove completed builds
            {
                PerformRemoveOperation();
            }
        }
        else
        {
            // if staff code invalid, no access
            MessageBox.Show("Access Denied.", "Error");
        }
    }

    // validate staff codes
    private bool IsValidStaffCode(string staffCode)
    {
        return staffCode == "1003" || staffCode == "1016";
    }

    // add completed builds
    private void PerformAddOperation()
    {
        string input = Interaction.InputBox("Enter the number of computers to add:", "Add Completed Builds", "0");

        if (int.TryParse(input, out int computersToAdd) && computersToAdd > 0)
        {
            _stopwatchManager.CompletedLaps += computersToAdd;
            _uiManager.UpdateCompletedCount(_stopwatchManager.CompletedLaps); // Update computer lbl
            MessageBox.Show($"{computersToAdd} computers added successfully!", "Success");
            _form.BehindTargetLabel();
        }
        else
        {
            MessageBox.Show("Invalid input. Please make sure you are entering a number.", "Error"); //error handling
        }
    }

    // remove completed builds
    private void PerformRemoveOperation()
    {
        string input = Interaction.InputBox("Enter the number of computers to remove:", "Remove Completed Builds", "0");

        if (int.TryParse(input, out int computersToRemove) && computersToRemove > 0)
        {
            if (_stopwatchManager.CompletedLaps >= computersToRemove)
            {
                _stopwatchManager.CompletedLaps -= computersToRemove;
                _uiManager.UpdateCompletedCount(_stopwatchManager.CompletedLaps); // update lablsd
                MessageBox.Show($"{computersToRemove} computers removed successfully!", "Success");
                _form.BehindTargetLabel();
            }
            else
            {
                MessageBox.Show("You cannot remove more computers than there are completed", "Error"); //error handling 
            }
        }
        else
        {
            MessageBox.Show("Invalid input. Please make sure you are entering a number", "Error");
        }
    }
}
