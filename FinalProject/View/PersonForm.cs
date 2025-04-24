using Microsoft.Data.SqlClient;
using Service;
using Service.DTO;
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
        private readonly PersonService _personService;

        public PersonForm()
        {
            InitializeComponent();
            _personService=new PersonService();
        }
        private void RefreshDataGrid()
        {
            var refreshList = _personService.GetAll();
            dgvPeople.DataSource = null;
            dgvPeople.DataSource = refreshList;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var p = new PostPersonDto()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Nationalid = Convert.ToInt32(txtNationalId.Text)
            };
            _personService.Post(p);
           
                txtId.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtNationalId.Clear();
            
        }
        

        private void PersonForm_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _personService.GetAll();
            MessageBox.Show("Done!");
        }
        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPeople.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells["Id"].Value?.ToString();
                txtFirstName.Text = selectedRow.Cells["FirstName"].Value?.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value?.ToString();
                txtNationalId.Text = selectedRow.Cells["NationalId"].Value?.ToString();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new EditPersonDto()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    NationalId = Convert.ToInt32(txtNationalId.Text)
                };
                _personService.Edit(p);
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
                        var p = new DeletePersonDto()
                        {
                            Id = Convert.ToInt32(txtId.Text)
                        };
                        _personService.Delete(p);
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
