using Library.Controllers;
using Library.Models;
using Library.Representation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class GenreForm : Form1
    {
        public GenreForm()
        {
            InitializeComponent();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            var genre = new GenreController();
            genreTable.DataSource = genre.GetGenres().Cast<GenreTableRepresentation>().ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            Box.Visible = true;
            Box.Text = "Добавление";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                var genre = new Genre
                {
                    Genre1 = nameGenre.Text
                };
                var genreController = new GenreController();
                DialogResult result = MessageBox.Show(
                    "Добавить жанр", "Сообщение", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    genreController.Add(genre);
                    panel1.Visible = true;
                    addButton.Enabled = true;
                    editButton.Enabled = true;
                    deleteButton.Enabled = true;
                    Box.Visible = false;
                    GenreForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            Box.Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (genreTable.SelectedRows.Count == 1)
            {
                var genre = genreTable.SelectedRows[0].DataBoundItem as GenreTableRepresentation;
                if (genre != null)
                {
                    try
                    {
                        var genreController = new GenreController();
                        DialogResult result = MessageBox.Show(
                            "Удалить жанр", "Сообщение", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            genreController.Delete(genre.RepresentEntity);
                            GenreForm_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);

            }
        }
    }
}
