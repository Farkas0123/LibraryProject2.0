using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryProject2._0
{
    public partial class UserControlAuthors : UserControl
    {
        LibraryModels.SoftwareprojectContext context = new();
        public UserControlAuthors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var q = from x in context.Authors
                        orderby x.FirstName
                        select x;

                authorBindingSource.DataSource = q.ToList();
                authorCount.Text = $"Number of authors: {q.Count()}";
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occured while loading in the data: {ex.Message}", "Error");
                throw;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var q2 = from x in context.Authors
                     where (x.FirstName + " " + x.LastName).Contains(textBox1.Text)
                     select x;

            authorBindingSource.DataSource = q2.ToList();
            authorCount.Text = $"Number of authors: {q2.Count()}";
        }

        private void buttonShowNewForm_Click(object sender, EventArgs e)
        {
            if(authorBindingSource.Current == null) { return; }

            LibraryModels.Author a = (LibraryModels.Author)authorBindingSource.Current;

            FormAuthorBooks f1 = new FormAuthorBooks(a);
            f1.ShowDialog();
        }
    }
}
