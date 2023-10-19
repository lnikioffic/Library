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
    }
}