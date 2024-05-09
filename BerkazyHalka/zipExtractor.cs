namespace BerkazyHalka
{
    using System;
    using System.IO;
    using System.IO.Compression;

    class zipExtractor
    {
        public void Extract(string zipFilePath ,string extractPath)
        {
           
            // Create the directory if it doesn't exist
           

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

