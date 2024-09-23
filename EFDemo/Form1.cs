using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemo
{ 
    public partial class Form1 : Form
    {
        private CustomerRepository _customerRepository = new CustomerRepository();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _customerRepository.ObtenerTodos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtBuscar.Text;
            Customers cliente = _customerRepository.ClientePorID(id);
            AsignarATxt(cliente);
            List<Customers> customer = new List<Customers> { cliente };
            dgvClientes.DataSource = customer;
        }

        private void AsignarATxt(Customers customer)
        {
            txtCustomerID.Text = customer.CustomerID;
            txtCompanyName.Text = customer.CompanyName;
            txtAddres.Text = customer.Address;
            txtContactName.Text = customer.ContactName;
            txtContactTitle.Text = customer.ContactTitle;
        }
    }
}
