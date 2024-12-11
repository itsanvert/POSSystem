namespace POSSystem.Forms.ImportDetail
{
    partial class FrmList
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
            label10 = new Label();
            txtSearch = new TextBox();
            button4 = new Button();
            button3 = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(15, 9);
            label10.Name = "label10";
            label10.Size = new Size(266, 41);
            label10.TabIndex = 29;
            label10.Text = "Import Detail List";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(17, 752);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(313, 27);
            txtSearch.TabIndex = 28;
            // 
            // button4
            // 
            button4.Location = new Point(1133, 734);
            button4.Name = "button4";
            button4.Size = new Size(104, 51);
            button4.TabIndex = 27;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1259, 733);
            button3.Name = "button3";
            button3.Size = new Size(104, 51);
            button3.TabIndex = 26;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(351, 737);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 51);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1475, 659);
            dataGridView1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(1386, 732);
            button1.Name = "button1";
            button1.Size = new Size(104, 51);
            button1.TabIndex = 30;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 795);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(txtSearch);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmList";
            Text = "FrmList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox txtSearch;
        private Button button4;
        private Button button3;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button button1;
    }
}