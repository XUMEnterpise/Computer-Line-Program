using LineProgram;
using System.Collections.Generic;
using System;
using System.IO;
using System.Windows.Forms;

public class DataExporter
{
    public void ExportData(List<BuildData> buildDataList)
    {
        string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
        string fileName = $"{DateTime.Now:yyyy-MM-dd}.txt";
        string filePath = Path.Combine(directoryPath, fileName);

        using (StreamWriter writer = File.CreateText(filePath))
        {
            foreach (BuildData buildData in buildDataList)
            {
                writer.WriteLine($"Build {buildData.Completed}:");
                writer.WriteLine($"\tCompleted: {buildData.Completed}");
                writer.WriteLine($"\tAverage Time: {buildData.AverageTime}");
                writer.WriteLine($"\tBest Time: {buildData.BestTime}");
                writer.WriteLine();
            }
        }

        MessageBox.Show($"Data exported to {filePath}");
    }
}
