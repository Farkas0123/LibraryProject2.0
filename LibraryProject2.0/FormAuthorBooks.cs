using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using LibraryProject2._0.LibraryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace LibraryProject2._0
{
    public partial class FormAuthorBooks : Form
    {
        LibraryModels.SoftwareprojectContext context = new();
        private LibraryModels.Author Author { get; set; }
        private List<BookDetailed> act { get; set; }
        public FormAuthorBooks()
        {
            InitializeComponent();
        }
        public FormAuthorBooks(LibraryModels.Author a)
        {
            Author = a;
            InitializeComponent();
        }

        private void FormAuthorBooks_Load(object sender, EventArgs e)
        {
            label1.Text = $"All the books written by {Author.LastName + ", " + Author.FirstName}";

            var q = from x in context.Books
                    where x.Authors.Contains(Author)
                    orderby x.Title
                    select new BookDetailed
                    {
                        Title = x.Title,
                        Description = x.Description,
                        Publisher = x.Publisher,
                        PublishYear = (int)x.PublishedYear,
                        Genre = string.Join(", ", x.Genres.Select(g => g.GenreName))
                    };
            act = q.ToList();
            dataGridView1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FileName = $"{Author.FirstName + Author.LastName}Books.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter w = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                    using (w)
                    {
                        w.WriteLine("Title,Description,Publisher,PublishYear,Genre");
                        for (int i = 0; i < act.Count(); i++)
                        {
                            w.WriteLine($"{act[i].Title},{act[i].Description},{act[i].Publisher},{act[i].PublishYear},{act[i].Genre}");
                        }
                    }
                    MessageBox.Show("Succesfully saved!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while exporting to csv: {ex.Message}", "Error");
                    throw;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "XLSX files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = $"{Author.FirstName + Author.LastName}Books.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Books");
                        worksheet.Cell(1, 1).Value = "Title";
                        worksheet.Cell(1, 2).Value = "Description";
                        worksheet.Cell(1, 3).Value = "Publisher";
                        worksheet.Cell(1, 4).Value = "Published Year";
                        worksheet.Cell(1, 5).Value = "Genre";

                        for (int i = 0; i < act.Count; i++)
                        {
                            worksheet.Cell(i + 2, 1).Value = act[i].Title;
                            worksheet.Cell(i + 2, 2).Value = act[i].Description;
                            worksheet.Cell(i + 2, 3).Value = act[i].Publisher;
                            worksheet.Cell(i + 2, 4).Value = act[i].PublishYear;
                            worksheet.Cell(i + 2, 5).Value = act[i].Genre;
                        }

                        var headerRange = worksheet.Range("A1:D1");
                        headerRange.Style.Font.Bold = true;

                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Succesfully saved!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while exporting to csv: {ex.Message}", "Error");
                    throw;
                }
            }
        }
    }

    public class BookDetailed
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }
        public string Genre { get; set; }
    }
}
