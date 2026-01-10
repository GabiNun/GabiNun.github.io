using System.IO;

class Program
{
    static void Main()
    {
        var setup = Directory.GetFiles(@"C:\Program Files (x86)\Microsoft\Edge\Application", "setup.exe", SearchOption.AllDirectories)[0];
        var directoryPath = @"C:\Windows\SystemApps\Microsoft.MicrosoftEdge_8wekyb3d8bbwe";
        
        Directory.CreateDirectory(directoryPath);
        File.Create(Path.Combine(directoryPath, "MicrosoftEdge.exe")).Close();

        System.Diagnostics.Process.Start(setup, "--uninstall --system-level --force-uninstall --delete-profile");
    }
}
