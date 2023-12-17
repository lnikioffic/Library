namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            JournalMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            UserMenuItem = new ToolStripMenuItem();
            StaffMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            BookMenuItem = new ToolStripMenuItem();
            GenreMenuItem = new ToolStripMenuItem();
            AuthorMenuItem = new ToolStripMenuItem();
            PublishMenuItem = new ToolStripMenuItem();
            ReportMenuItem = new ToolStripMenuItem();
            GenereReportStripMenuItem = new ToolStripMenuItem();
            AuthorReportStripMenuItem = new ToolStripMenuItem();
            StaffReportStripMenuItem5 = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, ReportMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(700, 24);
            Menu.TabIndex = 0;
            Menu.Text = "Меню";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(63, 20);
            toolStripMenuItem1.Text = "Главная";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { JournalMenuItem, toolStripSeparator1, UserMenuItem, StaffMenuItem, toolStripSeparator2, BookMenuItem, GenreMenuItem, AuthorMenuItem, PublishMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(87, 20);
            toolStripMenuItem2.Text = "Справочник";
            // 
            // JournalMenuItem
            // 
            JournalMenuItem.Name = "JournalMenuItem";
            JournalMenuItem.Size = new Size(147, 22);
            JournalMenuItem.Text = "Выдача";
            JournalMenuItem.Click += JournalMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(144, 6);
            // 
            // UserMenuItem
            // 
            UserMenuItem.Name = "UserMenuItem";
            UserMenuItem.Size = new Size(147, 22);
            UserMenuItem.Text = "Читатели ";
            UserMenuItem.Click += UserMenuItem_Click;
            // 
            // StaffMenuItem
            // 
            StaffMenuItem.Name = "StaffMenuItem";
            StaffMenuItem.Size = new Size(147, 22);
            StaffMenuItem.Text = "Сотрудники";
            StaffMenuItem.Click += StaffMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(144, 6);
            // 
            // BookMenuItem
            // 
            BookMenuItem.Name = "BookMenuItem";
            BookMenuItem.Size = new Size(147, 22);
            BookMenuItem.Text = "Книги";
            BookMenuItem.Click += BookMenuItem_Click;
            // 
            // GenreMenuItem
            // 
            GenreMenuItem.Name = "GenreMenuItem";
            GenreMenuItem.Size = new Size(147, 22);
            GenreMenuItem.Text = "Жанры";
            GenreMenuItem.Click += GenreMenuItem_Click;
            // 
            // AuthorMenuItem
            // 
            AuthorMenuItem.Name = "AuthorMenuItem";
            AuthorMenuItem.Size = new Size(147, 22);
            AuthorMenuItem.Text = "Авторы";
            AuthorMenuItem.Click += AuthorMenuItem_Click;
            // 
            // PublishMenuItem
            // 
            PublishMenuItem.Name = "PublishMenuItem";
            PublishMenuItem.Size = new Size(147, 22);
            PublishMenuItem.Text = "Издательства";
            PublishMenuItem.Click += PublishMenuItem_Click;
            // 
            // ReportMenuItem
            // 
            ReportMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GenereReportStripMenuItem, AuthorReportStripMenuItem, StaffReportStripMenuItem5 });
            ReportMenuItem.Name = "ReportMenuItem";
            ReportMenuItem.Size = new Size(60, 20);
            ReportMenuItem.Text = "Отчёты";
            // 
            // GenereReportStripMenuItem
            // 
            GenereReportStripMenuItem.Name = "GenereReportStripMenuItem";
            GenereReportStripMenuItem.Size = new Size(274, 22);
            GenereReportStripMenuItem.Text = "Популярность жарнов";
            GenereReportStripMenuItem.Click += GenereReportStripMenuItem_Click;
            // 
            // AuthorReportStripMenuItem
            // 
            AuthorReportStripMenuItem.Name = "AuthorReportStripMenuItem";
            AuthorReportStripMenuItem.Size = new Size(274, 22);
            AuthorReportStripMenuItem.Text = "Популярность авторов";
            AuthorReportStripMenuItem.Click += AuthorReportStripMenuItem_Click;
            // 
            // StaffReportStripMenuItem5
            // 
            StaffReportStripMenuItem5.Name = "StaffReportStripMenuItem5";
            StaffReportStripMenuItem5.Size = new Size(274, 22);
            StaffReportStripMenuItem5.Text = "Выданные книг которые не вернули";
            StaffReportStripMenuItem5.Click += StaffReportStripMenuItem5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 350);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "Form1";
            Text = "Form1";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem JournalMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem UserMenuItem;
        private ToolStripMenuItem StaffMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem BookMenuItem;
        private ToolStripMenuItem GenreMenuItem;
        private ToolStripMenuItem AuthorMenuItem;
        private ToolStripMenuItem PublishMenuItem;
        private ToolStripMenuItem ReportMenuItem;
        private ToolStripMenuItem GenereReportStripMenuItem;
        private ToolStripMenuItem AuthorReportStripMenuItem;
        private ToolStripMenuItem StaffReportStripMenuItem5;
    }
}