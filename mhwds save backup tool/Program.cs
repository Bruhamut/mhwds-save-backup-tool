using System;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace mhwds_save_backup_tool;

 //2246340
public class Program
{
    private const string gameID = "2246340";
    private const string userID = "null";

    private static DateTime currentDT = DateTime.Now;
    private static string formattedDT = currentDT.ToString("MM-dd-yyyy HH_mm_ss");
    public static string zipPath = @$"C:\Temp\{formattedDT}.zip";
    public static string savePath = @$"C:\Program Files (x86)\Steam\userdata\{userID}\{gameID}\remote\win64_save";
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]

   
    public static void CreateZipBackup(string zipPath, string savePath)
    {
        // Create zip file and update with files to be copied
        using (FileStream ZipFile = new FileStream(zipPath, FileMode.Create))
        using (ZipArchive archive = new ZipArchive(ZipFile, ZipArchiveMode.Update))
        {
            string[] files = Directory.GetFiles(savePath, "*.bin");
            foreach (var file in files)
            {   
                var entry = archive.CreateEntry(Path.GetFileName(file));

                using (var entryStream = entry.Open())
                using (var fileStream = new FileStream(file, FileMode.Open))
                {
                    fileStream.CopyTo(entryStream);
                }
            }
        }
    }

    public static void Main()
    {
        Application.Run(new Form1());
    }  
}