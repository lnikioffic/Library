﻿using Library.Controllers;
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
            if (searchField.Text.Trim() == "")
                userTable.DataSource = controller.GetData();
            else
                userTable.DataSource = controller.GetData(searchField.Text);

            userTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            userTable.ReadOnly = true;
            userTable.RowHeadersVisible = false;

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
            errorLable();
        }

        private void errorLable()
        {
            firstNameLable.Text = "";
            lastNameLable.Text = "";
            roleLable.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
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
                Staff selStaff = null;
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
                        selStaff = controller.Update(user);
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
                        selStaff = controller.Add(us);
                    }
                    viewButton();
                    StaffForm_Load(sender, e);
                    userTable.ClearSelection();
                    foreach (DataGridViewRow row in userTable.Rows)
                    {
                        string f = row.Cells["FirstName"].Value.ToString();
                        string l = row.Cells["LastName"].Value.ToString();
                        if (row.Cells["LastName"].Value != null
                            && l == selStaff.LastName && f == selStaff.FirstName)
                            row.Selected = true;
                    }
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

                user = (Staff)userTable.SelectedRows[0].DataBoundItem;
                if (user != null)
                {
                    firstName.Text = user.FirstName.ToString();
                    lastName.Text = user.LastName.ToString();
                    patron.Text = user.Patronymic.ToString();
                    var roles = roleController.GetData();
                    roleComboBox.SetDataToComoboBoxEdite(roles, user.Role);
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
                            "Удалить сотрудника?", "Сообщение", MessageBoxButtons.OKCancel);
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

        private void search_Click(object sender, EventArgs e)
        {
            StaffForm_Load(sender, e);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            searchField.Text = "";
            StaffForm_Load(sender, e);
        }

        public Staff? StaffSupp;

        private void userTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var sta = (Staff)userTable.SelectedRows[0].DataBoundItem;
            StaffSupp = sta;
            this.Close();
        }

        private void addRole_Click(object sender, EventArgs e)
        {
            var role = new RoleForm();
            role.ShowDialog();
            var roles = roleController.GetData();
            if (role.RoleSupp != null)
                roleComboBox.SetDataToComoboBoxEdite(roles, role.RoleSupp);
            else
                roleComboBox.SetDataToComboBox(roles);
        }
    }
}
