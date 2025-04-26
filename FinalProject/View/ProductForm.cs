using Service;
using Service.DTO;
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
    public partial class ProductForm : Form
    {
        private readonly ProductService _productService;
        public ProductForm()
        {
            InitializeComponent();
            _productService = new ProductService();
        }
        private void RefreshDataGrid()
        {
            var refreshList = _productService.GetAll();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = refreshList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var p = new PostProductDto()
            {
                ProductName = txtProductName.Text,
                ProductPrice = Convert.ToInt32(txtProductPrice.Text),
                ProductId = Convert.ToInt32(txtProductId.Text)
            };
            _productService.Post(p);

            txtProductId.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
        }


        private void ProductForm_Load(object sender, EventArgs e)
        {
            txtProductId.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = _productService.GetAll();
            MessageBox.Show("Done!");
        }
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProducts.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells["Id"].Value?.ToString();
                txtProductId.Text = selectedRow.Cells["ProductId"].Value?.ToString();
                txtProductName.Text = selectedRow.Cells["ProductName"].Value?.ToString();
                txtProductPrice.Text = selectedRow.Cells["ProductPrice"].Value?.ToString();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new EditProductDto()
                {
                    Id = Convert.ToInt32(txtProductId.Text),
                    ProductName = txtProductName.Text,
                    ProductId = Convert.ToInt32(txtProductId.Text),
                    ProductPrice = Convert.ToInt32(txtProductPrice.Text)
                };
                _productService.Edit(p);
                RefreshDataGrid();

                MessageBox.Show("Is Done!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are your sure?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            {
                try
                {
                    if (result == DialogResult.Yes)
                    {
                        var p = new DeleteProductDto()
                        {
                            Id = Convert.ToInt32(txtId.Text)
                        };
                        _productService.Delete(p);
                        RefreshDataGrid();
                    }
                }
                catch (Exception exception)
                {
                    throw new AggregateException("Error");
                }
            }
        }
    }
}
