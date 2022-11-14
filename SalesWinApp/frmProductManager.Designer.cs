﻿
namespace SalesWinApp
{
    partial class frmProductManager
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.txtUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.txtUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "Product Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Product ID:";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductName.Location = new System.Drawing.Point(154, 78);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(139, 27);
            this.txtProductName.TabIndex = 55;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(14, 139);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.Size = new System.Drawing.Size(846, 356);
            this.dgvProductList.TabIndex = 52;
            //this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(742, 523);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 40);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(298, 523);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 40);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(154, 523);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 40);
            this.btnNew.TabIndex = 49;
            this.btnNew.Text = "Create";
            this.btnNew.UseVisualStyleBackColor = true;
            //this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 523);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 40);
            this.btnLoad.TabIndex = 48;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Units In Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(315, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Unit Price:";
            // 
            // btnSearch2
            // 
            this.btnSearch2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch2.FlatAppearance.BorderSize = 2;
            this.btnSearch2.Location = new System.Drawing.Point(585, 27);
            this.btnSearch2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(118, 84);
            this.btnSearch2.TabIndex = 56;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(441, 80);
            this.txtUnitsInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitsInStock.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(112, 27);
            this.txtUnitsInStock.TabIndex = 64;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.DecimalPlaces = 4;
            this.txtUnitPrice.Location = new System.Drawing.Point(441, 27);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(112, 27);
            this.txtUnitPrice.TabIndex = 65;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearSearch.FlatAppearance.BorderSize = 2;
            this.btnClearSearch.Location = new System.Drawing.Point(730, 27);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(83, 84);
            this.btnClearSearch.TabIndex = 67;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(154, 27);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(112, 27);
            this.txtProductID.TabIndex = 68;
            // 
            // frmProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 579);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductManager";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductManager_FormClosing);
            this.Load += new System.EventHandler(this.frmProductManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.NumericUpDown txtUnitsInStock;
        private System.Windows.Forms.NumericUpDown txtUnitPrice;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.NumericUpDown txtProductID;
    }
}