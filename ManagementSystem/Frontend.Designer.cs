namespace ManagementSystem
{
    partial class Frontend
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
            FrontendHeader = new Label();
            resPanel = new TabControl();
            reservationPage = new TabPage();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            reservComboBox = new ComboBox();
            reservationlabel = new Label();
            updateButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            newButton = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SaveChanges = new MaterialSkin.Controls.MaterialButton();
            foodMenuButton = new Button();
            finalizeButton = new Button();
            foodSupplyCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            smsCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            checkinCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            dateTimePicker1 = new DateTimePicker();
            depertureLabel = new Label();
            roomNComboBox = new ComboBox();
            floorComboBox = new ComboBox();
            roomTypeComboBox = new ComboBox();
            qtGuestComboBox = new ComboBox();
            entryDatePicker = new DateTimePicker();
            entryLabel = new Label();
            choiceLabel = new Label();
            panel1 = new Panel();
            label4 = new Label();
            stateComboBox = new ComboBox();
            zipComboBox = new TextBox();
            cityTextBox = new TextBox();
            textBox4 = new TextBox();
            aptTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            genderComboBox = new ComboBox();
            BirthdayPicker = new DateTimePicker();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            genderLabel = new Label();
            birthdayLabel = new Label();
            nameLabel = new Label();
            searchPage = new TabPage();
            SearchError = new Label();
            searchDataGridView = new DataGridView();
            searchButton = new MaterialSkin.Controls.MaterialButton();
            searchTextBox = new TextBox();
            breakfastPicture = new PictureBox();
            metroTabPage2 = new TabPage();
            Refreshbtn = new Button();
            resTotalDataGridView = new DataGridView();
            roomPage = new TabPage();
            Refreshroombtn = new Button();
            reservedLabel = new Label();
            label1occupiedLabel = new Label();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            Tsubtn = new Button();
            resPanel.SuspendLayout();
            reservationPage.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).BeginInit();
            metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).BeginInit();
            roomPage.SuspendLayout();
            SuspendLayout();
            // 
            // FrontendHeader
            // 
            FrontendHeader.AutoSize = true;
            FrontendHeader.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FrontendHeader.ForeColor = Color.Crimson;
            FrontendHeader.Location = new Point(11, 9);
            FrontendHeader.Name = "FrontendHeader";
            FrontendHeader.Size = new Size(676, 25);
            FrontendHeader.TabIndex = 8;
            FrontendHeader.Text = "Welcome to the best Hotel Management System in the world!";
            // 
            // resPanel
            // 
            resPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resPanel.Controls.Add(reservationPage);
            resPanel.Controls.Add(searchPage);
            resPanel.Controls.Add(metroTabPage2);
            resPanel.Controls.Add(roomPage);
            resPanel.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resPanel.Location = new Point(11, 46);
            resPanel.Name = "resPanel";
            resPanel.SelectedIndex = 0;
            resPanel.Size = new Size(1117, 538);
            resPanel.TabIndex = 9;
            // 
            // reservationPage
            // 
            reservationPage.BackColor = Color.White;
            reservationPage.Controls.Add(panel4);
            reservationPage.Controls.Add(panel2);
            reservationPage.Controls.Add(panel1);
            reservationPage.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reservationPage.ForeColor = Color.Black;
            reservationPage.Location = new Point(4, 28);
            reservationPage.Name = "reservationPage";
            reservationPage.Padding = new Padding(3);
            reservationPage.Size = new Size(1109, 506);
            reservationPage.TabIndex = 0;
            reservationPage.Text = "          Reservation          ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(reservComboBox);
            panel4.Controls.Add(reservationlabel);
            panel4.Controls.Add(updateButton);
            panel4.Controls.Add(deleteButton);
            panel4.Controls.Add(editButton);
            panel4.Controls.Add(newButton);
            panel4.Location = new Point(10, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(355, 472);
            panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.New_Project__1_;
            pictureBox1.Location = new Point(-1, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 237);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // reservComboBox
            // 
            reservComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            reservComboBox.FormattingEnabled = true;
            reservComboBox.Location = new Point(11, 110);
            reservComboBox.Name = "reservComboBox";
            reservComboBox.Size = new Size(329, 24);
            reservComboBox.TabIndex = 35;
            reservComboBox.TabStop = false;
            reservComboBox.Visible = false;
            // 
            // reservationlabel
            // 
            reservationlabel.AutoSize = true;
            reservationlabel.Location = new Point(11, 90);
            reservationlabel.Name = "reservationlabel";
            reservationlabel.Size = new Size(171, 16);
            reservationlabel.TabIndex = 34;
            reservationlabel.Text = "Select reservation to edit";
            reservationlabel.Visible = false;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.LightGreen;
            updateButton.Location = new Point(11, 198);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(329, 33);
            updateButton.TabIndex = 33;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.RosyBrown;
            deleteButton.Location = new Point(11, 151);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(329, 36);
            deleteButton.TabIndex = 32;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.LightSteelBlue;
            editButton.Location = new Point(11, 46);
            editButton.Name = "editButton";
            editButton.Size = new Size(329, 33);
            editButton.TabIndex = 31;
            editButton.Text = "Edit existing Reservation";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // newButton
            // 
            newButton.BackColor = Color.LightSteelBlue;
            newButton.Location = new Point(11, 6);
            newButton.Name = "newButton";
            newButton.Size = new Size(329, 33);
            newButton.TabIndex = 30;
            newButton.Text = "New reservation";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(SaveChanges);
            panel2.Controls.Add(foodMenuButton);
            panel2.Controls.Add(finalizeButton);
            panel2.Controls.Add(foodSupplyCheckBox);
            panel2.Controls.Add(smsCheckBox);
            panel2.Controls.Add(checkinCheckBox);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(depertureLabel);
            panel2.Controls.Add(roomNComboBox);
            panel2.Controls.Add(floorComboBox);
            panel2.Controls.Add(roomTypeComboBox);
            panel2.Controls.Add(qtGuestComboBox);
            panel2.Controls.Add(entryDatePicker);
            panel2.Controls.Add(entryLabel);
            panel2.Controls.Add(choiceLabel);
            panel2.Location = new Point(744, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 472);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(40, 16);
            label3.TabIndex = 31;
            label3.Text = "Floor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 80);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 30;
            label2.Text = "Room Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 17);
            label1.Name = "label1";
            label1.Size = new Size(80, 16);
            label1.TabIndex = 29;
            label1.Text = "Room Type";
            // 
            // SaveChanges
            // 
            SaveChanges.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveChanges.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaveChanges.Depth = 0;
            SaveChanges.Enabled = false;
            SaveChanges.HighEmphasis = true;
            SaveChanges.Icon = null;
            SaveChanges.Location = new Point(85, 418);
            SaveChanges.Margin = new Padding(4, 6, 4, 6);
            SaveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            SaveChanges.Name = "SaveChanges";
            SaveChanges.NoAccentTextColor = Color.Empty;
            SaveChanges.Size = new Size(183, 36);
            SaveChanges.TabIndex = 28;
            SaveChanges.Text = "         Add Reservation        ";
            SaveChanges.TextAlign = ContentAlignment.MiddleLeft;
            SaveChanges.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveChanges.UseAccentColor = false;
            SaveChanges.UseVisualStyleBackColor = true;
            SaveChanges.Click += materialButton1_Click;
            // 
            // foodMenuButton
            // 
            foodMenuButton.BackColor = Color.SlateBlue;
            foodMenuButton.ForeColor = SystemColors.Control;
            foodMenuButton.Location = new Point(11, 264);
            foodMenuButton.Name = "foodMenuButton";
            foodMenuButton.Size = new Size(329, 33);
            foodMenuButton.TabIndex = 23;
            foodMenuButton.Text = "Food and Menu";
            foodMenuButton.UseVisualStyleBackColor = false;
            foodMenuButton.Click += foodMenuButton_Click;
            // 
            // finalizeButton
            // 
            finalizeButton.BackColor = Color.SlateBlue;
            finalizeButton.ForeColor = SystemColors.Control;
            finalizeButton.Location = new Point(11, 371);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new Size(328, 33);
            finalizeButton.TabIndex = 27;
            finalizeButton.Text = "Finalize Bill";
            finalizeButton.UseVisualStyleBackColor = false;
            finalizeButton.Click += finalizeButton_Click;
            // 
            // foodSupplyCheckBox
            // 
            foodSupplyCheckBox.AutoSize = true;
            foodSupplyCheckBox.Depth = 0;
            foodSupplyCheckBox.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodSupplyCheckBox.Location = new Point(10, 330);
            foodSupplyCheckBox.Margin = new Padding(0);
            foodSupplyCheckBox.MouseLocation = new Point(-1, -1);
            foodSupplyCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            foodSupplyCheckBox.ReadOnly = false;
            foodSupplyCheckBox.Ripple = true;
            foodSupplyCheckBox.Size = new Size(187, 37);
            foodSupplyCheckBox.TabIndex = 26;
            foodSupplyCheckBox.Text = "Food/Supply status ?";
            foodSupplyCheckBox.UseVisualStyleBackColor = true;
            // 
            // smsCheckBox
            // 
            smsCheckBox.AutoSize = true;
            smsCheckBox.Depth = 0;
            smsCheckBox.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smsCheckBox.Location = new Point(230, 299);
            smsCheckBox.Margin = new Padding(0);
            smsCheckBox.MouseLocation = new Point(-1, -1);
            smsCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            smsCheckBox.Name = "smsCheckBox";
            smsCheckBox.ReadOnly = false;
            smsCheckBox.Ripple = true;
            smsCheckBox.Size = new Size(109, 37);
            smsCheckBox.TabIndex = 25;
            smsCheckBox.Text = "Send SMS";
            smsCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkinCheckBox
            // 
            checkinCheckBox.AutoSize = true;
            checkinCheckBox.Depth = 0;
            checkinCheckBox.Location = new Point(10, 300);
            checkinCheckBox.Margin = new Padding(0);
            checkinCheckBox.MouseLocation = new Point(-1, -1);
            checkinCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            checkinCheckBox.Name = "checkinCheckBox";
            checkinCheckBox.ReadOnly = false;
            checkinCheckBox.Ripple = true;
            checkinCheckBox.Size = new Size(107, 37);
            checkinCheckBox.TabIndex = 24;
            checkinCheckBox.Text = "Check in ?";
            checkinCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(11, 228);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(329, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // depertureLabel
            // 
            depertureLabel.AutoSize = true;
            depertureLabel.Location = new Point(11, 207);
            depertureLabel.Name = "depertureLabel";
            depertureLabel.Size = new Size(117, 16);
            depertureLabel.TabIndex = 21;
            depertureLabel.Text = "Deperture [date]";
            // 
            // roomNComboBox
            // 
            roomNComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomNComboBox.FormattingEnabled = true;
            roomNComboBox.Location = new Point(177, 99);
            roomNComboBox.Name = "roomNComboBox";
            roomNComboBox.Size = new Size(163, 24);
            roomNComboBox.TabIndex = 20;
            roomNComboBox.Tag = "";
            // 
            // floorComboBox
            // 
            floorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            floorComboBox.FormattingEnabled = true;
            floorComboBox.Location = new Point(10, 99);
            floorComboBox.Name = "floorComboBox";
            floorComboBox.Size = new Size(161, 24);
            floorComboBox.TabIndex = 19;
            floorComboBox.Tag = "";
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.Location = new Point(177, 36);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new Size(163, 24);
            roomTypeComboBox.TabIndex = 18;
            roomTypeComboBox.Tag = "";
            // 
            // qtGuestComboBox
            // 
            qtGuestComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            qtGuestComboBox.FormattingEnabled = true;
            qtGuestComboBox.Location = new Point(10, 36);
            qtGuestComboBox.Name = "qtGuestComboBox";
            qtGuestComboBox.Size = new Size(161, 24);
            qtGuestComboBox.TabIndex = 17;
            qtGuestComboBox.Tag = "";
            // 
            // entryDatePicker
            // 
            entryDatePicker.Format = DateTimePickerFormat.Custom;
            entryDatePicker.Location = new Point(10, 161);
            entryDatePicker.Name = "entryDatePicker";
            entryDatePicker.Size = new Size(330, 23);
            entryDatePicker.TabIndex = 8;
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.Location = new Point(10, 138);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(86, 16);
            entryLabel.TabIndex = 2;
            entryLabel.Text = "Entry [Date]";
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.Location = new Point(10, 17);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(127, 16);
            choiceLabel.TabIndex = 0;
            choiceLabel.Text = "Number of Guests";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(stateComboBox);
            panel1.Controls.Add(zipComboBox);
            panel1.Controls.Add(cityTextBox);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(aptTextBox);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(phoneNumberTextBox);
            panel1.Controls.Add(genderComboBox);
            panel1.Controls.Add(BirthdayPicker);
            panel1.Controls.Add(lastNameTextBox);
            panel1.Controls.Add(firstNameTextBox);
            panel1.Controls.Add(phoneNumberLabel);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(genderLabel);
            panel1.Controls.Add(birthdayLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Location = new Point(377, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 472);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 438);
            label4.Name = "label4";
            label4.Size = new Size(45, 16);
            label4.TabIndex = 17;
            label4.Text = "State:";
            // 
            // stateComboBox
            // 
            stateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(65, 434);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(275, 24);
            stateComboBox.TabIndex = 16;
            stateComboBox.Tag = "";
            // 
            // zipComboBox
            // 
            zipComboBox.Location = new Point(177, 370);
            zipComboBox.Name = "zipComboBox";
            zipComboBox.PlaceholderText = "zip Code";
            zipComboBox.Size = new Size(163, 23);
            zipComboBox.TabIndex = 15;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(10, 402);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.PlaceholderText = "City";
            cityTextBox.Size = new Size(330, 23);
            cityTextBox.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(10, 370);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Apartment No.";
            textBox4.Size = new Size(161, 23);
            textBox4.TabIndex = 13;
            // 
            // aptTextBox
            // 
            aptTextBox.Location = new Point(10, 338);
            aptTextBox.Name = "aptTextBox";
            aptTextBox.PlaceholderText = "Address";
            aptTextBox.Size = new Size(330, 23);
            aptTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(10, 290);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "moatazazzamovic@gmail.com";
            emailTextBox.Size = new Size(330, 23);
            emailTextBox.TabIndex = 11;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(10, 227);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.PlaceholderText = "+2-999 999 99";
            phoneNumberTextBox.Size = new Size(330, 23);
            phoneNumberTextBox.TabIndex = 10;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(10, 163);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(330, 24);
            genderComboBox.TabIndex = 9;
            // 
            // BirthdayPicker
            // 
            BirthdayPicker.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BirthdayPicker.Format = DateTimePickerFormat.Custom;
            BirthdayPicker.Location = new Point(10, 100);
            BirthdayPicker.Name = "BirthdayPicker";
            BirthdayPicker.Size = new Size(330, 23);
            BirthdayPicker.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.ForeColor = Color.Black;
            lastNameTextBox.Location = new Point(177, 37);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Last Name";
            lastNameTextBox.Size = new Size(163, 23);
            lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(10, 37);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "First Name";
            firstNameTextBox.Size = new Size(161, 23);
            firstNameTextBox.TabIndex = 5;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(10, 205);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(106, 16);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(10, 267);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(139, 16);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Your e-mail address";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(10, 144);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(55, 16);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(10, 80);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(62, 16);
            birthdayLabel.TabIndex = 1;
            birthdayLabel.Text = "Birthday";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(10, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(47, 16);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // searchPage
            // 
            searchPage.BackColor = Color.FromArgb(255, 240, 255);
            searchPage.Controls.Add(SearchError);
            searchPage.Controls.Add(searchDataGridView);
            searchPage.Controls.Add(searchButton);
            searchPage.Controls.Add(searchTextBox);
            searchPage.Controls.Add(breakfastPicture);
            searchPage.Location = new Point(4, 28);
            searchPage.Name = "searchPage";
            searchPage.Padding = new Padding(3);
            searchPage.Size = new Size(1109, 506);
            searchPage.TabIndex = 1;
            searchPage.Text = "          Search          ";
            // 
            // SearchError
            // 
            SearchError.AutoSize = true;
            SearchError.Font = new Font("PT Bold Heading", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            SearchError.ForeColor = SystemColors.ActiveCaptionText;
            SearchError.Location = new Point(453, 125);
            SearchError.Name = "SearchError";
            SearchError.Size = new Size(259, 66);
            SearchError.TabIndex = 11;
            SearchError.Text = "Not Found";
            SearchError.Visible = false;
            // 
            // searchDataGridView
            // 
            searchDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new Point(185, 89);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.Size = new Size(748, 365);
            searchDataGridView.TabIndex = 10;
            searchDataGridView.Visible = false;
            // 
            // searchButton
            // 
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchButton.Depth = 0;
            searchButton.HighEmphasis = true;
            searchButton.Icon = null;
            searchButton.Location = new Point(855, 35);
            searchButton.Margin = new Padding(4, 6, 4, 6);
            searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchButton.Name = "searchButton";
            searchButton.NoAccentTextColor = Color.Empty;
            searchButton.Size = new Size(78, 36);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchButton.UseAccentColor = false;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(185, 36);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(739, 35);
            searchTextBox.TabIndex = 8;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // breakfastPicture
            // 
            breakfastPicture.Image = Properties.Resources.hotel_da_vinci1;
            breakfastPicture.Location = new Point(0, 0);
            breakfastPicture.Margin = new Padding(4, 3, 4, 3);
            breakfastPicture.Name = "breakfastPicture";
            breakfastPicture.Size = new Size(1113, 473);
            breakfastPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            breakfastPicture.TabIndex = 7;
            breakfastPicture.TabStop = false;
            // 
            // metroTabPage2
            // 
            metroTabPage2.BackColor = Color.FromArgb(255, 240, 255);
            metroTabPage2.Controls.Add(Refreshbtn);
            metroTabPage2.Controls.Add(resTotalDataGridView);
            metroTabPage2.Location = new Point(4, 28);
            metroTabPage2.Name = "metroTabPage2";
            metroTabPage2.Size = new Size(1109, 506);
            metroTabPage2.TabIndex = 2;
            metroTabPage2.Text = "          Reservation Adv. view          ";
            // 
            // Refreshbtn
            // 
            Refreshbtn.BackColor = Color.LightSteelBlue;
            Refreshbtn.Location = new Point(1, 6);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(1106, 33);
            Refreshbtn.TabIndex = 31;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = false;
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // resTotalDataGridView
            // 
            resTotalDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            resTotalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resTotalDataGridView.Location = new Point(1, 45);
            resTotalDataGridView.Name = "resTotalDataGridView";
            resTotalDataGridView.Size = new Size(1105, 420);
            resTotalDataGridView.TabIndex = 0;
            // 
            // roomPage
            // 
            roomPage.BackColor = Color.FromArgb(255, 240, 255);
            roomPage.Controls.Add(Refreshroombtn);
            roomPage.Controls.Add(reservedLabel);
            roomPage.Controls.Add(label1occupiedLabel);
            roomPage.Controls.Add(listBox2);
            roomPage.Controls.Add(listBox1);
            roomPage.Location = new Point(4, 28);
            roomPage.Name = "roomPage";
            roomPage.Size = new Size(1109, 506);
            roomPage.TabIndex = 4;
            roomPage.Text = "          Rooms          ";
            // 
            // Refreshroombtn
            // 
            Refreshroombtn.BackColor = Color.LightSteelBlue;
            Refreshroombtn.Location = new Point(0, 12);
            Refreshroombtn.Name = "Refreshroombtn";
            Refreshroombtn.Size = new Size(1106, 33);
            Refreshroombtn.TabIndex = 32;
            Refreshroombtn.Text = "Refresh";
            Refreshroombtn.UseVisualStyleBackColor = false;
            Refreshroombtn.Click += Refreshroombtn_Click;
            // 
            // reservedLabel
            // 
            reservedLabel.AutoSize = true;
            reservedLabel.Location = new Point(583, 57);
            reservedLabel.Name = "reservedLabel";
            reservedLabel.Size = new Size(138, 19);
            reservedLabel.TabIndex = 3;
            reservedLabel.Text = "Reserved Rooms";
            // 
            // label1occupiedLabel
            // 
            label1occupiedLabel.AutoSize = true;
            label1occupiedLabel.Location = new Point(12, 57);
            label1occupiedLabel.Name = "label1occupiedLabel";
            label1occupiedLabel.Size = new Size(141, 19);
            label1occupiedLabel.TabIndex = 2;
            label1occupiedLabel.Text = "Occupied Rooms";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 19;
            listBox2.Location = new Point(583, 88);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(509, 365);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(12, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(541, 365);
            listBox1.TabIndex = 0;
            // 
            // Tsubtn
            // 
            Tsubtn.Location = new Point(1005, 12);
            Tsubtn.Name = "Tsubtn";
            Tsubtn.Size = new Size(119, 23);
            Tsubtn.TabIndex = 10;
            Tsubtn.Text = "Technical Support";
            Tsubtn.UseVisualStyleBackColor = true;
            Tsubtn.Click += Tsubtn_Click;
            // 
            // Frontend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1141, 593);
            Controls.Add(Tsubtn);
            Controls.Add(resPanel);
            Controls.Add(FrontendHeader);
            Name = "Frontend";
            Text = "Frontend";
            Load += Frontend_Load;
            resPanel.ResumeLayout(false);
            reservationPage.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            searchPage.ResumeLayout(false);
            searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).EndInit();
            metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).EndInit();
            roomPage.ResumeLayout(false);
            roomPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FrontendHeader;
        private TabControl resPanel;
        private TabPage searchPage;
        private TabPage metroTabPage2;
        private TabPage roomPage;
        private TabPage reservationPage;
        private Panel panel4;
        private Panel panel2;
        public MaterialSkin.Controls.MaterialButton SaveChanges;
        private Button foodMenuButton;
        private Button finalizeButton;
        private MaterialSkin.Controls.MaterialCheckbox foodSupplyCheckBox;
        private MaterialSkin.Controls.MaterialCheckbox smsCheckBox;
        private MaterialSkin.Controls.MaterialCheckbox checkinCheckBox;
        private DateTimePicker dateTimePicker1;
        private Label depertureLabel;
        private ComboBox roomNComboBox;
        private ComboBox floorComboBox;
        private ComboBox roomTypeComboBox;
        private ComboBox qtGuestComboBox;
        private DateTimePicker entryDatePicker;
        private Label entryLabel;
        private Label choiceLabel;
        private Panel panel1;
        private ComboBox stateComboBox;
        private TextBox zipComboBox;
        private TextBox cityTextBox;
        private TextBox textBox4;
        private TextBox aptTextBox;
        private TextBox emailTextBox;
        private TextBox phoneNumberTextBox;
        private ComboBox genderComboBox;
        private DateTimePicker BirthdayPicker;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Label genderLabel;
        private Label birthdayLabel;
        private Label nameLabel;
        private ComboBox reservComboBox;
        private Label reservationlabel;
        private Button updateButton;
        private Button deleteButton;
        private Button editButton;
        private Button newButton;
        private PictureBox breakfastPicture;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private TextBox searchTextBox;
        private DataGridView searchDataGridView;
        private Label SearchError;
        private DataGridView resTotalDataGridView;
        private Label reservedLabel;
        private Label label1occupiedLabel;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button Tsubtn;
        private Button Refreshbtn;
        private Button Refreshroombtn;
        private PictureBox pictureBox1;
    }
}