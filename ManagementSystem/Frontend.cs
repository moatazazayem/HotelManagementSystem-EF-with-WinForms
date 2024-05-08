using ManagementSystem.Context;
using ManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;

namespace ManagementSystem
{
    public partial class Frontend : Form
    {
        ReservationContext ResContext;
        List<reservation> MyReservations;
        public Frontend()
        {
            InitializeComponent();
            CenterToParent();
            //SoundPlayer sp = new SoundPlayer("D:\\Intro.wav");
            //sp.Play();
            ResContext = new();
            this.Text = "General";

        }

        public int price = 0;
        public bool checkin = false;
        private double finalizedTotalAmount = 0.0;
        public bool foodSupply { get; set; } = false;
        FinalizePayment finalizebil = new FinalizePayment();
        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if (food_menu.breakfast == 0 && food_menu.lunch == 0 && food_menu.dinner == 0 && food_menu.cleaning == false && food_menu.towel == false && food_menu.surprise == false)
            {
                foodSupplyCheckBox.Checked = true;
                foodSupply = true;
            }
            if (roomTypeComboBox.SelectedItem.ToString() == "master")
            {
                price = 149;
                floorComboBox.SelectedItem = "1";
            }
            else if (roomTypeComboBox.SelectedItem.ToString() == "not master")
            {
                price = 299;
                floorComboBox.SelectedItem = "2";
            }
            else if (roomTypeComboBox.SelectedItem.ToString() == "moataz")
            {
                price = 349;
                floorComboBox.SelectedItem = "3";
            }
            else if (roomTypeComboBox.SelectedItem.ToString() == "not moataz")
            {
                price = 399;
                floorComboBox.SelectedItem = "4";
            }
            if (checkinCheckBox.Checked == true)
            {
                checkin = true;
            }
            int tax = 10;
            float totalAmountcalc = (float)(price + food_menu.foodBill + tax);
            finalizebil.Owner = this;
            finalizebil.GetTotalAmount(price, food_menu.foodBill, tax, totalAmountcalc);
            finalizebil.Show();
            totalBill = totalAmountcalc;
        }
        float totalBill;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            reservation newReservation = new();
            newReservation.first_name = firstNameTextBox.Text;
            newReservation.last_name = lastNameTextBox.Text;
            newReservation.birth_day = BirthdayPicker.Value.ToString("yyyy-MM-dd"); 
            newReservation.gender = genderComboBox.SelectedItem.ToString();
            newReservation.phone_number = phoneNumberTextBox.Text;
            newReservation.email_address = emailTextBox.Text;
            newReservation.number_guest = int.Parse(qtGuestComboBox.SelectedItem.ToString());
            newReservation.street_address = aptTextBox.Text;
            newReservation.apt_suite = textBox4.Text;
            newReservation.city = cityTextBox.Text;
            newReservation.state = stateComboBox.SelectedItem.ToString();
            newReservation.zip_code = zipComboBox.Text;
            newReservation.room_type = roomTypeComboBox.SelectedItem.ToString();
            newReservation.room_floor = floorComboBox.SelectedItem.ToString();
            newReservation.room_number = roomNComboBox.SelectedItem.ToString();
            newReservation.total_bill = totalBill;
            newReservation.payment_type = finalizebil.paymentType; 
            newReservation.card_type = finalizebil.CardType; 
            newReservation.card_number = finalizebil.paymentCardNumber; 
            newReservation.card_exp = finalizebil.MM_YY_Of_Card;
            newReservation.card_cvc = finalizebil.CVC_Of_Card;
            newReservation.arrival_time = entryDatePicker.Value;
            newReservation.leaving_time = dateTimePicker1.Value;
            newReservation.check_in = checkinCheckBox.Checked;
            newReservation.break_fast = food_menu.breakfast; 
            newReservation.lunch = food_menu.lunch; 
            newReservation.dinner = food_menu.dinner; 
            newReservation.cleaning = food_menu.cleaning; 
            newReservation.towel = food_menu.towel; 
            newReservation.s_surprise = food_menu.surprise; 
            newReservation.supply_status = foodSupplyCheckBox.Checked;
            newReservation.food_bill = food_menu.foodBill;

