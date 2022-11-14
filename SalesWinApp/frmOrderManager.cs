using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using DataAccess.Repository.Interface;
using System.Data;

namespace SalesWinApp
{
    public partial class frmOrderManager : Form
    {
        private IOrderRepository OrderRepository = new OrderRepository();
        private IOrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
        private BindingSource source;
        public Member Member { get; set; }
        public Order Order { get; set; }

        public frmOrderManager()
        {
            InitializeComponent();
        }

        public frmOrderManager(Order order)
        {
            Order = order;
            InitializeComponent();
        }

        private Order GetOrderObject() => (Order)dgvOrderList.CurrentRow.DataBoundItem;

        public void LoadOrderList()
        {
            var orders = OrderRepository.GetOrders();
            try
            {
                source = new BindingSource
                {
                    DataSource = orders
                };
                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;

                if (orders.Count() == 0) btnDelete.Enabled = false;
                else btnDelete.Enabled = true;
            }

            catch (Exception ex) { MessageBox.Show(ex.Message, "Load order list"); }
        }


        private void frmOrderManager_Load(object sender, EventArgs e)
        {
        }

        //private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    frmOrderDetails frmOrderDetails = new()
        //    {
        //        Text = "Update order",
        //        InsertOrUpdate = true,
        //        orderInfo = GetOrderObject(),
        //        OrderRepository = OrderRepository,
        //        Member = Member
        //    };
        //    if (frmOrderDetails.ShowDialog().Equals(DialogResult.OK))
        //    {
        //        LoadOrderList();
        //        source.Position = source.Count - 1;
        //    }
        //}

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        //private void btnNew_Click(object sender, EventArgs e)
        //{
        //    frmOrderDetails frmOrderDetails = new()
        //    {
        //        Text = "Add order",
        //        InsertOrUpdate = false,
        //        OrderRepository = OrderRepository,
        //        Member = Member
        //    };
        //    if (frmOrderDetails.ShowDialog().Equals(DialogResult.OK))
        //    {
        //        LoadOrderList();
        //        source.Position = source.Count - 1;
        //    }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                var orderDetail = OrderDetailRepository.GetOrderDetailByOrderID(order.OrderId);
                if (orderDetail != null) MessageBox.Show("Can not delete this order because this order is contained in one or more order detail!");
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete Order: " + order.OrderId, "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        OrderRepository.DeleteOrder(order.OrderId);
                        if (order == null) MessageBox.Show("Order has been deleted successfully!");
                        LoadOrderList();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Delete a order"); }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSort_Click(object sender, EventArgs e)
        {
            var orders = OrderRepository.GetOrders().OrderByDescending(m => m.OrderDate);
            try
            {
                source = new BindingSource
                {
                    DataSource = orders
                };

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;
                if (orders.Count() == 0) btnDelete.Enabled = false;
                else btnDelete.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Load order list"); }
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    int OrderID = 0;
        //    int MemberID = 0;
        //    int temp;
        //    try
        //    {
        //        if (int.TryParse(txtOrderID.Text, out temp))
        //        {
        //            OrderID = temp;
        //        }
        //        if (int.TryParse(txtMemberID.Text, out temp))
        //        {
        //            MemberID = temp;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    var members = OrderRepository.GetOrders().Where(OrderID != 0 && MemberID != 0 ?
        //       (m => m.OrderID.Equals(OrderID) && m.MemberID.Equals(MemberID))
        //       : m => m.OrderID.Equals(OrderID) || m.MemberID.Equals(MemberID));

        //    try
        //    {
        //        source = new BindingSource();
        //        source.DataSource = members;
        //        dgvOrderList.DataSource = null;
        //        dgvOrderList.DataSource = source;

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Load order list");
        //    }
        //}

        private void frmOrderManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.FormShowed[2] = "Closed";
            frmMain.omStrip.BackColor = SystemColors.Control;
        }

    }
}
