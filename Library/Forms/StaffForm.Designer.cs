namespace Library.Forms
{
    partial class StaffForm
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
            patron = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lastName = new TextBox();
            cancelButton = new Button();
            okButton = new Button();
            label2 = new Label();
            firstName = new TextBox();
            Box = new GroupBox();
            roleLable = new Label();
            lastNameLable = new Label();
            firstNameLable = new Label();
            label5 = new Label();
            roleComboBox = new ComboBox();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            label1 = new Label();
            reset = new Button();
            search = new Button();
            searchField = new TextBox();
            userTable = new DataGridView();
            panel1 = new Panel();
            Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // patron
            // 
            patron.Location = new Point(356, 47);
            patron.Name = "patron";
            patron.Size = new Size(169, 23);
            patron.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 30);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 30);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Фамилия:";
            // 
            // lastName
            // 
            lastName.Location = new Point(181, 47);
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
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Имя:";
            // 
            // firstName
            // 
            firstName.Location = new Point(6, 47);
            firstName.Name = "firstName";
            firstName.Size = new Size(169, 23);
            firstName.TabIndex = 0;
            // 
            // Box
            // 
            Box.Controls.Add(roleLable);
            Box.Controls.Add(lastNameLable);
            Box.Controls.Add(firstNameLable);
            Box.Controls.Add(label5);
            Box.Controls.Add(roleComboBox);
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
            Box.TabIndex = 18;
            Box.TabStop = false;
            Box.Text = "text";
            Box.Visible = false;
            // 
            // roleLable
            // 
            roleLable.AutoSize = true;
            roleLable.ForeColor = Color.Red;
            roleLable.Location = new Point(6, 135);
            roleLable.Name = "roleLable";
            roleLable.Size = new Size(38, 15);
            roleLable.TabIndex = 15;
            roleLable.Text = "label8";
            // 
            // lastNameLable
            // 
            lastNameLable.AutoSize = true;
            lastNameLable.ForeColor = Color.Red;
            lastNameLable.Location = new Point(181, 71);
            lastNameLable.Name = "lastNameLable";
            lastNameLable.Size = new Size(38, 15);
            lastNameLable.TabIndex = 14;
            lastNameLable.Text = "label7";
            // 
            // firstNameLable
            // 
            firstNameLable.AutoSize = true;
            firstNameLable.ForeColor = Color.Red;
            firstNameLable.Location = new Point(6, 71);
            firstNameLable.Name = "firstNameLable";
            firstNameLable.Size = new Size(38, 15);
            firstNameLable.TabIndex = 13;
            firstNameLable.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 91);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "Должность:";
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(6, 109);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(169, 23);
            roleComboBox.TabIndex = 11;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(596, 162);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 23);
            deleteButton.TabIndex = 17;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(596, 110);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 16;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(596, 81);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 15;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 14;
            label1.Text = "Сотрудники";
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
            userTable.RowTemplate.Height = 25;
            userTable.Size = new Size(548, 294);
            userTable.TabIndex = 0;
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
            panel1.TabIndex = 13;
            // 
            // StaffForm
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
            Name = "StaffForm";
            Text = "Сотрудники";
            Load += StaffForm_Load;
            Box.ResumeLayout(false);
            Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox patron;
        private Label label4;
        private Label label3;
        private TextBox lastName;
        private Button cancelButton;
        private Button okButton;
        private Label label2;
        private TextBox firstName;
        private GroupBox Box;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label label1;
        private Button reset;
        private Button search;
        private TextBox searchField;
        private DataGridView userTable;
        private Panel panel1;
        private ComboBox roleComboBox;
        private Label label5;
        private Label roleLable;
        private Label lastNameLable;
        private Label firstNameLable;
    }
}