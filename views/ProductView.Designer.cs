namespace Supermarket_mvp.views
{
    partial class ProductView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            DgProduct = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            dataGridView1 = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            TxtProductPrice = new TextBox();
            TxtProductStockQuantity = new TextBox();
            TxtProductProvider = new TextBox();
            TxtProductCategory = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            DgProduct.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 41);
            label1.Name = "label1";
            label1.Size = new Size(180, 46);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(DgProduct);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(881, 410);
            tabControl1.TabIndex = 1;
            // 
            // DgProduct
            // 
            DgProduct.Controls.Add(BtnClose);
            DgProduct.Controls.Add(BtnDelete);
            DgProduct.Controls.Add(BtnEdit);
            DgProduct.Controls.Add(BtnNew);
            DgProduct.Controls.Add(dataGridView1);
            DgProduct.Controls.Add(BtnSearch);
            DgProduct.Controls.Add(TxtSearch);
            DgProduct.Controls.Add(label2);
            DgProduct.Location = new Point(4, 29);
            DgProduct.Name = "DgProduct";
            DgProduct.Padding = new Padding(3);
            DgProduct.Size = new Size(873, 377);
            DgProduct.TabIndex = 0;
            DgProduct.Text = "Product list";
            DgProduct.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnCancel);
            tabPage2.Controls.Add(BtnSave);
            tabPage2.Controls.Add(TxtProductCategory);
            tabPage2.Controls.Add(TxtProductProvider);
            tabPage2.Controls.Add(TxtProductStockQuantity);
            tabPage2.Controls.Add(TxtProductPrice);
            tabPage2.Controls.Add(TxtProductName);
            tabPage2.Controls.Add(TxtProductId);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(873, 377);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Product Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 18);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(21, 45);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(584, 27);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(621, 31);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(51, 55);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(584, 263);
            dataGridView1.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(686, 114);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 47);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(686, 180);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 45);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(686, 245);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 47);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(686, 310);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 50);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(71, 47);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 141);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 1;
            label4.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(71, 239);
            label5.Name = "label5";
            label5.Size = new Size(152, 23);
            label5.TabIndex = 2;
            label5.Text = "Product Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(425, 239);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 3;
            label6.Text = "Stock Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(425, 141);
            label7.Name = "label7";
            label7.Size = new Size(49, 23);
            label7.TabIndex = 4;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(425, 47);
            label8.Name = "label8";
            label8.Size = new Size(146, 23);
            label8.TabIndex = 5;
            label8.Text = "Product Provider";
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(71, 73);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(179, 27);
            TxtProductId.TabIndex = 6;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(72, 167);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(178, 27);
            TxtProductName.TabIndex = 7;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(430, 167);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(161, 27);
            TxtProductPrice.TabIndex = 8;
            // 
            // TxtProductStockQuantity
            // 
            TxtProductStockQuantity.Location = new Point(430, 265);
            TxtProductStockQuantity.Name = "TxtProductStockQuantity";
            TxtProductStockQuantity.Size = new Size(156, 27);
            TxtProductStockQuantity.TabIndex = 9;
            // 
            // TxtProductProvider
            // 
            TxtProductProvider.Location = new Point(426, 73);
            TxtProductProvider.Name = "TxtProductProvider";
            TxtProductProvider.Size = new Size(160, 27);
            TxtProductProvider.TabIndex = 10;
            // 
            // TxtProductCategory
            // 
            TxtProductCategory.Location = new Point(71, 265);
            TxtProductCategory.Name = "TxtProductCategory";
            TxtProductCategory.Size = new Size(179, 27);
            TxtProductCategory.TabIndex = 11;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(210, 308);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 50);
            BtnSave.TabIndex = 12;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.search_small;
            BtnCancel.Location = new Point(380, 308);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 50);
            BtnCancel.TabIndex = 13;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 535);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            DgProduct.ResumeLayout(false);
            DgProduct.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage DgProduct;
        private Label label2;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProductCategory;
        private TextBox TxtProductProvider;
        private TextBox TxtProductStockQuantity;
        private TextBox TxtProductPrice;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
        private Button BtnCancel;
        private Button BtnSave;
    }
}