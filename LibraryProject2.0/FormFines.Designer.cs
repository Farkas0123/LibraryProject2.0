namespace LibraryProject2._0
{
    partial class FormFines
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            labelName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(623, 187);
            dataGridView1.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Yellow;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelName.ForeColor = Color.Red;
            labelName.Location = new Point(91, 76);
            labelName.Name = "labelName";
            labelName.Size = new Size(114, 28);
            labelName.TabIndex = 1;
            labelName.Text = "labelName";
            // 
            // FormFines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelName);
            Controls.Add(dataGridView1);
            Name = "FormFines";
            Text = "FormFines";
            Load += FormFines_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelName;
    }
}