﻿namespace Library.Forms
{
    partial class JournalForm
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            journalTable = new DataGridView();
            label1 = new Label();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            label2 = new Label();
            okButton = new Button();
            cancelButton = new Button();
            dateOfIssuedLable = new Label();
            Box = new GroupBox();
            userLable = new Label();
            label9 = new Label();
            userComboBox = new ComboBox();
            staffLabel = new Label();
            label7 = new Label();
            staffComboBox = new ComboBox();
            bookLable = new Label();
            label5 = new Label();
            bookCombobox = new ComboBox();
            actualReturnDateLable = new Label();
            estimatedReturnDateLable = new Label();
            dataLable = new Label();
            actualReturnDate = new DateTimePicker();
            label3 = new Label();
            estimatedReturnDate = new DateTimePicker();
            dateOfIssued = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)journalTable).BeginInit();
            Box.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(journalTable);
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 336);
            panel1.TabIndex = 8;
            // 
            // button5
            // 
            button5.Location = new Point(457, 3);
            button5.Name = "button5";
            button5.Size = new Size(100, 23);
            button5.TabIndex = 3;
            button5.Text = "Очистить";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(351, 3);
            button4.Name = "button4";
            button4.Size = new Size(100, 23);
            button4.TabIndex = 2;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 23);
            textBox1.TabIndex = 1;
            // 
            // journalTable
            // 
            journalTable.AllowUserToAddRows = false;
            journalTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            journalTable.Location = new Point(9, 32);
            journalTable.Name = "journalTable";
            journalTable.RowHeadersWidth = 51;
            journalTable.RowTemplate.Height = 25;
            journalTable.Size = new Size(566, 294);
            journalTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 9;
            label1.Text = "Журнал выдачи";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(596, 166);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 23);
            deleteButton.TabIndex = 17;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(596, 114);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 16;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(596, 85);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 15;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Дата выдачи:";
            // 
            // okButton
            // 
            okButton.Location = new Point(387, 299);
            okButton.Name = "okButton";
            okButton.Size = new Size(76, 23);
            okButton.TabIndex = 3;
            okButton.Text = "Ок";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(469, 299);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(76, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // dateOfIssuedLable
            // 
            dateOfIssuedLable.AutoSize = true;
            dateOfIssuedLable.ForeColor = Color.Red;
            dateOfIssuedLable.Location = new Point(6, 73);
            dateOfIssuedLable.Name = "dateOfIssuedLable";
            dateOfIssuedLable.Size = new Size(38, 15);
            dateOfIssuedLable.TabIndex = 18;
            dateOfIssuedLable.Text = "label7";
            // 
            // Box
            // 
            Box.Controls.Add(userLable);
            Box.Controls.Add(label9);
            Box.Controls.Add(userComboBox);
            Box.Controls.Add(staffLabel);
            Box.Controls.Add(label7);
            Box.Controls.Add(staffComboBox);
            Box.Controls.Add(bookLable);
            Box.Controls.Add(label5);
            Box.Controls.Add(bookCombobox);
            Box.Controls.Add(actualReturnDateLable);
            Box.Controls.Add(estimatedReturnDateLable);
            Box.Controls.Add(dataLable);
            Box.Controls.Add(actualReturnDate);
            Box.Controls.Add(label3);
            Box.Controls.Add(estimatedReturnDate);
            Box.Controls.Add(dateOfIssued);
            Box.Controls.Add(dateOfIssuedLable);
            Box.Controls.Add(cancelButton);
            Box.Controls.Add(okButton);
            Box.Controls.Add(label2);
            Box.Location = new Point(9, 80);
            Box.Name = "Box";
            Box.Size = new Size(559, 338);
            Box.TabIndex = 18;
            Box.TabStop = false;
            Box.Text = "text";
            Box.Visible = false;
            // 
            // userLable
            // 
            userLable.AutoSize = true;
            userLable.ForeColor = Color.Red;
            userLable.Location = new Point(6, 261);
            userLable.Name = "userLable";
            userLable.Size = new Size(38, 15);
            userLable.TabIndex = 36;
            userLable.Text = "label9";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 217);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 35;
            label9.Text = "Читатель:";
            // 
            // userComboBox
            // 
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(6, 235);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(200, 23);
            userComboBox.TabIndex = 34;
            // 
            // staffLabel
            // 
            staffLabel.AutoSize = true;
            staffLabel.ForeColor = Color.Red;
            staffLabel.Location = new Point(7, 198);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(38, 15);
            staffLabel.TabIndex = 33;
            staffLabel.Text = "label9";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 154);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 32;
            label7.Text = "Сотрудник:";
            // 
            // staffComboBox
            // 
            staffComboBox.FormattingEnabled = true;
            staffComboBox.Location = new Point(7, 172);
            staffComboBox.Name = "staffComboBox";
            staffComboBox.Size = new Size(200, 23);
            staffComboBox.TabIndex = 31;
            // 
            // bookLable
            // 
            bookLable.AutoSize = true;
            bookLable.ForeColor = Color.Red;
            bookLable.Location = new Point(7, 136);
            bookLable.Name = "bookLable";
            bookLable.Size = new Size(38, 15);
            bookLable.TabIndex = 30;
            bookLable.Text = "label9";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 92);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 29;
            label5.Text = "Книга:";
            // 
            // bookCombobox
            // 
            bookCombobox.FormattingEnabled = true;
            bookCombobox.Location = new Point(7, 110);
            bookCombobox.Name = "bookCombobox";
            bookCombobox.Size = new Size(226, 23);
            bookCombobox.TabIndex = 28;
            // 
            // actualReturnDateLable
            // 
            actualReturnDateLable.AutoSize = true;
            actualReturnDateLable.ForeColor = Color.Red;
            actualReturnDateLable.Location = new Point(375, 74);
            actualReturnDateLable.Name = "actualReturnDateLable";
            actualReturnDateLable.Size = new Size(38, 15);
            actualReturnDateLable.TabIndex = 27;
            actualReturnDateLable.Text = "label7";
            actualReturnDateLable.Visible = false;
            // 
            // estimatedReturnDateLable
            // 
            estimatedReturnDateLable.AutoSize = true;
            estimatedReturnDateLable.ForeColor = Color.Red;
            estimatedReturnDateLable.Location = new Point(191, 74);
            estimatedReturnDateLable.Name = "estimatedReturnDateLable";
            estimatedReturnDateLable.Size = new Size(38, 15);
            estimatedReturnDateLable.TabIndex = 26;
            estimatedReturnDateLable.Text = "label7";
            // 
            // dataLable
            // 
            dataLable.AutoSize = true;
            dataLable.Location = new Point(375, 30);
            dataLable.Name = "dataLable";
            dataLable.Size = new Size(86, 15);
            dataLable.TabIndex = 25;
            dataLable.Text = "Дата возврата:";
            dataLable.Visible = false;
            // 
            // actualReturnDate
            // 
            actualReturnDate.Location = new Point(375, 47);
            actualReturnDate.Name = "actualReturnDate";
            actualReturnDate.Size = new Size(178, 23);
            actualReturnDate.TabIndex = 24;
            actualReturnDate.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 30);
            label3.Name = "label3";
            label3.Size = new Size(180, 15);
            label3.TabIndex = 23;
            label3.Text = "Предполагаемая дата возврата:";
            // 
            // estimatedReturnDate
            // 
            estimatedReturnDate.Location = new Point(191, 48);
            estimatedReturnDate.Name = "estimatedReturnDate";
            estimatedReturnDate.Size = new Size(178, 23);
            estimatedReturnDate.TabIndex = 22;
            // 
            // dateOfIssued
            // 
            dateOfIssued.ImeMode = ImeMode.NoControl;
            dateOfIssued.Location = new Point(7, 47);
            dateOfIssued.Name = "dateOfIssued";
            dateOfIssued.Size = new Size(178, 23);
            dateOfIssued.TabIndex = 21;
            // 
            // JournalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 430);
            Controls.Add(Box);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "JournalForm";
            Text = "Журнал выдачи";
            Load += JournalForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)journalTable).EndInit();
            Box.ResumeLayout(false);
            Box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private TextBox textBox1;
        private DataGridView journalTable;
        private Label label1;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label label2;
        private Button okButton;
        private Button cancelButton;
        private Label dateOfIssuedLable;
        private GroupBox Box;
        private Label label3;
        private DateTimePicker estimatedReturnDate;
        private DateTimePicker dateOfIssued;
        private Label actualReturnDateLable;
        private Label estimatedReturnDateLable;
        private Label dataLable;
        private DateTimePicker actualReturnDate;
        private Label userLable;
        private Label label9;
        private ComboBox userComboBox;
        private Label staffLabel;
        private Label label7;
        private ComboBox staffComboBox;
        private Label bookLable;
        private Label label5;
        private ComboBox bookCombobox;
    }
}