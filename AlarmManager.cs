using System;
using System.Collections.Generic;
using System.IO;

namespace LineProgram
{
    public class AlarmManager
    {
        private readonly Dictionary<int, int> _peopleTimeThresholds;
        private readonly System.Media.SoundPlayer _player;

        public AlarmManager()
        {
            _peopleTimeThresholds = new Dictionary<int, int>
            {
                { 1, 600 }, // 10 minutes
                { 2, 480 }, // 8 minutes
                { 3, 240 }, // 4 minutes
                { 4, 200 }  // 3 minutes
            };
            _player = new System.Media.SoundPlayer(Path.Combine(Directory.GetCurrentDirectory(), @"alarm.wav"));
        }

        public void CheckAlarm(object sender, EventArgs e)
        {
            StopwatchManager stopwatchManager = sender as StopwatchManager;

            if (stopwatchManager == null || !_peopleTimeThresholds.ContainsKey(stopwatchManager.PeopleCount)) return;

            if (stopwatchManager.TotalTime >= _peopleTimeThresholds[stopwatchManager.PeopleCount])
            {
                _player.PlayLooping();
            }
        }

        public void StopAlarm()
        {
            _player.Stop();
        }
    }
}
