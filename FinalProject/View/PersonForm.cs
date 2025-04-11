using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtLastName.Text) && !string.IsNullOrWhiteSpace(txtNationalId.Text) && !string.IsNullOrEmpty(txtId.Text))
            {
                dgvPeople.Rows.Add(txtId.Text, txtFirstName.Text, txtLastName.Text, txtNationalId.Text);
                txtFirstName.Clear();
                txtLastName.Clear();
                txtNationalId.Clear();
                txtId.Clear();
                txtId.Focus();
            }
            else
            {
                MessageBox.Show("Please dont let the textbox be null");
            }
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }
    }
}
