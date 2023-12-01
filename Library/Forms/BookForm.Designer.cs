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
            reset = new Button();
            search = new Button();
            searchField = new TextBox();
            bookTable = new DataGridView();
            label1 = new Label();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            Box = new GroupBox();
            authorDataLable = new Label();
            genreDataLable = new Label();
            publishingComboboxLable = new Label();
            datePubLable = new Label();
            nameBookLable = new Label();
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
            addPub = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookTable).BeginInit();
            Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)authorData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(reset);
            panel1.Controls.Add(search);
            panel1.Controls.Add(searchField);
            panel1.Controls.Add(bookTable);
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 336);
            panel1.TabIndex = 7;
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
            // bookTable
            // 
            bookTable.AllowUserToAddRows = false;
            bookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookTable.Location = new Point(9, 32);
            bookTable.Name = "bookTable";
            bookTable.RowHeadersWidth = 51;
            bookTable.RowTemplate.Height = 25;
            bookTable.Size = new Size(563, 294);
            bookTable.TabIndex = 0;
            bookTable.DoubleClick += bookTable_DoubleClick;
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
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(596, 113);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 13;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
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
            Box.Controls.Add(addPub);
            Box.Controls.Add(authorDataLable);
            Box.Controls.Add(genreDataLable);
            Box.Controls.Add(publishingComboboxLable);
            Box.Controls.Add(datePubLable);
            Box.Controls.Add(nameBookLable);
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
            // authorDataLable
            // 
            authorDataLable.AutoSize = true;
            authorDataLable.ForeColor = Color.Red;
            authorDataLable.Location = new Point(6, 285);
            authorDataLable.Name = "authorDataLable";
            authorDataLable.Size = new Size(38, 15);
            authorDataLable.TabIndex = 22;
            authorDataLable.Text = "label7";
            // 
            // genreDataLable
            // 
            genreDataLable.AutoSize = true;
            genreDataLable.ForeColor = Color.Red;
            genreDataLable.Location = new Point(345, 285);
            genreDataLable.Name = "genreDataLable";
            genreDataLable.Size = new Size(38, 15);
            genreDataLable.TabIndex = 21;
            genreDataLable.Text = "label7";
            // 
            // publishingComboboxLable
            // 
            publishingComboboxLable.AutoSize = true;
            publishingComboboxLable.ForeColor = Color.Red;
            publishingComboboxLable.Location = new Point(7, 133);
            publishingComboboxLable.Name = "publishingComboboxLable";
            publishingComboboxLable.Size = new Size(38, 15);
            publishingComboboxLable.TabIndex = 20;
            publishingComboboxLable.Text = "label9";
            // 
            // datePubLable
            // 
            datePubLable.AutoSize = true;
            datePubLable.ForeColor = Color.Red;
            datePubLable.Location = new Point(278, 133);
            datePubLable.Name = "datePubLable";
            datePubLable.Size = new Size(38, 15);
            datePubLable.TabIndex = 19;
            datePubLable.Text = "label8";
            // 
            // nameBookLable
            // 
            nameBookLable.AutoSize = true;
            nameBookLable.ForeColor = Color.Red;
            nameBookLable.Location = new Point(6, 73);
            nameBookLable.Name = "nameBookLable";
            nameBookLable.Size = new Size(38, 15);
            nameBookLable.TabIndex = 18;
            nameBookLable.Text = "label7";
            // 
            // datePub
            // 
            datePub.Location = new Point(278, 107);
            datePub.Name = "datePub";
            datePub.Size = new Size(79, 23);
            datePub.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 89);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 16;
            label6.Text = "Год издания:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 89);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 14;
            label5.Text = "Издательство:";
            // 
            // publishingCombobox
            // 
            publishingCombobox.FormattingEnabled = true;
            publishingCombobox.Location = new Point(7, 107);
            publishingCombobox.Name = "publishingCombobox";
            publishingCombobox.Size = new Size(200, 23);
            publishingCombobox.TabIndex = 13;
            // 
            // deleteAuthor
            // 
            deleteAuthor.Location = new Point(278, 204);
            deleteAuthor.Name = "deleteAuthor";
            deleteAuthor.Size = new Size(23, 23);
            deleteAuthor.TabIndex = 12;
            deleteAuthor.Text = "-";
            deleteAuthor.UseVisualStyleBackColor = true;
            deleteAuthor.Click += deleteAuthor_Click;
            // 
            // addAuthor
            // 
            addAuthor.Location = new Point(278, 175);
            addAuthor.Name = "addAuthor";
            addAuthor.Size = new Size(23, 23);
            addAuthor.TabIndex = 11;
            addAuthor.Text = "+";
            addAuthor.UseVisualStyleBackColor = true;
            addAuthor.Click += addAuthor_Click;
            // 
            // deleteGenre
            // 
            deleteGenre.Location = new Point(522, 204);
            deleteGenre.Name = "deleteGenre";
            deleteGenre.Size = new Size(23, 23);
            deleteGenre.TabIndex = 10;
            deleteGenre.Text = "-";
            deleteGenre.UseVisualStyleBackColor = true;
            deleteGenre.Click += deleteGenre_Click;
            // 
            // addGenre
            // 
            addGenre.Location = new Point(522, 175);
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
            label4.Location = new Point(6, 158);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Авторы:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 158);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "Жанры:";
            // 
            // authorData
            // 
            authorData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authorData.Location = new Point(6, 175);
            authorData.Margin = new Padding(3, 2, 3, 2);
            authorData.Name = "authorData";
            authorData.RowHeadersWidth = 51;
            authorData.RowTemplate.Height = 29;
            authorData.Size = new Size(266, 108);
            authorData.TabIndex = 6;
            // 
            // genreData
            // 
            genreData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            genreData.Location = new Point(345, 175);
            genreData.Margin = new Padding(3, 2, 3, 2);
            genreData.Name = "genreData";
            genreData.RowHeadersWidth = 51;
            genreData.RowTemplate.Height = 29;
            genreData.Size = new Size(171, 108);
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
            okButton.Click += okButton_Click;
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
            nameBook.Size = new Size(266, 23);
            nameBook.TabIndex = 0;
            // 
            // addPub
            // 
            addPub.Location = new Point(213, 107);
            addPub.Name = "addPub";
            addPub.Size = new Size(27, 23);
            addPub.TabIndex = 38;
            addPub.Text = "...";
            addPub.UseVisualStyleBackColor = true;
            addPub.Click += addPub_Click;
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
        private Button reset;
        private Button search;
        private TextBox searchField;
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
        private Label publishingComboboxLable;
        private Label datePubLable;
        private Label nameBookLable;
        private Label genreDataLable;
        private Label authorDataLable;
        private Button addPub;
    }
}