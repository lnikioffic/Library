namespace Library.Forms
{
    partial class BookForm
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
            bookTable = new DataGridView();
            label1 = new Label();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            Box = new GroupBox();
            datePub = new TextBox();
            label6 = new Label();
            label5 = new Label();
            publishingCombobox = new ComboBox();
            deleteAuthor = new Button();
            addAuthor = new Button();
            deleteGenre = new Button();
            addGenre = new Button();
            label4 = new Label();
            label3 = new Label();
            authorData = new DataGridView();
            genreData = new DataGridView();
            cancelButton = new Button();
            okButton = new Button();
            label2 = new Label();
            nameBook = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookTable).BeginInit();
            Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)authorData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(bookTable);
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 336);
            panel1.TabIndex = 7;
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
            // bookTable
            // 
            bookTable.AllowUserToAddRows = false;
            bookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookTable.Location = new Point(9, 32);
            bookTable.Name = "bookTable";
            bookTable.RowHeadersWidth = 51;
            bookTable.RowTemplate.Height = 25;
            bookTable.Size = new Size(548, 294);
            bookTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Книги";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(596, 165);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 23);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(596, 113);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 13;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(596, 84);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 12;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Box
            // 
            Box.Controls.Add(datePub);
            Box.Controls.Add(label6);
            Box.Controls.Add(label5);
            Box.Controls.Add(publishingCombobox);
            Box.Controls.Add(deleteAuthor);
            Box.Controls.Add(addAuthor);
            Box.Controls.Add(deleteGenre);
            Box.Controls.Add(addGenre);
            Box.Controls.Add(label4);
            Box.Controls.Add(label3);
            Box.Controls.Add(authorData);
            Box.Controls.Add(genreData);
            Box.Controls.Add(cancelButton);
            Box.Controls.Add(okButton);
            Box.Controls.Add(label2);
            Box.Controls.Add(nameBook);
            Box.Location = new Point(9, 80);
            Box.Name = "Box";
            Box.Size = new Size(551, 338);
            Box.TabIndex = 15;
            Box.TabStop = false;
            Box.Text = "text";
            Box.Visible = false;
            // 
            // datePub
            // 
            datePub.Location = new Point(212, 102);
            datePub.Name = "datePub";
            datePub.Size = new Size(79, 23);
            datePub.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 84);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 16;
            label6.Text = "Год издания:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 84);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 14;
            label5.Text = "Издательство:";
            // 
            // publishingCombobox
            // 
            publishingCombobox.FormattingEnabled = true;
            publishingCombobox.Location = new Point(6, 102);
            publishingCombobox.Name = "publishingCombobox";
            publishingCombobox.Size = new Size(200, 23);
            publishingCombobox.TabIndex = 13;
            // 
            // deleteAuthor
            // 
            deleteAuthor.Location = new Point(265, 186);
            deleteAuthor.Name = "deleteAuthor";
            deleteAuthor.Size = new Size(23, 23);
            deleteAuthor.TabIndex = 12;
            deleteAuthor.Text = "-";
            deleteAuthor.UseVisualStyleBackColor = true;
            deleteAuthor.Click += deleteAuthor_Click;
            // 
            // addAuthor
            // 
            addAuthor.Location = new Point(265, 157);
            addAuthor.Name = "addAuthor";
            addAuthor.Size = new Size(23, 23);
            addAuthor.TabIndex = 11;
            addAuthor.Text = "+";
            addAuthor.UseVisualStyleBackColor = true;
            addAuthor.Click += addAuthor_Click;
            // 
            // deleteGenre
            // 
            deleteGenre.Location = new Point(505, 186);
            deleteGenre.Name = "deleteGenre";
            deleteGenre.Size = new Size(23, 23);
            deleteGenre.TabIndex = 10;
            deleteGenre.Text = "-";
            deleteGenre.UseVisualStyleBackColor = true;
            deleteGenre.Click += deleteGenre_Click;
            // 
            // addGenre
            // 
            addGenre.Location = new Point(505, 157);
            addGenre.Name = "addGenre";
            addGenre.Size = new Size(23, 23);
            addGenre.TabIndex = 9;
            addGenre.Text = "+";
            addGenre.UseVisualStyleBackColor = true;
            addGenre.Click += addGenre_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 140);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Авторы:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 140);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "Жанры:";
            // 
            // authorData
            // 
            authorData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authorData.Location = new Point(6, 157);
            authorData.Margin = new Padding(3, 2, 3, 2);
            authorData.Name = "authorData";
            authorData.RowHeadersWidth = 51;
            authorData.RowTemplate.Height = 29;
            authorData.Size = new Size(253, 97);
            authorData.TabIndex = 6;
            // 
            // genreData
            // 
            genreData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            genreData.Location = new Point(345, 157);
            genreData.Margin = new Padding(3, 2, 3, 2);
            genreData.Name = "genreData";
            genreData.RowHeadersWidth = 51;
            genreData.RowTemplate.Height = 29;
            genreData.Size = new Size(154, 97);
            genreData.TabIndex = 5;
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
            // okButton
            // 
            okButton.Location = new Point(387, 299);
            okButton.Name = "okButton";
            okButton.Size = new Size(76, 23);
            okButton.TabIndex = 3;
            okButton.Text = "Ок";
            okButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Название:";
            // 
            // nameBook
            // 
            nameBook.Location = new Point(6, 47);
            nameBook.Name = "nameBook";
            nameBook.Size = new Size(201, 23);
            nameBook.TabIndex = 0;
            // 
            // BookForm
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookForm";
            Text = "Книги";
            Load += BookForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookTable).EndInit();
            Box.ResumeLayout(false);
            Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)authorData).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private TextBox textBox1;
        private DataGridView bookTable;
        private Label label1;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private GroupBox Box;
        private Button cancelButton;
        private Button okButton;
        private Label label2;
        private TextBox nameBook;
        private Label label4;
        private Label label3;
        private DataGridView authorData;
        private DataGridView genreData;
        private Button addGenre;
        private Button deleteAuthor;
        private Button addAuthor;
        private Button deleteGenre;
        private ComboBox publishingCombobox;
        private Label label5;
        private Label label6;
        private TextBox datePub;
    }
}