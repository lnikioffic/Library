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
    public partial class BookForm : Form1
    {

        private BookController controller;

        private Book? book { get; set; }

        public BookForm()
        {
            controller = new BookController();
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            var dt = controller.GetBooks().ToList();
            bookTable.DataSource = dt;
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

        private void viewButton()
        {
            panel1.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            Box.Visible = false;
            nameBook.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton();
        }
    }
}
