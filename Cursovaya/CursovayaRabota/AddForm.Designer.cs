namespace CursovayaRabota
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameLabe = new System.Windows.Forms.Label();
            this.SurnameLabe = new System.Windows.Forms.Label();
            this.AFNametextBox = new System.Windows.Forms.TextBox();
            this.AFSurnametextBox = new System.Windows.Forms.TextBox();
            this.AFDobavBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextSomeInformation = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // NameLabe
            // 
            this.NameLabe.AutoSize = true;
            this.NameLabe.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabe.Location = new System.Drawing.Point(12, 38);
            this.NameLabe.Name = "NameLabe";
            this.NameLabe.Size = new System.Drawing.Size(61, 26);
            this.NameLabe.TabIndex = 4;
            this.NameLabe.Text = "Имя:";
            // 
            // SurnameLabe
            // 
            this.SurnameLabe.AutoSize = true;
            this.SurnameLabe.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabe.Location = new System.Drawing.Point(-5, 118);
            this.SurnameLabe.Name = "SurnameLabe";
            this.SurnameLabe.Size = new System.Drawing.Size(111, 26);
            this.SurnameLabe.TabIndex = 5;
            this.SurnameLabe.Text = "Фамилия:";
            // 
            // AFNametextBox
            // 
            this.AFNametextBox.BackColor = System.Drawing.Color.SpringGreen;
            this.AFNametextBox.Location = new System.Drawing.Point(0, 78);
            this.AFNametextBox.Name = "AFNametextBox";
            this.AFNametextBox.Size = new System.Drawing.Size(100, 20);
            this.AFNametextBox.TabIndex = 6;
            // 
            // AFSurnametextBox
            // 
            this.AFSurnametextBox.BackColor = System.Drawing.Color.SpringGreen;
            this.AFSurnametextBox.Location = new System.Drawing.Point(0, 159);
            this.AFSurnametextBox.Name = "AFSurnametextBox";
            this.AFSurnametextBox.Size = new System.Drawing.Size(100, 20);
            this.AFSurnametextBox.TabIndex = 7;
            // 
            // AFDobavBut
            // 
            this.AFDobavBut.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AFDobavBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AFDobavBut.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AFDobavBut.Location = new System.Drawing.Point(60, 210);
            this.AFDobavBut.Name = "AFDobavBut";
            this.AFDobavBut.Size = new System.Drawing.Size(145, 40);
            this.AFDobavBut.TabIndex = 8;
            this.AFDobavBut.Text = "ДОБАВИТЬ";
            this.AFDobavBut.UseVisualStyleBackColor = false;
            this.AFDobavBut.Click += new System.EventHandler(this.AFDobavBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дата рождения:";
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimeBirthday.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimeBirthday.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimeBirthday.Font = new System.Drawing.Font("Franklin Gothic Medium", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBirthday.Location = new System.Drawing.Point(141, 78);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(91, 18);
            this.dateTimeBirthday.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дополнительно:";
            // 
            // richTextSomeInformation
            // 
            this.richTextSomeInformation.BackColor = System.Drawing.Color.SpringGreen;
            this.richTextSomeInformation.Location = new System.Drawing.Point(110, 147);
            this.richTextSomeInformation.Name = "richTextSomeInformation";
            this.richTextSomeInformation.Size = new System.Drawing.Size(148, 45);
            this.richTextSomeInformation.TabIndex = 12;
            this.richTextSomeInformation.Text = "";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextSomeInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeBirthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AFDobavBut);
            this.Controls.Add(this.AFSurnametextBox);
            this.Controls.Add(this.AFNametextBox);
            this.Controls.Add(this.SurnameLabe);
            this.Controls.Add(this.NameLabe);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление новой записи";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Label NameLabe;
        private System.Windows.Forms.Label SurnameLabe;
        private System.Windows.Forms.TextBox AFNametextBox;
        private System.Windows.Forms.TextBox AFSurnametextBox;
        private System.Windows.Forms.Button AFDobavBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextSomeInformation;
    }
}