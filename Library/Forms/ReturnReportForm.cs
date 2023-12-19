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
    public partial class ReturnReportForm : Form
    {
        ReportController reportController { get; set; }

        StaffController staffController { get; set; }

        public ReturnReportForm()
        {
            reportController = new ReportController();
            staffController = new StaffController();
            InitializeComponent();
        }

        private void SataffReportForm_Load(object sender, EventArgs e)
        {
            var staffs = staffController.GetData();
            staffComboBox.SetDataToComboBox(staffs);
            errorLable();
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

        private void buttonReportStaff_Click(object sender, EventArgs e)
        {
            DateOnly start = DateOnly.Parse(startDate.Value.ToString("dd.MM.yyyy"));
            DateOnly end = DateOnly.Parse(endDate.Value.ToString("dd.MM.yyyy"));
            errorLable();
            bool b = CheckComboBox();
            //bool se = StartEndDate(start, end);
            bool se = true;
            if (b && se)
            {
                string[] s = staffComboBox.SelectedItem.ToString().Split(" ");
                var staff = staffController.GetData(s[1], s[0]).First();

                var reportReturneds = reportController.ReportReturneds(start, end);

                List<List<string>> reportReturnedsList = new List<List<string>>
                {
                    new List<string> {"Книга", "Авторы", "Предполагаема дата возврата",
                        "Пропущено дней", "Читатель"}
                };
                foreach (var item in reportReturneds)
                    reportReturnedsList.Add(new List<string> { item.BookTitel, item.Authors,
                        item.EstimatedReturnDate, item.MissedDays.ToString(), item.User});

                ReportDesigner report = new ReportDesigner("Не возвращённые книги");
                report.AddHeader();
                report.AddDate();
                report.CreateTableWithContent(reportReturnedsList);
                report.AddSignatureDate();
                report.AddSignature(staff);
                report.Save();
            }
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

        private void errorLable()
        {
            staffLabel.Text = "";
            dateOfIssuedLable.Text = "";
            estimatedReturnDateLable.Text = "";
        }
    }
}
