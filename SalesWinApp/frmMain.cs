using BusinessObject;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public string EmailLogin { get; set; }
        public Member Member { get; set; }
        public static string[] FormShowed = { "", "Closed", "Closed", "Closed", "Closed", "Closed", "Closed" };
        private int firstShowed = 0;
        private int lastShowed = 0;

        public static ToolStripMenuItem mmStrip;
        public static ToolStripMenuItem omStrip;
        public static ToolStripMenuItem odStrip;
        public static ToolStripMenuItem pmStrip;
        public static ToolStripMenuItem rmStrip;
        public static ToolStripMenuItem profileStrip;

        //private frmMemberManager MM;
        //private frmOrderManager OM;
        private frmOrderDetailList OD;
        //private frmProductManager PM;
        //private frmReport RM;
        //private frmProfile Profile;
        public frmMain()
        {
            InitializeComponent();
            mmStrip = memberManagerToolStripMenuItem;
            omStrip = orderManagerToolStripMenuItem;
            odStrip = orderDetailToolStripMenuItem;
            pmStrip = productManagerToolStripMenuItem;
            rmStrip = reportToolStripMenuItem;
            profileStrip = profileToolStripMenuItem;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //CheckRole();
            WindowState = FormWindowState.Maximized;

            if (EmailLogin.Equals("admin@fstore.com"))
            {
                orderManagerToolStripMenuItem.Enabled = true;
                productManagerToolStripMenuItem.Enabled = true;
                memberManagerToolStripMenuItem.Enabled = true;
                //orderManagementToolStripMenuItem.Enabled = true;
                //productManagementToolStripMenuItem.Enabled = true;
                //memberManagementToolStripMenuItem.Enabled = true;
            }
            else
            {
                productManagerToolStripMenuItem.Enabled = false;
                productManagerToolStripMenuItem.Visible = false;
                orderManagerToolStripMenuItem.Enabled = true;
                memberManagerToolStripMenuItem.Enabled = true;
                //productManagementToolStripMenuItem.Enabled = false;
                //productManagementToolStripMenuItem.Visible = false;
                //orderManagementToolStripMenuItem.Enabled = true;
                //memberManagementToolStripMenuItem.Enabled = true;
            }
        }

        private bool CheckRole()
        {
            if (Member.Email.Equals("admin@fstore.com")) return true;
            else
            {
                memberManagerToolStripMenuItem.Visible = false;
                orderManagerToolStripMenuItem.Visible = false;
                orderDetailToolStripMenuItem.Visible = false;
                productManagerToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible = false;

                return false;
            }
        }

        private void HideOtherForm(int curForm)
        {
            if (curForm != lastShowed)
            {
                lastShowed = firstShowed;
                firstShowed = curForm;
            }
            int formClosed = 0;
            FormShowed[curForm] = "Opened";
            for (int i = 1; i < (FormShowed.Length); i++)
            {
                if (i != curForm) if (FormShowed[i].Equals("Opened")) FormShowed[i] = "Hidden";
                if (FormShowed[i].Equals("Closed")) formClosed += 1;
            }
            if (formClosed == 6)
            {
                firstShowed = 0;
                lastShowed = 0;
            }
        }

        private void CloseForm(int curForm)
        {
            FormShowed[curForm] = "Closed";
            if (FormShowed[lastShowed].Equals("Hidden")) FormShowed[lastShowed] = "Opened";
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormShowed[3].Equals("Closed"))
            {
                OD = new frmOrderDetailList
                {
                    Text = "Order Detail Manager",
                    Member = Member
                };
                odStrip.BackColor = SystemColors.ActiveCaption;
                HideOtherForm(3);
                OD.MdiParent = this;
                OD.Show();
            }
            else if (FormShowed[3].Equals("Opened"))
            {
                odStrip.BackColor = SystemColors.Control;
                CloseForm(3);
                OD.Close();

            }
            else if (FormShowed[3].Equals("Hidden"))
            {
                odStrip.BackColor = SystemColors.ActiveCaption;
                HideOtherForm(3);
                OD.Focus();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}