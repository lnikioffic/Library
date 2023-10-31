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
            button5 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            userTable = new DataGridView();
            label1 = new Label();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            Box = new GroupBox();
            patron = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lastName = new TextBox();
            cancelButton = new Button();
            okButton = new Button();
            label2 = new Label();
            firstName = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            Box.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(userTable);
            panel1.Location = new Point(3, 72);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 448);
            panel1.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(522, 4);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(114, 31);
            button5.TabIndex = 3;
            button5.Text = "Очистить";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(401, 4);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(114, 31);
            button4.TabIndex = 2;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 4);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 27);
            textBox1.TabIndex = 1;
            // 
            // userTable
            // 
            userTable.AllowUserToAddRows = false;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTable.Location = new Point(10, 43);
            userTable.Margin = new Padding(3, 4, 3, 4);
            userTable.Name = "userTable";
            userTable.RowHeadersWidth = 51;
            userTable.RowTemplate.Height = 25;
            userTable.Size = new Size(626, 392);
            userTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(680, 223);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(114, 31);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(680, 153);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(114, 31);
            editButton.TabIndex = 10;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(680, 114);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(114, 31);
            addButton.TabIndex = 9;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Box
            // 
            Box.Controls.Add(label5);
            Box.Controls.Add(comboBox1);
            Box.Controls.Add(patron);
            Box.Controls.Add(label4);
            Box.Controls.Add(label3);
            Box.Controls.Add(lastName);
            Box.Controls.Add(cancelButton);
            Box.Controls.Add(okButton);
            Box.Controls.Add(label2);
            Box.Controls.Add(firstName);
            Box.Location = new Point(7, 107);
            Box.Margin = new Padding(3, 4, 3, 4);
            Box.Name = "Box";
            Box.Padding = new Padding(3, 4, 3, 4);
            Box.Size = new Size(626, 293);
            Box.TabIndex = 12;
            Box.TabStop = false;
            Box.Text = "text";
            Box.Visible = false;
            // 
            // patron
            // 
            patron.Location = new Point(7, 180);
            patron.Margin = new Padding(3, 4, 3, 4);
            patron.Name = "patron";
            patron.Size = new Size(193, 27);
            patron.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 157);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 98);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Фамилия:";
            // 
            // lastName
            // 
            lastName.Location = new Point(7, 121);
            lastName.Margin = new Padding(3, 4, 3, 4);
            lastName.Name = "lastName";
            lastName.Size = new Size(193, 27);
            lastName.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(505, 255);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(114, 31);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(384, 255);
            okButton.Margin = new Padding(3, 4, 3, 4);
            okButton.Name = "okButton";
            okButton.Size = new Size(114, 31);
            okButton.TabIndex = 3;
            okButton.Text = "Ок";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 40);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя:";
            // 
            // firstName
            // 
            firstName.Location = new Point(7, 63);
            firstName.Margin = new Padding(3, 4, 3, 4);
            firstName.Name = "firstName";
            firstName.Size = new Size(193, 27);
            firstName.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(7, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 28);
            comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 211);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 10;
            label5.Text = "Роль";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 573);
            Controls.Add(Box);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(addButton, 0);
            Controls.SetChildIndex(editButton, 0);
            Controls.SetChildIndex(deleteButton, 0);
            Controls.SetChildIndex(Box, 0);
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
        private Button button5;
        private Button button4;
        private TextBox textBox1;
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
        private ComboBox comboBox1;
    }
}