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
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelAppDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelAppDbContextBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
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
            buttonCustomers.Location = new Point(882, 441);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(134, 29);
            buttonCustomers.TabIndex = 54;
            buttonCustomers.Text = "Hantera Kunder";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // FormManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 482);
            Controls.Add(buttonCustomers);
            Name = "FormManagement";
            Text = "Bokningshantering";
            Load += FormManagement_Load;
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelAppDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelAppDbContextBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource hotelAppDbContextBindingSource;
        private BindingSource bookingBindingSource;
        private BindingSource hotelAppDbContextBindingSource1;
        private BindingSource roomBindingSource;
        private Button buttonCustomers;
    }
}