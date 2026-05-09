namespace LibraryProject2._0
{
    partial class UserControlGenres
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            comboBox1 = new ComboBox();
            genreBindingSource = new BindingSource(components);
            label2 = new Label();
            listBox1 = new ListBox();
            bookBindingSource = new BindingSource(components);
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(153, 54);
            label1.TabIndex = 0;
            label1.Text = "Genres";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = genreBindingSource;
            comboBox1.DisplayMember = "GenreName";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // genreBindingSource
            // 
            genreBindingSource.DataSource = typeof(LibraryModels.Genre);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 2;
            label2.Text = "Select a genre";
            // 
            // listBox1
            // 
            listBox1.DataSource = bookBindingSource;
            listBox1.DisplayMember = "Title";
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(32, 189);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(186, 364);
            listBox1.TabIndex = 3;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(LibraryModels.Book);
            bookBindingSource.CurrentChanged += bookBindingSource_CurrentChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(344, 355);
            button1.Name = "button1";
            button1.Size = new Size(351, 198);
            button1.TabIndex = 4;
            button1.Text = "GET BOOK INFO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(344, 189);
            label3.Name = "label3";
            label3.Size = new Size(167, 28);
            label3.TabIndex = 5;
            label3.Text = "Short description:";
            // 
            // UserControlGenres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "UserControlGenres";
            Size = new Size(1242, 614);
            Load += UserControlGenres_Load;
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private BindingSource genreBindingSource;
        private Label label2;
        private ListBox listBox1;
        private BindingSource bookBindingSource;
        private Button button1;
        private Label label3;
    }
}
