namespace View
{
    partial class ProductForm
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
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnBack = new Button();
            btnAdd = new Button();
            txtProductPrice = new TextBox();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvProducts = new DataGridView();
            txtId = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 224, 192);
            btnRefresh.Location = new Point(632, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 50);
            btnRefresh.TabIndex = 21;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 224, 192);
            btnDelete.Location = new Point(512, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 50);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 224, 192);
            btnEdit.Location = new Point(390, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 50);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit\r\n";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 224, 192);
            btnBack.Location = new Point(18, 307);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 50);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnAdd.Location = new Point(270, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 50);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(118, 134);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(125, 27);
            txtProductPrice.TabIndex = 16;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(118, 83);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(125, 27);
            txtProductId.TabIndex = 15;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(118, 39);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 137);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 13;
            label3.Text = "Product Price :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 12;
            label2.Text = "Product Id :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 42);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 11;
            label1.Text = "Product name :";
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.Menu;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(270, 83);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(456, 274);
            dgvProducts.TabIndex = 22;
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 180);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 183);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 24;
            label4.Text = "Id :";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(dgvProducts);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductId);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnBack;
        private Button btnAdd;
        private TextBox txtProductPrice;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvProducts;
        private TextBox txtId;
        private Label label4;
    }
}