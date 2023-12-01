﻿using Library.Controllers;
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
using Library.tools;

namespace Library
{
    public partial class MainMenu : Form1
    {
        JournalController JournalController { get; set; }

        public MainMenu()
        {
            JournalController = new JournalController();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var a = JournalController.GetReport();

            //ReportDesigner report = new ReportDesigner(a);
            MessageBox.Show(JournalController.G());
        }
    }
}
