using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MaterialSkin;
using Microsoft.VisualBasic;

namespace LineProgram
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private string userId;
        private int numericUserId;
        private PeopleManager _peopleManager;
        private PersonCountManager personCountManager;
        private int _currentStep;
        private ManualOverrideManager _manualOverrideManager;
        private HourlyTargetManager _hourlyTargetManager;
        private SoundManager _soundManager;
        public StopwatchManager _stopwatchManager; //all the stopwatch stuff in the class like start and stop
        private AlarmManager _alarmManager; // alarm class
        private UIManager _uiManager; // ui class
        
        private DataExporter _dataExporter; // export file class, will have functions to export all needed data to the file i make
        private const int TargetCompletedCount = 15;
        private List<BuildData> _buildDataList;
        public int peopleCount;
        //a simple list that should(i hope it works) store average times and stuff, list just makes it easier to export the stuff from the list into the text document i guess

        public Form1()
        {

            InitializeComponent();
            GetValidUserID();
            idbox.Text = $"User ID: {userId}";//for user id

            _peopleManager = new PeopleManager();
            this.KeyPreview = true;
            _soundManager = new SoundManager();
            _stopwatchManager = new StopwatchManager();
            _alarmManager = new AlarmManager(_soundManager);
            InitializeMaterialSkin();
            
            
            _uiManager = new UIManager(this);
            
            
            _dataExporter = new DataExporter();
            
            _manualOverrideManager = new ManualOverrideManager(_stopwatchManager, _uiManager, this); // Initialize ManualOverrideManager
            _buildDataList = new List<BuildData>();

            _stopwatchManager.Elapsed += UpdateUI;
            _stopwatchManager.Elapsed += _alarmManager.CheckAlarm;
            _uiManager.SetTargetText("Click How Many People");
            _uiManager.EnableCompleteButton(false);
            materialButton1.Enabled = false; //manual override button 

            buildbox.SelectedIndexChanged += new EventHandler(Buildbox_SelectedIndexChanged);
            person1.Enabled = false;
            person2.Enabled = false;
            person3.Enabled = false;
            person4.Enabled = false;





        }
        private void Buildbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buildbox.SelectedItem != null)
            {
                // Enable step buttons when a build is selected
                people1.Enabled = false;
                people2.Enabled = false;
                people3.Enabled = false;
                people4.Enabled = false;
                person1.Enabled = true;
                person2.Enabled = true;
                person3.Enabled = true;
                person4.Enabled = true;
            }
        }
        private void notselectbuildbox()
        {
            if (buildbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a build", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void GetValidUserID()
        {
            bool isValid = false;
            while (!isValid)
            {
                userId = Interaction.InputBox("Please enter your Id", "User ID");
                if (int.TryParse(userId, out numericUserId) && numericUserId >= 1000 && numericUserId <= 2000)
                {
                    isValid = true;  
                }
                else
                {
                    //Invalid ID
                    MessageBox.Show("Invalid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void InitializeMaterialSkin()
        {
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, Accent.Red100, TextShade.WHITE);
        }

     
        private void UpdateUI(object sender, EventArgs e)//updates the information on the form
        {
            _uiManager.UpdateStopwatchDisplay(_stopwatchManager.TotalTime, _stopwatchManager.AverageTime, _stopwatchManager.BestTime);
        }

        
        private void startBTN_Click(object sender, EventArgs e) //start stopwatch
        {
            
            if (_peopleManager.PeopleCount == 0)
            {
                MessageBox.Show("What step are you on?"); //some error checking stops them from starting it without setting the right people count
            }
            else
            {
                _stopwatchManager.Start();
                
                
            }
        }

        
        private void pauseBTN_Click(object sender, EventArgs e) //pause timer
        {
            _stopwatchManager.Pause();
        }

        
        private void resetBTN_Click(object sender, EventArgs e)
        {
            _peopleManager.ResetTargetTime();
            _peopleManager.ResetPeopleCount();
            // Disable control buttons
            startBTN.Enabled = false;
            CompleteBTN.Enabled = false;
            pauseBTN.Enabled = false;
            unpauseBTN.Enabled = false;
            person1.Enabled = false;
            person2.Enabled = false;
            person3.Enabled = false;
            person4.Enabled = false;
            people1.Enabled = false;
            people2.Enabled = false;
            people3.Enabled = false;
            people4.Enabled = false;
            _stopwatchManager.Reset();

            // Clear the target time label
            target.Text = "00:00:00";
            


            _soundManager.StopAlarmSound();
            if (_peopleManager.PeopleCount == 0) //reset everything
            {
                MessageBox.Show("What step are you on?");
            }
            else
            {
                _stopwatchManager.Reset(); // reset clock
                _peopleManager.ResetPeopleCount(); // reset how many people so they can select again, someone might leave the line
                _uiManager.ResetPeopleSelection(); // makes all the buttons enabled again so can change how many people
                _uiManager.ResetPeopleOnline();
                _uiManager.UpdateCompletedCount(0); // sets completed to 0 no cheating
                _uiManager.EnableCompleteButton(false); // so they cant bug the program again and make it start the timer without setting the right people count
                resetbehindtarget();
                disablemanual();
            }
        }

        
        private void unpauseBTN_Click(object sender, EventArgs e)
        {
            _stopwatchManager.Resume(); //unpause
        }

        private string currentBuildID;
        private void CompleteBTN_Click(object sender, EventArgs e)
        {
            CompleteComputer();
            if (string.IsNullOrEmpty(currentBuildID))
            {
                currentBuildID = scanBuild.Text;  // Get the build ID from the scanbuild textbox
            }

            // Ensure the build ID valid
            if (!string.IsNullOrEmpty(currentBuildID) && currentBuildID.Length >= 6)
            {
                
                CompleteComputer();

                // Clear the build ID
                currentBuildID = null;
                scanBuild.Clear();  
            }


            if (_soundManager != null)
            {
                _soundManager.StopAlarmSound();
            }
        }


        private void CompleteComputer()
        {
            BehindTargetLabel();
            string selectedBuild = buildbox.SelectedItem.ToString();
            double totalTime = _stopwatchManager.TotalTime; // Capture TotalTime before it is reset
            double targetTime = _peopleManager.TargetTime;
            if (totalTime <= targetTime && targetTime > 0)
            {
                
                _soundManager.PlaySuccessLapSound(); // Play success sound for lap completion
            }
            else
            {
                
                _soundManager.PlayFailLapSound(); // Play fail sound for lap completion
            }

            _stopwatchManager.CompleteLap(); // After using TotalTime, record the lap and reset the stopwatch

            // Store the build data
            BuildData buildData = new BuildData
            {
                Completed = _stopwatchManager.CompletedLaps,
                AverageTime = _stopwatchManager.AverageTime,
                BestTime = _stopwatchManager.BestTime,
                Build = selectedBuild,
                PcID = currentBuildID


            };

            _buildDataList.Add(buildData);
            _uiManager.UpdateCompletedCount(_stopwatchManager.CompletedLaps); // Update the completed count in the UI
        }


        private void ExportData()
        {
            if (_currentStep == 0)
            {
                MessageBox.Show("Please select a step before exporting data.", "Error");
                return;
            }

            string datePart = DateTime.Now.ToString("dd-MM-yyyy"); // DATE
            string fileName = $"step{_currentStep}-{datePart}.txt"; // filename
            string selectedBuild = buildbox.SelectedItem.ToString();

            _dataExporter.Export(fileName, _buildDataList, _currentStep, userId);
            
        }




        private void exportdata_Click(object sender, EventArgs e) // exports build list information to a text file with a clean format easier to read and could be usefull to add to a excel spreadsheet and be able to see all the information for the week
        {
        ExportData();
        }

       
        private void people1_Click(object sender, EventArgs e) //how many people buttons
        {


            if (buildbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a build ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                enablemanual();
                _currentStep = 1;
                _stopwatchManager.StartWithTarget(180);
                int step = 1;
                
                _peopleManager.SetPeople(peopleCount);
                _peopleManager.SetTargetTimeForStep(step);
                _peopleManager.ApplyTargetTimeToUI(_uiManager);
            }
            
        }

        private void people2_Click(object sender, EventArgs e)
        {
            if (buildbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a build ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int step = 2;
                
                _peopleManager.SetPeople(peopleCount);
                _peopleManager.SetTargetTimeForStep(step);
                _peopleManager.ApplyTargetTimeToUI(_uiManager);

                enablemanual();
                _currentStep = 2;
                _stopwatchManager.StartWithTarget(180);
            }
            
        }

        private void people3_Click(object sender, EventArgs e) // how many people buttons
        {
            if (buildbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a build ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                enablemanual();
                _currentStep = 1;

                // Start the stopwatch with 3-minute target (180 seconds)
                _stopwatchManager.StartWithTarget(180);  // Ensure _stopwatchManager is not null here

                int step = 3;
                

                // Set people count and target time in peopleManager
                _peopleManager.SetPeople(peopleCount);
                _peopleManager.SetTargetTimeForStep(step);

                // Apply the target time to the UI
                _peopleManager.ApplyTargetTimeToUI(_uiManager);

            }
                


                
             
        }


        private void people4_Click(object sender, EventArgs e)
        {
            
            if (buildbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a build", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int step = 4;
                
                _peopleManager.SetPeople(peopleCount);
                _peopleManager.ApplyTargetTimeToUI(_uiManager);
                enablemanual();
                _stopwatchManager.StartWithTarget(180);
            }
            
        }

        
        private void SetPeople(int count) //set people method so i dont repeat over and over, just cleaner
        {
            _peopleManager.SetPeople(count);
            string targetMessage = _peopleManager.GetTargetTimeMessage(); // the target will be set on how many people
            _uiManager.SetTargetText(targetMessage); // changes the labe to the target
            _uiManager.SetPeopleSelectionButtons(count); // the people buttons will be enabled / disabled, good for reset button when we needed to enable them and start when we want them disabled
            _uiManager.EnableCompleteButton(true); // complete button will be enabled, when its false it will be disabled and wont be able to bug the program and star it without setting people count which wouldnt set off an alarm
        }

        private void stopwatch_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            _manualOverrideManager.HandleManualOverride();
        }
        public void BehindTargetLabel()
        {
            int completedCount = _stopwatchManager.CompletedLaps;
            int behindCount = TargetCompletedCount - completedCount;

            if (behindCount > 0)
            {
                behindlbl.Text = $"Behind Target: {behindCount}";
                behindlbl.ForeColor = Color.Red;
            }
            else
            {
                behindlbl.Text = "On Target or Ahead";
                behindlbl.ForeColor = Color.Green;
            }
        }

        public void resetbehindtarget()
        {
            behindlbl.Text = "Behind Target: 0";

        }
        public void enablemanual()
        {
            materialButton1.Enabled = true;
        }
        public void disablemanual()
        {
            materialButton1.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                CompleteBTN.PerformClick(); 
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                pauseBTN.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                unpauseBTN.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
                {
                resetBTN.PerformClick();
                }


        }

        private void target_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void person2_Click(object sender, EventArgs e)
        {
            peopleCount = 2;
            if (buildbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a build ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UpdateTargetTimeAndEnableButtons(2);  // Person 2 selected
                _uiManager.DisableOtherPersonButtons(2);
                _peopleManager.SetPeople(2);
                _peopleManager.SetTargetTimeForStep(_currentStep);
            }
        }

        private void bestTimelbl_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTargetTimeAndEnableButtons(int selectedPerson)
        {
            // Set people count in PeopleManager
            _peopleManager.SetPeople(selectedPerson);

            // Adjust target time for the current step
            _peopleManager.SetTargetTimeForStep(_currentStep);

            // Calculate minutes and seconds
            int minutes = (int)(_peopleManager.TargetTime / 60);
            int seconds = (int)(_peopleManager.TargetTime % 60);

            // Create a user-friendly message
            string targetTimeMessage = $"Target Time: {minutes} minute{(minutes != 1 ? "s" : "")}";
            if (seconds > 0)
            {
                targetTimeMessage += $" {seconds} second{(seconds != 1 ? "s" : "")}";
            }

            // Update the target time label with the new message
            target.Text = targetTimeMessage;

            // Enable step buttons once a person is selected
            people1.Enabled = true;
            people2.Enabled = true;
            people3.Enabled = true;
            people4.Enabled = true;

            // Enable other buttons (start, complete, etc.)
            startBTN.Enabled = true;
            CompleteBTN.Enabled = true;
            pauseBTN.Enabled = true;
            unpauseBTN.Enabled = true;
        }



        private void person1_Click(object sender, EventArgs e)
        {
            peopleCount = 1;
            if (buildbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a build ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UpdateTargetTimeAndEnableButtons(1);  // Person 1 selected
                _uiManager.DisableOtherPersonButtons(1);
                _peopleManager.SetPeople(1);
                _peopleManager.SetTargetTimeForStep(_currentStep);
            }
        }

        private void person3_Click(object sender, EventArgs e)
        {
            peopleCount = 3;
            if (buildbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a build ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UpdateTargetTimeAndEnableButtons(3);  // Person 3 selected
                _uiManager.DisableOtherPersonButtons(3);
                _peopleManager.SetPeople(3);
                _peopleManager.SetTargetTimeForStep(_currentStep);
            }
        }

        private void person4_Click(object sender, EventArgs e)
        {

            peopleCount = 4;
            if (buildbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a build ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UpdateTargetTimeAndEnableButtons(4);  // Person 4 selected
                _uiManager.DisableOtherPersonButtons(4);
                _peopleManager.SetPeople(4);
                _peopleManager.SetTargetTimeForStep(_currentStep);
            }
        }

        private void scanBuild_TextChanged(object sender, EventArgs e)
        {
            string buildID = scanBuild.Text;
            if (buildID.Length >=5)
            {
                CompleteBTN_Click(sender, e);
                scanBuild.Clear();
            }
            
        }
    }
}
