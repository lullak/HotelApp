using HotelApp.Repository;
using HotelApp.Repository.Entities;
using HotelApp.Repository.Repos;

namespace HotelApp.Views
{
    public partial class FormCustomers : Form
    {
        private readonly CustomerRepo _customerRepo;
        public FormCustomers(HotelAppDbContext context)
        {
            InitializeComponent();
            _customerRepo = new CustomerRepo(context);

        }

        private void LoadCustomers()
        {
            listBoxCustomers.Items.Clear();
            var customers = _customerRepo.GetAllCustomers();

            foreach (var customer in customers)
            {
                listBoxCustomers.Items.Add(customer);
            }
        }

        private void ClearAll()
        {
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            listBoxCustomers.ClearSelected();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void FormCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem is Customer selectedCustomer)
            {
                bool hasBookings = _customerRepo.HasBookings(selectedCustomer.CustomerId);

                if (hasBookings)
                {
                    MessageBox.Show("Kan inte radera en kund som har en bokning.");
                    return;
                }
 
                bool isDeleted = _customerRepo.DeleteCustomer(selectedCustomer.CustomerId);

                if (isDeleted)
                {
                    LoadCustomers();
                    ClearAll();
                    MessageBox.Show("Kunden har raderats bort.");
                }
                else
                {
                    MessageBox.Show("Ett fel inträffade vid radering av kund.");
                }
            }
            else
            {
                MessageBox.Show("Välj en kund för att radera.");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem is Customer selectedCustomer)
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPhone.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    MessageBox.Show("Fälten får inte vara tomma");
                    return;
                }

                selectedCustomer.Name = textBoxName.Text.Trim();
                selectedCustomer.Email = textBoxEmail.Text.Trim();
                selectedCustomer.PhoneNumber = textBoxPhone.Text.Trim();

                try
                {
                    _customerRepo.UpdateCustomer(selectedCustomer);
                    LoadCustomers();
                    ClearAll();

                    MessageBox.Show("Kundinformationen har uppdaterats.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Något gick fel med uppdateringen.\n{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Välj en kund för att redigera kundinformationen");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPhone.Text) ||string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Fyll i Fälten");
                return;
            }
            var newCustomer = new Customer
            {
                Name = textBoxName.Text.Trim(),
                Email = textBoxEmail.Text.Trim(),
                PhoneNumber = textBoxPhone.Text.Trim()
            };

            try
            {
                _customerRepo.AddCustomer(newCustomer);

                LoadCustomers();
                ClearAll();

                MessageBox.Show("Kunden har lagts till.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde ej lägga till kund.\n{ex.Message}");
            }
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = listBoxCustomers.SelectedItem == null;

            if (listBoxCustomers.SelectedItem is Customer selectedCustomer)
            {
                textBoxName.Text = selectedCustomer.Name;
                textBoxEmail.Text = selectedCustomer.Email;
                textBoxPhone.Text = selectedCustomer.PhoneNumber;
            }
        }
    }
}
