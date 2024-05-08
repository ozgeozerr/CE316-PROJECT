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
    public partial class ahmetsqltest : Form
    {
        public ahmetsqltest()
        {
            connectSql();
            InitializeComponent();
        }
        private void connectSql()
        {
            string connectionPath = @"Data source=C:\\Users\\adana\\OneDrive\\Masaüstü\\CE316-Project\\Assign_Database.db;Version=3";
            using (var connection = new SQLiteConnection(connectionPath))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection Sucess");
                }
                catch(Exception err) {
                    MessageBox.Show("Connection Error"+err.Message);
                }
            }
            
        }
        
    }
}
