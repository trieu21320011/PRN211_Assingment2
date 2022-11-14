using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        private MemberRepository MemberRepository = new();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var memberLogin = MemberRepository.CheckLogin(txtEmail1.Text, txtPassword1.Text);
            if (memberLogin != null && memberLogin.Email.Equals("admin@fstore.com"))
            {
                frmMain frm = new()
                {
                    EmailLogin = txtEmail1.Text
                };
                Hide();
                frm.Show();
            }
            else if (memberLogin != null && !memberLogin.Email.Equals("admin@fstore.com"))
            {
                frmMain frm = new()
                {
                    EmailLogin = txtEmail1.Text
                };
                Hide();
                frm.Show();
            }
            else if (memberLogin == null) MessageBox.Show("Incorrect email or password");
            else MessageBox.Show("Something error in login method");
        }
    }
}
