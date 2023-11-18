using Library.Controllers;
using Library.Models;
using Library.Representation;
using Microsoft.VisualBasic.ApplicationServices;
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
            book = null;
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
        private List<BookGenre> CreateBG(int book)
        {
            var list = new List<BookGenre>();
            foreach (var genre in genreList)
            {
                list.Add(
                    new BookGenre
                    {
                        BookId = book,
                        GenreId = genre.Id,
                    }
                    );
            }
            return list;
        }

        private List<AuthorBook> CreateAB(int book)
        {
            var list = new List<AuthorBook>();
            foreach (var authro in authorList)
            {
                list.Add(
                    new AuthorBook
                    {
                        BookId = book,
                        AuthorId = authro.Id,
                    }
                    );
            }
            return list;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (book != null)
                {
                    //var role = publishingController.GetData(publishingCombobox.SelectedItem.ToString()).First();
                    //book.FirstName = firstName.Text;
                    //book.LastName = lastName.Text;
                    //book.Patronymic = patron.Text;
                    //book.Role = role;
                    //controller.Update(user);
                }
                else
                {
                    var pub = publishingController.GetData(publishingCombobox.SelectedItem.ToString()).First();
                    var book = new Book
                    {
                        Title = nameBook.Text,
                        PublishingId = pub.Id,
                        PublicationDate = datePub.Text
                    };
                    var idBook = controller.Add(book);
                    book.AuthorBooks = CreateAB(idBook);
                    book.BookGenres = CreateBG(idBook);
                    
                }
                viewButton();
                BookForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (bookTable.SelectedRows.Count == 1)
            {
                var bo = bookTable.SelectedRows[0].DataBoundItem as PressBook;
                if (bo != null)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show(
                            "Удалить читателя", "Сообщение", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            controller.Delete(bo.book);
                            BookForm_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                }
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
