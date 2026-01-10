using System.IO;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Directory.CreateDirectory(@"C:\Windows\SystemApps\Microsoft.MicrosoftEdge_8wekyb3d8bbwe");
        File.Create(@"C:\Windows\SystemApps\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\MicrosoftEdge.exe").Close();

        var setup = Directory.GetFiles(@"C:\Program Files (x86)\Microsoft\Edge\Application", "setup.exe", SearchOption.AllDirectories)[0];

        Process.Start(setup, "--uninstall --system-level --force-uninstall --delete-profile");
    }
}
