namespace LibraryProject2._0
{
    partial class UserControlAuthors
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
            button1 = new Button();
            buttonShowNewForm = new Button();
            button3 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            originDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label2 = new Label();
            authorCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 85);
            button1.Name = "button1";
            button1.Size = new Size(231, 49);
            button1.TabIndex = 0;
            button1.Text = "Load all the authors in the database";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonShowNewForm
            // 
            buttonShowNewForm.Location = new Point(24, 173);
            buttonShowNewForm.Name = "buttonShowNewForm";
            buttonShowNewForm.Size = new Size(231, 38);
            buttonShowNewForm.TabIndex = 1;
            buttonShowNewForm.Text = "View selected author's books";
            buttonShowNewForm.UseVisualStyleBackColor = true;
            buttonShowNewForm.Click += buttonShowNewForm_Click;
            // 
            // button3
            // 
            button3.Location = new Point(24, 386);
            button3.Name = "button3";
            button3.Size = new Size(148, 38);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(234, 60);
            label1.TabIndex = 3;
            label1.Text = "AUTHORS";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, originDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = authorBindingSource;
            dataGridView1.Location = new Point(288, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(871, 503);
            dataGridView1.TabIndex = 4;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // originDataGridViewTextBoxColumn
            // 
            originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            originDataGridViewTextBoxColumn.HeaderText = "Origin";
            originDataGridViewTextBoxColumn.MinimumWidth = 6;
            originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            originDataGridViewTextBoxColumn.ReadOnly = true;
            originDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorBindingSource
            // 
            authorBindingSource.DataSource = typeof(LibraryModels.Author);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 224);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 6;
            label2.Text = "Search by name";
            // 
            // authorCount
            // 
            authorCount.AutoSize = true;
            authorCount.Location = new Point(24, 137);
            authorCount.Name = "authorCount";
            authorCount.Size = new Size(152, 20);
            authorCount.TabIndex = 7;
            authorCount.Text = "Number of author's: 0";
            // 
            // UserControlAuthors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            Controls.Add(authorCount);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(buttonShowNewForm);
            Controls.Add(button1);
            Name = "UserControlAuthors";
            Size = new Size(1177, 604);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonShowNewForm;
        private Button button3;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private BindingSource authorBindingSource;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private Label authorCount;
    }
}
