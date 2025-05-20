using ApplicationService;
using ApplicationService.Dtos;
using Model;
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
            _productService = new ProductService(new FinalDbContext());
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            dgvProduct.DataSource = _productService.GetAllProducts();
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                var selected = (GetProductDto)dgvProduct.SelectedRows[0].DataBoundItem;
                txtProductName.Text = selected.ProductName;
                txtPrice.Text = selected.Price.ToString();
                txtQuantity.Text = selected.Quantity.ToString();
            }
        }
        private void ClearInputs()
        {
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var dto = new PostProductDto()
                {
                    ProductName = txtProductName.Text,
                    Price = int.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text)
                };
                _productService.AddProduct(dto);
                RefreshDataGrid();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                try
                {
                    var selected = (GetProductDto)dgvProduct.SelectedRows[0].DataBoundItem;
                    var dto = new EditProductDto
                    {
                        Id = selected.Id,
                        ProductName = txtProductName.Text,
                        Price = int.Parse(txtPrice.Text),
                        Quantity = int.Parse(txtQuantity.Text)
                    };
                    _productService.UpdateProduct(dto);
                    RefreshDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                try
                {
                    var selected = (GetProductDto)dgvProduct.SelectedRows[0].DataBoundItem;
                    _productService.DeleteProduct(new DeleteProductDto { Id = selected.Id });
                    RefreshDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
