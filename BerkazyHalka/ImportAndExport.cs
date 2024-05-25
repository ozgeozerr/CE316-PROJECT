using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            [JsonProperty("language")]
            public string Language { get; set; }
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
                        Console.WriteLine($"Language: {config.Language}");
                        Console.WriteLine($"CompilerPath: {config.CompilerPath}");



                        MessageBox.Show(config.Name);
                        MessageBox.Show(config.Language);
                      
                        MessageBox.Show(config.CompilerPath);
                        using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
                        {
                            using (var insertData = new SQLiteCommand($"INSERT INTO configuration(name,language_name,compiler_path,sourcecode) VALUES ('{config.Name}', '{config.Language}','{config.CompilerPath}','{config.CompilerPath}');SELECT last_insert_rowid();", connection))
                            {
                                try
                                {
                                    connection.Open();
                                    Form_HomePage.currentConfigID = Convert.ToInt32(insertData.ExecuteScalar());
                                    MessageBox.Show("Added to SQL successfully!" + Form_HomePage.currentConfigID);
                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show(err.Message);
                                }
                            }
                        }
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
