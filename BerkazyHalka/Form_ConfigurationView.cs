using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkazyHalka
{
    public partial class Form_ConfigurationView : Form
    {
        public Form_ConfigurationView()
        {
            
            InitializeComponent();
            listConfiguration();
        }
        

        static DataTable dt;

        public void listConfiguration()
        {
            dataGridView1.ReadOnly = true;
            using (var connection = new SQLiteConnection(Form1.connectionPath))
            {
                using (var readData = new SQLiteCommand("SELECT * FROM configuration", connection))
                {
                    try
                    {
                        connection.Open();
                        dt = new DataTable();
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(readData))
                        {
                   
                            adapter.Fill(dt);
                            
                        }
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                       
                        }
                        else
                        {
                            MessageBox.Show("No data found in the configuration table.");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
