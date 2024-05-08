using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkazyHalka
{
    public partial class Form_HomePage : Form
    {
        public static Form_HomePage instance;
        public Form_HomePage()
        {
            InitializeComponent();
            instance = this;
            ozgedeneme.AddItemsToListView(listView1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeScreenInstructions_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void labelPastAssignments_Click(object sender, EventArgs e)
        {

        }
    }
}
