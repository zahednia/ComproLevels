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

        public int Id { get; }

        public frmMain(IUserAccessService userAccess , int Id)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            this.Id = Id;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = userAccess.CopyUserAccess(new AccessLevel(), Id);
        }
    }
}
