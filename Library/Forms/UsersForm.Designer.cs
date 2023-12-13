namespace Library.Forms
{
    partial class UsersForm
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
            reset = new Button();
            search = new Button();
            searchField = new TextBox();
            userTable = new DataGridView();
            label1 = new Label();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            Box = new GroupBox();
            lastNameLable = new Label();
            firstNameLable = new Label();
            label5 = new Label();
            readerID = new TextBox();
            patron = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lastName = new TextBox();
            cancelButton = new Button();
            okButton = new Button();
            label2 = new Label();
            firstName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            Box.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(reset);
            panel1.Controls.Add(search);
            panel1.Controls.Add(searchField);
            panel1.Controls.Add(userTable);
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 336);
            panel1.TabIndex = 6;
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
            // userTable
            // 
            userTable.AllowUserToAddRows = false;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTable.Location = new Point(9, 32);
            userTable.Name = "userTable";
            userTable.RowHeadersWidth = 51;
            userTable.RowTemplate.Height = 25;
            userTable.Size = new Size(548, 294);
            userTable.TabIndex = 0;
            userTable.DoubleClick += userTable_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "Читатели";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(595, 167);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 23);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(595, 115);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 10;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(595, 86);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 9;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Box
            // 
            Box.Controls.Add(lastNameLable);
            Box.Controls.Add(firstNameLable);
            Box.Controls.Add(label5);
            Box.Controls.Add(readerID);
            Box.Controls.Add(patron);
            Box.Controls.Add(label4);
            Box.Controls.Add(label3);
            Box.Controls.Add(lastName);
            Box.Controls.Add(cancelButton);
            Box.Controls.Add(okButton);
            Box.Controls.Add(label2);
            Box.Controls.Add(firstName);
            Box.Location = new Point(6, 80);
            Box.Name = "Box";
            Box.Size = new Size(548, 220);
            Box.TabIndex = 12;
            Box.TabStop = false;
            Box.Text = "text";
            Box.Visible = false;
            // 
            // lastNameLable
            // 
            lastNameLable.AutoSize = true;
            lastNameLable.ForeColor = Color.Red;
            lastNameLable.Location = new Point(182, 111);
            lastNameLable.Name = "lastNameLable";
            lastNameLable.Size = new Size(38, 15);
            lastNameLable.TabIndex = 12;
            lastNameLable.Text = "label7";
            // 
            // firstNameLable
            // 
            firstNameLable.AutoSize = true;
            firstNameLable.ForeColor = Color.Red;
            firstNameLable.Location = new Point(7, 111);
            firstNameLable.Name = "firstNameLable";
            firstNameLable.Size = new Size(38, 15);
            firstNameLable.TabIndex = 11;
            firstNameLable.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 18);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 10;
            label5.Text = "Читательский билет:";
            // 
            // readerID
            // 
            readerID.Enabled = false;
            readerID.Location = new Point(6, 36);
            readerID.Name = "readerID";
            readerID.Size = new Size(169, 23);
            readerID.TabIndex = 9;
            // 
            // patron
            // 
            patron.Location = new Point(357, 87);
            patron.Name = "patron";
            patron.Size = new Size(169, 23);
            patron.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 70);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 70);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Фамилия:";
            // 
            // lastName
            // 
            lastName.Location = new Point(182, 87);
            lastName.Name = "lastName";
            lastName.Size = new Size(169, 23);
            lastName.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(466, 191);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(76, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(384, 192);
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
            label2.Location = new Point(7, 70);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Имя:";
            // 
            // firstName
            // 
            firstName.Location = new Point(7, 87);
            firstName.Name = "firstName";
            firstName.Size = new Size(169, 23);
            firstName.TabIndex = 0;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 430);
            Controls.Add(Box);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsersForm";
            Text = "Читатели";
            Load += UsersForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
            Box.ResumeLayout(false);
            Box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button reset;
        private Button search;
        private TextBox searchField;
        private DataGridView userTable;
        private Label label1;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private GroupBox Box;
        private TextBox patron;
        private Label label4;
        private Label label3;
        private TextBox lastName;
        private Button cancelButton;
        private Button okButton;
        private Label label2;
        private TextBox firstName;
        private Label label5;
        private TextBox readerID;
        private Label lastNameLable;
        private Label firstNameLable;
    }
}