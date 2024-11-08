using HotelApp.Repository.Repos;
using HotelApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp.Views
{
    public partial class FormManagement : Form
    {

        public FormManagement()
        {
            InitializeComponent();
        }

        private void FormManagement_Load(object sender, EventArgs e)
        {

        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            HotelAppDbContext context = new HotelAppDbContext(); 

            FormCustomers formCustomers = new FormCustomers(context);
            formCustomers.Show();
        }
    }
}
