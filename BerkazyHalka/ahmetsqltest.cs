using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BerkazyHalka
{
    public partial class ahmetsqltest : Form
    {
        static string server = "127.0.0.1";
        static string database = "assignmentdb";
        static string Uid = "root";
        static string password = "";
        static string connstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "Uid=" + Uid + ";" + "PASSWORD=" + password + ";";
        MySqlConnection conn = new MySqlConnection(connstring);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public void openConnection()
        {
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }
        public ahmetsqltest()
        {
            InitializeComponent();
        }
    }
}
