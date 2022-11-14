using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using DataAccess.Repository.Interface;

namespace SalesWinApp
{
    public partial class frmOrderDetailProduct : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        private IOrderRepository orderRepository = new OrderRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private BindingSource source;
        public bool InsertOrUpdate { get; set; }
        public Product? PO { get; set; }
        public Order? OO { get; set; }
        public OrderDetail orderDetailInfo { get; set; }


        public frmOrderDetailProduct()
        {
            InitializeComponent();
        }

        private void frmOrderDetailProduct_Load(object sender, EventArgs e)
        {
            //When update disable dgv
            if (InsertOrUpdate == true)
            {
                intQuantity.Focus();
                btnAdd.Text = "Update";
                txtOrderID.Text = orderDetailInfo.OrderId.ToString();
                txtProductName.Text = orderDetailInfo.ProductId.ToString();
                dgvOrderID.Enabled = false;
                dgvOrderProductList.Enabled = false;
            }
            else
            {
                LoadDetailProductList();
                dgvOrderID.ClearSelection();
                dgvOrderProductList.ClearSelection();
            }
        }

        private Product GetProductObject() => (Product)dgvOrderProductList.CurrentRow.DataBoundItem;

        private Order GetOrderObject() => (Order)dgvOrderID.CurrentRow.DataBoundItem;

        private void dgvOrderProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PO = GetProductObject();
            txtProductName.Text = PO.ProductName;
        }

        private void dgvOrderID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OO = GetOrderObject();
            txtOrderID.Text = OO.OrderId.ToString();
        }

        public void LoadDetailProductList()
        {
            var products = productRepository.GetProducts();

            try
            {
                source = new BindingSource
                {
                    DataSource = products
                };
                dgvOrderProductList.DataSource = null;
                dgvOrderProductList.DataSource = source;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Load product list"); }

            var orderList = orderRepository.GetOrders();

            try
            {
                source = new BindingSource
                {
                    DataSource = orderList
                };
                dgvOrderID.DataSource = null;
                dgvOrderID.DataSource = source;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Load orderID list"); }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        public void ReloadODList(frmOrderDetailList frmOrderDetailList) => frmOrderDetailList.LoadOrderDetailList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (InsertOrUpdate != true)
            {
                try
                {
                    var orderDetail = new OrderDetail
                    {
                        OrderId = int.Parse(txtOrderID.Text),
                        ProductId = PO.ProductId,
                        UnitPrice = PO.UnitPrice,
                        Quantity = Convert.ToInt32(intQuantity.Value),
                        Discount = (double)decimalDiscount.Value
                    };
                    orderDetailRepository.InsertOrderDetail(orderDetail);
                    MessageBox.Show("Order Detail has been added Successfully!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Add an Order Detail"); }
            }
            else
            {
                try
                {
                    var orderDetail = new OrderDetail
                    {
                        OrderId = int.Parse(txtOrderID.Text),
                        ProductId = PO.ProductId,
                        UnitPrice = PO.UnitPrice,
                        Quantity = Convert.ToInt32(intQuantity.Value),
                        Discount = (double)decimalDiscount.Value
                    };
                    orderDetailRepository.UpdateOrderDetail(orderDetail);
                    MessageBox.Show("Order Detail has been updated Successfully!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Update an Order Detail"); }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadDetailProductList();
    }
}
