﻿namespace WinFormsApp1
{
    partial class frmMain
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
            lblName = new Label();
            btnDone = new Button();
            DGMaghsad = new DataGridView();
            DGMabda = new DataGridView();
            txtMaghsad = new TextBox();
            txtMabda = new TextBox();
            btnMaghsad = new Button();
            btnMabda = new Button();
            lblmabda = new Label();
            lblMaghsad = new Label();
            ((System.ComponentModel.ISupportInitialize)DGMaghsad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGMabda).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(192, 192, 255);
            lblName.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(536, 20);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.Yes;
            lblName.Size = new Size(243, 23);
            lblName.TabIndex = 0;
            lblName.Text = "انتقال دسترسی در کامپرو";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(192, 255, 192);
            btnDone.Location = new Point(240, 683);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(855, 78);
            btnDone.TabIndex = 1;
            btnDone.Text = "DONE";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // DGMaghsad
            // 
            DGMaghsad.AllowUserToAddRows = false;
            DGMaghsad.AllowUserToDeleteRows = false;
            DGMaghsad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGMaghsad.Location = new Point(736, 143);
            DGMaghsad.Name = "DGMaghsad";
            DGMaghsad.ReadOnly = true;
            DGMaghsad.RowTemplate.Height = 25;
            DGMaghsad.Size = new Size(394, 502);
            DGMaghsad.TabIndex = 3;
            DGMaghsad.DoubleClick += DGMaghsad_DoubleClick;
            // 
            // DGMabda
            // 
            DGMabda.AllowUserToAddRows = false;
            DGMabda.AllowUserToDeleteRows = false;
            DGMabda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGMabda.Location = new Point(192, 139);
            DGMabda.Name = "DGMabda";
            DGMabda.ReadOnly = true;
            DGMabda.RowTemplate.Height = 25;
            DGMabda.Size = new Size(394, 506);
            DGMabda.TabIndex = 4;
            DGMabda.CellContentClick += DGMabda_CellContentClick;
            DGMabda.DoubleClick += DGMabda_DoubleClick;
            // 
            // txtMaghsad
            // 
            txtMaghsad.BorderStyle = BorderStyle.FixedSingle;
            txtMaghsad.Location = new Point(736, 110);
            txtMaghsad.Name = "txtMaghsad";
            txtMaghsad.Size = new Size(250, 27);
            txtMaghsad.TabIndex = 5;
            // 
            // txtMabda
            // 
            txtMabda.Location = new Point(192, 106);
            txtMabda.Name = "txtMabda";
            txtMabda.Size = new Size(250, 27);
            txtMabda.TabIndex = 6;
            // 
            // btnMaghsad
            // 
            btnMaghsad.BackColor = Color.FromArgb(192, 192, 255);
            btnMaghsad.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaghsad.Location = new Point(992, 106);
            btnMaghsad.Name = "btnMaghsad";
            btnMaghsad.Size = new Size(117, 31);
            btnMaghsad.TabIndex = 7;
            btnMaghsad.Text = "show";
            btnMaghsad.UseVisualStyleBackColor = false;
            btnMaghsad.Click += btnMaghsad_Click;
            // 
            // btnMabda
            // 
            btnMabda.BackColor = Color.FromArgb(192, 192, 255);
            btnMabda.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMabda.Location = new Point(448, 102);
            btnMabda.Name = "btnMabda";
            btnMabda.Size = new Size(117, 31);
            btnMabda.TabIndex = 8;
            btnMabda.Text = "show";
            btnMabda.UseVisualStyleBackColor = false;
            btnMabda.Click += btnMabda_Click;
            // 
            // lblmabda
            // 
            lblmabda.AutoSize = true;
            lblmabda.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblmabda.Location = new Point(211, 72);
            lblmabda.Name = "lblmabda";
            lblmabda.Size = new Size(45, 23);
            lblmabda.TabIndex = 9;
            lblmabda.Text = "مبدا";
            // 
            // lblMaghsad
            // 
            lblMaghsad.AutoSize = true;
            lblMaghsad.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaghsad.Location = new Point(758, 72);
            lblMaghsad.Name = "lblMaghsad";
            lblMaghsad.Size = new Size(62, 23);
            lblMaghsad.TabIndex = 10;
            lblMaghsad.Text = "مقصد";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 786);
            Controls.Add(lblMaghsad);
            Controls.Add(lblmabda);
            Controls.Add(btnMabda);
            Controls.Add(btnMaghsad);
            Controls.Add(txtMabda);
            Controls.Add(txtMaghsad);
            Controls.Add(DGMaghsad);
            Controls.Add(btnDone);
            Controls.Add(lblName);
            Controls.Add(DGMabda);
            Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            RightToLeft = RightToLeft.No;
            Text = "انتقال دسترسی";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)DGMaghsad).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGMabda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnDone;
        private DataGridView DGMaghsad;
        private DataGridView DGMabda;
        private TextBox txtMaghsad;
        private TextBox txtMabda;
        private Button btnMaghsad;
        private Button btnMabda;
        private Label lblmabda;
        private Label lblMaghsad;
    }
}