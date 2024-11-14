using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegistration
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvShowText.Items.Clear();
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {

        }

        private void findtbn_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Title = "Browse Text Files",
                    DefaultExt = "txt",
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lvShowText.Items.Clear(); 
                    string path = openFileDialog.FileName;
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            lvShowText.Items.Add(line);
                        }
                    }
                }
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            FrmRegistration registration = new FrmRegistration();
            registration.Show();
            this.Close();
        }
    }
}
