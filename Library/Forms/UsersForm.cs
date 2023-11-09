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
    public partial class UsersForm : Form1
    {
        private UserController controller;

        private User? user { get; set; }

        public UsersForm(bool staff)
        {
            controller = new UserController(staff);
            InitializeComponent();
            if (!staff)
            {
                label1.Text = "Читатели";
                this.Text = "Читатели";
            }
            else
            {
                label1.Text = "Сотрудники";
                this.Text = "Сотрудники";
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            var dt = controller.GetData();
            userTable.DataSource = dt;
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
            user = null;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
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
                    };
                    controller.Add(us);
                }
                viewButton();
                UsersForm_Load(sender, e);
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

                user = (User)userTable.SelectedRows[0].DataBoundItem;
                if (user != null)
                {
                    firstName.Text = user.FirstName.ToString();
                    lastName.Text = user.LastName.ToString();
                    patron.Text = user.Patronymic.ToString();
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
                            "Удалить жанр", "Сообщение", MessageBoxButtons.OKCancel);
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
    }
}
