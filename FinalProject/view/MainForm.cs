using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            PersonForm frm = new PersonForm();
            frm.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();
            this.Hide();
        }
    }
}
