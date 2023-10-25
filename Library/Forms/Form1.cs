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
    }
}