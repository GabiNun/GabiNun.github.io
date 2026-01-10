using System;
using System.IO;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string directoryPath = @"C:\Windows\SystemApps\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\";
        System.IO.Directory.CreateDirectory(directoryPath);

        string filePath = System.IO.Path.Combine(directoryPath, "MicrosoftEdge.exe");
        System.IO.File.Create(filePath).Close();
         
        var setup = System.Linq.Enumerable.First(
            Directory.EnumerateFiles(@"C:\Program Files (x86)\Microsoft\Edge\Application", "setup.exe", SearchOption.AllDirectories)
        );

        Process.Start(setup, "--uninstall --system-level --force-uninstall --delete-profile");    
    }
}