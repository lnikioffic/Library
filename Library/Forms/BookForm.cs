using Library.Controllers;
using Library.Models;
using Library.Representation;
using Library.tools;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class BookForm : Form
    {

        private BookController controller;

        private PublishingController publishingController;

        private GenreController genreController;

        private AuthorController authorController;

        private Book? book { get; set; }

        private List<Genre> genreList = new List<Genre>();

        private List<Author> authorList = new List<Author>();

        private Book? editbook { get; set; }

        public BookForm(Book? editbook = null)
        {
            authorController = new AuthorController();
            controller = new BookController();
            publishingController = new PublishingController();
            genreController = new GenreController();
            InitializeComponent();
            this.editbook = editbook;
            if (editbook != null)
                MessageBox.Show(editbook.ToString());
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            if (this.Modal == true)
            {
                if (editbook != null)
                {
                    if (searchField.Text.Trim() == "")
                        bookTable.DataSource = controller.GetBooksU(editbook).ToList();
                    else
                        bookTable.DataSource = controller.GetBooksU(searchField.Text, editbook).ToList();
                }
                else
                {
                    if (searchField.Text.Trim() == "")
                        bookTable.DataSource = controller.GetBooksU().ToList();
                    else
                        bookTable.DataSource = controller.GetBooksU(searchField.Text).ToList();
                }
            }
            else
            {
                if (searchField.Text.Trim() == "")
                    bookTable.DataSource = controller.GetBooks().ToList();
                else
                    bookTable.DataSource = controller.GetBooks(searchField.Text).ToList();
            }

            bookTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            bookTable.ReadOnly = true;

            genreData.ReadOnly = true;
            genreData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            authorData.ReadOnly = true;
            authorData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
            errorLable();
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
            authorData.DataSource = null;
            authorList.Clear();
            datePub.Text = "";
            book = null;
            publishingCombobox.SelectedItem = null;
            errorLable();
        }

        private void errorLable()
        {
            nameBookLable.Text = ""; datePubLable.Text = ""; publishingComboboxLable.Text = "";
            genreDataLable.Text = "";
            authorDataLable.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton();
        }

        //таблицы многих ко многим
        private bool CheckUniqGenre(List<Genre> list, Genre a)
        {
            foreach (var item in list)
            {
                if (item.Id == a.Id)
                    return false;
            }
            return true;
        }

        private bool CheckUniqAuthor(List<Author> list, Author a)
        {
            foreach (var item in list)
            {
                if (item.Id == a.Id)
                    return false;
            }
            return true;
        }

        private void GenreClear()
        {
            List<Genre> genreNew = new List<Genre>();
            var genre = genreController.GetData();
            foreach (var item in genreList)
            {
                // работает на оборот 
                if (CheckUniqGenre(genre, item))
                    genreNew.Add(item);
            }
            foreach (var item in genreNew)
                genreList.Remove(item);
        }

        private void AuthorClear()
        {
            List<Author> authorNew = new List<Author>();
            var autror = authorController.GetData();
            foreach (var item in authorList)
            {
                // работает на оборот 
                if (CheckUniqAuthor(autror, item))
                    authorNew.Add(item);
            }
            foreach (var item in authorNew)
                authorList.Remove(item);
        }

        private void addGenre_Click(object sender, EventArgs e)
        {
            var genreForm = new GenreForm();
            genreForm.ShowDialog();
            genreDataLable.Text = "";
            if (genreForm.GenSupp != null)
            {
                if (CheckUniqGenre(genreList, genreForm.GenSupp))
                {
                    genreList.Add(genreForm.GenSupp);
                }
                else
                    genreDataLable.Text = $"Вы уже добалили этот жанр {genreForm.GenSupp.Genre1}";
            }
            GenreClear();
            showData();
        }

        private void addAuthor_Click(object sender, EventArgs e)
        {
            var authorForm = new AuthorForm();
            authorForm.ShowDialog();
            authorDataLable.Text = "";
            if (authorForm.AuthorSupp != null)
            {
                if (CheckUniqAuthor(authorList, authorForm.AuthorSupp))
                    authorList.Add(authorForm.AuthorSupp);
                else
                    authorDataLable.Text = $"Вы уже добалили этотого автора {authorForm.AuthorSupp.LastName}";
            }
            AuthorClear();
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
        private List<BookGenre> CreateBG(Book book)
        {
            var list = new List<BookGenre>();
            foreach (var genre in genreList)
            {
                list.Add(
                    new BookGenre
                    {
                        BookId = book.Id,
                        GenreId = genre.Id,
                    }
                    );
            }
            return list;
        }

        private List<AuthorBook> CreateAB(Book book)
        {
            var list = new List<AuthorBook>();
            foreach (var authro in authorList)
            {
                list.Add(
                    new AuthorBook
                    {
                        BookId = book.Id,
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
                errorLable();
                Dictionary<TextBox, Label> errorLables = new Dictionary<TextBox, Label>
                {
                    {nameBook, nameBookLable },
                    {datePub, datePubLable },
                };
                Dictionary<ComboBox, Label> errorComboBox = new Dictionary<ComboBox, Label>
                {
                    {publishingCombobox, publishingComboboxLable},
                };
                Dictionary<DataGridView, Label> errorList = new Dictionary<DataGridView, Label>
                {
                    {genreData, genreDataLable},
                    {authorData, authorDataLable},
                };
                bool isValidTextBox = Validator.ValidateTextBox(errorLables);
                bool isValidComboBox = Validator.ValidateComboBox(errorComboBox);
                bool isValidData = Validator.ValidateData(errorList);
                if (isValidTextBox && isValidComboBox && isValidData)
                {
                    if (Regex.IsMatch(datePub.Text, @"^\d{4}$"))
                    {
                        var pub = publishingController.GetData(publishingCombobox.SelectedItem.ToString()).First();
                        if (book != null)
                        {
                            book.Title = nameBook.Text;
                            book.Publishing = pub;
                            book.PublicationDate = datePub.Text;
                            book.AuthorBooks = CreateAB(book);
                            book.BookGenres = CreateBG(book);
                            controller.Update(book);
                        }
                        else
                        {
                            var book = new Book
                            {
                                Title = nameBook.Text,
                                PublishingId = pub.Id,
                                PublicationDate = datePub.Text
                            };
                            book.AuthorBooks = CreateAB(book);
                            book.BookGenres = CreateBG(book);
                            controller.Add(book);
                        }
                        viewButton();
                        BookForm_Load(sender, e);
                    }
                    else
                        datePubLable.Text = "Введите корректный год";
                }
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

        private void editButton_Click(object sender, EventArgs e)
        {
            if (bookTable.SelectedRows.Count == 1)
            {
                panel1.Visible = false;
                addButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                Box.Visible = true;
                Box.Text = "Редактирование";
                errorLable();

                book = ((PressBook)bookTable.SelectedRows[0].DataBoundItem).book;
                if (book != null)
                {
                    nameBook.Text = book.Title.ToString();
                    datePub.Text = book.PublicationDate.ToString();
                    var pub = publishingController.GetData();
                    publishingCombobox.SetDataToComoboBoxEdite(pub, book.Publishing);
                    foreach (var author in book.AuthorBooks)
                        authorList.Add(author.Author);
                    foreach (var genre in book.BookGenres)
                        genreList.Add(genre.Genre);
                    showData();
                }
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        private void search_Click(object sender, EventArgs e)
        {
            BookForm_Load(sender, e);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            searchField.Text = "";
            BookForm_Load(sender, e);
        }

        public Book? BookSupp;

        private void bookTable_DoubleClick(object sender, EventArgs e)
        {
            var book = ((PressBook)bookTable.SelectedRows[0].DataBoundItem).book;
            BookSupp = book;
            this.Close();
        }

        private void addPub_Click(object sender, EventArgs e)
        {
            var publ = new PublishingForm();
            publ.ShowDialog();
            var publishings = publishingController.GetData();
            if (publ.PublishingSupp != null)
                publishingCombobox.SetDataToComoboBoxEdite(publishings, publ.PublishingSupp);
            else
                publishingCombobox.SetDataToComboBox(publishings);
        }
    }
}
