using Library.Controllers;
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
    public partial class GenreReportForm : Form
    {
        ReportController reportController { get; set; }

        StaffController staffController { get; set; }

        public GenreReportForm()
        {
            reportController = new ReportController();
            staffController = new StaffController();
            InitializeComponent();
        }

        private void buttonReportGenre_Click(object sender, EventArgs e)
        {
            DateOnly start = DateOnly.Parse(startDate.Value.ToString("dd.MM.yyyy"));
            DateOnly end = DateOnly.Parse(endDate.Value.ToString("dd.MM.yyyy"));
            string cr = dateCreate.Value.ToString("dd.MM.yyyy-HH.mm");
            DateTime create = DateTime.ParseExact(cr, "dd.MM.yyyy-HH.mm", null);
            errorLable();
            bool b = CheckComboBox();
            bool se = StartEndDate(start, end);
            //bool sc = StartCreateDate(start, create);
            if (b && se)
            {
                string[] s = staffComboBox.SelectedItem.ToString().Split(" ");
                var staff = staffController.GetData(s[1], s[0]).First();

                var reportGenres = reportController.ReportGenres(start, end);

                List<List<string>> reportGenresList = new List<List<string>>
                {
                    new List<string> {"Название жанр", "Кол-во выданных книг", "Доля от общего \n числа выдач %",
                        "Количество книг с жанром"}
                };
                foreach (var item in reportGenres)
                    reportGenresList.Add(new List<string> { item.Name, item.CountBook.ToString(),
                    Math.Round(item.Popularity, 2).ToString(), item.Book.ToString()});

                ReportDesigner report2 = new ReportDesigner("Популярность литературных жанров");
                report2.AddHeader();
                report2.AddDate(start.ToString(), end.ToString());
                report2.CreateTableWithContent(reportGenresList);
                report2.AddSignatureDate();
                report2.AddSignature(staff);
                report2.Save();
            }
        }

        private void GenreReportForm_Load(object sender, EventArgs e)
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

        private void addStaff_Click(object sender, EventArgs e)
        {
            var staff = new StaffForm();
            staff.ShowDialog();
            var staffs = staffController.GetData();
            if (staff.StaffSupp != null)
                staffComboBox.SetDataToComoboBoxEdite(staffs, staff.StaffSupp);
            else
                staffComboBox.SetDataToComboBox(staffs);
        }
    }
}
