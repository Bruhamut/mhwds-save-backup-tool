using System;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace mhwds_save_backup_tool;

 //2246340

public static class SteamSavePath
{
    public static string GetSavePath()
    {
        string baseSteamPath = @$"C:\Program Files (x86)\Steam\userdata\";

        string[] userDirs = Directory.GetDirectories(baseSteamPath);

        string userID = Path.GetFileName(userDirs[0]);

        string savePath = Path.Combine(baseSteamPath, userID, "2246340", "remote", "win64_save");

        return savePath;
    }
}

public class Program
{
    public static string savePath = SteamSavePath.GetSavePath();
    public static string backupFolderPath = @"C:\Temp";

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>

    public static void CreateZipBackup(string savePath)
    {
        DateTime currentDT = DateTime.Now;
        string formattedDT = currentDT.ToString("MM-dd-yyyy HH_mm_ss");
        string zipPath = Path.Combine(backupFolderPath, @$"{formattedDT}.zip");

        // Create zip file and update with files to be copied
        using (FileStream ZipFile = new FileStream(zipPath, FileMode.Create))
        using (ZipArchive archive = new ZipArchive(ZipFile, ZipArchiveMode.Update))
        {
            string[] files = Directory.GetFiles(savePath, "*.bin");
            foreach (var file in files)
            {   
                var entry = archive.CreateEntry(Path.GetFileName(file));

                using var entryStream = entry.Open();
                using var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                fileStream.CopyTo(entryStream);
            }
        }
    }

    [STAThread]
    public static void Main()
    {
        Application.Run(new MainWindow());
    }  
}