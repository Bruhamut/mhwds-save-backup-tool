using System;
using System.IO;
using System.IO.Compression;

namespace mhwds_save_backup_tool;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void CreateZipFolder(string directory, string zipPath)
    {
        ZipFile.CreateFromDirectory(directory, zipPath);
    }

    public static void Main()
    {
        string directory = @"C:\Temp\Logs";
        string zipPath = @"C:\Temp\LogFiles.zip";

        CreateZipFolder(directory, zipPath);
    }  
}