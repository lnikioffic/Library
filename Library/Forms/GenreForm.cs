using Library.Controllers;
using Library.Models;
using Library.Representation;
using Library.tools;
using System;
using System.CodeDom.Compiler;
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
    public partial class GenreForm : Form
    {
        private GenreController controller;

        private Genre? genreV { get; set; }

        public GenreForm()
        {
            controller = new GenreController();
            InitializeComponent();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            var dt = controller.GetData();
            genreTable.DataSource = dt;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            Box.Visible = true;
            Box.Text = "Добавление";
            genre.Text = "";
            genreV = null;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<TextBox, Label> errorLables = new Dictionary<TextBox, Label>
                {
                    {nameGenre, genre }
                };
                bool isValid = Validator.ValidateTextBox(errorLables);
                if (isValid)
                {
                    if (genreV != null)
                    {
                        genreV.Genre1 = nameGenre.Text;
                        controller.Update(genreV);
                    }
                    else
                    {
                        var genre = new Genre
                        {
                            Genre1 = nameGenre.Text
                        };
                        controller.Add(genre);
                    }
                    viewButton();
                    GenreForm_Load(sender, e);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void viewButton()
        {
            panel1.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            Box.Visible = false;
            nameGenre.Text = "";
            genreV = null;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            viewButton();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (genreTable.SelectedRows.Count == 1)
            {
                var genre = genreTable.SelectedRows[0].DataBoundItem as Genre;
                if (genre != null)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show(
                            "Удалить жанр", "Сообщение", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            controller.Delete(genre);
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
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (genreTable.SelectedRows.Count == 1)
            {
                panel1.Visible = false;
                addButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                Box.Visible = true;
                Box.Text = "Редактирование";
                genre.Text = "";

                genreV = (Genre)genreTable.SelectedRows[0].DataBoundItem;
                if (genreV != null)
                    nameGenre.Text = genreV.Genre1.ToString();
            }
            else
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
        }

        public Genre GenSupp { get; set; }

        private void genreTable_DoubleClick(object sender, EventArgs e)
        {
            var gen = (Genre)genreTable.SelectedRows[0].DataBoundItem;
            GenSupp = gen;
            this.Close();
        }
    }
}
