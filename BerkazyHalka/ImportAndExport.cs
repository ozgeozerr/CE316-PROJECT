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
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("language_path")]
            public string LanguagePath { get; set; }

            [JsonProperty("compiler_path")]
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
                     
                        Configuration config = JsonConvert.DeserializeObject<Configuration>(jsonContent);

                     
                     
                        Console.WriteLine($"Name: {config.Name}");
                        Console.WriteLine($"LanguagePath: {config.LanguagePath}");
                        Console.WriteLine($"CompilerPath: {config.CompilerPath}");

                  
                        
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
