using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryProject2._0
{
    public partial class UserControlGenres : UserControl
    {
        LibraryModels.SoftwareprojectContext context = new();
        public UserControlGenres()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genreBindingSource.Current == null) { return; }

            LibraryModels.Genre genre = (LibraryModels.Genre)genreBindingSource.Current;

            var q = from x in context.Books
                    where x.Genres.Contains(genre)
                    select x;

            bookBindingSource.DataSource = q.ToList();
        }

        private void UserControlGenres_Load(object sender, EventArgs e)
        {
            var q = from x in context.Genres
                    orderby x.GenreName
                    select x;

            genreBindingSource.DataSource = q.ToList();
        }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bookBindingSource.Current == null) { return; }
            LibraryModels.Book book = (LibraryModels.Book)bookBindingSource.Current;

            var q = from x in context.Books
                    where book.BookId == x.BookId
                    select x;
            label3.Text = $"Short description:\n{q.ToList().First().Description}";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bookBindingSource.Current == null) { return; }
            LibraryModels.Book book = (LibraryModels.Book)bookBindingSource.Current;

            FormBooksInGenre f1 = new FormBooksInGenre(book);
            f1.ShowDialog();
        }
    }
}
