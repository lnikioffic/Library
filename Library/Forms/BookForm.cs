using Library.Controllers;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class BookForm : Form
    {

        private BookController controller;

        private AuthorController authorController;

        private PublishingController publishingController;

        private Book? book { get; set; }

        private List<Genre> genreList = new List<Genre>();

        private List<Author> authorList = new List<Author>();

        public BookForm()
        {
            controller = new BookController();
            authorController = new AuthorController();
            publishingController = new PublishingController();
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            var dt = controller.GetBooks().ToList();
            bookTable.DataSource = dt;

            var publishingList = publishingController.GetData();
            publishingCombobox.SetDataToComboBox(publishingList);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            Box.Visible = true;
            Box.Text = "Добавление";
        }

        private void viewButton()
        {
            panel1.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            Box.Visible = false;
            nameBook.Text = "";
            genreData.DataSource = null;
            genreList.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton();
        }

        //таблицы многих ко многим
        private void addGenre_Click(object sender, EventArgs e)
        {
            var genreForm = new GenreForm();
            genreForm.ShowDialog();
            genreList.Add(genreForm.GenSupp);
            showData();
        }

        private void showData()
        {
            genreData.DataSource = null;
            authorData.DataSource = null;
            genreData.DataSource = genreList;
            authorData.DataSource = authorList;
        }

        private void deleteGenre_Click(object sender, EventArgs e)
        {
            if (genreData.SelectedRows.Count == 1)
            {
                var genre = genreData.SelectedRows[0].DataBoundItem as Genre;
                genreList.Remove(genre);
                showData();
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        private void addAuthor_Click(object sender, EventArgs e)
        {
            var authorForm = new AuthorForm();
            authorForm.ShowDialog();
            authorList.Add(authorForm.AuthorSupp);
            showData();
        }

        private void deleteAuthor_Click(object sender, EventArgs e)
        {
            if (authorData.SelectedRows.Count == 1)
            {
                var author = authorData.SelectedRows[0].DataBoundItem as Author;
                authorList.Remove(author);
                showData();
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }
        //
    }
}
