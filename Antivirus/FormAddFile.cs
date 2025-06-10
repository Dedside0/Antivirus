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
        public int SizeInBytes { get; private set; }
        bool isAllOk;

        Dictionary<string, int> SizeMultyply = new Dictionary<string, int>
        {
            {"бит",1 },
            {"байт",8 },
            {"кб",1024*8 },
            {"мб",1024*8*1024 },
        };
        public FormAddFile()
        {
            InitializeComponent();
        }

        private void FormAddFile_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            isAllOk = true;
            FileName = textBoxFileName.Text;
            if (FileName == "")
            {
                MessageBox.Show("Введите имя файла");
                isAllOk = false;
            }

            UserName = textBoxUserName.Text;
            if (UserName == "")
            {
                MessageBox.Show("Введите имя пользователя");
                isAllOk = false;
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
                SizeInBytes = Convert.ToInt32(textBoxFileSize.Text)*SizeMultyply[comboBoxSizeType.Text];
                this.Close();
            }
            
        }
    }
}
