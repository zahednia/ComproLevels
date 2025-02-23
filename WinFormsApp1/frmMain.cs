using Application.Services.CopyUser;
using ApplicationCompro.Services.GetListDG;
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
        private readonly IGetListService getMabda;
        private readonly IGetListServiceMaghsad getMaghsad;

        public frmMain(IUserAccessService userAccess,
            IGetListService getMabda, IGetListServiceMaghsad getMaghsad)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            this.getMabda = getMabda;
            this.getMaghsad = getMaghsad;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var Mabda = getMabda.Execute();
            var Maghsad = getMaghsad.ExecuteMaghsad();

            SettingGridview(Mabda);
            SettingGridviewMaghsad(Maghsad);

            this.Cursor = Cursors.Default;
        }

        private void SettingGridview(List<GetListDGDto> Mabda)
        {
            DGMabda.DataSource = Mabda;
            DGMabda.Columns[0].HeaderText = "ID";
            DGMabda.Columns[1].HeaderText = "نام کاربری";
            DGMabda.Columns[2].HeaderText = "پرسنلی";
            DGMabda.Columns[0].Width = 40;
            DGMabda.Columns[1].Width = 229;
            DGMabda.Columns[2].Width = 80;
        }

        private void SettingGridviewMaghsad(List<GetListDGMaghsadDto> Maghsad)
        {
            DGMaghsad.DataSource = Maghsad;
            DGMaghsad.Columns[0].HeaderText = "ID";
            DGMaghsad.Columns[1].HeaderText = "نام کاربری";
            DGMaghsad.Columns[2].HeaderText = "پرسنلی";
            DGMaghsad.Columns[0].Width = 40;
            DGMaghsad.Columns[1].Width = 229;
            DGMaghsad.Columns[2].Width = 80;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sourceUserId = int.Parse(txtMaghsad.Text);
            int targetUserId = int.Parse(txtMabda.Text);

            bool success = userAccess.CopyUserAccess(sourceUserId, targetUserId);

            MessageBox.Show(success ? "دسترسی‌ها منتقل شدند!" : "انتقال دسترسی‌ها ناموفق بود.");
        }

        private void DGMabda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMabda_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var SearchMabda = getMabda.Execute(txtMabda.Text);
            SettingGridview(SearchMabda);
            this.Cursor = Cursors.Default;
        }

        private void btnMaghsad_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var SearchMaghsad = getMaghsad.ExecuteMaghsad(txtMaghsad.Text);
            SettingGridviewMaghsad(SearchMaghsad);
            this.Cursor = Cursors.Default;
        }

        private void DGMabda_DoubleClick(object sender, EventArgs e)
        {
            int sourceUserId = int.Parse(DGMabda.CurrentRow.Cells[0].Value.ToString());
        }

        private void DGMaghsad_DoubleClick(object sender, EventArgs e)
        {
            int targetUserId = int.Parse(DGMabda.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
