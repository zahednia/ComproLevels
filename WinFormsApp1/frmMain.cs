using Application.Services.CopyUser;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        private readonly IUserAccessService userAccess;


        public frmMain(IUserAccessService userAccess)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sourceUserId = int.Parse(textBox1.Text);
            int targetUserId = int.Parse(textBox2.Text);

            bool success = userAccess.CopyUserAccess(sourceUserId, targetUserId);

            MessageBox.Show(success ? "دسترسی‌ها منتقل شدند!" : "انتقال دسترسی‌ها ناموفق بود.");
        }
    }
}
