using BusinessObject;

namespace SalesWinApp
{
    public partial class frmOrderDetails : Form
    {
        //public IOrderRepository OrderRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfo { get; set; }
        public Member Member { get; set; }


        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                dtpOrderDate.Text = OrderInfo.OrderDate.ToString();
                dtpRequiredDate.Text = OrderInfo.RequiredDate.ToString();
                dtpShippedDate.Text = OrderInfo.ShippedDate.ToString();
                intFreight.Text = OrderInfo.Freight.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int memberID = Member.MemberId;
                Order order = new()
                {
                    MemberId = memberID,
                    OrderDate = dtpOrderDate.Value,
                    RequiredDate = dtpRequiredDate.Value,
                    ShippedDate = dtpShippedDate.Value,
                    Freight = intFreight.Value
                };
                if (InsertOrUpdate == false)
                {
                    //OrderRepository.InsertOrder(order);
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Order has been created Successfully!");
                    Close();
                }
                else
                {
                    //OrderRepository.UpdateOrder(order);
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Order has been updated Successfully!");
                    Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order" : "Update a order"); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}