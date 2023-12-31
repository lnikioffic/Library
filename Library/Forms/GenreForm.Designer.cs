﻿namespace Library
{
    partial class GenreForm
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
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            panel1 = new Panel();
            reset = new Button();
            search = new Button();
            searchField = new TextBox();
            genreTable = new DataGridView();
            label1 = new Label();
            Box = new GroupBox();
            genre = new Label();
            cancelButton = new Button();
            okButton = new Button();
            label2 = new Label();
            nameGenre = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)genreTable).BeginInit();
            Box.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(513, 80);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(513, 109);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 2;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(513, 162);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(reset);
            panel1.Controls.Add(search);
            panel1.Controls.Add(searchField);
            panel1.Controls.Add(genreTable);
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 336);
            panel1.TabIndex = 4;
            // 
            // reset
            // 
            reset.Location = new Point(389, 3);
            reset.Name = "reset";
            reset.Size = new Size(100, 23);
            reset.TabIndex = 3;
            reset.Text = "Очистить";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // search
            // 
            search.Location = new Point(283, 3);
            search.Name = "search";
            search.Size = new Size(100, 23);
            search.TabIndex = 2;
            search.Text = "Поиск";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // searchField
            // 
            searchField.Location = new Point(9, 3);
            searchField.Name = "searchField";
            searchField.Size = new Size(268, 23);
            searchField.TabIndex = 1;
            // 
            // genreTable
            // 
            genreTable.AllowUserToAddRows = false;
            genreTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            genreTable.Location = new Point(9, 32);
            genreTable.Name = "genreTable";
            genreTable.RowTemplate.Height = 25;
            genreTable.Size = new Size(484, 294);
            genreTable.TabIndex = 0;
            genreTable.DoubleClick += genreTable_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "Жанры";
            // 
            // Box
            // 
            Box.Controls.Add(genre);
            Box.Controls.Add(cancelButton);
            Box.Controls.Add(okButton);
            Box.Controls.Add(label2);
            Box.Controls.Add(nameGenre);
            Box.Location = new Point(9, 80);
            Box.Name = "Box";
            Box.Size = new Size(487, 183);
            Box.TabIndex = 6;
            Box.TabStop = false;
            Box.Text = "text";
            Box.Visible = false;
            // 
            // genre
            // 
            genre.AutoSize = true;
            genre.ForeColor = Color.Red;
            genre.Location = new Point(6, 73);
            genre.Name = "genre";
            genre.Size = new Size(38, 15);
            genre.TabIndex = 5;
            genre.Text = "label3";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(399, 154);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(76, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(317, 154);
            okButton.Name = "okButton";
            okButton.Size = new Size(76, 23);
            okButton.TabIndex = 3;
            okButton.Text = "Ок";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Название:";
            // 
            // nameGenre
            // 
            nameGenre.Location = new Point(6, 47);
            nameGenre.Name = "nameGenre";
            nameGenre.Size = new Size(194, 23);
            nameGenre.TabIndex = 0;
            // 
            // GenreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 407);
            Controls.Add(Box);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Name = "GenreForm";
            Text = "Жанры";
            Load += GenreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)genreTable).EndInit();
            Box.ResumeLayout(false);
            Box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Panel panel1;
        private DataGridView genreTable;
        private TextBox searchField;
        private Button reset;
        private Button search;
        private Label label1;
        private GroupBox Box;
        private TextBox nameGenre;
        private Label label2;
        private Button cancelButton;
        private Button okButton;
        private Label genre;
    }
}