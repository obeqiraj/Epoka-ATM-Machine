﻿namespace Loading_form
{
    partial class balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balance));
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            balancelb = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(234, 23);
            label2.Name = "label2";
            label2.Size = new Size(493, 61);
            label2.TabIndex = 4;
            label2.Text = "EPOKA ATM MACHINE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 56, 79);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-92, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(897, 109);
            panel2.TabIndex = 17;
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
            label1.Click += label1_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(442, 22);
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
            panel1.Location = new Point(-77, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 84);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(205, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(48, 56, 79);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(334, 108);
            label5.Name = "label5";
            label5.Size = new Size(117, 37);
            label5.TabIndex = 20;
            label5.Text = "BALANCE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(48, 56, 79);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(410, 213);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 30;
            label6.Text = "Your Balance is :";
            // 
            // balancelb
            // 
            balancelb.AutoSize = true;
            balancelb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            balancelb.ForeColor = Color.FromArgb(48, 56, 79);
            balancelb.ImeMode = ImeMode.NoControl;
            balancelb.Location = new Point(455, 248);
            balancelb.Name = "balancelb";
            balancelb.Size = new Size(22, 25);
            balancelb.TabIndex = 31;
            balancelb.Text = "$";
            // 
            // balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(balancelb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "balance";
            Load += balance_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label balancelb;
    }
}