using HotelApp.Repository;
using HotelApp.Repository.Entities;
using HotelApp.Repository.Repos;

namespace HotelApp.Views
{
    public partial class FormBooking : Form
    {

        private readonly RoomRepo _roomRepo;
        private readonly CustomerRepo _customerRepo;
        private readonly BookingRepo _bookingRepo;
        public FormBooking(HotelAppDbContext context)
        {
            InitializeComponent();
            _roomRepo = new(context);
            _customerRepo = new(context);
            _bookingRepo = new(context);
        }

        private void SearchAvailableRooms()
        {
            DateTime checkInDate = dateTimePickerCheckIn.Value;
            DateTime checkOutDate = dateTimePickerCheckOut.Value;
            int capacity = (int)comboBoxCapacity.SelectedItem;

            var availableRooms = _roomRepo.GetAvailableRooms(checkInDate, checkOutDate, capacity);

            listBoxSearchResults.DataSource = null;

            listBoxSearchResults.Items.Clear();
            foreach (var room in availableRooms)
            {
                listBoxSearchResults.Items.Add(room);
            }
        }
        private void ClearAll()
        {
            comboBoxCustomer.SelectedIndex = -1;
            listBoxSearchResults.ClearSelected();
            numericUpDownAmount.Value = 0;
            dateTimePickerCheckIn.Value = DateTime.Now;
            dateTimePickerCheckOut.Value = DateTime.Now;

            var rooms = _roomRepo.GetAllRooms();
            listBoxSearchResults.DataSource = rooms;

            var customers = _customerRepo.GetAllCustomers();
            comboBoxCustomer.DataSource = customers;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchAvailableRooms();

        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            comboBoxCapacity.Items.AddRange(new object[] { 1, 2, 3, 4 });
            comboBoxCapacity.SelectedIndex = 0;

            var customers = _customerRepo.GetAllCustomers();
            comboBoxCustomer.DataSource = customers;
            comboBoxCustomer.DisplayMember = "Name";    
            comboBoxCustomer.ValueMember = "CustomerId";   
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            var selectedRoom = listBoxSearchResults.SelectedItem as Room;

            var selectedCustomer = comboBoxCustomer.SelectedItem as Customer;

            if (selectedRoom == null || selectedCustomer == null)
            {
                MessageBox.Show("Välj ett rum och en kund.");
                return;
            }

            var checkInDate = dateTimePickerCheckIn.Value;
            var checkOutDate = dateTimePickerCheckOut.Value;

            if (checkOutDate <= checkInDate)
            {
                MessageBox.Show("Check-out måste vara ett datum efter check-in.");
                return;
            }

            if (checkInDate <= DateTime.Today) {

                MessageBox.Show("Datum kan ej vara tidigare än dagens datum.");
                return;
            }

            var isRoomAvailable = _roomRepo.IsRoomAvailable(selectedRoom.RoomId, checkInDate, checkOutDate);
            if (!isRoomAvailable)
            {
                MessageBox.Show("Rummet är inte tillgänlig mellan valda datum.");
                return;
            }

            var amount = numericUpDownAmount.Value;

            var newBooking = _bookingRepo.CreateBooking(selectedCustomer, selectedRoom, checkInDate, checkOutDate, amount);

            MessageBox.Show("Bokningen är nu slutförd!");

            ClearAll();
        }
    }
}
