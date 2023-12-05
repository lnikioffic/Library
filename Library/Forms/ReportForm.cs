using Library.Controllers;
using Library.Models.ReportModels;
using Library.tools;
using Microsoft.Office.Interop.Word;
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
    public partial class ReportForm : Form
    {
        ReportController reportController { get; set; }

        StaffController staffController { get; set; }

        public ReportForm()
        {
            reportController = new ReportController();
            staffController = new StaffController();
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            var staffs = staffController.GetData();
            staffComboBox.SetDataToComboBox(staffs);
            errorLable();
        }

        private bool CheckComboBox()
        {
            Dictionary<ComboBox, Label> errorComboBox = new Dictionary<ComboBox, Label>
                {
                    {staffComboBox, staffLabel},
                };
            return Validator.ValidateComboBox(errorComboBox);
        }

        private bool StartEndDate(DateOnly startDate, DateOnly endDate)
        {
            if (!(startDate < endDate))
                estimatedReturnDateLable.Text = "Неправильный период";
            return startDate < endDate;
        }

        private bool StartCreateDate(DateOnly startDate, DateOnly createDate)
        {
            if (!(startDate > createDate))
                createLable.Text = "Дата создания отчёта должна быть " +
                    "\n больше начало периода";
            return startDate > createDate;
        }

        private void errorLable()
        {
            staffLabel.Text = "";
            dateOfIssuedLable.Text = "";
            estimatedReturnDateLable.Text = "";
            createLable.Text = "";
        }

        private void buttonReportGenre_Click(object sender, EventArgs e)
        {
            DateOnly start = DateOnly.Parse(startDate.Value.ToString("dd.MM.yyyy"));
            DateOnly end = DateOnly.Parse(endDate.Value.ToString("dd.MM.yyyy"));
            DateOnly create = DateOnly.Parse(dateCreate.Value.ToString("dd.MM.yyyy"));
            errorLable();
            bool b = CheckComboBox();
            bool se = StartEndDate(start, end);
            bool sc = StartCreateDate(start, create);
            if (b && se && sc)
            {
                var staff = staffComboBox.SelectedItem.ToString();

                var reportGenres = reportController.ReportGenres(start, end);

                List<List<string>> reportGenresList = new List<List<string>>
                {
                    new List<string> {"Название жанр", "Кол-во выданных книг", "Процент популярности"}
                };
                foreach (var item in reportGenres)
                    reportGenresList.Add(new List<string> { item.Name, item.CountBook.ToString(),
                    Math.Round(item.Popularity, 2).ToString() });

                ReportDesigner report2 = new ReportDesigner("Статистика по жанрам");
                report2.AddHeader();
                report2.AddDate(start.ToString(), end.ToString());
                report2.CreateTableWithContent(reportGenresList);
                report2.AddSignature(staff);
                report2.AddSignatureDate(create.ToString());
                report2.Save();
            }
        }

        private void buttonReportStaff_Click(object sender, EventArgs e)
        {
            DateOnly start = DateOnly.Parse(startDate.Value.ToString("dd.MM.yyyy"));
            DateOnly end = DateOnly.Parse(endDate.Value.ToString("dd.MM.yyyy"));
            DateOnly create = DateOnly.Parse(dateCreate.Value.ToString("dd.MM.yyyy"));
            errorLable();
            bool b = CheckComboBox();
            bool se = StartEndDate(start, end);
            bool sc = StartCreateDate(start, create);
            if (b && se && sc)
            {
                var staff = staffComboBox.SelectedItem.ToString();

                var reportStaff = reportController.ReportStaff(start, end);

                List<List<string>> reportStaffsList = new List<List<string>>
                {
                    new List<string> {"Сотрудник", "Кол-во выданных книг"}
                };
                foreach (var item in reportStaff)
                    reportStaffsList.Add(new List<string> { item.Name, item.Count.ToString() });

                ReportDesigner report = new ReportDesigner("Статистика по сотрудникам");
                report.AddHeader();
                report.AddDate(start.ToString(), end.ToString());
                report.CreateTableWithContent(reportStaffsList);
                report.AddSignature(staff);
                report.AddSignatureDate(create.ToString());
                report.Save();
            }
        }

        private void buttonReportAuthor_Click(object sender, EventArgs e)
        {
            DateOnly start = DateOnly.Parse(startDate.Value.ToString("dd.MM.yyyy"));
            DateOnly end = DateOnly.Parse(endDate.Value.ToString("dd.MM.yyyy"));
            DateOnly create = DateOnly.Parse(dateCreate.Value.ToString("dd.MM.yyyy"));
            errorLable();
            bool b = CheckComboBox();
            bool se = StartEndDate(start, end);
            bool sc = StartCreateDate(start, create);
            if (b && se && sc)
            {
                var staff = staffComboBox.SelectedItem.ToString();

                var reportAuthors = reportController.ReportAuthors(start, end);

                List<List<string>> reportAuthorsList = new List<List<string>>
                {
                    new List<string> {"Автор", "Кол-во выданных книг", "Процент популярности"}
                };
                foreach (var item in reportAuthors)
                    reportAuthorsList.Add(new List<string> { item.Name, item.CountBook.ToString(),
                    Math.Round(item.Popularity, 2).ToString()});

                ReportDesigner report3 = new ReportDesigner("Статистика по авторам");
                report3.AddHeader();
                report3.AddDate(start.ToString(), end.ToString());
                report3.CreateTableWithContent(reportAuthorsList);
                report3.AddSignature(staff);
                report3.AddSignatureDate(create.ToString());
                report3.Save();
            }
        }
    }
}
