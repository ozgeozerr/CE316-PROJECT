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
            dataGridView1.KeyDown += dataGridView1_KeyDown;




        }


        static DataTable dt;
        public void listConfiguration()
        {
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
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
                            dataGridView1.Columns["id"].ReadOnly = true;


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

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string name = row.Cells["name"].Value != null ? row.Cells["name"].Value.ToString() : "";
                string languageName = row.Cells["language_name"].Value != null ? row.Cells["language_name"].Value.ToString() : "";
                string compilerPath = row.Cells["compiler_path"].Value != null ? row.Cells["compiler_path"].Value.ToString() : "";
                string sourceCode = row.Cells["sourcecode"].Value != null ? row.Cells["sourcecode"].Value.ToString() : "";
                UpdateRowInDatabase(id, name, languageName, compilerPath, sourceCode);
            }

        }
        private void UpdateRowInDatabase(int id, string name, string languageName, string compilerPath, string sourceCode)
        {
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                string query = "UPDATE configuration SET name = @name, language_name = @languageName, compiler_path = @compilerPath, sourcecode = @sourceCode WHERE id = @id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@languageName", languageName);
                    command.Parameters.AddWithValue("@compilerPath", compilerPath);
                    command.Parameters.AddWithValue("@sourceCode", sourceCode);
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating row: " + ex.Message);
                    }
                }
            }
        }

        private Form_Configuration configurationForm;

        private void button1_Click(object sender, EventArgs e)
        {
            if (configurationForm == null || configurationForm.Visible == false)
            {
                configurationForm = new Form_Configuration();
                configurationForm.FormClosed += ConfigurationForm_FormClosed;
                this.Enabled = false;
                configurationForm.Show();
            }
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDataGridView();

            this.Enabled = true;
        }
        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = GetUpdatedDataSource();
        }

        private DataTable GetUpdatedDataSource()
        {
            DataTable updatedData = new DataTable();
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                string query = "SELECT * FROM configuration";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(updatedData);
                    }
                }
            }

            return updatedData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int selectedId = Convert.ToInt32(selectedRow.Cells[0].Value);
                dataGridView1.Rows.RemoveAt(selectedRow.Index);
                DeleteRowFromDatabase(selectedId);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void DeleteRowFromDatabase(int id)
        {
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                string query = "DELETE FROM configuration WHERE id = @id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            GetUpdatedDataSource();
                            MessageBox.Show("Row deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting row: " + ex.Message);
                    }
                }
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int selectedId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    DeleteRowFromDatabase(selectedId);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
        }

        private void ımportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
