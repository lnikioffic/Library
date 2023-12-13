namespace Library.Forms
{
    partial class AuthorForm
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
            authorTable = new DataGridView();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            Box = new GroupBox();
            lastNameLable = new Label();
            firstNameLable = new Label();
            patron = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lastName = new TextBox();
            cancelButton = new Button();
            okButton = new Button();
            label2 = new Label();
            firstName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)authorTable).BeginInit();
            Box.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Авторы";
            // 
            // panel1
            // 
            panel1.Controls.Add(reset);
            panel1.Controls.Add(search);
            panel1.Controls.Add(searchField);
            panel1.Controls.Add(authorTable);
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 336);
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
            // authorTable
            // 
            authorTable.AllowUserToAddRows = false;
            authorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authorTable.Location = new Point(9, 32);
            authorTable.Name = "authorTable";
            authorTable.RowTemplate.Height = 25;
            authorTable.Size = new Size(548, 294);
            authorTable.TabIndex = 0;
            authorTable.DoubleClick += authorTable_DoubleClick;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(574, 162);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 23);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(574, 109);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 7;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(574, 80);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Box
            // 
            Box.Controls.Add(lastNameLable);
            Box.Controls.Add(firstNameLable);
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
            Box.TabIndex = 10;
            Box.TabStop = false;
            Box.Text = "text";
            Box.Visible = false;
            // 
            // lastNameLable
            // 
            lastNameLable.AutoSize = true;
            lastNameLable.ForeColor = Color.Red;
            lastNameLable.Location = new Point(181, 73);
            lastNameLable.Name = "lastNameLable";
            lastNameLable.Size = new Size(38, 15);
            lastNameLable.TabIndex = 10;
            lastNameLable.Text = "label6";
            // 
            // firstNameLable
            // 
            firstNameLable.AutoSize = true;
            firstNameLable.ForeColor = Color.Red;
            firstNameLable.Location = new Point(6, 73);
            firstNameLable.Name = "firstNameLable";
            firstNameLable.Size = new Size(38, 15);
            firstNameLable.TabIndex = 9;
            firstNameLable.Text = "label5";
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
            label4.Location = new Point(356, 29);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 29);
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
            okButton.Location = new Point(384, 191);
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
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 406);
            Controls.Add(Box);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AuthorForm";
            Text = "Авторы";
            Load += AuthorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)authorTable).EndInit();
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
        private DataGridView authorTable;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private GroupBox Box;
        private Label label3;
        private TextBox lastName;
        private Button cancelButton;
        private Button okButton;
        private Label label2;
        private TextBox firstName;
        private TextBox patron;
        private Label label4;
        private Label lastNameLable;
        private Label firstNameLable;
    }
}