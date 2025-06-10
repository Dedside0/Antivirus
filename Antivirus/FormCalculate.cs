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
    public partial class FormCalculate : Form
    {
        public double ChekSpeed { get; private set; }
        bool isAllOk;
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void FormCalculate_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            isAllOk = true;
            string speed = textBoxSpeed.Text.Replace(".", ",");
            foreach (var sym in speed)
            {
                if (sym != ',' && !(char.IsDigit(sym)))
                {
                    MessageBox.Show("Неверный формат");
                    isAllOk = false;
                    break;
                }
            }
            if (isAllOk)
            {
                ChekSpeed = Convert.ToDouble(speed);
                this.Close();
            }
        }
    }
}
