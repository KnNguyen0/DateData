using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string exePath = @"C:\Users\KNguyen01\Desktop\Testing\DataLogger.exe"; // <-- Update this path
        if (File.Exists(exePath))
        {
            Process.Start(exePath);
            Console.WriteLine("Launched DateLogger.exe");
        }
        else
        {
            Console.WriteLine("Executable not found: " + exePath);
        }
    }
}
