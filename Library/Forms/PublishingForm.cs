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

namespace Library
{
    public partial class PublishingForm : Form
    {
        private PublishingController controller;

        private Publishing? publishing { get; set; }

        public PublishingForm()
        {
            controller = new PublishingController();
            InitializeComponent();
        }

        private void PublishingForm_Load(object sender, EventArgs e)
        {
            if (searchField.Text.Trim() == "")
                publishingTable.DataSource = controller.GetData();
            else
                publishingTable.DataSource = controller.GetData();

            publishingTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            publishingTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            publishingTable.ReadOnly = true;
        }

        private void viewButton()
        {
            panel1.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            Box.Visible = false;
            namePub.Text = "";
            adressPub.Text = "";
            publishing = null;
            namePub.Text = ""; adressPub.Text = "";
            errorLable();
        }

        private void errorLable()
        {
            namePubLable.Text = "";
            adressPubLable.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            Box.Visible = true;
            Box.Text = "Добавление";
            publishing = null;
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
                    {namePub, namePubLable },
                    {adressPub, adressPubLable },
                };
                bool isValidTextBox = Validator.ValidateTextBox(errorLables);
                if (isValidTextBox)
                {
                    if (publishing != null)
                    {
                        publishing.Name = namePub.Text;
                        publishing.Address = adressPub.Text;
                        controller.Update(publishing);
                    }
                    else
                    {
                        var pub = new Publishing
                        {
                            Name = namePub.Text,
                            Address = adressPub.Text,
                        };
                        controller.Add(pub);
                    }
                    viewButton();
                    PublishingForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (publishingTable.SelectedRows.Count == 1)
            {
                var pub = publishingTable.SelectedRows[0].DataBoundItem as Publishing;
                if (pub != null)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show(
                            "Удалить жанр", "Сообщение", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            controller.Delete(pub);
                            PublishingForm_Load(sender, e);
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
            if (publishingTable.SelectedRows.Count == 1)
            {
                panel1.Visible = false;
                addButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                Box.Visible = true;
                Box.Text = "Редактирование";
                errorLable();

                publishing = (Publishing)publishingTable.SelectedRows[0].DataBoundItem;
                if (publishing != null)
                {
                    namePub.Text = publishing.Name.ToString();
                    adressPub.Text = publishing.Address.ToString();
                }
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        private void search_Click(object sender, EventArgs e)
        {
            PublishingForm_Load(sender, e);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            searchField.Text = "";
            PublishingForm_Load(sender, e);
        }
    }
}
