namespace View
{
    partial class MainForm
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
            btnPerson = new Button();
            btnProduct = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPerson
            // 
            btnPerson.Location = new Point(106, 197);
            btnPerson.Name = "btnPerson";
            btnPerson.Size = new Size(142, 90);
            btnPerson.TabIndex = 0;
            btnPerson.Text = "Person";
            btnPerson.UseVisualStyleBackColor = true;
            btnPerson.Click += btnPerson_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(484, 197);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(142, 90);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 255, 128);
            label1.Location = new Point(222, 47);
            label1.Name = "label1";
            label1.Size = new Size(296, 101);
            label1.TabIndex = 2;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnProduct);
            Controls.Add(btnPerson);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPerson;
        private Button btnProduct;
        private Label label1;
    }
}