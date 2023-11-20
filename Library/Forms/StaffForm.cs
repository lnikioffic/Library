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
    public partial class StaffForm : Form
    {
        private StaffController controller;

        private RoleController roleController;

        private Staff? user { get; set; }

        public StaffForm()
        {
            roleController = new RoleController();
            controller = new StaffController();
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            var dt = controller.GetData();
            userTable.DataSource = dt;

            var roles = roleController.GetData();
            roleComboBox.SetDataToComboBox(roles);
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
            firstNameLable.Text = ""; lastNameLable.Text = ""; roleLable.Text = "";
            user = null;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNameLable.Text = ""; lastNameLable.Text = ""; roleLable.Text = "";
                Dictionary<TextBox, Label> errorLables = new Dictionary<TextBox, Label>
                {
                    {firstName, firstNameLable },
                    {lastName, lastNameLable },
                };
                Dictionary<ComboBox, Label> errorComboBox = new Dictionary<ComboBox, Label>
                {
                    {roleComboBox, roleLable},
                };
                bool isValidTextBox = Validator.ValidateTextBox(errorLables);
                bool isValidComboBox = Validator.ValidateComboBox(errorComboBox);
                if (isValidTextBox && isValidComboBox)
                {
                    var role = roleController.GetData(roleComboBox.SelectedItem.ToString()).First();
                    if (user != null)
                    {
                        user.FirstName = firstName.Text;
                        user.LastName = lastName.Text;
                        user.Patronymic = patron.Text;
                        user.Role = role;
                        controller.Update(user);
                    }
                    else
                    {
                        var us = new Staff
                        {
                            FirstName = firstName.Text,
                            LastName = lastName.Text,
                            Patronymic = patron.Text,
                            RoleId = role.Id
                        };
                        controller.Add(us);
                    }
                    viewButton();
                    StaffForm_Load(sender, e);
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
                firstNameLable.Text = ""; lastNameLable.Text = ""; roleLable.Text = "";

                user = (Staff)userTable.SelectedRows[0].DataBoundItem;
                if (user != null)
                {
                    firstName.Text = user.FirstName.ToString();
                    lastName.Text = user.LastName.ToString();
                    patron.Text = user.Patronymic.ToString();
                    roleComboBox.SelectedText = user.Role.NameRole;
                }
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count == 1)
            {
                var auth = userTable.SelectedRows[0].DataBoundItem as Staff;
                if (auth != null)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show(
                            "Удалить читателя", "Сообщение", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            controller.Delete(auth);
                            StaffForm_Load(sender, e);
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
