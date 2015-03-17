namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитеФайлСТекстомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитеФайлСловаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатьФайлыВHTMLдокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьWebстраницуВБраузереToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(203, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "1.Загрузите файл с текстом";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(203, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "2.Загрузите файл словаря";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(203, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "3.Записать файлы в HTML-документ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(203, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "4.Открыть Web-страницу в браузере";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(386, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитеФайлСТекстомToolStripMenuItem,
            this.загрузитеФайлСловаряToolStripMenuItem,
            this.записатьФайлыВHTMLдокументToolStripMenuItem,
            this.открытьWebстраницуВБраузереToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрСправкиToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОПрограммеToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // загрузитеФайлСТекстомToolStripMenuItem
            // 
            this.загрузитеФайлСТекстомToolStripMenuItem.Name = "загрузитеФайлСТекстомToolStripMenuItem";
            this.загрузитеФайлСТекстомToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.загрузитеФайлСТекстомToolStripMenuItem.Text = "1,Загрузите файл с текстом";
            this.загрузитеФайлСТекстомToolStripMenuItem.Click += new System.EventHandler(this.загрузитеФайлСТекстомToolStripMenuItem_Click);
            // 
            // загрузитеФайлСловаряToolStripMenuItem
            // 
            this.загрузитеФайлСловаряToolStripMenuItem.Name = "загрузитеФайлСловаряToolStripMenuItem";
            this.загрузитеФайлСловаряToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.загрузитеФайлСловаряToolStripMenuItem.Text = "2.Загрузите файл словаря";
            this.загрузитеФайлСловаряToolStripMenuItem.Click += new System.EventHandler(this.загрузитеФайлСловаряToolStripMenuItem_Click);
            // 
            // записатьФайлыВHTMLдокументToolStripMenuItem
            // 
            this.записатьФайлыВHTMLдокументToolStripMenuItem.Name = "записатьФайлыВHTMLдокументToolStripMenuItem";
            this.записатьФайлыВHTMLдокументToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.записатьФайлыВHTMLдокументToolStripMenuItem.Text = "3.Записать файлы в HTML-документ";
            this.записатьФайлыВHTMLдокументToolStripMenuItem.Click += new System.EventHandler(this.записатьФайлыВHTMLдокументToolStripMenuItem_Click);
            // 
            // открытьWebстраницуВБраузереToolStripMenuItem
            // 
            this.открытьWebстраницуВБраузереToolStripMenuItem.Name = "открытьWebстраницуВБраузереToolStripMenuItem";
            this.открытьWebстраницуВБраузереToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.открытьWebстраницуВБраузереToolStripMenuItem.Text = "4.Открыть Web-страницу в браузере";
            this.открытьWebстраницуВБраузереToolStripMenuItem.Click += new System.EventHandler(this.открытьWebстраницуВБраузереToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // просмотрСправкиToolStripMenuItem
            // 
            this.просмотрСправкиToolStripMenuItem.Name = "просмотрСправкиToolStripMenuItem";
            this.просмотрСправкиToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.просмотрСправкиToolStripMenuItem.Text = "Просмотр справки";
            this.просмотрСправкиToolStripMenuItem.Click += new System.EventHandler(this.просмотрСправкиToolStripMenuItem_Click);
            // 
            // информацияОПрограммеToolStripMenuItem
            // 
            this.информацияОПрограммеToolStripMenuItem.Name = "информацияОПрограммеToolStripMenuItem";
            this.информацияОПрограммеToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.информацияОПрограммеToolStripMenuItem.Text = "Информация о программе";
            this.информацияОПрограммеToolStripMenuItem.Click += new System.EventHandler(this.информацияОПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 422);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Тестовое задание Клочкова Александра Евгеньевича";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитеФайлСТекстомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитеФайлСловаряToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатьФайлыВHTMLдокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьWebстраницуВБраузереToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОПрограммеToolStripMenuItem;
    }
}

