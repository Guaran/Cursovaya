namespace CursovayaRabota
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DobavBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDopInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UdalBut = new System.Windows.Forms.Button();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // DobavBut
            // 
            this.DobavBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DobavBut.BackColor = System.Drawing.Color.DarkTurquoise;
            this.DobavBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DobavBut.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DobavBut.Location = new System.Drawing.Point(12, 185);
            this.DobavBut.Name = "DobavBut";
            this.DobavBut.Size = new System.Drawing.Size(161, 65);
            this.DobavBut.TabIndex = 2;
            this.DobavBut.Text = "ДОБАВИТЬ";
            this.DobavBut.UseVisualStyleBackColor = false;
            this.DobavBut.Click += new System.EventHandler(this.DobavBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteCheckBox,
            this.GridName,
            this.GridSurname,
            this.GridDopInf});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(431, 152);
            this.dataGridView1.TabIndex = 3;
            // 
            // DeleteCheckBox
            // 
            this.DeleteCheckBox.FalseValue = "false";
            this.DeleteCheckBox.FillWeight = 24.35001F;
            this.DeleteCheckBox.HeaderText = "-";
            this.DeleteCheckBox.Name = "DeleteCheckBox";
            this.DeleteCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteCheckBox.TrueValue = "true";
            // 
            // GridName
            // 
            this.GridName.FillWeight = 151.7818F;
            this.GridName.HeaderText = "Имя";
            this.GridName.Name = "GridName";
            this.GridName.ReadOnly = true;
            // 
            // GridSurname
            // 
            this.GridSurname.FillWeight = 151.7818F;
            this.GridSurname.HeaderText = "Фамилия";
            this.GridSurname.Name = "GridSurname";
            this.GridSurname.ReadOnly = true;
            // 
            // GridDopInf
            // 
            this.GridDopInf.FillWeight = 151.7818F;
            this.GridDopInf.HeaderText = "Дополнительно";
            this.GridDopInf.Name = "GridDopInf";
            this.GridDopInf.ReadOnly = true;
            // 
            // UdalBut
            // 
            this.UdalBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UdalBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UdalBut.BackColor = System.Drawing.Color.DarkTurquoise;
            this.UdalBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UdalBut.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UdalBut.Location = new System.Drawing.Point(258, 185);
            this.UdalBut.Name = "UdalBut";
            this.UdalBut.Size = new System.Drawing.Size(161, 65);
            this.UdalBut.TabIndex = 4;
            this.UdalBut.Text = "УДАЛИТЬ";
            this.UdalBut.UseVisualStyleBackColor = false;
            this.UdalBut.Click += new System.EventHandler(this.UdalBut_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(431, 262);
            this.Controls.Add(this.UdalBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DobavBut);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ежедневник";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.Button DobavBut;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UdalBut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeleteCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDopInf;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
    }
}

