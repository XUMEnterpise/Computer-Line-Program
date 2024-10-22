using LineProgram;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

public class DataExporter
{
    private UIManager _uiManager;

    public DataExporter(UIManager uiManager)
    {
        _uiManager = uiManager;
    }

    public void ExportAsHtml(string fileName, List<BuildData> buildDataList, int currentStep, string userId,int peopleCount)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Start HTML structure
                writer.WriteLine("<html>");
                writer.WriteLine("<head>");
                writer.WriteLine("<title>Build Export</title>");

                // Add basic styles for background and formatting
                writer.WriteLine("<style>");
                writer.WriteLine("body { font-family: Arial, sans-serif; background-color: #f0f0f0; padding: 20px; }");
                writer.WriteLine("table { width: 100%; border-collapse: collapse; margin-bottom: 20px; }");
                writer.WriteLine("th, td { border: 1px solid #ddd; padding: 8px; text-align: center; }");
                writer.WriteLine("th { background-color: #4CAF50; color: white; }");
                writer.WriteLine("tr:nth-child(even) { background-color: #f2f2f2; }");
                writer.WriteLine("h1 { color: #333; }");
                writer.WriteLine("</style>");

                writer.WriteLine("</head>");
                writer.WriteLine("<body>");

                // Title and summary
                writer.WriteLine($"<h1>Export Summary for User ID: {userId}</h1>");
                writer.WriteLine($"<p>Step: {currentStep}</p>");
                writer.WriteLine($"<p>People on Line: {peopleCount}</p>");
                writer.WriteLine($"<p>Date: {DateTime.Now:dd/MM/yyyy HH:mm:ss}</p>");

                // Start Table
                writer.WriteLine("<table>");
                writer.WriteLine("<tr>");
                writer.WriteLine("<th>Build Number</th>");
                writer.WriteLine("<th>Build ID</th>");
                writer.WriteLine("<th>Total Time</th>");
                writer.WriteLine("<th>Target Time</th>");
                writer.WriteLine("<th>Average Time</th>");
                writer.WriteLine("<th>Best Time</th>");
                writer.WriteLine("</tr>");

                //populate the table
                int buildNumber = 1;
                foreach (var buildData in buildDataList)
                {
                    writer.WriteLine("<tr>");
                    writer.WriteLine($"<td>{buildNumber}</td>");
                    writer.WriteLine($"<td>{buildData.Build}</td>");
                    writer.WriteLine($"<td>{FormatTime(buildData.TotalTime)}</td>");
                    writer.WriteLine($"<td>{FormatTime(buildData.TargetTime)}</td>");
                    writer.WriteLine($"<td>{FormatTime(buildData.AverageTime)}</td>");
                    writer.WriteLine($"<td>{FormatTime(buildData.BestTime)}</td>");
                    writer.WriteLine("</tr>");

                    buildNumber++;
                }

                writer.WriteLine("</table>");

                // End HTML 
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }

            // Automatically open 
            Process.Start(new ProcessStartInfo(fileName) { UseShellExecute = true });

            MessageBox.Show($"Data successfully exported to {fileName}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to export data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private string FormatTime(double totalSeconds)
    {
        TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
        return time.ToString(@"hh\:mm\:ss");
    }
}
