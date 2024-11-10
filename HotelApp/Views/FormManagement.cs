using HotelApp.Classes;
using HotelApp.Repository;
using HotelApp.Repository.Entities;
using HotelApp.Repository.Repos;
using System.Data;

namespace HotelApp.Views
{
    public partial class FormManagement : Form
    {
        private readonly HotelAppDbContext _context;
        private readonly CustomerRepo _customerRepo;
        private readonly RoomRepo _roomRepo;
        private readonly InvoiceRepo _invoiceRepo;
        private readonly BookingRepo _bookingRepo;
        public FormManagement()
        {
            InitializeComponent();
            _context = new();
            _customerRepo = new(_context);
            _roomRepo = new(_context);
            _bookingRepo = new(_context);
            _invoiceRepo = new(_context);
        }

        private void LoadBookings()
        {
            listBoxBookings.Items.Clear();

            var bookings = _bookingRepo.GetAllBookings();

            foreach (var booking in bookings)
            {
                listBoxBookings.Items.Add(new ListBoxItem
                {
                    Text = booking.ToString(),
                    Tag = booking
                });
            }
        }

        private void ClearAll()
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                control.Clear();
            }

            foreach (var control in Controls.OfType<ComboBox>())
            {
                control.SelectedIndex = -1;
            }

            foreach (var control in Controls.OfType<DateTimePicker>())
            {
                control.Value = DateTime.Now;
            }

            foreach (var control in Controls.OfType<NumericUpDown>())
            {
                control.Value = 0;
            }


            foreach (var control in Controls.OfType<CheckBox>())
            {
                control.Checked = false;
            }

            listBoxBookings.ClearSelected();

            var rooms = _roomRepo.GetAllRooms();
            comboBoxRoom.DataSource = rooms;
            comboBoxRoom.DisplayMember = "RoomName";
            comboBoxRoom.ValueMember = "RoomId";

            var customers = _customerRepo.GetAllCustomers();
            comboBoxCustomer.DataSource = customers;
            comboBoxCustomer.DisplayMember = "Name";
            comboBoxCustomer.ValueMember = "CustomerId";

            LoadBookings();
        }
        private void FormManagement_Load(object sender, EventArgs e)
        {
            _bookingRepo.CancelOverdueBookings();
            LoadBookings();
            ClearAll();
        }


        private void buttonCustomers_Click(object sender, EventArgs e)
        {

            FormCustomers formCustomers = new FormCustomers(_context);
            formCustomers.Show();
        }

        private void listBoxBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBookings.SelectedItem is ListBoxItem selectedItem)
            {
                var selectedBooking = selectedItem.Tag as Booking;

                if (selectedBooking != null)
                {
                    comboBoxRoom.SelectedItem = comboBoxRoom.Items.Cast<Room>()
                        .FirstOrDefault(r => r.RoomId == selectedBooking.Room.RoomId);
                    comboBoxCustomer.SelectedItem = comboBoxCustomer.Items.Cast<Customer>()
                        .FirstOrDefault(c => c.CustomerId == selectedBooking.Customer.CustomerId);

                    dateTimePickerBookingdate.Value = selectedBooking.BookingDate;
                    dateTimePickerCheckIn.Value = selectedBooking.CheckInDate;
                    dateTimePickerCheckOut.Value = selectedBooking.CheckOutDate;

                    textBoxRoomType.Text = selectedBooking.Room.RoomType;
                    textBoxCapacity.Text = selectedBooking.Room.Capacity.ToString();
                    textBoxExtraBeds.Text = selectedBooking.Room.ExtraBedCount.ToString();

                    numericUpDownAmount.Value = selectedBooking.Invoice.Amount;
                    dateTimePickerInvoiceDate.Value = selectedBooking.Invoice.DateIssued;
                    checkBoxPayment.Checked = selectedBooking.Invoice.IsPaid;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRoom.SelectedItem is Room selectedRoom)
            {
                textBoxRoomType.Text = selectedRoom.RoomType;
                textBoxCapacity.Text = selectedRoom.Capacity.ToString();
                textBoxExtraBeds.Text = selectedRoom.ExtraBedCount.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBooking formBooking = new FormBooking(_context);
            formBooking.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxBookings.SelectedItem is ListBoxItem selectedItem)
            {
                var selectedBooking = selectedItem.Tag as Booking;
                if (selectedBooking != null)
                {
                    int bookingId = selectedBooking.BookingId;
                    int newCustomerId = (int)comboBoxCustomer.SelectedValue;
                    int newRoomId = ((Room)comboBoxRoom.SelectedItem).RoomId;
                    DateTime checkInDate = dateTimePickerCheckIn.Value;
                    DateTime checkOutDate = dateTimePickerCheckOut.Value;
                    decimal amount = numericUpDownAmount.Value;
                    bool isPaid = checkBoxPayment.Checked;

                    _bookingRepo.UpdateBooking(bookingId, newCustomerId, newRoomId, checkInDate, checkOutDate, amount, isPaid);

                    MessageBox.Show("Bokningen har uppdaterats.");
                    LoadBookings();
                }
            }
            else
            {
                MessageBox.Show("Välj en bookning att uppdatera.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxBookings.SelectedItem is ListBoxItem selectedItem)
            {
                var bookingToDelete = selectedItem.Tag as Booking;

                if (bookingToDelete != null)
                {
                    var confirmResult = MessageBox.Show("Vill du radera bokningen?",
                                                        "Bekräfta", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        _bookingRepo.DeleteBooking(bookingToDelete.BookingId);

                        LoadBookings();
                        MessageBox.Show("Bokningen har raderats.");
                    }
                }
                else
                {
                    MessageBox.Show("Välj en bokning att radera.");
                }
            }
        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            var selectedRoom = comboBoxRoom.SelectedItem as Room;

            if (selectedRoom == null)
            {
                MessageBox.Show("Välj ett rum att redigera.");
                return;
            }

            if (!int.TryParse(textBoxExtraBeds.Text, out int extraBedCount))
            {
                MessageBox.Show("Ange antalet extrasängar.");
                return;
            }

            if (selectedRoom.RoomType == "Single" && extraBedCount > 0)
            {
                MessageBox.Show("Singelrum kan inte ha extrasängar");
                return;
            }
            else if (selectedRoom.RoomType == "Double" && (extraBedCount < 0 || extraBedCount > 2))
            {
                MessageBox.Show("Dubbelrum kan endast ha 1 eller 2 extra sängar.");
                return;
            }

            int newCapacity = selectedRoom.Capacity + extraBedCount; 

            selectedRoom.ExtraBedCount = extraBedCount;
            selectedRoom.Capacity = selectedRoom.RoomType == "Double" ? 2 + extraBedCount : 1;

            _roomRepo.UpdateRoom(selectedRoom);

            MessageBox.Show("Kapacitet och antal extrasängar har uppdaterats.");
            ClearAll();
        }
    }
}
