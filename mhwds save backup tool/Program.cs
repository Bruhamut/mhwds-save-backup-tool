using System;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace mhwds_save_backup_tool;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]

    public static void CreateZipFileWithFiles(string zipPath, string filePath)
    {
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "This is a file");
        }
        using (FileStream ZipFile = new FileStream(zipPath, FileMode.Create))
        using (ZipArchive archive = new ZipArchive(ZipFile, ZipArchiveMode.Update))
            {
            string entryName = Path.GetFileName(filePath);
          
            var existingEntry = archive.GetEntry(entryName);
            if (existingEntry != null)
            {
                existingEntry.Delete();
            }
              archive.CreateEntryFromFile(filePath, entryName);
        }
    }

    public static void Main()
    {
        DateTime currentDT = DateTime.Now;
        string formattedDT = currentDT.ToString("MM-dd-yyyy HH_mm");
        string zipPath = @$"C:\Temp\{formattedDT}.zip";
        string filePath = @"C:\Temp\testfile.txt";

        CreateZipFileWithFiles(zipPath, filePath);
    }  
}