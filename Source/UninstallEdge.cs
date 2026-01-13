using System.IO;

class Program
{
    static void Main()
    {
        var Setup = Directory.GetFiles(@"C:\Program Files (x86)\Microsoft\Edge\Application", "setup.exe", SearchOption.AllDirectories)[0];
        var UWP = @"C:\Windows\SystemApps\Microsoft.MicrosoftEdge_8wekyb3d8bbwe";
        
        Directory.CreateDirectory(UWP);
        File.Create(Path.Combine(UWP, "MicrosoftEdge.exe")).Close();

        System.Diagnostics.Process.Start(Setup, "--uninstall --system-level --force-uninstall --delete-profile");
    }
}
