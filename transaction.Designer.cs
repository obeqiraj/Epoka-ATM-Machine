namespace Loading_form
{
    partial class transaction
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            transactionDga = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionDga).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 56, 79);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-48, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(897, 109);
            panel2.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Demi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(825, 0);
            label5.Name = "label5";
            label5.Size = new Size(25, 30);
            label5.TabIndex = 7;
            label5.Text = "x";
            label5.Click += label5_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(866, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 30);
            label1.TabIndex = 6;
            label1.Text = "x";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(1046, 0);
            label4.Name = "label4";
            label4.Size = new Size(25, 30);
            label4.TabIndex = 5;
            label4.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(191, 24);
            label2.Name = "label2";
            label2.Size = new Size(493, 61);
            label2.TabIndex = 4;
            label2.Text = "EPOKA ATM MACHINE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(400, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 34);
            label3.TabIndex = 6;
            label3.Text = "BACK";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 56, 79);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-33, 413);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 43);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium Cond", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(48, 56, 79);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(264, 107);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(264, 37);
            label6.TabIndex = 21;
            label6.Text = "TRANSACTION HISTORY";
            // 
            // transactionDga
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            transactionDga.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            transactionDga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            transactionDga.ColumnHeadersHeight = 20;
            transactionDga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            transactionDga.DefaultCellStyle = dataGridViewCellStyle3;
            transactionDga.GridColor = Color.FromArgb(231, 229, 255);
            transactionDga.Location = new Point(12, 142);
            transactionDga.Name = "transactionDga";
            transactionDga.RowHeadersVisible = false;
            transactionDga.RowTemplate.Height = 25;
            transactionDga.Size = new Size(776, 265);
            transactionDga.TabIndex = 22;
            transactionDga.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            transactionDga.ThemeStyle.AlternatingRowsStyle.Font = null;
            transactionDga.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            transactionDga.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            transactionDga.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            transactionDga.ThemeStyle.BackColor = Color.White;
            transactionDga.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            transactionDga.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(48, 56, 79);
            transactionDga.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            transactionDga.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            transactionDga.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            transactionDga.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            transactionDga.ThemeStyle.HeaderStyle.Height = 20;
            transactionDga.ThemeStyle.ReadOnly = false;
            transactionDga.ThemeStyle.RowsStyle.BackColor = Color.White;
            transactionDga.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            transactionDga.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            transactionDga.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            transactionDga.ThemeStyle.RowsStyle.Height = 25;
            transactionDga.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            transactionDga.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            transactionDga.CellContentClick += transactionDga_CellContentClick;
            // 
            // transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(transactionDga);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "transaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "transaction";
            Load += transaction_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionDga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView transactionDga;
    }
}