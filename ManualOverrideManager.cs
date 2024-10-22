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
        // Ask the user for the staff code
        string staffCode = Interaction.InputBox("Enter Staff Code", "Manual Override", "");

        // If the staff code is valid
        if (IsValidStaffCode(staffCode))
        {
            // Ask the user if they want to Add, Remove, or Enable Reset Button
            string action = Interaction.InputBox("Enter 1 to Add, 2 to Remove, or 3 to Enable Reset Button", "Manual Override", "");

            //  the actions results
            switch (action)
            {
                case "1":
                    // Add completed builds
                    PerformAddOperation();
                    break;

                case "2":
                    // Remove completed builds
                    PerformRemoveOperation();
                    break;

                case "3":
                    // Enable the Reset Button
                    EnableResetButton();
                    
                    break;

                default:
                    // If invalid 
                    MessageBox.Show("Invalid option. Please enter 1, 2, or 3.", "Error");
                    break;
            }
        }
        else
        {
            // If staff code is invalid, show Access Denied
            MessageBox.Show("Access Denied.", "Error");
        }
    }

    private void EnableResetButton()
    {
        _form.resetBTN.Enabled = true;
        _stopwatchManager.Reset();
        _form.people1.Enabled = false;
        _form.people2.Enabled = false;
        _form.people3.Enabled = false;
        _form.people4.Enabled = false;
        _form.person1.Enabled = false;
        _form.person2.Enabled = false;
        _form.person3.Enabled = false;
        _form.person4.Enabled = false;
    }

    // validate staff codes
    private bool IsValidStaffCode(string staffCode)
    {
        return staffCode == "1003" || staffCode == "1016"; //add more staff codes if authorized 
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
