namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProvidersList = new TabPage();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProviders = new DataGridView();
            BtnSearch = new Button();
            label2 = new Label();
            TxtSearch = new TextBox();
            tabPageProvidersDetail = new TabPage();
            label6 = new Label();
            label7 = new Label();
            TxtContactEmail = new TextBox();
            TxtContactPhone = new TextBox();
            TxtContactName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtProviderName = new TextBox();
            TxtProvidersId = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPageProvidersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 111);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 36);
            label1.Name = "label1";
            label1.Size = new Size(166, 37);
            label1.TabIndex = 0;
            label1.Text = "PROVIDERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProvidersList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 111);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 339);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProvidersList
            // 
            tabPageProvidersList.Controls.Add(button5);
            tabPageProvidersList.Controls.Add(button1);
            tabPageProvidersList.Controls.Add(button2);
            tabPageProvidersList.Controls.Add(button3);
            tabPageProvidersList.Controls.Add(button4);
            tabPageProvidersList.Controls.Add(BtnClose);
            tabPageProvidersList.Controls.Add(BtnDelete);
            tabPageProvidersList.Controls.Add(BtnEdit);
            tabPageProvidersList.Controls.Add(BtnNew);
            tabPageProvidersList.Controls.Add(DgProviders);
            tabPageProvidersList.Controls.Add(BtnSearch);
            tabPageProvidersList.Controls.Add(label2);
            tabPageProvidersList.Controls.Add(TxtSearch);
            tabPageProvidersList.Location = new Point(4, 24);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3);
            tabPageProvidersList.Size = new Size(792, 311);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Image = Properties.Resources.search_small;
            button5.Location = new Point(552, 30);
            button5.Name = "button5";
            button5.Size = new Size(38, 41);
            button5.TabIndex = 12;
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Image = Properties.Resources.cerrar;
            button1.Location = new Point(627, 248);
            button1.Name = "button1";
            button1.Size = new Size(133, 51);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Image = Properties.Resources.delete;
            button2.Location = new Point(627, 191);
            button2.Name = "button2";
            button2.Size = new Size(133, 51);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Image = Properties.Resources.edit;
            button3.Location = new Point(627, 134);
            button3.Name = "button3";
            button3.Size = new Size(133, 51);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = Properties.Resources._new;
            button4.Location = new Point(627, 77);
            button4.Name = "button4";
            button4.Size = new Size(133, 51);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(1214, 254);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(133, 51);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(1214, 197);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(133, 51);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(1214, 140);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(133, 51);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(1214, 83);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(133, 51);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(28, 77);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.Size = new Size(562, 228);
            DgProviders.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(1161, 36);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(38, 41);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 18);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Search Providers";
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(28, 36);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(518, 23);
            TxtSearch.TabIndex = 0;
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(label6);
            tabPageProvidersDetail.Controls.Add(label7);
            tabPageProvidersDetail.Controls.Add(TxtContactEmail);
            tabPageProvidersDetail.Controls.Add(TxtContactPhone);
            tabPageProvidersDetail.Controls.Add(TxtContactName);
            tabPageProvidersDetail.Controls.Add(label5);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Controls.Add(TxtProviderName);
            tabPageProvidersDetail.Controls.Add(TxtProvidersId);
            tabPageProvidersDetail.Controls.Add(BtnCancel);
            tabPageProvidersDetail.Controls.Add(BtnSave);
            tabPageProvidersDetail.Location = new Point(4, 24);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(792, 311);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(423, 140);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 12;
            label6.Text = "Providers Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(423, 88);
            label7.Name = "label7";
            label7.Size = new Size(160, 17);
            label7.TabIndex = 11;
            label7.Text = "Providers Contact Phone";
            // 
            // TxtContactEmail
            // 
            TxtContactEmail.Location = new Point(423, 163);
            TxtContactEmail.Name = "TxtContactEmail";
            TxtContactEmail.PlaceholderText = "Providers Email";
            TxtContactEmail.Size = new Size(272, 23);
            TxtContactEmail.TabIndex = 10;
            // 
            // TxtContactPhone
            // 
            TxtContactPhone.Location = new Point(423, 108);
            TxtContactPhone.Name = "TxtContactPhone";
            TxtContactPhone.PlaceholderText = "Providers Contact Phone";
            TxtContactPhone.Size = new Size(272, 23);
            TxtContactPhone.TabIndex = 9;
            // 
            // TxtContactName
            // 
            TxtContactName.Location = new Point(91, 163);
            TxtContactName.Name = "TxtContactName";
            TxtContactName.PlaceholderText = "Providers Contact Name";
            TxtContactName.Size = new Size(272, 23);
            TxtContactName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(91, 140);
            label5.Name = "label5";
            label5.Size = new Size(157, 17);
            label5.TabIndex = 7;
            label5.Text = "Providers Contact Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 88);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 6;
            label4.Text = "Providers Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 36);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 5;
            label3.Text = "Providers Id";
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(91, 108);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Providers Name";
            TxtProviderName.Size = new Size(272, 23);
            TxtProviderName.TabIndex = 3;
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(91, 56);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.ReadOnly = true;
            TxtProvidersId.Size = new Size(156, 23);
            TxtProvidersId.TabIndex = 2;
            TxtProvidersId.Text = "0";
            TxtProvidersId.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.search_small;
            BtnCancel.Location = new Point(402, 236);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(99, 60);
            BtnCancel.TabIndex = 1;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(282, 236);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(99, 60);
            BtnSave.TabIndex = 0;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "ProvidersView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProvidersList.ResumeLayout(false);
            tabPageProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProviders;
        private Button BtnSearch;
        private Label label2;
        private TextBox TxtSearch;
        private TabPage tabPageProvidersDetail;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProviderName;
        private TextBox TxtProvidersId;
        private Button BtnCancel;
        private Button BtnSave;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox TxtContactEmail;
        private TextBox TxtContactPhone;
        private TextBox TxtContactName;
        private Label label6;
        private Label label7;
    }
}