            ResContext.Add(newReservation);
            ResContext.SaveChanges();
            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //SoundPlayer addedbtn = new("D:\\brav.wav");
            //addedbtn.Play();
            this.SaveChanges.Enabled = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            firstNameTextBox.Text = default;
            lastNameTextBox.Text = default;
            BirthdayPicker.Value = DateTime.Today;
            genderComboBox.Text = default;
            phoneNumberTextBox.Text = default;
            emailTextBox.Text = default;
            qtGuestComboBox.Text = default;
            aptTextBox.Text = default;
            cityTextBox.Text = default;
            stateComboBox.Text = default;
            zipComboBox.Text = default;
            roomTypeComboBox.Text = default;
            floorComboBox.Text = default;
            roomNComboBox.Text = default;
            entryDatePicker.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today.AddDays(1);
            checkinCheckBox.Checked = false;
            foodSupplyCheckBox.Checked = false;
            smsCheckBox.Checked = false;
        }

        private void Frontend_Load(object sender, EventArgs e)
        {
            genderComboBoxLoad();
            stateComboBoxLoad();
            gstsComboBoxLoad();
            roomComboBoxLoad();
            floorComboBoxLoad();
            roomnumComboBoxLoad();
            entryDatePicker.MinDate = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today.AddDays(1);
            panel1.Enabled = false;
            panel2.Enabled = false;

        }
        private void genderComboBoxLoad()
        {
            var genderCombo = new List<string>();
            genderCombo.Add("Male");
            genderCombo.Add("Female");
            genderComboBox.DataSource = genderCombo;
        }
        private void stateComboBoxLoad()
        {
            var stateCombo = new List<string>();
            stateCombo.Add("Cairo");
            stateCombo.Add("Minia");
            stateCombo.AddRange([
                "Alabama ",
                "Alaska ",
                "Arizona ",
                "Arkansas ",
                "California ",
                "Colorado ",
                "Connecticut ",
                "Delaware ",
                "Florida ",
                "Georgia ",
                "Hawaii ",
                "Idaho ",
                "Illinois Indiana ",
                "Iowa ",
                "Kansas ",
                "Kentucky ",
                "Louisiana ",
                "Maine ",
                "Maryland ",
                "Massachusetts ",
                "Michigan ",
                "Minnesota ",
                "Mississippi ",
                "Missouri ",
                "Montana Nebraska ",
                "Nevada ",
                "New Hampshire ",
                "New Jersey ",
                "New Mexico ",
                "New York ",
                "North Carolina ",
                "North Dakota ",
                "Ohio ",
                "Oklahoma ",
                "Oregon ",
                "Pennsylvania Rhode Island ",
                "South Carolina ",
                "South Dakota ",
                "Tennessee ",
                "Texas ",
                "Utah ",
                "Vermont ",
                "Virginia ",
                "Washington ",
                "West Virginia ",
                "Wisconsin ",
                "Wyoming"
            ]);
            stateComboBox.DataSource = stateCombo;
        }
        private void gstsComboBoxLoad()
        {
            var gstsCombo = new List<string>();
            gstsCombo.AddRange(["1", "2", "3", "4", "5"]);
            qtGuestComboBox.DataSource = gstsCombo;
        }
        private void roomComboBoxLoad()
        {
            var roomCombo = new List<string>();
            roomCombo.AddRange(["Single    ",
                "Double    ",
                "Twin      ",
                "Duplex    ",
                "Suite     "]);
            roomTypeComboBox.DataSource = roomCombo;
        }
        private void floorComboBoxLoad()
        {
            var floorCombo = new List<string>();
            floorCombo.AddRange(["1         ", "2         ", "3         ", "4         ", "5         "]);
            floorComboBox.DataSource = floorCombo;
        }
        private void roomnumComboBoxLoad()
        {
            var roomnumCombo = new List<string>();
            roomnumCombo.AddRange(["101        ",
                "102       ",
                "103       ",
                "104       ",
                "105       ",
                "106       ",
                "107       ",
                "108       ",
                "109       ",
                "110       ",
                "201       ",
                "202       ",
                "203       ",
                "204       ",
                "205       ",
                "206       ",
                "207       ",
                "208       ",
                "209       ",
                "210       ",
                "301       ",
                "302       ",
                "303       ",
                "304       ",
                "305       ",
                "306       ",
                "307       ",
                "308       ",
                "309       ",
                "310       ",
                "401       ",
                "402       ",
                "403       ",
                "404       ",
                "405       ",
                "406       ",
                "407       ",
                "408       ",
                "409       ",
                "410       ",
                "501       ",
                "502       ",
                "503       ",
                "504       ",
                "505       ",
                "506       ",
                "507       ",
                "508       ",
                "509       ",
                "510       "]);
            roomNComboBox.DataSource = roomnumCombo;
        }
       
        FoodMenu food_menu = new FoodMenu();
        private void foodMenuButton_Click(object sender, EventArgs e)
        {
            food_menu.Show();
        }


        private void newButton_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = true;

            reservation newReservation = new();
            firstNameTextBox.Text = default;
            lastNameTextBox.Text = default;
            BirthdayPicker.Value = DateTime.Today;
            genderComboBox.Text = default;
            phoneNumberTextBox.Text = default;
            emailTextBox.Text = default;
            qtGuestComboBox.Text = default;
            aptTextBox.Text = default;
            cityTextBox.Text = default;
            stateComboBox.Text = default;
            zipComboBox.Text = default;
            roomTypeComboBox.Text = default;
            floorComboBox.Text = default;
            roomNComboBox.Text = default;
            entryDatePicker.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today.AddDays(1);
            checkinCheckBox.Checked = false;
            foodSupplyCheckBox.Checked = false;
            smsCheckBox.Checked = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            editButton.Enabled = false;
            reservationlabel.Visible = true;
            reservComboBox.Visible = true;
            deleteButton.Visible = true;
            updateButton.Visible = true;
            ResContext.reservations.Load();
            MyReservations = ResContext.reservations.Local.ToList();
            reservComboBox.DataSource = MyReservations;
            reservComboBox.DisplayMember = "first_name";

            this.firstNameTextBox.DataBindings.Add("Text", MyReservations, "first_name");
            this.lastNameTextBox.DataBindings.Add("Text", MyReservations, "last_name");
            BirthdayPicker.DataBindings.Add("Text", MyReservations, "birth_day");
            genderComboBox.DataBindings.Add("SelectedItem", MyReservations, "gender");
            this.phoneNumberTextBox.DataBindings.Add("Text", MyReservations, "phone_number");
            this.emailTextBox.DataBindings.Add("Text", MyReservations, "email_address");
            this.qtGuestComboBox.DataBindings.Add("Text", MyReservations, "number_guest");

            this.aptTextBox.DataBindings.Add("Text", MyReservations, "street_address");
            this.textBox4.DataBindings.Add("Text", MyReservations, "apt_suite");
            this.zipComboBox.DataBindings.Add("Text", MyReservations, "zip_code");
            this.cityTextBox.DataBindings.Add("Text", MyReservations, "city");

            this.stateComboBox.DataBindings.Add("Text", MyReservations, "state", true);
            this.roomTypeComboBox.DataBindings.Add("SelectedItem", MyReservations, "room_type", true);
            this.floorComboBox.DataBindings.Add("SelectedItem", MyReservations, "room_floor", true);
            this.roomNComboBox.DataBindings.Add("SelectedItem", MyReservations, "room_number", true);
            entryDatePicker.DataBindings.Add("Value", MyReservations, "arrival_time", true);
            dateTimePicker1.DataBindings.Add("Value", MyReservations, "leaving_time", true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (reservComboBox.SelectedItem != null)
            {
                var selectedReservation = reservComboBox.SelectedItem as reservation;
                if (selectedReservation != null)
                {
                    ResContext.reservations.Remove(selectedReservation);
                    ResContext.SaveChanges();

                    MyReservations.Remove(selectedReservation);

                    reservComboBox.DataSource = null;
                    reservComboBox.DataSource = MyReservations;
                    reservComboBox.DisplayMember = "first_name";

                    if (MyReservations.Count > 0)
                    {
                        reservComboBox.SelectedIndex = 0;
                    }
                }
                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (reservComboBox.SelectedItem != null)
            {
                ResContext.SaveChanges();
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reservComboBox.DataSource = null;
                reservComboBox.DataSource = MyReservations;
                reservComboBox.DisplayMember = "first_name";
            }
        }
        private void Tsubtn_Click(object sender, EventArgs e)
        {
            SoundPlayer tssound = new("D:\\CHINESE TOY PHONE ALL SOUNDS LINE RECORD.wav");
            tssound.Play();
            System.ComponentModel.CancelEventArgs ts = new();
            MessageBox.Show("Hello, This is Moataz Azzam! \n\nIf you have any problem, Please call technical support for us!. We're in this together! :)", "Technical Support.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ts.Cancel = true;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            //ResContext = new();
            string s = searchTextBox.Text;
            ResContext.reservations.Load();
            var results = ResContext.reservations.Where(r =>
                r.Id.ToString().Contains(s) ||
                r.first_name.Contains(s) ||
                r.last_name.Contains(s) ||
                r.birth_day.Contains(s) ||
                r.gender.Contains(s) ||
                r.phone_number.Contains(s) ||
                r.email_address.Contains(s) ||
                r.street_address.Contains(s) ||
                r.apt_suite.Contains(s) ||
                r.city.Contains(s) ||
                r.state.Contains(s) ||
                r.zip_code.Contains(s) ||
                r.room_type.Contains(s) ||
                r.room_floor.Contains(s) ||
                r.room_number.Contains(s) ||
                r.payment_type.Contains(s) ||
                r.card_type.Contains(s) ||
                r.card_number.Contains(s) ||
                r.card_exp.Contains(s) ||
                r.card_cvc.Contains(s)
            ).ToList();
            if (results.Count() > 0)
            {
                searchDataGridView.Visible = true;
                searchDataGridView.DataSource = results;
            }
            else
            {
                SearchError.Visible = true;
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchDataGridView.Visible = false;
            SearchError.Visible = false;

        }

        private void resTotalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            ResContext.reservations.Load();
            resTotalDataGridView.DataSource = null;
            resTotalDataGridView.DataSource = ResContext.reservations.Local.ToBindingList();
            var OccupiedRooms = ResContext.reservations.Local.Where(r => r.check_in == true).Distinct();
        }

        private void Refreshroombtn_Click(object sender, EventArgs e)
        {
            ResContext.reservations.Load();
            var OccupiedRooms = ResContext.reservations.Local.Where(r => r.check_in == true).Select(r => r.room_number).Distinct();
            listBox1.DataSource = OccupiedRooms.ToList();
            listBox1.DisplayMember = "room_number";
            var ReservedRooms = ResContext.reservations.Local.Where(r => r.check_in == false).Select(r => r.room_number).Distinct();
            listBox2.DataSource = ReservedRooms.ToList();
            listBox2.DisplayMember = "room_number";
        }

    }
}
