using ManagementSystem.Context;
using ManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class Kitchen : Form
    {
        ReservationContext ResContext { get; set; } = new();
        public Kitchen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kitchen_Load(object sender, EventArgs e)
        {
            ResContext.reservations.Load();
            var results = ResContext.reservations.Local.ToBindingList();
            listBox1.DataSource = results;
            listBox1.DisplayMember = "first_name";
            this.firstNameTextBox.DataBindings.Add("Text", results, "first_name");
            this.firstNameTextBox.ReadOnly = true;

            this.lastNameTextBox.DataBindings.Add("Text", results, "last_name");
            this.lastNameTextBox.ReadOnly = true;

            this.phoneNumberTextBox.DataBindings.Add("Text", results, "phone_number");
            this.phoneNumberTextBox.ReadOnly = true;

            this.textBox1.DataBindings.Add("Text", results, "room_type");
            this.textBox1.ReadOnly = true;

            this.textBox2.DataBindings.Add("Text", results, "room_number");
            this.textBox2.ReadOnly = true;


            this.textBox3.DataBindings.Add("Text", results, "room_floor");
            this.textBox3.ReadOnly = true;


            this.breakfastQTY.DataBindings.Add("Text", results, "break_fast");
            this.dinnerQTY.DataBindings.Add("Text", results, "dinner");
            this.lunchQTY.DataBindings.Add("Text", results, "lunch");
            this.breakfastQTY.ReadOnly = true;
            this.dinnerQTY.ReadOnly = true;
            this.lunchQTY.ReadOnly = true;
            cleaningCheckBox.Enabled = false;
            towelsCheckBox.Enabled = false;
            surpriseCheckBox.Enabled = false;

            if (listBox1.SelectedItem != null)
            {
                reservation selectedReservation = (reservation)listBox1.SelectedItem;
                if (selectedReservation.cleaning == true)
                    cleaningCheckBox.Checked = true;
                else
                    cleaningCheckBox.Checked = true;

                if (selectedReservation.towel == true)
                    towelsCheckBox.Checked = true;
                else
                    towelsCheckBox.Checked = false;

                if (selectedReservation.s_surprise == true)
                    surpriseCheckBox.Checked = true;
                else
                    surpriseCheckBox.Checked = false;
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                cleaningCheckBox.Checked = true;
                towelsCheckBox.Checked = true;
                surpriseCheckBox.Checked = true;
                reservation selectedReservation = (reservation)listBox1.SelectedItem;
                selectedReservation.cleaning = true;
                selectedReservation.towel = true;
                selectedReservation.s_surprise = true;
            }



        }
        FoodMenu newfoodmenu = new FoodMenu();
        private void foodSelectionButton_Click(object sender, EventArgs e)
        {
            newfoodmenu.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (newfoodmenu != null)
            {
                this.breakfastQTY.Text = newfoodmenu.breakfast.ToString();
                this.dinnerQTY.Text = newfoodmenu.dinner.ToString();
                this.lunchQTY.Text = newfoodmenu.lunch.ToString();
                this.cleaningCheckBox.Checked = newfoodmenu.cleaning;
                this.towelsCheckBox.Checked = newfoodmenu.towel;
                this.surpriseCheckBox.Checked = newfoodmenu.surprise;

            }






            if (listBox1.SelectedItem != null)
            {
                reservation selectedReservation = (reservation)listBox1.SelectedItem;
                selectedReservation.food_bill = newfoodmenu.foodBill;
                selectedReservation.break_fast = int.Parse(this.breakfastQTY.Text);
                selectedReservation.lunch = int.Parse(this.dinnerQTY.Text);
                selectedReservation.dinner = int.Parse(this.lunchQTY.Text);
                selectedReservation.cleaning = this.cleaningCheckBox.Checked;
                selectedReservation.towel = this.towelsCheckBox.Checked;
                selectedReservation.s_surprise = this.surpriseCheckBox.Checked;
            }
            string R = $"numer = {ResContext.SaveChanges()}";
            listBox1.DataSource = null;
            ResContext.reservations.Load();
            listBox1.DataSource = ResContext.reservations.Local.ToBindingList();
            listBox1.DisplayMember = "first_name";



        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            ResContext.reservations.Load();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ResContext.reservations.Local.ToBindingList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
        }
    }
}
