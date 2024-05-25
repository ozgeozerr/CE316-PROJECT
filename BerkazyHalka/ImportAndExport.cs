using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BerkazyHalka
{
    internal class ImportAndExport
    {
        public class Configuration
        {
         
            public string Name { get; set; }
            public string LanguagePath { get; set; }
            public string CompilerPath { get; set; }
        }

        public void ImportJsonFile() 
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Open JSON File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        string jsonContent = File.ReadAllText(filePath);
                        // Parse JSON content into Configuration object
                        Configuration config = JsonConvert.DeserializeObject<Configuration>(jsonContent);

                        // Write properties to the console
                     
                        Console.WriteLine($"Name: {config.Name}");
                        Console.WriteLine($"LanguagePath: {config.LanguagePath}");
                        Console.WriteLine($"CompilerPath: {config.CompilerPath}");

                        // Display JSON content in a message box
                        MessageBox.Show(jsonContent, "JSON Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(config.Name);
                        MessageBox.Show(config.LanguagePath);
                        MessageBox.Show(config.CompilerPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                    }





                }
        }
    }
}
    }
