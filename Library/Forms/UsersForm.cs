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

        public UsersForm(string type)
        {
            controller = new UserController(type);
            InitializeComponent();
            if (type == "user")
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
    }
}
