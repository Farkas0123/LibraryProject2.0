using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject2._0.LibraryModels;
using System.Windows.Forms.Design;
using System.IO;
using Microsoft.EntityFrameworkCore;


namespace LibraryProject2._0
{
    public partial class FormBooksInGenre : Form
    {
        LibraryModels.SoftwareprojectContext context = new();
        private LibraryModels.Book Book { get; set; }
        public FormBooksInGenre()
        {
            InitializeComponent();
        }
        public FormBooksInGenre(LibraryModels.Book b)
        {
            InitializeComponent();
            Book = b;
        }

        private void FormBooksInGenre_Load(object sender, EventArgs e)
        {
            label1.Text = $"The individual book items of {Book.Title}";
            var q = from x in context.BookItems
                    where x.BookId == Book.BookId
                    select new WhereAre()
                    {
                        Title = x.Book.Title,
                        Author = x.Book.Authors.First().FirstName + " " + x.Book.Authors.First().LastName,
                        Status = x.StatusCodeNavigation.Description,
                        Start = x.TakeOutRecords.First().StartDate,
                        End = x.TakeOutRecords.First().DueDate,
                        Return = x.TakeOutRecords.First().ReturnDate
                    };
            dataGridView1.DataSource = q.ToList();
        }
    }
    public class WhereAre()
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public DateTime? Return { get; set; }
    }
}
