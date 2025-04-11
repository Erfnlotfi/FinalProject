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
            btnPerson.BackColor = Color.FromArgb(255, 224, 192);
            btnPerson.Location = new Point(146, 177);
            btnPerson.Name = "btnPerson";
            btnPerson.Size = new Size(94, 73);
            btnPerson.TabIndex = 0;
            btnPerson.Text = "Person";
            btnPerson.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(255, 224, 192);
            btnProduct.Location = new Point(489, 177);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(94, 73);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Segoe Print", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 31);
            label1.MinimumSize = new Size(200, 50);
            label1.Name = "label1";
            label1.Size = new Size(243, 82);
            label1.TabIndex = 2;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnProduct);
            Controls.Add(btnPerson);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPerson;
        private Button btnProduct;
        private Label label1;
    }
}