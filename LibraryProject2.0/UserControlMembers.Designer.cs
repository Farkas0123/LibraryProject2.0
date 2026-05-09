namespace LibraryProject2._0
{
    partial class UserControlMembers
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
            label2 = new Label();
            listBox1 = new ListBox();
            memberBindingSource = new BindingSource(components);
            dataGridViewTake = new DataGridView();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTake).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(215, 54);
            label1.TabIndex = 0;
            label1.Text = "MEMBERS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 89);
            label2.Name = "label2";
            label2.Size = new Size(173, 28);
            label2.TabIndex = 1;
            label2.Text = "All the members:";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.DataSource = memberBindingSource;
            listBox1.DisplayMember = "FirstName";
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(25, 119);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(211, 504);
            listBox1.TabIndex = 2;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(LibraryModels.Member);
            memberBindingSource.CurrentChanged += memberBindingSource_CurrentChanged;
            // 
            // dataGridViewTake
            // 
            dataGridViewTake.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewTake.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTake.Location = new Point(441, 119);
            dataGridViewTake.Name = "dataGridViewTake";
            dataGridViewTake.RowHeadersWidth = 51;
            dataGridViewTake.Size = new Size(750, 504);
            dataGridViewTake.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(272, 119);
            label4.Name = "label4";
            label4.Size = new Size(163, 28);
            label4.TabIndex = 6;
            label4.Text = "Takeout records";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(272, 46);
            button1.Name = "button1";
            button1.Size = new Size(174, 43);
            button1.TabIndex = 7;
            button1.Text = "Load Members";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserControlMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dataGridViewTake);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlMembers";
            Size = new Size(1207, 638);
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTake).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private BindingSource memberBindingSource;
        private DataGridView dataGridViewRes;
        private DataGridView dataGridViewTake;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
