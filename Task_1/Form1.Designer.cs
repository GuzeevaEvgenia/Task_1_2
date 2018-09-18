namespace Task_1
{
    partial class Form1
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
            this.DownloadFile1 = new System.Windows.Forms.Button();
            this.DownloadFile2 = new System.Windows.Forms.Button();
            this.Compare = new System.Windows.Forms.Button();
            this.SaveFile1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // DownloadFile1
            // 
            this.DownloadFile1.Location = new System.Drawing.Point(163, 76);
            this.DownloadFile1.Name = "DownloadFile1";
            this.DownloadFile1.Size = new System.Drawing.Size(256, 77);
            this.DownloadFile1.TabIndex = 0;
            this.DownloadFile1.Text = "Загрузить файл №1";
            this.DownloadFile1.UseVisualStyleBackColor = true;
            this.DownloadFile1.Click += new System.EventHandler(this.DownloadFile1_Click);
            // 
            // DownloadFile2
            // 
            this.DownloadFile2.Location = new System.Drawing.Point(701, 76);
            this.DownloadFile2.Name = "DownloadFile2";
            this.DownloadFile2.Size = new System.Drawing.Size(256, 77);
            this.DownloadFile2.TabIndex = 1;
            this.DownloadFile2.Text = "Загрузить файл №2";
            this.DownloadFile2.UseVisualStyleBackColor = true;
            this.DownloadFile2.Click += new System.EventHandler(this.DownloadFile2_Click);
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(1114, 290);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(206, 77);
            this.Compare.TabIndex = 2;
            this.Compare.Text = "Объединить";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // SaveFile1
            // 
            this.SaveFile1.Location = new System.Drawing.Point(1114, 435);
            this.SaveFile1.Name = "SaveFile1";
            this.SaveFile1.Size = new System.Drawing.Size(206, 77);
            this.SaveFile1.TabIndex = 3;
            this.SaveFile1.Text = "Сохранить файл №1";
            this.SaveFile1.UseVisualStyleBackColor = true;
            this.SaveFile1.Click += new System.EventHandler(this.SaveFile1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(30, 181);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(496, 480);
            this.TextBox1.TabIndex = 4;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(573, 181);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox2.Size = new System.Drawing.Size(496, 480);
            this.TextBox2.TabIndex = 5;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFileDialog2
            // 
            this.OpenFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 702);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.SaveFile1);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.DownloadFile2);
            this.Controls.Add(this.DownloadFile1);
            this.Name = "Form1";
            this.Text = "Task_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadFile1;
        private System.Windows.Forms.Button DownloadFile2;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Button SaveFile1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog2;
    }
}

