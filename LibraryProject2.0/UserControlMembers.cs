using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace LibraryProject2._0
{
    public partial class UserControlMembers : UserControl
    {
        LibraryModels.SoftwareprojectContext context = new();
        public UserControlMembers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var q = from x in context.Members
                    orderby x.FirstName
                    select x;
            memberBindingSource.DataSource = q.ToList();
        }

        private void memberBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (memberBindingSource.Current == null)
            {
                return;
            }
            var memb = (LibraryModels.Member)memberBindingSource.Current;

            var q2 = from x in context.TakeOutRecords
                     where x.MemberId == memb.MemberId
                     select new TakeOut
                     {
                         MembName = x.Member.FirstName + x.Member.LastName,
                         BookName = x.BarcodeNavigation.Book.Title,
                         Start = x.StartDate,
                         End = x.DueDate,
                         Return = x.ReturnDate,
                         Status = x.BarcodeNavigation.StatusCodeNavigation.Description
                     };

            dataGridViewTake.DataSource = q2.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (memberBindingSource.Current == null){ return; }
            LibraryModels.Member m = (LibraryModels.Member)memberBindingSource.Current;

            FormFines f1 = new FormFines(m);
            f1.ShowDialog();
        }
    }
    public class TakeOut()
    {
        public string MembName { get; set; }
        public string BookName { get; set; }
        public DateTime Start{ get; set; }
        public DateTime End { get; set; }
        public DateTime? Return { get; set; }
        public string Status { get; set; }
    }
}
