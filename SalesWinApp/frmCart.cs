using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;
using DataAccess.UnitOfWork;
namespace SalesWinApp
{
    public partial class frmCart : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private Product currentProduct;
        private Dictionary<int, Product> cart = new Dictionary<int, Product>();
        private readonly IMemberRepository _memberRepository;
        public frmCart()
        {
            _unitOfWork = new UnitOfWork();
            _memberRepository = new MemberRepository();
            InitializeComponent();
        }
        
        private void frmCart_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.DataSource =  _unitOfWork.productForCartRepository.GetAll();
            comboBox3.DisplayMember = "Email";
            comboBox3.DataSource = _memberRepository.GetMembers().ToList();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentProduct = (Product)comboBox1.SelectedItem;
            textBox1.Text = currentProduct.ProductName;
            textBox2.Text = currentProduct.UnitPrice.ToString();
            List<int> quantities = new List<int>();
            for (int i = 0; i < currentProduct.UnitStock; i++)
            {
                quantities.Add(i+1);
            }

            comboBox2.DataSource = quantities;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Please pick product first");
                return;
            }
            
            int quantity = comboBox2.SelectedIndex + 1;
            int productId = currentProduct.ProductId;  
            currentProduct.UnitStock = quantity;
            if (!cart.ContainsKey(productId))
            {
                cart.Add(productId, currentProduct);
            }
            else
            {
                cart[productId].UnitStock = quantity;
            }
            dataGridView1.DataSource = cart.Values.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var product = cart.Values.ToList()[index];
            cart.Remove(product.ProductId);
            dataGridView1.DataSource = cart.Values.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Empty Cart");
                return;
            }
            var products = cart.Values.ToList();
            var member = (Member)comboBox3.SelectedValue;
            int orderId;
            var orders = _unitOfWork.orderRepository.GetAll();
            if (orders == null || orders.Count() == 0) orderId = 1;
            else orderId = orders.Count()+1;
            Order order = new Order()
            {
                MemberId = member.Memberid,
                Freight = 100,
                OrderDate = DateTime.Now,
                RepuiredDate = DateTime.Now,
                ShippedDate = DateTime.Now,
                OrderId = orderId
            };
            _unitOfWork.orderRepository.Add(order);
            _unitOfWork.Save();
            foreach (var product in products)
            {
                if (!_unitOfWork.productForCartRepository.checkQuantity(product))
                {
                    MessageBox.Show("Not enough quantity for: " + product.ProductName);
                    return;
                }
                OrderDetail detail = new OrderDetail()
                {
                    OrderId = orderId,
                    Discount = 5,
                    ProductId = product.ProductId,
                    UnitPrice = product.UnitPrice,
                    Quantity = product.UnitStock,

                };
                
                _unitOfWork.productForCartRepository.Update(product);
                _unitOfWork.detailRepository.Add(detail);

            }
            _unitOfWork.Save();

        }
    }
}
