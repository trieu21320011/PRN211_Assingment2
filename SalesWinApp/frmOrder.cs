using DataAccess.UnitOfWork;
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
    public partial class frmOrder : Form
    {
        public string EmailLogin { get; set; }
        private readonly IUnitOfWork _unitOfWork;
        public frmOrder()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _unitOfWork.orderRepository.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new frmCart();
            form.ShowDialog();
            dataGridView1.DataSource = _unitOfWork.orderRepository.GetAll();
        }
    }
}
