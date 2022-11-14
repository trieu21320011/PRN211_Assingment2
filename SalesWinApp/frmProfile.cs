using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using DataAccess.Repository.Interface;
using System.Diagnostics;

namespace SalesWinApp
{
    public partial class frmProfile : Form
    {
        private IOrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
        private IOrderRepository OrderRepository = new OrderRepository();
        private IMemberRepository MemberRepository = new MemberRepository();
        private BindingSource source;
        public Member Member { get; set; }

        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            ActiveControl = label7;
            LoadProfile();
            LoadOrderHistory();
        }

        public void LoadProfile()
        {
            ActiveControl = label7;
            txtMemberID.Text = Member.MemberId.ToString();
            txtCompanyName.Text = Member.CompanyName;
            txtEmail.Text = Member.Email;
            txtCountry.Text = Member.Country;
            txtCity.Text = Member.City;
            txtPassword.Text = Member.Password;

            txtCity.Enabled = false;
            txtCompanyName.ReadOnly = true;
            txtCountry.Enabled = false;
            txtEmail.ReadOnly = true;
            txtPassword.ReadOnly = true;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = true;
        }

        public void LoadOrderHistory()
        {
            try
            {
                List<Order> orderList = OrderRepository.GetOrderByMemberID(Member.MemberId);
                List<OrderDetail> orderDetailList = new();
                foreach (Order or in orderList) orderDetailList.Add(OrderDetailRepository.GetOrderDetailByOrderID(or.OrderId));
                source = new BindingSource
                {
                    DataSource = orderDetailList
                };
                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Load order list"); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrderHistory();
            LoadProfile();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            txtCity.Enabled = true;
            txtCompanyName.ReadOnly = false;
            txtCountry.Enabled = true;
            txtEmail.ReadOnly = false;
            txtPassword.ReadOnly = false;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var member = new Member
            {
                MemberId = Member.MemberId,
                CompanyName = txtCompanyName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Country = txtCountry.Text,
                City = txtCity.Text
            };
            Trace.WriteLine(member.ToString());

            try
            {
                MemberRepository.UpdateMember(member);
                Member = member;
                LoadProfile();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadProfile();
            btnCancel.Enabled = false;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        private void frmProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.FormShowed[6] = "Closed";
            frmMain.profileStrip.BackColor = SystemColors.Control;
        }
    }
}
