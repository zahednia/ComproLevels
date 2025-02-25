namespace WinFormsApp1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            PicArrow = new PictureBox();
            PicLogo = new PictureBox();
            PicLogo2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGMaghsad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGMabda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLogo2).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.Control;
            lblName.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(522, 20);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.Yes;
            lblName.Size = new Size(243, 23);
            lblName.TabIndex = 0;
            lblName.Text = "انتقال دسترسی در کامپرو";
            lblName.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(192, 255, 192);
            btnDone.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.ForeColor = Color.Black;
            btnDone.Location = new Point(230, 674);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(855, 78);
            btnDone.TabIndex = 5;
            btnDone.Text = "DONE";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // DGMaghsad
            // 
            DGMaghsad.AllowUserToAddRows = false;
            DGMaghsad.AllowUserToDeleteRows = false;
            DGMaghsad.BackgroundColor = SystemColors.Control;
            DGMaghsad.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGMaghsad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGMaghsad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGMaghsad.DefaultCellStyle = dataGridViewCellStyle2;
            DGMaghsad.Location = new Point(734, 154);
            DGMaghsad.Name = "DGMaghsad";
            DGMaghsad.ReadOnly = true;
            DGMaghsad.RowTemplate.Height = 25;
            DGMaghsad.Size = new Size(394, 469);
            DGMaghsad.TabIndex = 4;
            DGMaghsad.DoubleClick += DGMaghsad_DoubleClick;
            // 
            // DGMabda
            // 
            DGMabda.AllowUserToAddRows = false;
            DGMabda.AllowUserToDeleteRows = false;
            DGMabda.BackgroundColor = SystemColors.Control;
            DGMabda.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuBar;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGMabda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGMabda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DGMabda.DefaultCellStyle = dataGridViewCellStyle4;
            DGMabda.Location = new Point(190, 150);
            DGMabda.Name = "DGMabda";
            DGMabda.ReadOnly = true;
            DGMabda.RowTemplate.Height = 25;
            DGMabda.Size = new Size(394, 473);
            DGMabda.TabIndex = 3;
            DGMabda.CellContentClick += DGMabda_CellContentClick;
            DGMabda.DoubleClick += DGMabda_DoubleClick;
            // 
            // txtMaghsad
            // 
            txtMaghsad.BorderStyle = BorderStyle.FixedSingle;
            txtMaghsad.Location = new Point(734, 121);
            txtMaghsad.Name = "txtMaghsad";
            txtMaghsad.Size = new Size(250, 27);
            txtMaghsad.TabIndex = 2;
            txtMaghsad.KeyDown += txtMaghsad_KeyDown;
            // 
            // txtMabda
            // 
            txtMabda.Location = new Point(190, 117);
            txtMabda.Name = "txtMabda";
            txtMabda.Size = new Size(250, 27);
            txtMabda.TabIndex = 1;
            txtMabda.KeyDown += txtMabda_KeyDown;
            // 
            // btnMaghsad
            // 
            btnMaghsad.BackColor = SystemColors.ActiveBorder;
            btnMaghsad.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaghsad.Location = new Point(990, 121);
            btnMaghsad.Name = "btnMaghsad";
            btnMaghsad.Size = new Size(138, 27);
            btnMaghsad.TabIndex = 7;
            btnMaghsad.Text = "Search";
            btnMaghsad.UseVisualStyleBackColor = false;
            btnMaghsad.Click += btnMaghsad_Click;
            // 
            // btnMabda
            // 
            btnMabda.BackColor = SystemColors.ActiveBorder;
            btnMabda.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMabda.Location = new Point(446, 117);
            btnMabda.Name = "btnMabda";
            btnMabda.Size = new Size(138, 27);
            btnMabda.TabIndex = 8;
            btnMabda.Text = "Search";
            btnMabda.UseVisualStyleBackColor = false;
            btnMabda.Click += btnMabda_Click;
            // 
            // lblmabda
            // 
            lblmabda.AutoSize = true;
            lblmabda.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblmabda.Location = new Point(199, 83);
            lblmabda.Name = "lblmabda";
            lblmabda.Size = new Size(45, 23);
            lblmabda.TabIndex = 9;
            lblmabda.Text = "مبدا";
            // 
            // lblMaghsad
            // 
            lblMaghsad.AutoSize = true;
            lblMaghsad.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaghsad.Location = new Point(750, 83);
            lblMaghsad.Name = "lblMaghsad";
            lblMaghsad.Size = new Size(62, 23);
            lblMaghsad.TabIndex = 10;
            lblMaghsad.Text = "مقصد";
            lblMaghsad.Click += lblMaghsad_Click;
            // 
            // PicArrow
            // 
            PicArrow.Image = Endpoint.Properties.Resources.fast_forward;
            PicArrow.Location = new Point(608, 335);
            PicArrow.Name = "PicArrow";
            PicArrow.Size = new Size(100, 106);
            PicArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            PicArrow.TabIndex = 11;
            PicArrow.TabStop = false;
            // 
            // PicLogo
            // 
            PicLogo.Image = Endpoint.Properties.Resources.Only_Arm_Reverse;
            PicLogo.Location = new Point(771, 12);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(41, 38);
            PicLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLogo.TabIndex = 12;
            PicLogo.TabStop = false;
            // 
            // PicLogo2
            // 
            PicLogo2.Image = Endpoint.Properties.Resources.Only_Arm_Reverse;
            PicLogo2.Location = new Point(475, 12);
            PicLogo2.Name = "PicLogo2";
            PicLogo2.Size = new Size(41, 38);
            PicLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLogo2.TabIndex = 13;
            PicLogo2.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1342, 786);
            Controls.Add(PicLogo2);
            Controls.Add(PicLogo);
            Controls.Add(PicArrow);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            RightToLeft = RightToLeft.No;
            Text = "انتقال دسترسی";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)DGMaghsad).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGMabda).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLogo2).EndInit();
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
        private PictureBox PicArrow;
        private PictureBox PicLogo;
        private PictureBox PicLogo2;
    }
}