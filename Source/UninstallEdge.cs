using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = @"C:\Windows\SystemApps\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\";
        System.IO.Directory.CreateDirectory(directoryPath);

        string filePath = Path.Combine(directoryPath, "MicrosoftEdge.exe");
        File.Create(filePath).Close();
         
        var setup = System.Linq.Enumerable.First(Directory.EnumerateFiles(@"C:\Program Files (x86)\Microsoft\Edge\Application", "setup.exe", SearchOption.AllDirectories));

        System.Diagnostics.Process.Start(setup, "--uninstall --system-level --force-uninstall --delete-profile");    
    }

}
