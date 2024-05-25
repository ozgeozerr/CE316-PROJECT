using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json.Linq;

namespace BerkazyHalka
{
    internal class ImportAndExport
    {
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

                        // Parse JSON content
                        JObject json = JObject.Parse(jsonContent);
                        string formattedJson = json.ToString();

                        // Display JSON content in a message box
                        MessageBox.Show(formattedJson, "JSON Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
