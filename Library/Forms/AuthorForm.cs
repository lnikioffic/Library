using Library.Controllers;
using Library.Models;
using Library.tools;
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
    public partial class AuthorForm : Form
    {
        private AuthorController controller;

        private Author? author { get; set; }

        public AuthorForm()
        {
            controller = new AuthorController();
            InitializeComponent();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            var dt = controller.GetData();
            authorTable.DataSource = dt;
            authorTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            authorTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void viewButton()
        {
            panel1.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            Box.Visible = false;
            firstName.Text = "";
            lastName.Text = "";
            patron.Text = "";
            author = null;
            firstNameLable.Text = ""; lastNameLable.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            Box.Visible = true;
            Box.Text = "Добавление";
            author = null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (authorTable.SelectedRows.Count == 1)
            {
                var auth = authorTable.SelectedRows[0].DataBoundItem as Author;
                if (auth != null)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show(
                            "Удалить жанр", "Сообщение", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            controller.Delete(auth);
                            AuthorForm_Load(sender, e);
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
            if (authorTable.SelectedRows.Count == 1)
            {
                panel1.Visible = false;
                addButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                Box.Visible = true;
                Box.Text = "Редактирование";
                firstNameLable.Text = ""; lastNameLable.Text = "";

                author = (Author)authorTable.SelectedRows[0].DataBoundItem;
                if (author != null)
                {
                    firstName.Text = author.FirstName.ToString();
                    lastName.Text = author.LastName.ToString();
                    patron.Text = author.Patronymic.ToString();
                }
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNameLable.Text = ""; lastNameLable.Text = "";
                Dictionary<TextBox, Label> errorLables = new Dictionary<TextBox, Label>
                {
                    {firstName, firstNameLable },
                    {lastName, lastNameLable },
                };
                bool isValidTextBox = Validator.ValidateTextBox(errorLables);
                if (isValidTextBox)
                {
                    if (author != null)
                    {
                        author.FirstName = firstName.Text;
                        author.LastName = lastName.Text;
                        author.Patronymic = patron.Text;
                        controller.Update(author);
                    }
                    else
                    {
                        var pub = new Author
                        {
                            FirstName = firstName.Text,
                            LastName = lastName.Text,
                            Patronymic = patron.Text,
                        };
                        controller.Add(pub);
                    }
                    viewButton();
                    AuthorForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        public Author? AuthorSupp { get; set; }

        private void authorTable_DoubleClick(object sender, EventArgs e)
        {
            var author = (Author)authorTable.SelectedRows[0].DataBoundItem;
            AuthorSupp = author;
            this.Close();
        }
    }
}
