using Library.Controllers;
using Library.Models;
using Library.Representation;
using Library.tools;
using Npgsql.Internal.TypeHandlers.DateTimeHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class JournalForm : Form
    {
        private JournalController controller;

        private StaffController staffController;

        private UserController userController;

        private BookController bookController;

        private Journal? journal { get; set; }

        public JournalForm()
        {
            controller = new JournalController();
            staffController = new StaffController();
            userController = new UserController();
            bookController = new BookController();
            InitializeComponent();
        }

        private void JournalForm_Load(object sender, EventArgs e)
        {
            if (searchField.Text.Trim() == "")
                journalTable.DataSource = controller.GetData();
            else
                journalTable.DataSource = controller.GetData(searchField.Text);

            journalTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            journalTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            journalTable.ReadOnly = true;

            var books = bookController.GetActuall();
            var staffs = staffController.GetData();
            var users = userController.GetData();
            bookCombobox.SetDataToComboBox(books);
            staffComboBox.SetDataToComboBox(staffs);
            userComboBox.SetDataToComboBox(users);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            Box.Visible = true;
            Box.Text = "Добавление";
            staffLabel.Text = ""; bookLable.Text = ""; userLable.Text = "";
            dateOfIssuedLable.Text = "";
            estimatedReturnDateLable.Text = "";
            actualReturnDateLable.Text = "";
        }

        private void viewButton(object sender, EventArgs e)
        {
            panel1.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            Box.Visible = false;
            dataLable.Visible = false;
            actualReturnDate.Visible = false;
            actualReturnDateLable.Visible = false;
            bookCombobox.SetDataNull();
            journal = null;
            JournalForm_Load(sender, e);
            errorLable();
        }

        private void errorLable()
        {
            staffLabel.Text = ""; bookLable.Text = ""; userLable.Text = "";
            dateOfIssuedLable.Text = "";
            estimatedReturnDateLable.Text = "";
            actualReturnDateLable.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton(sender, e);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLable();
                Dictionary<ComboBox, Label> errorComboBox = new Dictionary<ComboBox, Label>
                {
                    {staffComboBox, staffLabel},
                    {bookCombobox, bookLable },
                    {userComboBox, userLable},
                };
                bool isValidComboBox = Validator.ValidateComboBox(errorComboBox);
                if (isValidComboBox)
                {
                    var book = bookController.GetData(bookCombobox.SelectedItem.ToString()).First();
                    string[] s = staffComboBox.SelectedItem.ToString().Split(" ");
                    var staff = staffController.GetData(s[1], s[0]).First();
                    string[] u = userComboBox.SelectedItem.ToString().Split(" ");
                    var user = userController.GetData(u[1], u[0]).First();
                    DateOnly d1 = DateOnly.Parse(dateOfIssued.Value.ToString("dd.MM.yyyy"));
                    DateOnly d2 = DateOnly.Parse(estimatedReturnDate.Value.ToString("dd.MM.yyyy"));
                    DateOnly d3 = DateOnly.Parse(actualReturnDate.Value.ToString("dd.MM.yyyy"));
                    if (d1 <= d2)
                    {
                        if (journal != null)
                        {
                            if (d1 <= d3)
                            {
                                journal.DateOfIssued = d1;
                                journal.EstimatedReturnDate = d2;
                                journal.ActualReturnDate = d3;
                                journal.Book = book;
                                journal.User = user;
                                journal.Staff = staff;
                                controller.Update(journal);
                                viewButton(sender, e);
                            }
                            else
                                actualReturnDateLable.Text = "Дата возврата должна быть \n больше даты выдачи";
                        }
                        else
                        {
                            var journal = new Journal
                            {
                                DateOfIssued = d1,
                                EstimatedReturnDate = d2,
                                BookId = book.Id,
                                StaffId = staff.Id,
                                UserId = user.Id,
                            };
                            controller.Add(journal);
                            viewButton(sender, e);
                        }
                    }
                    else
                        estimatedReturnDateLable.Text = "Дата возврата должна быть \n больше даты выдачи";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (journalTable.SelectedRows.Count == 1)
            {
                panel1.Visible = false;
                addButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                Box.Visible = true;
                Box.Text = "Редактирование";
                dataLable.Visible = true;
                actualReturnDate.Visible = true;
                actualReturnDateLable.Visible = true;
                errorLable();

                journal = (Journal)journalTable.SelectedRows[0].DataBoundItem;
                if (journal != null)
                {
                    dateOfIssued.Value = DateTime.Parse(journal.DateOfIssued.ToString());
                    estimatedReturnDate.Value = DateTime.Parse(journal.EstimatedReturnDate.ToString());
                    if (journal.ActualReturnDate == null)
                        actualReturnDate.Value = DateTime.Today;
                    else
                        actualReturnDate.Value = DateTime.Parse(journal.ActualReturnDate.ToString());
                    //новый запрос с книгой и со сложением листов
                    var books = bookController.GetActuall();
                    if (journal.ActualReturnDate == null)
                        books.Add(journal.Book);
                    var staffs = staffController.GetData();
                    var users = userController.GetData();
                    bookCombobox.SetDataToComoboBoxEdite(books, journal.Book);
                    staffComboBox.SetDataToComoboBoxEdite(staffs, journal.Staff);
                    userComboBox.SetDataToComoboBoxEdite(users, journal.User);
                }
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (journalTable.SelectedRows.Count == 1)
            {
                var j = journalTable.SelectedRows[0].DataBoundItem as Journal;
                if (j != null)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show(
                            "Удалить читателя", "Сообщение", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            controller.Delete(j);
                            JournalForm_Load(sender, e);
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

        private void search_Click(object sender, EventArgs e)
        {
            JournalForm_Load(sender, e);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            searchField.Text = "";
            JournalForm_Load(sender, e);
        }
    }
}
