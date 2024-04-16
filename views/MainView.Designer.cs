namespace Supermarket_mvp.views
{
    partial class MainView
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
            pictureBox1 = new PictureBox();
            BtnPayMode = new Button();
            BtnProduct = new Button();
            BtnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnPayMode
            // 
            BtnPayMode.Image = Properties.Resources.buy;
            BtnPayMode.Location = new Point(-1, 147);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(183, 107);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // BtnProduct
            // 
            BtnProduct.Image = Properties.Resources.products;
            BtnProduct.Location = new Point(-1, 298);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(183, 103);
            BtnProduct.TabIndex = 2;
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.Image = Properties.Resources.cerrar;
            BtnExit.Location = new Point(-1, 442);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(183, 97);
            BtnExit.TabIndex = 3;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 539);
            Controls.Add(BtnExit);
            Controls.Add(BtnProduct);
            Controls.Add(BtnPayMode);
            Controls.Add(pictureBox1);
            Name = "MainView";
            Text = "Supermarkert";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnPayMode;
        private Button BtnProduct;
        private Button BtnExit;
    }
}