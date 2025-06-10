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
            this.textBoxListOfFiles = new System.Windows.Forms.TextBox();
            this.buttonAddNewFile = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxListOfFiles
            // 
            this.textBoxListOfFiles.Location = new System.Drawing.Point(22, 33);
            this.textBoxListOfFiles.Multiline = true;
            this.textBoxListOfFiles.Name = "textBoxListOfFiles";
            this.textBoxListOfFiles.Size = new System.Drawing.Size(269, 394);
            this.textBoxListOfFiles.TabIndex = 0;
            // 
            // buttonAddNewFile
            // 
            this.buttonAddNewFile.Location = new System.Drawing.Point(364, 103);
            this.buttonAddNewFile.Name = "buttonAddNewFile";
            this.buttonAddNewFile.Size = new System.Drawing.Size(198, 93);
            this.buttonAddNewFile.TabIndex = 1;
            this.buttonAddNewFile.Text = "Добавить";
            this.buttonAddNewFile.UseVisualStyleBackColor = true;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonAddNewFile);
            this.Controls.Add(this.textBoxListOfFiles);
            this.Name = "FormMain";
            this.Text = "Антивирус";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxListOfFiles;
        private System.Windows.Forms.Button buttonAddNewFile;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

