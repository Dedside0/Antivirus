using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antivirus
{
    public partial class FormMain : Form
    {
        List<File> listOfFiles = new List<File>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAddNewFile_Click(object sender, EventArgs e)
        {
            FormAddFile formAddFile = new FormAddFile();
            formAddFile.ShowDialog();
            var username = formAddFile.UserName;
            var fileName = formAddFile.FileName;
            int size = formAddFile.Size;
            File file = new File(fileName, username,size);
            listOfFiles.Add(file);
            ShowListOfFile(listOfFiles);
        }

        void ShowListOfFile(List<File> listOfFiles)
        {
            listBoxListOfFiles.Items.Clear();
            foreach (var file in listOfFiles)
            {
                listBoxListOfFiles.Items.Add(file);
            }
        }
    }
}
