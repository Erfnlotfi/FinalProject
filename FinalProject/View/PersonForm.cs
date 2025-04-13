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
                Nationalid = txtNationalId.Text,
            };
            _personService.Post(p);
           

                txtFirstName.Clear();
                txtLastName.Clear();
                txtNationalId.Clear();
            
        }
        

        private void PersonForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _personService.GetAll();
            MessageBox.Show("Done!");
        }
    }
}
