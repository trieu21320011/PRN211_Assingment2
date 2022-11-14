
namespace SalesWinApp
{
    partial class frmOrderDetailProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.intQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvOrderProductList = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.decimalDiscount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.dgvOrderID = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.intQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderID)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(301, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(112, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Product Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.Location = new System.Drawing.Point(520, 28);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 71);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductName.Location = new System.Drawing.Point(112, 64);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(169, 27);
            this.txtProductName.TabIndex = 49;
            // 
            // intQuantity
            // 
            this.intQuantity.Location = new System.Drawing.Point(301, 65);
            this.intQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.intQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intQuantity.Name = "intQuantity";
            this.intQuantity.Size = new System.Drawing.Size(90, 27);
            this.intQuantity.TabIndex = 54;
            this.intQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(786, 523);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 40);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvOrderProductList
            // 
            this.dgvOrderProductList.AllowUserToAddRows = false;
            this.dgvOrderProductList.AllowUserToDeleteRows = false;
            this.dgvOrderProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProductList.Location = new System.Drawing.Point(731, 97);
            this.dgvOrderProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrderProductList.Name = "dgvOrderProductList";
            this.dgvOrderProductList.ReadOnly = true;
            this.dgvOrderProductList.RowHeadersWidth = 51;
            this.dgvOrderProductList.RowTemplate.Height = 25;
            this.dgvOrderProductList.Size = new System.Drawing.Size(756, 365);
            this.dgvOrderProductList.TabIndex = 65;
            this.dgvOrderProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderProductList_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.Location = new System.Drawing.Point(14, 523);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 39);
            this.btnRefresh.TabIndex = 66;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // decimalDiscount
            // 
            this.decimalDiscount.DecimalPlaces = 2;
            this.decimalDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.decimalDiscount.Location = new System.Drawing.Point(410, 65);
            this.decimalDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decimalDiscount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.decimalDiscount.Name = "decimalDiscount";
            this.decimalDiscount.Size = new System.Drawing.Size(90, 27);
            this.decimalDiscount.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(410, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderID.Location = new System.Drawing.Point(14, 64);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(78, 27);
            this.txtOrderID.TabIndex = 69;
            // 
            // dgvOrderID
            // 
            this.dgvOrderID.AllowUserToAddRows = false;
            this.dgvOrderID.AllowUserToDeleteRows = false;
            this.dgvOrderID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderID.Location = new System.Drawing.Point(6, 150);
            this.dgvOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrderID.Name = "dgvOrderID";
            this.dgvOrderID.ReadOnly = true;
            this.dgvOrderID.RowHeadersWidth = 51;
            this.dgvOrderID.RowTemplate.Height = 25;
            this.dgvOrderID.Size = new System.Drawing.Size(719, 365);
            this.dgvOrderID.TabIndex = 71;
            this.dgvOrderID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderID_CellClick);
            // 
            // frmOrderDetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 579);
            this.Controls.Add(this.dgvOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.decimalDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvOrderProductList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.intQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderDetailProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmOrderDetailProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.NumericUpDown intQuantity;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvOrderProductList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown decimalDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DataGridView dgvOrderID;
    }
}