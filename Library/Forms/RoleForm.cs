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
    public partial class RoleForm : Form
    {
        private RoleController controller;

        private Role? role { get; set; }

        public RoleForm()
        {
            controller = new RoleController();
            InitializeComponent();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            if (searchField.Text.Trim() == "")
                roleTable.DataSource = controller.GetData();
            else
                roleTable.DataSource = controller.Get(searchField.Text);

            roleTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roleTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            roleTable.ReadOnly = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            Box.Visible = true;
            Box.Text = "Добавление";
            nameRole.Text = "";
            role = null;
            errorLable();
        }

        private void errorLable()
        {
            roleLable.Text = "";
        }

        private void viewButton()
        {
            panel1.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            Box.Visible = false;
            nameRole.Text = "";
            role = null;
            errorLable();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLable();
                Dictionary<TextBox, Label> errorLables = new Dictionary<TextBox, Label>
                {
                    {nameRole, roleLable }
                };
                bool isValid = Validator.ValidateTextBox(errorLables);
                if (isValid)
                {
                    if (role != null)
                    {
                        role.NameRole = nameRole.Text;
                        controller.Update(role);
                    }
                    else
                    {
                        var role = new Role
                        {
                            NameRole = nameRole.Text
                        };
                        controller.Add(role);
                    }
                    viewButton();
                    RoleForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (roleTable.SelectedRows.Count == 1)
            {
                panel1.Visible = false;
                addButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                Box.Visible = true;
                Box.Text = "Редактирование";
                errorLable();

                role = (Role)roleTable.SelectedRows[0].DataBoundItem;
                if (role != null)
                    nameRole.Text = role.NameRole.ToString();
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (roleTable.SelectedRows.Count == 1)
            {
                var rol = roleTable.SelectedRows[0].DataBoundItem as Role;
                if (rol != null)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show(
                            "Удалить роль", "Сообщение", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            controller.Delete(rol);
                            RoleForm_Load(sender, e);
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
            RoleForm_Load(sender, e);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            searchField.Text = "";
            RoleForm_Load(sender, e);
        }

        public Role? RoleSupp;

        private void roleTable_DoubleClick(object sender, EventArgs e)
        {
            var rol = (Role)roleTable.SelectedRows[0].DataBoundItem;
            RoleSupp = rol;
            this.Close();
        }
    }
}
