namespace HotelApp.Views
{
    partial class FormManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bookingBindingSource = new BindingSource(components);
            hotelAppDbContextBindingSource = new BindingSource(components);
            hotelAppDbContextBindingSource1 = new BindingSource(components);
            roomBindingSource = new BindingSource(components);
            buttonCustomers = new Button();
            listBoxBookings = new ListBox();
            comboBoxCustomer = new ComboBox();
            comboBoxRoom = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            checkBoxPayment = new CheckBox();
            dateTimePickerInvoiceDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            numericUpDownAmount = new NumericUpDown();
            dateTimePickerBookingdate = new DateTimePicker();
            dateTimePickerCheckIn = new DateTimePicker();
            dateTimePickerCheckOut = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxCapacity = new TextBox();
            textBoxExtraBeds = new TextBox();
            textBoxRoomType = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            button2 = new Button();
            label14 = new Label();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelAppDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelAppDbContextBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // bookingBindingSource
            // 
            bookingBindingSource.DataSource = typeof(Repository.Entities.Booking);
            // 
            // hotelAppDbContextBindingSource
            // 
            hotelAppDbContextBindingSource.DataSource = typeof(Repository.HotelAppDbContext);
            // 
            // hotelAppDbContextBindingSource1
            // 
            hotelAppDbContextBindingSource1.DataSource = typeof(Repository.HotelAppDbContext);
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Repository.Entities.Room);
            // 
            // buttonCustomers
            // 
            buttonCustomers.Location = new Point(1392, 649);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(134, 29);
            buttonCustomers.TabIndex = 54;
            buttonCustomers.Text = "Hantera Kunder";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // listBoxBookings
            // 
            listBoxBookings.FormattingEnabled = true;
            listBoxBookings.Location = new Point(38, 53);
            listBoxBookings.Name = "listBoxBookings";
            listBoxBookings.Size = new Size(1474, 384);
            listBoxBookings.TabIndex = 55;
            listBoxBookings.SelectedIndexChanged += listBoxBookings_SelectedIndexChanged;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(713, 471);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(151, 28);
            comboBoxCustomer.TabIndex = 56;
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new Point(102, 472);
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new Size(151, 28);
            comboBoxRoom.TabIndex = 57;
            comboBoxRoom.SelectedIndexChanged += comboBoxRoom_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(713, 448);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 58;
            label1.Text = "Kund";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 449);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 59;
            label2.Text = "Rum";
            // 
            // button1
            // 
            button1.Location = new Point(1418, 446);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 60;
            button1.Text = "Rensa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 511);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 61;
            label3.Text = "Bookning";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 592);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 62;
            label4.Text = "Faktura";
            // 
            // checkBoxPayment
            // 
            checkBoxPayment.AutoSize = true;
            checkBoxPayment.Location = new Point(546, 639);
            checkBoxPayment.Name = "checkBoxPayment";
            checkBoxPayment.Size = new Size(74, 24);
            checkBoxPayment.TabIndex = 64;
            checkBoxPayment.Text = "Betald";
            checkBoxPayment.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerInvoiceDate
            // 
            dateTimePickerInvoiceDate.Location = new Point(272, 637);
            dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            dateTimePickerInvoiceDate.Size = new Size(250, 27);
            dateTimePickerInvoiceDate.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 614);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 66;
            label5.Text = "Pris";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 614);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 67;
            label6.Text = "Faktura Datum";
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(103, 636);
            numericUpDownAmount.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(150, 27);
            numericUpDownAmount.TabIndex = 68;
            // 
            // dateTimePickerBookingdate
            // 
            dateTimePickerBookingdate.Location = new Point(102, 558);
            dateTimePickerBookingdate.Name = "dateTimePickerBookingdate";
            dateTimePickerBookingdate.Size = new Size(250, 27);
            dateTimePickerBookingdate.TabIndex = 69;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(358, 558);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(250, 27);
            dateTimePickerCheckIn.TabIndex = 70;
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(614, 558);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(250, 27);
            dateTimePickerCheckOut.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 535);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 72;
            label7.Text = "Bokningsdatum";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(358, 535);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 73;
            label8.Text = "Check in";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(614, 535);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 74;
            label9.Text = "Check Out";
            // 
            // textBoxCapacity
            // 
            textBoxCapacity.Location = new Point(422, 473);
            textBoxCapacity.Name = "textBoxCapacity";
            textBoxCapacity.ReadOnly = true;
            textBoxCapacity.Size = new Size(125, 27);
            textBoxCapacity.TabIndex = 75;
            // 
            // textBoxExtraBeds
            // 
            textBoxExtraBeds.Location = new Point(565, 472);
            textBoxExtraBeds.Name = "textBoxExtraBeds";
            textBoxExtraBeds.ReadOnly = true;
            textBoxExtraBeds.Size = new Size(125, 27);
            textBoxExtraBeds.TabIndex = 76;
            // 
            // textBoxRoomType
            // 
            textBoxRoomType.Location = new Point(272, 473);
            textBoxRoomType.Name = "textBoxRoomType";
            textBoxRoomType.ReadOnly = true;
            textBoxRoomType.Size = new Size(125, 27);
            textBoxRoomType.TabIndex = 77;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(102, 449);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 78;
            label10.Text = "Rumnamn";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(422, 451);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 79;
            label11.Text = "Max Kapacitet";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(565, 450);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 80;
            label12.Text = "Antal Extra sängar";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(272, 450);
            label13.Name = "label13";
            label13.Size = new Size(60, 20);
            label13.TabIndex = 81;
            label13.Text = "Rumtyp";
            // 
            // button2
            // 
            button2.Location = new Point(1292, 649);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 82;
            button2.Text = "Boka rum";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F);
            label14.Location = new Point(38, 9);
            label14.Name = "label14";
            label14.Size = new Size(122, 32);
            label14.TabIndex = 83;
            label14.Text = "Bokningar";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(662, 636);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 84;
            buttonEdit.Text = "Redigera";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(770, 634);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 85;
            buttonDelete.Text = "Radera";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 684);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(label14);
            Controls.Add(button2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBoxRoomType);
            Controls.Add(textBoxExtraBeds);
            Controls.Add(textBoxCapacity);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(dateTimePickerCheckIn);
            Controls.Add(dateTimePickerBookingdate);
            Controls.Add(numericUpDownAmount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePickerInvoiceDate);
            Controls.Add(checkBoxPayment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxRoom);
            Controls.Add(comboBoxCustomer);
            Controls.Add(listBoxBookings);
            Controls.Add(buttonCustomers);
            Name = "FormManagement";
            Text = "Bokningshantering";
            Load += FormManagement_Load;
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelAppDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelAppDbContextBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource hotelAppDbContextBindingSource;
        private BindingSource bookingBindingSource;
        private BindingSource hotelAppDbContextBindingSource1;
        private BindingSource roomBindingSource;
        private Button buttonCustomers;
        private ListBox listBoxBookings;
        private ComboBox comboBoxCustomer;
        private ComboBox comboBoxRoom;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private CheckBox checkBoxPayment;
        private DateTimePicker dateTimePickerInvoiceDate;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDownAmount;
        private DateTimePicker dateTimePickerBookingdate;
        private DateTimePicker dateTimePickerCheckIn;
        private DateTimePicker dateTimePickerCheckOut;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxCapacity;
        private TextBox textBoxExtraBeds;
        private TextBox textBoxRoomType;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button2;
        private Label label14;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}