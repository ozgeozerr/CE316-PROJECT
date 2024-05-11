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

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        String selectedFileForZipEx;
        String extractPath;
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void selectAStudent_Click(object sender, EventArgs e)
        {
            Form_StudentsChoosingWindow form=new Form_StudentsChoosingWindow();
            form.Show();
            this.Hide();

        }

        private void createManual_Click(object sender, EventArgs e)
        {

        }

        private void zipButton_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileForZipEx = openFileDialog.FileName;
                MessageBox.Show(selectedFileForZipEx);

            }

        }

        private void exButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string extractPath = folderBrowserDialog.SelectedPath;
                MessageBox.Show(extractPath);

                zipExtractor zipper = new zipExtractor();
                zipper.Extract(selectedFileForZipEx, extractPath);
            }
        }
    }
}



//oldu mu?