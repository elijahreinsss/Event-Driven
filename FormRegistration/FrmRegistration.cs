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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        
        private void Register_Click(object sender, EventArgs e)

        {
            
            string[] StudentInformation = { "Student Number :" + studotxtbox.Text, $"{"Last Name :" + lnametxtbox.Text},{"First Name : " + fnametxtbox.Text},{"Middle Initial : " + mnametxtbox.Text}",
                "Program : " + programcbox.Text, "Gender" + gendercbox.Text, "Age : " + agetxtbox.Text,"Birthday :" + dateTimePicker.Text,"Contact Number : " + contactnotxtbox.Text };

            string docpat = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docpat, FrmFileName.SetFileName))) 
            {
                foreach (string info in StudentInformation)
                {
                    outputFile.WriteLine(info);
                }
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void recordsbtn_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecord = new FrmStudentRecord();
            studentRecord.Show();
        }

        private void contactnotxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gendercbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void programcbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
