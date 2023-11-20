using Library.Controllers;
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
    public partial class JournalForm : Form
    {
        private JournalController controller;

        private StaffController staffController;

        private UserController userController;

        private BookController bookController;

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
            var dt = controller.GetData();
            journalTable.DataSource = dt;
            journalTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
