namespace ManagementSystem
{
    partial class FinalizePayment
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
            reservation = new Label();
            currentBill = new Label();
            foodBillLabel = new Label();
            paymentLabel = new Label();
            metroLabel12 = new Label();
            cardTypeView = new Label();
            totalLabel = new Label();
            metroLabel5 = new Label();
            priceLabel = new Label();
            totalAmount = new Label();
            taxAmount = new Label();
            foodBillAmount = new Label();
            currentBillAmount = new Label();
            paymentComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            phoneNComboBox = new TextBox();
            cvcComboBox = new TextBox();
            label1 = new Label();
            nextButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // reservation
            // 
            reservation.AutoSize = true;
            reservation.Font = new Font("Segoe UI", 11.25F);
            reservation.Location = new Point(49, 26);
            reservation.Name = "reservation";
            reservation.Size = new Size(86, 20);
            reservation.TabIndex = 1;
            reservation.Text = "Reservation";
            // 
            // currentBill
            // 
            currentBill.AutoSize = true;
            currentBill.Font = new Font("Segoe UI", 11.25F);
            currentBill.Location = new Point(49, 52);
            currentBill.Name = "currentBill";
            currentBill.Size = new Size(82, 20);
            currentBill.TabIndex = 2;
            currentBill.Text = "Current Bill";
            // 
            // foodBillLabel
            // 
            foodBillLabel.AutoSize = true;
            foodBillLabel.Font = new Font("Segoe UI", 11.25F);
            foodBillLabel.Location = new Point(49, 78);
            foodBillLabel.Name = "foodBillLabel";
            foodBillLabel.Size = new Size(68, 20);
            foodBillLabel.TabIndex = 3;
            foodBillLabel.Text = "Food Bill";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Font = new Font("Segoe UI", 11.25F);
            paymentLabel.Location = new Point(49, 156);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(111, 20);
            paymentLabel.TabIndex = 4;
            paymentLabel.Text = "Payement Type:";
            // 
            // metroLabel12
            // 
            metroLabel12.AutoSize = true;
            metroLabel12.Location = new Point(50, 247);
            metroLabel12.Name = "metroLabel12";
            metroLabel12.Size = new Size(62, 15);
            metroLabel12.TabIndex = 5;
            metroLabel12.Text = "Card Type:";
            // 
            // cardTypeView
            // 
            cardTypeView.AutoSize = true;
            cardTypeView.Location = new Point(118, 247);
            cardTypeView.Name = "cardTypeView";
            cardTypeView.Size = new Size(58, 15);
            cardTypeView.TabIndex = 6;
            cardTypeView.Text = "Unknown";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 11.25F);
            totalLabel.Location = new Point(49, 130);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(42, 20);
            totalLabel.TabIndex = 7;
            totalLabel.Text = "Total";
            totalLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.Font = new Font("Segoe UI", 11.25F);
            metroLabel5.Location = new Point(49, 104);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(30, 20);
            metroLabel5.TabIndex = 8;
            metroLabel5.Text = "Tax";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 11.25F);
            priceLabel.Location = new Point(236, 25);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 20);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price";
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI", 11.25F);
            totalAmount.Location = new Point(245, 130);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(17, 20);
            totalAmount.TabIndex = 10;
            totalAmount.Text = "$";
            // 
            // taxAmount
            // 
            taxAmount.AutoSize = true;
            taxAmount.Font = new Font("Segoe UI", 11.25F);
            taxAmount.Location = new Point(245, 103);
            taxAmount.Name = "taxAmount";
            taxAmount.Size = new Size(17, 20);
            taxAmount.TabIndex = 11;
            taxAmount.Text = "$";
            // 
            // foodBillAmount
            // 
            foodBillAmount.AutoSize = true;
            foodBillAmount.Font = new Font("Segoe UI", 11.25F);
            foodBillAmount.Location = new Point(245, 80);
            foodBillAmount.Name = "foodBillAmount";
            foodBillAmount.Size = new Size(17, 20);
            foodBillAmount.TabIndex = 12;
            foodBillAmount.Text = "$";
            // 
            // currentBillAmount
            // 
            currentBillAmount.AutoSize = true;
            currentBillAmount.Font = new Font("Segoe UI", 11.25F);
            currentBillAmount.Location = new Point(245, 53);
            currentBillAmount.Name = "currentBillAmount";
            currentBillAmount.Size = new Size(17, 20);
            currentBillAmount.TabIndex = 13;
            currentBillAmount.Text = "$";
            // 
            // paymentComboBox
            // 
            paymentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            paymentComboBox.FormattingEnabled = true;
            paymentComboBox.Location = new Point(166, 157);
            paymentComboBox.Name = "paymentComboBox";
            paymentComboBox.Size = new Size(127, 23);
            paymentComboBox.TabIndex = 14;
            // 
            // monthComboBox
            // 
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Location = new Point(51, 215);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(42, 23);
            monthComboBox.TabIndex = 15;
            // 
            // yearComboBox
            // 
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(118, 215);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(69, 23);
            yearComboBox.TabIndex = 16;
            // 
            // phoneNComboBox
            // 
            phoneNComboBox.Location = new Point(51, 186);
            phoneNComboBox.Name = "phoneNComboBox";
            phoneNComboBox.Size = new Size(242, 23);
            phoneNComboBox.TabIndex = 17;
            // 
            // cvcComboBox
            // 
            cvcComboBox.Location = new Point(193, 215);
            cvcComboBox.Name = "cvcComboBox";
            cvcComboBox.PlaceholderText = "CVC";
            cvcComboBox.Size = new Size(100, 23);
            cvcComboBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 213);
            label1.Name = "label1";
            label1.Size = new Size(19, 25);
            label1.TabIndex = 19;
            label1.Text = "/";
            // 
            // nextButton
            // 
            nextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextButton.Depth = 0;
            nextButton.HighEmphasis = true;
            nextButton.Icon = null;
            nextButton.Location = new Point(121, 289);
            nextButton.Margin = new Padding(4, 6, 4, 6);
            nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            nextButton.Name = "nextButton";
            nextButton.NoAccentTextColor = Color.Empty;
            nextButton.Size = new Size(97, 36);
            nextButton.TabIndex = 20;
            nextButton.Text = "   Confirm   ";
            nextButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nextButton.UseAccentColor = false;
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // FinalizePayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(338, 359);
            Controls.Add(nextButton);
            Controls.Add(label1);
            Controls.Add(cvcComboBox);
            Controls.Add(phoneNComboBox);
            Controls.Add(yearComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(paymentComboBox);
            Controls.Add(currentBillAmount);
            Controls.Add(foodBillAmount);
            Controls.Add(taxAmount);
            Controls.Add(totalAmount);
            Controls.Add(priceLabel);
            Controls.Add(metroLabel5);
            Controls.Add(totalLabel);
            Controls.Add(cardTypeView);
            Controls.Add(metroLabel12);
            Controls.Add(paymentLabel);
            Controls.Add(foodBillLabel);
            Controls.Add(currentBill);
            Controls.Add(reservation);
            Name = "FinalizePayment";
            Text = "FinalizePayment";
            Load += FinalizePayment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label reservation;
        private Label currentBill;
        private Label foodBillLabel;
        private Label paymentLabel;
        private Label metroLabel12;
        private Label cardTypeView;
        private Label totalLabel;
        private Label metroLabel5;
        private Label priceLabel;
        private Label totalAmount;
        private Label taxAmount;
        private Label foodBillAmount;
        private Label currentBillAmount;
        private ComboBox paymentComboBox;
        private ComboBox monthComboBox;
        private ComboBox yearComboBox;
        private TextBox phoneNComboBox;
        private TextBox cvcComboBox;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton nextButton;
    }
}