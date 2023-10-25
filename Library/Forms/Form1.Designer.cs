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
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            B = new ToolStripMenuItem();
            GenreMenuItem = new ToolStripMenuItem();
            AuthorMenuItem = new ToolStripMenuItem();
            PublishMenuItem = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
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
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripSeparator1, toolStripMenuItem4, toolStripMenuItem5, toolStripSeparator2, B, GenreMenuItem, AuthorMenuItem, PublishMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(87, 20);
            toolStripMenuItem2.Text = "Справочник";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Выдача";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 22);
            toolStripMenuItem4.Text = "Читатели ";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(180, 22);
            toolStripMenuItem5.Text = "Сотрудники";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // B
            // 
            B.Name = "B";
            B.Size = new Size(180, 22);
            B.Text = "Книги";
            // 
            // GenreMenuItem
            // 
            GenreMenuItem.Name = "GenreMenuItem";
            GenreMenuItem.Size = new Size(180, 22);
            GenreMenuItem.Text = "Жанры";
            GenreMenuItem.Click += GenreMenuItem_Click;
            // 
            // AuthorMenuItem
            // 
            AuthorMenuItem.Name = "AuthorMenuItem";
            AuthorMenuItem.Size = new Size(180, 22);
            AuthorMenuItem.Text = "Авторы";
            AuthorMenuItem.Click += AuthorMenuItem_Click;
            // 
            // PublishMenuItem
            // 
            PublishMenuItem.Name = "PublishMenuItem";
            PublishMenuItem.Size = new Size(180, 22);
            PublishMenuItem.Text = "Издательства";
            PublishMenuItem.Click += PublishMenuItem_Click;
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
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem B;
        private ToolStripMenuItem GenreMenuItem;
        private ToolStripMenuItem AuthorMenuItem;
        private ToolStripMenuItem PublishMenuItem;
    }
}