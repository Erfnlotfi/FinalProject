﻿namespace View
{
    partial class PersonForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtNationalId = new TextBox();
            btnAdd = new Button();
            btnBack = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvPeople = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clmFirstName = new DataGridViewTextBoxColumn();
            clmLastName = new DataGridViewTextBoxColumn();
            clmNationalid = new DataGridViewTextBoxColumn();
            txtId = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 73);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "First name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 125);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 173);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Natinal Id :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(109, 70);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(109, 122);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 3;
            // 
            // txtNationalId
            // 
            txtNationalId.Location = new Point(109, 170);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new Size(125, 27);
            txtNationalId.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnAdd.Location = new Point(275, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 50);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 224, 192);
            btnBack.Location = new Point(19, 323);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 50);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 224, 192);
            btnEdit.Location = new Point(395, 25);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 50);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit\r\n";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 224, 192);
            btnDelete.Location = new Point(517, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 50);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 224, 192);
            btnRefresh.Location = new Point(637, 25);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 50);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvPeople
            // 
            dgvPeople.BackgroundColor = SystemColors.Menu;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Columns.AddRange(new DataGridViewColumn[] { clmId, clmFirstName, clmLastName, clmNationalid });
            dgvPeople.Location = new Point(275, 99);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.Size = new Size(494, 274);
            dgvPeople.TabIndex = 23;
            // 
            // clmId
            // 
            clmId.HeaderText = "Id";
            clmId.MinimumWidth = 6;
            clmId.Name = "clmId";
            clmId.Width = 110;
            // 
            // clmFirstName
            // 
            clmFirstName.HeaderText = "First Name";
            clmFirstName.MinimumWidth = 6;
            clmFirstName.Name = "clmFirstName";
            clmFirstName.Width = 110;
            // 
            // clmLastName
            // 
            clmLastName.HeaderText = "Lastname";
            clmLastName.MinimumWidth = 6;
            clmLastName.Name = "clmLastName";
            clmLastName.Width = 110;
            // 
            // clmNationalid
            // 
            clmNationalid.HeaderText = "National id";
            clmNationalid.MinimumWidth = 6;
            clmNationalid.Name = "clmNationalid";
            clmNationalid.Width = 110;
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 25);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 25;
            label4.Text = "Id :";
            // 
            // PersonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(dgvPeople);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(txtNationalId);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonForm";
            Text = "PersonForm";
            Load += PersonForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtNationalId;
        private Button btnAdd;
        private Button btnBack;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dgvPeople;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmFirstName;
        private DataGridViewTextBoxColumn clmLastName;
        private DataGridViewTextBoxColumn clmNationalid;
        private TextBox txtId;
        private Label label4;
    }
}