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
    public partial class Form_Configuration : Form
    {
        public Form_Configuration()
        {
            InitializeComponent();
        }

      

        
        private void browseFiles_button_Click(object sender, EventArgs e)
        {


            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog2.FileName);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog2.FileName);
            }

        }

        private void Form_Configuration_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Form_CreatingNewAssignment form_CreatingNewAssignment = new Form_CreatingNewAssignment();
            form_CreatingNewAssignment.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form_HomePage form=new Form_HomePage();
            form.Show();
            this.Hide();
        }
    }
}
