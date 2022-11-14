using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public string EmailLogin { get; set; }

        MemberRepository memberRepository = new MemberRepository();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (EmailLogin.Equals("admin@fstore.com"))
            {
                orderManagementToolStripMenuItem.Enabled = true;
                productManagementToolStripMenuItem.Enabled = true;
                memberManagementToolStripMenuItem.Enabled = true;
            }
            else
            {
                productManagementToolStripMenuItem.Enabled = false;
                productManagementToolStripMenuItem.Visible = false;
                orderManagementToolStripMenuItem.Enabled = true;
                memberManagementToolStripMenuItem.Enabled = true;
            }
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder
            {
                EmailLogin = EmailLogin
            };
            frm.Show();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct
            {
                EmailLogin = EmailLogin
            };
            frm.Show();
        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EmailLogin.Equals("admin@fstore.com"))
            {
                frmMember frm = new frmMember
                {
                    EmailLogin = EmailLogin
                };
                frm.Show();
            }
            else
            {
                frmMemberDetail frmMemberDetail = new frmMemberDetail()
                {
             /*       Text = "Update Member",
                    InsertOrUpdate = true,
                    MemberInfo = memberRepository.GetMemberByEmail(EmailLogin),
                    MemberRepository = memberRepository*/
                };
                frmMemberDetail.Show();
            }
        }
    }
}
