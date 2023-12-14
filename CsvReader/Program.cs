using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = @"C:\\vafa"; // Replace with your actual directory path

        // Check if the specified directory exists
        if (Directory.Exists(directoryPath))
        {
            QueryFilesInDirectory(directoryPath);
        }
        else
        {
            Console.WriteLine("The specified directory does not exist.");
        }
    }

    static void QueryFilesInDirectory(string directoryPath)
    {
        try
        {
            string[] files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);

            foreach (var filePath in files)
            {
                FileInfo fileInfo = new FileInfo(filePath);

                // Check if the file is hidden
                if ((fileInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    Console.WriteLine($"File: {fileInfo.Name}");
                    Console.WriteLine($"Size in Bytes: {fileInfo.Length}");
                    Console.WriteLine($"Size in KB: {fileInfo.Length / 1024.0} KB");
                    Console.WriteLine($"Size in MB: {fileInfo.Length / (1024.0 * 1024.0)} MB");
                    Console.WriteLine($"Size in GB: {fileInfo.Length / (1024.0 * 1024.0 * 1024.0)} GB");
                    Console.ReadLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error querying files: {ex.Message}");
        }
    }
}
