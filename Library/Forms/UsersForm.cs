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
    public partial class UsersForm : Form
    {
        private UserController controller;

        private User? user { get; set; }

        public UsersForm()
        {
            controller = new UserController();
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            if (searchField.Text.Trim() == "")
                userTable.DataSource = controller.GetData();
            else
            {
                userTable.DataSource = controller.GetData();
            }

            userTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            userTable.ReadOnly = true;
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
            readerID.Text = "";
            user = null;
            errorLable();
        }

        private void errorLable()
        {
            firstNameLable.Text = "";
            lastNameLable.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            readerID.Text = controller.GetHashCode().ToString();
            Box.Visible = true;
            Box.Text = "Добавление";
            user = null;
            errorLable();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLable();
                Dictionary<TextBox, Label> errorLables = new Dictionary<TextBox, Label>
                {
                    {firstName, firstNameLable },
                    {lastName, lastNameLable },
                };
                bool isValid = Validator.ValidateTextBox(errorLables);
                if (isValid)
                {
                    if (user != null)
                    {
                        user.FirstName = firstName.Text;
                        user.LastName = lastName.Text;
                        user.Patronymic = patron.Text;
                        controller.Update(user);
                    }
                    else
                    {
                        var us = new User
                        {
                            FirstName = firstName.Text,
                            LastName = lastName.Text,
                            Patronymic = patron.Text,
                            Ticket = int.Parse(readerID.Text)
                        };
                        controller.Add(us);
                    }
                    viewButton();
                    UsersForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count == 1)
            {
                panel1.Visible = false;
                addButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                Box.Visible = true;
                Box.Text = "Редактирование";
                errorLable();

                user = (User)userTable.SelectedRows[0].DataBoundItem;
                if (user != null)
                {
                    firstName.Text = user.FirstName.ToString();
                    lastName.Text = user.LastName.ToString();
                    patron.Text = user.Patronymic.ToString();
                    readerID.Text = user.Ticket.ToString();
                }
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count == 1)
            {
                var auth = userTable.SelectedRows[0].DataBoundItem as User;
                if (auth != null)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show(
                            "Удалить читателя", "Сообщение", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            controller.Delete(auth);
                            UsersForm_Load(sender, e);
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
            UsersForm_Load(sender, e);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            searchField.Text = "";
            UsersForm_Load(sender, e);
        }
    }
}
