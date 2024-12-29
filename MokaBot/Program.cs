using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Get the current date and time in ISO 8601 format
        string currentTime = DateTime.UtcNow.ToString("o");

        // Emit the output using GITHUB_OUTPUT
        string githubOutputFile = Environment.GetEnvironmentVariable("GITHUB_OUTPUT");
        if (!string.IsNullOrEmpty(githubOutputFile))
        {
            File.AppendAllText(githubOutputFile, $"date_time={currentTime}{Environment.NewLine}");
        }

        // Print the time for container logs (optional)
        Console.WriteLine($"Current time: {currentTime}");
    }
}