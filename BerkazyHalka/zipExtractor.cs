namespace BerkazyHalka
{
    using System;
    using System.IO;
    using System.IO.Compression;

    class zipExtractor
    {
        static void Extract()
        {
            // Specify the path to the zip file and the directory where you want to extract its contents
            string zipFilePath = @"C:\path\to\your\file.zip";
            string extractPath = @"C:\path\to\extract\directory";

            // Create the directory if it doesn't exist
            Directory.CreateDirectory(extractPath);

            // Extract the zip file
            try
            {
                ZipFile.ExtractToDirectory(zipFilePath, extractPath);
                Console.WriteLine("Zip file extracted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

