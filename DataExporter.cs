using LineProgram;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

public class DataExporter
{
    // Method to export data to a TXT file in the program's directory
    public void Export(string fileName, List<BuildData> data, int currentStep)
    {
        try
        {
            // Combine the file name with the program's directory
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            // Use StreamWriter to write the data to a TXT file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write headers and general information
                writer.WriteLine("Export Summary");
                writer.WriteLine("Step: " + currentStep);
                writer.WriteLine("Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); //found this online, makes the text document look fancy
                writer.WriteLine("----------------------------------------");
                writer.WriteLine("Build Number\tCompleted\tAverage Time\tBest Time");
                writer.WriteLine("----------------------------------------");

                // Writing the data for each build
                int buildNumber = 1;
                foreach (var buildData in data)
                {
                    writer.WriteLine($"{buildNumber}\t\t{buildData.Completed}\t\t{buildData.AverageTime}\t\t{buildData.BestTime}");
                    buildNumber++;
                }
            }

            // Notify the user that the export was successful
            MessageBox.Show($"Data successfully exported to: {filePath}", "Export Success");
        }
        catch (Exception ex)
        {
            // Handle any errors that occur during the file write process
            MessageBox.Show($"Failed to export data. Error: {ex.Message}", "Export Error");
        }
    }
}
