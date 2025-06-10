namespace Antivirus
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddNewFile = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBoxListOfFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAddNewFile
            // 
            this.buttonAddNewFile.Location = new System.Drawing.Point(364, 103);
            this.buttonAddNewFile.Name = "buttonAddNewFile";
            this.buttonAddNewFile.Size = new System.Drawing.Size(198, 93);
            this.buttonAddNewFile.TabIndex = 1;
            this.buttonAddNewFile.Text = "Добавить";
            this.buttonAddNewFile.UseVisualStyleBackColor = true;
            this.buttonAddNewFile.Click += new System.EventHandler(this.buttonAddNewFile_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(364, 261);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(198, 93);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // listBoxListOfFiles
            // 
            this.listBoxListOfFiles.FormattingEnabled = true;
            this.listBoxListOfFiles.Location = new System.Drawing.Point(25, 35);
            this.listBoxListOfFiles.Name = "listBoxListOfFiles";
            this.listBoxListOfFiles.Size = new System.Drawing.Size(306, 381);
            this.listBoxListOfFiles.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxListOfFiles);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonAddNewFile);
            this.Name = "FormMain";
            this.Text = "Антивирус";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddNewFile;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListBox listBoxListOfFiles;
    }
}

