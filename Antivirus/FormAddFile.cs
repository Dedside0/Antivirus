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
    public partial class FormAddFile : Form
    {
        public string UserName { get; private set; }
        public string FileName { get; private set; }
        public int Size { get; private set; }
        bool isAllOk = true;
        public FormAddFile()
        {
            InitializeComponent();
        }

        private void FormAddFile_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            FileName = textBoxFileName.Text;
            if (FileName == "")
            {
                MessageBox.Show("Введите имя файла");
                isAllOk = false;
            }
            else
            {
                isAllOk = true;
            }

            UserName = textBoxUserName.Text;
            if (UserName == "")
            {
                MessageBox.Show("Введите имя пользователя");
                isAllOk = false;
            }
            else
            {
                isAllOk = true;
            }

            if (textBoxFileSize.Text == "")
            {
                MessageBox.Show("Введите размер файла");
                isAllOk = false;
            }
            else
            {
                foreach (var sym in textBoxFileSize.Text)
                {
                    if (!(char.IsDigit(sym)))
                    {
                        MessageBox.Show("Ошибка в вводе размера файла");
                        isAllOk = false;
                        break;
                    }
                }
            }
            if (isAllOk)
            {
                Size = Convert.ToInt32(textBoxFileSize.Text);
                this.Close();
            }
            
        }
    }
}
