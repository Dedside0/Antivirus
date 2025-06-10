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
            int size = formAddFile.SizeInBytes;

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

        

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (listOfFiles.Count == 0)
                return;
            FormCalculate formCalculate = new FormCalculate();
            formCalculate.ShowDialog();
            var speed  = formCalculate.ChekSpeed;
            int wholeSize = 0;
            foreach (var file in listOfFiles)
            {
                wholeSize += file.Size;
            }
            double totalTime = wholeSize * speed / (1024.0*8);
            MessageBox.Show("Время проверки всех файлов: "+totalTime.ToString() + " секунд");
        }
    }
}
