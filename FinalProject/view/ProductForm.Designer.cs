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
            btnBack = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvProduct = new DataGridView();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(13, 360);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 57);
            btnBack.TabIndex = 27;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(581, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 29);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(475, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(67, 29);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(364, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(67, 29);
            btnEdit.TabIndex = 24;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 29);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(260, 50);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(388, 247);
            dgvProduct.TabIndex = 22;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(118, 185);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(118, 142);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 20;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(118, 97);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 188);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 17;
            label4.Text = "Quantity :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 145);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 16;
            label3.Text = "Price :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 97);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 15;
            label2.Text = "ProductName :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 53);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 14;
            label1.Text = "Id :";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvProduct);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvProduct;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtProductName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}