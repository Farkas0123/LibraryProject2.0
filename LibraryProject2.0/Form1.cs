using LibraryProject2._0.LibraryModels;

namespace LibraryProject2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlAuthors userControlAuthors = new UserControlAuthors();
            panel1.Controls.Clear();
            panel1.Controls.Add(userControlAuthors);
            userControlAuthors.Dock = DockStyle.Fill;
            label1.Text = "OUTLINE:\nIn this menu you can search authors and then view their books in the system\n🤓";
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlBooks books = new UserControlBooks();
            panel1.Controls.Clear();
            panel1.Controls.Add(books);
            books.Dock = DockStyle.Fill;
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlGenres genres = new UserControlGenres();
            panel1.Controls.Clear();
            panel1.Controls.Add(genres);
            genres.Dock = DockStyle.Fill;
            label1.Text = "OUTLINE:\nIn this menu you can select a genre and get information about the books in it\n🤓";
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlMembers members = new UserControlMembers();
            panel1.Controls.Clear();
            panel1.Controls.Add(members);
            members.Dock = DockStyle.Fill;
            label1.Text = "OUTLINE:\nIn this menu you can look at out members and get meaningful insights about their take out records\n🤓";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "OUTLINE:\nThis application helps you to navigate through an imaginary Library database.\nTo get started please select" +
                "from the options in the file menu.";
        }
    }
}
