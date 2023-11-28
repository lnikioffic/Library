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
using Microsoft.Office.Interop.Word;

namespace Library
{
    public partial class MainMenu : Form1
    {
        JournalController JournalController { get; set; }

        private string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/test.docx";
        public MainMenu()
        {
            JournalController = new JournalController();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var a = JournalController.GetReport();
            var word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;
            var doc = word.Documents.Add();
            doc.Range().Text = a;
            doc.SaveAs2(path);
            word.Quit();
            //MessageBox.Show(a);
        }
    }
}
