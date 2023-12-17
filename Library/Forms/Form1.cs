using Library.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenreMenuItem_Click(object sender, EventArgs e)
        {
            var genreForm = new GenreForm();
            genreForm.Show();
        }

        private void PublishMenuItem_Click(object sender, EventArgs e)
        {
            var publishForm = new PublishingForm();
            publishForm.Show();
        }

        private void AuthorMenuItem_Click(object sender, EventArgs e)
        {
            var authroForm = new AuthorForm();
            authroForm.Show();
        }

        private void BookMenuItem_Click(object sender, EventArgs e)
        {
            var bookForm = new BookForm();
            bookForm.Show();
        }

        private void JournalMenuItem_Click(object sender, EventArgs e)
        {
            var journalForm = new JournalForm();
            journalForm.Show();
        }

        private void StaffMenuItem_Click(object sender, EventArgs e)
        {
            var staffForm = new StaffForm();
            staffForm.Show();
        }

        private void UserMenuItem_Click(object sender, EventArgs e)
        {
            var userForm = new UsersForm();
            userForm.Show();
        }

        private void GenereReportStripMenuItem_Click(object sender, EventArgs e)
        {
            var genreReport = new GenreReportForm();
            genreReport.Show();
        }

        private void AuthorReportStripMenuItem_Click(object sender, EventArgs e)
        {
            var authorReport = new AuthorRepotForm();
            authorReport.Show();
        }

        private void StaffReportStripMenuItem5_Click(object sender, EventArgs e)
        {
            var staffReport = new ReturnReportForm();
            staffReport.Show();
        }
    }
}