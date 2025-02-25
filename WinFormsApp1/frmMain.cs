using Application.Services.CopyUser;
using ApplicationCompro.Services.GetListDG;
using ApplicationCompro.Services.ShowName;



namespace WinFormsApp1
{
    public partial class frmMain : Form
    {

        private readonly IUserAccessService userAccess;
        private readonly IGetListService getMabda;
        private readonly IGetListServiceMaghsad getMaghsad;
        private readonly IShowName showName;
        private int sourceUserId;
        private int targetUserId;
        public frmMain(IUserAccessService userAccess,
            IGetListService getMabda, IGetListServiceMaghsad getMaghsad, IShowName showName)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            this.getMabda = getMabda;
            this.getMaghsad = getMaghsad;
            this.showName = showName;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var Mabda = getMabda.Execute();
            var Maghsad = getMaghsad.ExecuteMaghsad();
            SettingGridview(Mabda);
            SettingGridviewMaghsad(Maghsad);
            this.Cursor = Cursors.Default;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // یا FixedDialog و ...
            this.MaximizeBox = false;
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
            sourceUserId = int.Parse(DGMabda.CurrentRow.Cells[0].Value.ToString());
            var serviceAdd = (IShowName)Program.ServiceProvider.GetService(typeof(IShowName));
            var Code = int.Parse(DGMabda.CurrentRow.Cells[2].Value.ToString());
            var Showname = showName.ShowName(new ShowNameDTO(), Code);
            if (Showname.IsSuccess == false)
            {
                MessageBox.Show(Showname.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblmabda.Text = Showname.Data.FullNameE;
            txtMabda.Text = Showname.Data.FullNameE + " | " + Showname.Data.Code;
            lblmabda.BackColor = Color.Green;
        }


        private void DGMaghsad_DoubleClick(object sender, EventArgs e)
        {
            targetUserId = int.Parse(DGMaghsad.CurrentRow.Cells[0].Value.ToString());
            var serviceAdd = (IShowName)Program.ServiceProvider.GetService(typeof(IShowName));
            var Code = int.Parse(DGMaghsad.CurrentRow.Cells[2].Value.ToString());
            var Showname = showName.ShowName(new ShowNameDTO(), Code);
            if (Showname.IsSuccess == false)
            {
                MessageBox.Show(Showname.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblMaghsad.Text = Showname.Data.FullNameE;
            txtMaghsad.Text = Showname.Data.FullNameE + " | " + Showname.Data.Code;
            txtMaghsad.BackColor = Color.Green;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            var mabda = DGMabda.CurrentRow.Cells[1].Value.ToString();
            var maghsad = DGMaghsad.CurrentRow.Cells[1].Value.ToString();
            DialogResult dialogResult = MessageBox.Show($"به صورت کامل کپی شود ؟ {maghsad} به {mabda} آیا میخوای دسترسی کاربر",
                "کپی کردن دسترسی",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                var result = userAccess.CopyUserAccess(sourceUserId, targetUserId, copyOnlyView: false);
                MessageBox.Show(result.Message);
            }
            else if (dialogResult == DialogResult.No)
            {
                //view only
                var result = userAccess.CopyUserAccess(sourceUserId, targetUserId, copyOnlyView: true);
                MessageBox.Show(result.Message);
            }
        }

        private void txtMabda_KeyDown(object sender, KeyEventArgs e)
        {
            // اگر کلید Enter فشرده شد
            if (e.KeyCode == Keys.Enter)
            {
                // کار دکمه show را انجام بده
                btnMabda.PerformClick();
                // جلوگیرى از ادامه‌ى رویداد پیش‌فرض (مثل بیپ زدن)
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            // اگر کلید Tab فشرده شد (اختیاری است چون معمولاً ویندوز خودش تب را مدیریت می‌کند)
            else if (e.KeyCode == Keys.Tab)
            {
                // فوکوس را ببریم به تکست‌باکس بعدى
                txtMaghsad.Focus();
                // در صورت تمایل برای جلوگیری از رویداد پیش‌فرض
                e.Handled = true;
            }
        }

        private void txtMaghsad_KeyDown(object sender, KeyEventArgs e)
        {
            // اگر کلید Enter فشرده شد
            if (e.KeyCode == Keys.Enter)
            {
                // کار دکمه show را انجام بده
                btnMaghsad.PerformClick();
                // جلوگیرى از ادامه‌ى رویداد پیش‌فرض (مثل بیپ زدن)
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            // اگر کلید Tab فشرده شد (اختیاری است چون معمولاً ویندوز خودش تب را مدیریت می‌کند)
            else if (e.KeyCode == Keys.Tab)
            {
                // فوکوس را ببریم به تکست‌باکس بعدى
                txtMabda.Focus();
                // در صورت تمایل برای جلوگیری از رویداد پیش‌فرض
                e.Handled = true;
            }
        }

        private void lblMaghsad_Click(object sender, EventArgs e)
        {

        }

        private void lblmabda_Click(object sender, EventArgs e)
        {

        }
    }
}
