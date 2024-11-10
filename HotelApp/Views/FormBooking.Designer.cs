namespace HotelApp.Views
{
    partial class FormBooking
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
            listBoxSearchResults = new ListBox();
            comboBoxCapacity = new ComboBox();
            dateTimePickerCheckIn = new DateTimePicker();
            dateTimePickerCheckOut = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSearch = new Button();
            comboBoxCustomer = new ComboBox();
            numericUpDownAmount = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            buttonBook = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // listBoxSearchResults
            // 
            listBoxSearchResults.FormattingEnabled = true;
            listBoxSearchResults.Location = new Point(36, 108);
            listBoxSearchResults.Name = "listBoxSearchResults";
            listBoxSearchResults.Size = new Size(801, 324);
            listBoxSearchResults.TabIndex = 0;
            // 
            // comboBoxCapacity
            // 
            comboBoxCapacity.FormattingEnabled = true;
            comboBoxCapacity.Location = new Point(36, 74);
            comboBoxCapacity.Name = "comboBoxCapacity";
            comboBoxCapacity.Size = new Size(151, 28);
            comboBoxCapacity.TabIndex = 1;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(193, 75);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(250, 27);
            dateTimePickerCheckIn.TabIndex = 2;
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(449, 75);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(250, 27);
            dateTimePickerCheckOut.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 51);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 4;
            label1.Text = "Antal personer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 51);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Check in";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 49);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 6;
            label3.Text = "Check out";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(705, 73);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(132, 29);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Sök lediga rum";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(548, 463);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(151, 28);
            comboBoxCustomer.TabIndex = 8;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(386, 464);
            numericUpDownAmount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(150, 27);
            numericUpDownAmount.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 441);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 10;
            label4.Text = "Pris";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(548, 441);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 11;
            label5.Text = "Kund";
            // 
            // buttonBook
            // 
            buttonBook.Location = new Point(743, 462);
            buttonBook.Name = "buttonBook";
            buttonBook.Size = new Size(94, 29);
            buttonBook.TabIndex = 12;
            buttonBook.Text = "Boka";
            buttonBook.UseVisualStyleBackColor = true;
            buttonBook.Click += buttonBook_Click;
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 569);
            Controls.Add(buttonBook);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDownAmount);
            Controls.Add(comboBoxCustomer);
            Controls.Add(buttonSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(dateTimePickerCheckIn);
            Controls.Add(comboBoxCapacity);
            Controls.Add(listBoxSearchResults);
            Name = "FormBooking";
            Text = "FormBooking";
            Load += FormBooking_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSearchResults;
        private ComboBox comboBoxCapacity;
        private DateTimePicker dateTimePickerCheckIn;
        private DateTimePicker dateTimePickerCheckOut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSearch;
        private ComboBox comboBoxCustomer;
        private NumericUpDown numericUpDownAmount;
        private Label label4;
        private Label label5;
        private Button buttonBook;
    }
}