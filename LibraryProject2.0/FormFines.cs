using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryProject2._0
{
    public partial class FormFines : Form
    {
        LibraryModels.SoftwareprojectContext context = new();
        private LibraryModels.Member Member { get; set; }
        public FormFines()
        {
            InitializeComponent();
        }
        public FormFines(LibraryModels.Member m)
        {
            Member = m;
            InitializeComponent();
        }

        private void FormFines_Load(object sender, EventArgs e)
        {
            var fines = from x in context.TakeOutRecords
                        where x.MemberId == Member.MemberId
                        select x.TakeOutId;

            var finesList = fines.ToList();
            var q = from x in context.Fines
                    where finesList.Contains(x.TakeOutId)
                    select new FineInfo()
                    {
                        BookName = x.TakeOut.BarcodeNavigation.Book.Title,
                        Start = x.TakeOut.StartDate,
                        End = x.TakeOut.DueDate,
                        Return = x.TakeOut.ReturnDate,
                        Amount = x.Amount
                    };
            dataGridView1.DataSource = q.ToList();
            labelName.Text = $"The fines {Member.FirstName +" "+Member.LastName} accumulated: {q.Count()}";

        }
    }

    internal class FineInfo()
    {
        public object BookName { get; set; }
        public object Start { get; set; }
        public object End { get; set; }
        public object Return { get; set; }
        public object Amount { get; set; }
    }
}
