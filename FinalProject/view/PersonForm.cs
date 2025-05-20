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
    public partial class PersonForm : Form
    {
        private readonly PersonService _personService;

        public PersonForm()
        {
            InitializeComponent();
            _personService = new PersonService(new FinalDbContext());
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            dgvPerson.DataSource = _personService.GetAllPersons();
            dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvPerson_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count > 0)
            {
                var selected = (GetPersonDto)dgvPerson.SelectedRows[0].DataBoundItem;
                txtFirstName.Text = selected.FirstName;
                txtLastName.Text = selected.LastName;
                txtAge.Text = selected.Age.ToString();
            }
        }

        private void ClearInputs()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAge.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var dto = new PostPersonDto
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Age = int.Parse(txtAge.Text)
                };
                _personService.AddPerson(dto);
                RefreshDataGrid();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count > 0)
            {
                try
                {
                    var selected = (GetPersonDto)dgvPerson.SelectedRows[0].DataBoundItem;
                    var dto = new EditPersonDto
                    {
                        Id = selected.Id,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Age = int.Parse(txtAge.Text)
                    };
                    _personService.UpdatePerson(dto);
                    RefreshDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count > 0)
            {
                try
                {
                    var selected = (GetPersonDto)dgvPerson.SelectedRows[0].DataBoundItem;
                    _personService.DeletePerson(new DeletePersonDto { Id = selected.Id });
                    RefreshDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
