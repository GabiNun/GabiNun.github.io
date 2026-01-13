using System.IO;

class Program
{
    static void Main()
    {
        var Setup = Path.Combine(Directory.GetDirectories(@"C:\Program Files (x86)\Microsoft\Edge\Application")[0], "Installer", "setup.exe");
        var Folder = @"C:\Windows\SystemApps\Microsoft.MicrosoftEdge_8wekyb3d8bbwe";
        
        Directory.CreateDirectory(Folder);
        File.Create(Path.Combine(Folder, "MicrosoftEdge.exe")).Close();

        System.Diagnostics.Process.Start(Setup, "--uninstall --system-level --force-uninstall --delete-profile");
    }
}
