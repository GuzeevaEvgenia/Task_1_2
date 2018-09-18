namespace Task_2
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.ShowItems = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(296, 94);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(212, 67);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Открыть";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ShowItems
            // 
            this.ShowItems.Location = new System.Drawing.Point(296, 393);
            this.ShowItems.Name = "ShowItems";
            this.ShowItems.Size = new System.Drawing.Size(212, 67);
            this.ShowItems.TabIndex = 1;
            this.ShowItems.Text = "Вывести элементы";
            this.ShowItems.UseVisualStyleBackColor = true;
            this.ShowItems.Click += new System.EventHandler(this.ShowItems_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(214, 194);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(365, 118);
            this.TextBox1.TabIndex = 2;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(214, 488);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox2.Size = new System.Drawing.Size(365, 118);
            this.TextBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(184, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Открыть файл с целыми числами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(748, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вывести нулевой, первый, предпоследний и последний элементы";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(296, 643);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(212, 66);
            this.SaveFile.TabIndex = 6;
            this.SaveFile.Text = "Сохранить";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 753);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.ShowItems);
            this.Controls.Add(this.OpenFile);
            this.Name = "Form1";
            this.Text = "Task_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button ShowItems;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

