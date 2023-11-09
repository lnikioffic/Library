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
    }
}
