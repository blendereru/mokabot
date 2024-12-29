using System;

class Program
{
    static void Main()
    {
        // Get the current date and time in ISO 8601 format
        string currentTime = DateTime.UtcNow.ToString("o");

        // Emit the output for GitHub Actions
        Console.WriteLine($"::set-output name=date_time::{currentTime}");
    }
}