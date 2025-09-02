using System;
using System.IO;

class Program
{
    static void Main()
    {
        string logFile = @"C:\Users\KNguyen01\Desktop\Testing\log.txt";

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        File.AppendAllText(logFile, timestamp + Environment.NewLine);
        Console.WriteLine("Logged: " + timestamp);

    }
}
