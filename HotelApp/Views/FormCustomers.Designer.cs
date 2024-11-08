namespace HotelApp.Views
{
    partial class FormCustomers
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
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            listBoxCustomers = new ListBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(722, 58);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(297, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(722, 122);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(297, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(722, 192);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(297, 27);
            textBoxPhone.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 4;
            label1.Text = "Kunder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(722, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Namn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(722, 99);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(722, 169);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 7;
            label4.Text = "Telefonnummer";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(925, 409);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Rensa";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(925, 269);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Radera";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(825, 269);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "Redigera";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(722, 269);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Lägg till";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.Location = new Point(45, 56);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(612, 324);
            listBoxCustomers.TabIndex = 12;
            listBoxCustomers.SelectedIndexChanged += listBoxCustomers_SelectedIndexChanged;
            // 
            // FormCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 450);
            Controls.Add(listBoxCustomers);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Name = "FormCustomers";
            Text = "Customers";
            Load += FormCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private ListBox listBoxCustomers;
    }
}