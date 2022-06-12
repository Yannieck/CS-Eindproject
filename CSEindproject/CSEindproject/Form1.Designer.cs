namespace CSEindproject
{
    partial class Form1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CampingPage = new System.Windows.Forms.TabPage();
            this.TotIncomeLabelValue = new System.Windows.Forms.Label();
            this.AvgTimespanLabelValue = new System.Windows.Forms.Label();
            this.PeopleAmtLabelValue = new System.Windows.Forms.Label();
            this.AdressLabelValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CampingNameLabel = new System.Windows.Forms.Label();
            this.ReservePage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.ReservationPriceLabel = new System.Windows.Forms.Label();
            this.ReservationPlaceInput = new System.Windows.Forms.TextBox();
            this.HasCarCheckbox = new System.Windows.Forms.CheckBox();
            this.PeopleAmountField = new System.Windows.Forms.NumericUpDown();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PlacePage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.PlacePriceField = new System.Windows.Forms.NumericUpDown();
            this.PlaceNameField = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlaceListLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TabControl.SuspendLayout();
            this.CampingPage.SuspendLayout();
            this.ReservePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleAmountField)).BeginInit();
            this.PlacePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlacePriceField)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CampingPage);
            this.TabControl.Controls.Add(this.ReservePage);
            this.TabControl.Controls.Add(this.PlacePage);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(633, 491);
            this.TabControl.TabIndex = 0;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.Camping_Selected);
            // 
            // CampingPage
            // 
            this.CampingPage.Controls.Add(this.TotIncomeLabelValue);
            this.CampingPage.Controls.Add(this.AvgTimespanLabelValue);
            this.CampingPage.Controls.Add(this.PeopleAmtLabelValue);
            this.CampingPage.Controls.Add(this.AdressLabelValue);
            this.CampingPage.Controls.Add(this.label4);
            this.CampingPage.Controls.Add(this.label3);
            this.CampingPage.Controls.Add(this.label2);
            this.CampingPage.Controls.Add(this.label1);
            this.CampingPage.Controls.Add(this.CampingNameLabel);
            this.CampingPage.Location = new System.Drawing.Point(4, 25);
            this.CampingPage.Name = "CampingPage";
            this.CampingPage.Padding = new System.Windows.Forms.Padding(3);
            this.CampingPage.Size = new System.Drawing.Size(625, 462);
            this.CampingPage.TabIndex = 0;
            this.CampingPage.Text = "Camping";
            this.CampingPage.UseVisualStyleBackColor = true;
            // 
            // TotIncomeLabelValue
            // 
            this.TotIncomeLabelValue.AutoSize = true;
            this.TotIncomeLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotIncomeLabelValue.Location = new System.Drawing.Point(205, 188);
            this.TotIncomeLabelValue.Name = "TotIncomeLabelValue";
            this.TotIncomeLabelValue.Size = new System.Drawing.Size(35, 20);
            this.TotIncomeLabelValue.TabIndex = 8;
            this.TotIncomeLabelValue.Text = "null";
            // 
            // AvgTimespanLabelValue
            // 
            this.AvgTimespanLabelValue.AutoSize = true;
            this.AvgTimespanLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgTimespanLabelValue.Location = new System.Drawing.Point(205, 155);
            this.AvgTimespanLabelValue.Name = "AvgTimespanLabelValue";
            this.AvgTimespanLabelValue.Size = new System.Drawing.Size(35, 20);
            this.AvgTimespanLabelValue.TabIndex = 7;
            this.AvgTimespanLabelValue.Text = "null";
            // 
            // PeopleAmtLabelValue
            // 
            this.PeopleAmtLabelValue.AutoSize = true;
            this.PeopleAmtLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleAmtLabelValue.Location = new System.Drawing.Point(205, 123);
            this.PeopleAmtLabelValue.Name = "PeopleAmtLabelValue";
            this.PeopleAmtLabelValue.Size = new System.Drawing.Size(35, 20);
            this.PeopleAmtLabelValue.TabIndex = 6;
            this.PeopleAmtLabelValue.Text = "null";
            // 
            // AdressLabelValue
            // 
            this.AdressLabelValue.AutoSize = true;
            this.AdressLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressLabelValue.Location = new System.Drawing.Point(205, 91);
            this.AdressLabelValue.Name = "AdressLabelValue";
            this.AdressLabelValue.Size = new System.Drawing.Size(35, 20);
            this.AdressLabelValue.TabIndex = 5;
            this.AdressLabelValue.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Totale Inkomsten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gemm. Tijdsduur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aantal Personen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres:";
            // 
            // CampingNameLabel
            // 
            this.CampingNameLabel.AutoSize = true;
            this.CampingNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampingNameLabel.Location = new System.Drawing.Point(30, 42);
            this.CampingNameLabel.Name = "CampingNameLabel";
            this.CampingNameLabel.Size = new System.Drawing.Size(194, 29);
            this.CampingNameLabel.TabIndex = 0;
            this.CampingNameLabel.Text = "CampingName";
            // 
            // ReservePage
            // 
            this.ReservePage.Controls.Add(this.button2);
            this.ReservePage.Controls.Add(this.ReservationPriceLabel);
            this.ReservePage.Controls.Add(this.ReservationPlaceInput);
            this.ReservePage.Controls.Add(this.HasCarCheckbox);
            this.ReservePage.Controls.Add(this.PeopleAmountField);
            this.ReservePage.Controls.Add(this.EndDatePicker);
            this.ReservePage.Controls.Add(this.StartDatePicker);
            this.ReservePage.Controls.Add(this.label15);
            this.ReservePage.Controls.Add(this.label14);
            this.ReservePage.Controls.Add(this.label13);
            this.ReservePage.Controls.Add(this.label12);
            this.ReservePage.Controls.Add(this.label11);
            this.ReservePage.Controls.Add(this.label10);
            this.ReservePage.Controls.Add(this.label9);
            this.ReservePage.Location = new System.Drawing.Point(4, 25);
            this.ReservePage.Name = "ReservePage";
            this.ReservePage.Padding = new System.Windows.Forms.Padding(3);
            this.ReservePage.Size = new System.Drawing.Size(625, 462);
            this.ReservePage.TabIndex = 1;
            this.ReservePage.Text = "Reserveren";
            this.ReservePage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reserveer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ReserveBtn_Click);
            // 
            // ReservationPriceLabel
            // 
            this.ReservationPriceLabel.AutoSize = true;
            this.ReservationPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationPriceLabel.Location = new System.Drawing.Point(217, 294);
            this.ReservationPriceLabel.Name = "ReservationPriceLabel";
            this.ReservationPriceLabel.Size = new System.Drawing.Size(49, 20);
            this.ReservationPriceLabel.TabIndex = 12;
            this.ReservationPriceLabel.Text = "€5,00";
            // 
            // ReservationPlaceInput
            // 
            this.ReservationPlaceInput.Location = new System.Drawing.Point(221, 223);
            this.ReservationPlaceInput.Name = "ReservationPlaceInput";
            this.ReservationPlaceInput.Size = new System.Drawing.Size(200, 22);
            this.ReservationPlaceInput.TabIndex = 11;
            this.ReservationPlaceInput.TextChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // HasCarCheckbox
            // 
            this.HasCarCheckbox.AutoSize = true;
            this.HasCarCheckbox.Location = new System.Drawing.Point(221, 189);
            this.HasCarCheckbox.Name = "HasCarCheckbox";
            this.HasCarCheckbox.Size = new System.Drawing.Size(95, 20);
            this.HasCarCheckbox.TabIndex = 10;
            this.HasCarCheckbox.Text = "checkBox1";
            this.HasCarCheckbox.UseVisualStyleBackColor = true;
            this.HasCarCheckbox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // PeopleAmountField
            // 
            this.PeopleAmountField.Location = new System.Drawing.Point(221, 155);
            this.PeopleAmountField.Name = "PeopleAmountField";
            this.PeopleAmountField.Size = new System.Drawing.Size(200, 22);
            this.PeopleAmountField.TabIndex = 9;
            this.PeopleAmountField.ValueChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(221, 122);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 22);
            this.EndDatePicker.TabIndex = 8;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(221, 91);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 22);
            this.StartDatePicker.TabIndex = 7;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Prijs:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Plaats:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Auto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Aantal personen:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Einddatum:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Startdatum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Reserveren";
            // 
            // PlacePage
            // 
            this.PlacePage.Controls.Add(this.button1);
            this.PlacePage.Controls.Add(this.PlacePriceField);
            this.PlacePage.Controls.Add(this.PlaceNameField);
            this.PlacePage.Controls.Add(this.label24);
            this.PlacePage.Controls.Add(this.label23);
            this.PlacePage.Controls.Add(this.panel1);
            this.PlacePage.Controls.Add(this.label18);
            this.PlacePage.Controls.Add(this.label17);
            this.PlacePage.Location = new System.Drawing.Point(4, 25);
            this.PlacePage.Name = "PlacePage";
            this.PlacePage.Padding = new System.Windows.Forms.Padding(3);
            this.PlacePage.Size = new System.Drawing.Size(625, 462);
            this.PlacePage.TabIndex = 2;
            this.PlacePage.Text = "Plaatsen";
            this.PlacePage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddPlace);
            // 
            // PlacePriceField
            // 
            this.PlacePriceField.DecimalPlaces = 2;
            this.PlacePriceField.Location = new System.Drawing.Point(395, 164);
            this.PlacePriceField.Name = "PlacePriceField";
            this.PlacePriceField.Size = new System.Drawing.Size(190, 22);
            this.PlacePriceField.TabIndex = 10;
            // 
            // PlaceNameField
            // 
            this.PlaceNameField.Location = new System.Drawing.Point(395, 133);
            this.PlaceNameField.Name = "PlaceNameField";
            this.PlaceNameField.Size = new System.Drawing.Size(190, 22);
            this.PlaceNameField.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(321, 163);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 20);
            this.label24.TabIndex = 8;
            this.label24.Text = "Prijs:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(321, 133);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 20);
            this.label23.TabIndex = 7;
            this.label23.Text = "Naam:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.PlaceListLabel);
            this.panel1.Location = new System.Drawing.Point(35, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 346);
            this.panel1.TabIndex = 2;
            // 
            // PlaceListLabel
            // 
            this.PlaceListLabel.AutoSize = true;
            this.PlaceListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceListLabel.Location = new System.Drawing.Point(20, 22);
            this.PlaceListLabel.Name = "PlaceListLabel";
            this.PlaceListLabel.Size = new System.Drawing.Size(62, 20);
            this.PlaceListLabel.TabIndex = 3;
            this.PlaceListLabel.Text = "label19";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(320, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(225, 29);
            this.label18.TabIndex = 1;
            this.label18.Text = "Plaats toevoegen";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(30, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 29);
            this.label17.TabIndex = 0;
            this.label17.Text = "Plaatsen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 515);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.CampingPage.ResumeLayout(false);
            this.CampingPage.PerformLayout();
            this.ReservePage.ResumeLayout(false);
            this.ReservePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleAmountField)).EndInit();
            this.PlacePage.ResumeLayout(false);
            this.PlacePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlacePriceField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CampingPage;
        private System.Windows.Forms.TabPage ReservePage;
        private System.Windows.Forms.TabPage PlacePage;
        private System.Windows.Forms.Label CampingNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotIncomeLabelValue;
        private System.Windows.Forms.Label AvgTimespanLabelValue;
        private System.Windows.Forms.Label PeopleAmtLabelValue;
        private System.Windows.Forms.Label AdressLabelValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ReservationPriceLabel;
        private System.Windows.Forms.TextBox ReservationPlaceInput;
        private System.Windows.Forms.CheckBox HasCarCheckbox;
        private System.Windows.Forms.NumericUpDown PeopleAmountField;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label PlaceListLabel;
        private System.Windows.Forms.NumericUpDown PlacePriceField;
        private System.Windows.Forms.TextBox PlaceNameField;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

