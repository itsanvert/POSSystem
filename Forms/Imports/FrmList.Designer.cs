namespace POSSystem.Forms.Import
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
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1496, 696);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(340, 767);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 51);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1404, 767);
            button2.Name = "button2";
            button2.Size = new Size(104, 51);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1265, 767);
            button3.Name = "button3";
            button3.Size = new Size(104, 51);
            button3.TabIndex = 3;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1131, 767);
            button4.Name = "button4";
            button4.Size = new Size(104, 51);
            button4.TabIndex = 4;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 779);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(313, 27);
            txtSearch.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1479, 5);
            label1.Name = "label1";
            label1.Size = new Size(29, 31);
            label1.TabIndex = 22;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 5);
            label10.Name = "label10";
            label10.Size = new Size(174, 41);
            label10.TabIndex = 23;
            label10.Text = "Import List";
            // 
            // FrmList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1520, 842);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmList";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmList";
            Load += FrmList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearch;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtSearch;
        private Label label1;
        private Label label10;
    }
}