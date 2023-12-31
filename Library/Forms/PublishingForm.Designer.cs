﻿namespace Library
{
    partial class PublishingForm
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
            label1 = new Label();
            panel1 = new Panel();
            reset = new Button();
            search = new Button();
            searchField = new TextBox();
            publishingTable = new DataGridView();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            Box = new GroupBox();
            adressPubLable = new Label();
            namePubLable = new Label();
            label3 = new Label();
            adressPub = new TextBox();
            cancelButton = new Button();
            okButton = new Button();
            label2 = new Label();
            namePub = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)publishingTable).BeginInit();
            Box.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Издательства";
            // 
            // panel1
            // 
            panel1.Controls.Add(reset);
            panel1.Controls.Add(search);
            panel1.Controls.Add(searchField);
            panel1.Controls.Add(publishingTable);
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 336);
            panel1.TabIndex = 5;
            // 
            // reset
            // 
            reset.Location = new Point(457, 3);
            reset.Name = "reset";
            reset.Size = new Size(100, 23);
            reset.TabIndex = 3;
            reset.Text = "Очистить";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // search
            // 
            search.Location = new Point(351, 3);
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
            searchField.Size = new Size(336, 23);
            searchField.TabIndex = 1;
            // 
            // publishingTable
            // 
            publishingTable.AllowUserToAddRows = false;
            publishingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            publishingTable.Location = new Point(9, 32);
            publishingTable.Name = "publishingTable";
            publishingTable.RowTemplate.Height = 25;
            publishingTable.Size = new Size(548, 294);
            publishingTable.TabIndex = 0;
            publishingTable.DoubleClick += publishingTable_DoubleClick;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(577, 162);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 23);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(577, 109);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 7;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(577, 80);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Box
            // 
            Box.Controls.Add(adressPubLable);
            Box.Controls.Add(namePubLable);
            Box.Controls.Add(label3);
            Box.Controls.Add(adressPub);
            Box.Controls.Add(cancelButton);
            Box.Controls.Add(okButton);
            Box.Controls.Add(label2);
            Box.Controls.Add(namePub);
            Box.Location = new Point(9, 80);
            Box.Name = "Box";
            Box.Size = new Size(548, 183);
            Box.TabIndex = 9;
            Box.TabStop = false;
            Box.Text = "text";
            Box.Visible = false;
            // 
            // adressPubLable
            // 
            adressPubLable.AutoSize = true;
            adressPubLable.ForeColor = Color.Red;
            adressPubLable.Location = new Point(6, 137);
            adressPubLable.Name = "adressPubLable";
            adressPubLable.Size = new Size(38, 15);
            adressPubLable.TabIndex = 8;
            adressPubLable.Text = "label5";
            // 
            // namePubLable
            // 
            namePubLable.AutoSize = true;
            namePubLable.ForeColor = Color.Red;
            namePubLable.Location = new Point(6, 73);
            namePubLable.Name = "namePubLable";
            namePubLable.Size = new Size(38, 15);
            namePubLable.TabIndex = 7;
            namePubLable.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 93);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Адрес:";
            // 
            // adressPub
            // 
            adressPub.Location = new Point(6, 111);
            adressPub.Name = "adressPub";
            adressPub.Size = new Size(296, 23);
            adressPub.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(466, 154);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(76, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(384, 154);
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
            // namePub
            // 
            namePub.Location = new Point(6, 47);
            namePub.Name = "namePub";
            namePub.Size = new Size(197, 23);
            namePub.TabIndex = 0;
            // 
            // PublishingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 430);
            Controls.Add(Box);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "PublishingForm";
            Text = "Издательства";
            Load += PublishingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)publishingTable).EndInit();
            Box.ResumeLayout(false);
            Box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button reset;
        private Button search;
        private TextBox searchField;
        private DataGridView publishingTable;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private GroupBox Box;
        private Label label3;
        private TextBox adressPub;
        private Button cancelButton;
        private Button okButton;
        private Label label2;
        private TextBox namePub;
        private Label adressPubLable;
        private Label namePubLable;
    }
}