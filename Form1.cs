using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;

namespace LineProgram
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        
        private StopwatchManager _stopwatchManager; //all the stopwatch stuff in the class like start and stop
        private AlarmManager _alarmManager; // alarm class
        private UIManager _uiManager; // ui class
        private PeopleManager _peopleManager; // people class, manages how many people on the line and sets the right stuff like timer , target time , etc
        private DataExporter _dataExporter; // export file class, will have functions to export all needed data to the file i make

        private List<BuildData> _buildDataList;            //a simple list that should(i hope it works) store average times and stuff, list just makes it easier to export the stuff from the list into the text document i guess

        public Form1()
        {
            InitializeComponent();
            InitializeMaterialSkin();
            _stopwatchManager = new StopwatchManager();
            _alarmManager = new AlarmManager();
            _uiManager = new UIManager(this);
            _peopleManager = new PeopleManager();
            _dataExporter = new DataExporter();
            _buildDataList = new List<BuildData>();
            _stopwatchManager.Elapsed += UpdateUI; // everytime the timer is ticked, everything needed will update like lable text, this should be a faster way that manually doing it
            _stopwatchManager.Elapsed += _alarmManager.CheckAlarm; // checks alarm, so if the alarm is needed when the stopwatch goes to a certain time lets say 3mins
            _uiManager.SetTargetText("Click How Many People"); // couldnt be bothered repeating this over and over, so might as well make a function for it
            _uiManager.EnableCompleteButton(false); // a issue i noticed was when the completed button was pressed, it completely ignored if how many people was pressed, gonna end up breaking the program at some point, so might as well fix it he
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
                MessageBox.Show("PICK HOW MANY PEOPLE ON LINE!"); //some error checking stops them from starting it without setting the right people count
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
            if (_peopleManager.PeopleCount == 0) //reset everything
            {
                MessageBox.Show("PICK HOW MANY PEOPLE ON LINE!");
            }
            else
            {
                _stopwatchManager.Reset(); // reset clock
                _peopleManager.ResetPeopleCount(); // reset how many people so they can select again, someone might leave the line, i seen it happen, matt.
                _uiManager.ResetPeopleSelection(); // makes all the buttons enabled again so can change how many people
                _uiManager.UpdateCompletedCount(0); // sets completed to 0 no cheating
                _uiManager.EnableCompleteButton(false); // so they cant bug the program again and make it start the timer without setting the right people count
            }
        }

        
        private void unpauseBTN_Click(object sender, EventArgs e)
        {
            _stopwatchManager.Unpause(); //unpause
        }

        
        private void CompleteBTN_Click(object sender, EventArgs e)
        {
            CompleteComputer(); //complete button
        }

        
        private void CompleteComputer() //everytime a build is completed, it will store the information like average time, best time  into build list, for exporting later
        {
            _stopwatchManager.CompleteLap(); // every build will be counted as a lap, so if 100 builds is done, its like 100 laps, so it knows a build has been completed
            BuildData buildData = new BuildData
            {
                Completed = _stopwatchManager.CompletedLaps,
                AverageTime = _stopwatchManager.AverageTime,
                BestTime = _stopwatchManager.BestTime
            };

            _buildDataList.Add(buildData); // all the data should be stored into the list above, in the future i guess the list could maybe be a database and the two programs from step 4 and step 1 could be linked, so error checking added such as features like matt suggested
            _uiManager.UpdateCompletedCount(_stopwatchManager.CompletedLaps); // changes the completed count with how many builds /laps have been done
        }

        
        private void exportdata_Click(object sender, EventArgs e) // exports build list information to a text file with a clean format easier to read and could be usefull to add to a excel spreadsheet and be able to see all the information for the week
        {
            _dataExporter.ExportData(_buildDataList); // writes the list to the file
        }

       
        private void people1_Click(object sender, EventArgs e) //how many people buttons
        {
            SetPeople(1);
        }

        private void people2_Click(object sender, EventArgs e)
        {
            SetPeople(2);
        }

        private void people3_Click(object sender, EventArgs e)
        {
            SetPeople(3);
        }

        private void people4_Click(object sender, EventArgs e)
        {
            SetPeople(4);
        }

        
        private void SetPeople(int count) //set people method so i dont repeat over and over, just cleaner
        {
            _peopleManager.SetPeople(count);
            string targetMessage = _peopleManager.GetTargetTimeMessage(); // the target will be set on how many people
            _uiManager.SetTargetText(targetMessage); // changes the labe to the target
            _uiManager.SetPeopleSelectionButtons(count); // the people buttons will be enabled / disabled, good for reset button when we needed to enable them and start when we want them disabled
            _uiManager.EnableCompleteButton(true); // complete button will be enabled, when its false it will be disabled and wont be able to bug the program and star it without setting people count which wouldnt set off an alarm
        }
    }
}
