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
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();
            CenterToScreen();
            test.Text = breakfastQTY.Text;
        }
        public int foodBill { get; set; } = 0;
        public int breakfast { get; set; } = 0;
        public int lunch { get; set; } = 0;
        public int dinner { get; set; } = 0;
        public bool cleaning { get; set; } = false;
        public bool towel { get; set; } = false;
        public bool surprise { get; set; } = false;

        private void updatecheckbox()
        {
            if (int.TryParse(breakfastQTY.Text, out int breakfastQTYValue))
            {
                if (breakfastQTYValue > 0)
                {
                    this.breakfastCheckBox.Checked = true;
                    breakfast = breakfastQTYValue;
                }
                else
                    this.breakfastCheckBox.Checked = false;
            }
            if (int.TryParse(lunchQTY.Text, out int lunchQTYValue))
            {
                if (lunchQTYValue > 0)
                {
                    this.lunchCheckBox.Checked = true;
                    lunch = lunchQTYValue;

                }
                else
                    this.lunchCheckBox.Checked = false;
            }
            if (int.TryParse(dinnerQTY.Text, out int dinnerValue))
            {
                if (dinnerValue > 0)
                {
                    this.dinnerCheckBox.Checked = true;
                    dinner = dinnerValue;
                }
                else
                    this.dinnerCheckBox.Checked = false;
            }

        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            foodBill = (7 * breakfast) + (15 * lunch) + (15 * dinner);
            if (cleaningCheckBox.Checked == true)
                cleaning = true;
            if (towelsCheckBox.Checked == true)
                towel = true;
            if (surpriseCheckBox.Checked == true)
                surprise = true;
            this.Hide();
        }

        private void breakfastQTY_Leave(object sender, EventArgs e)
        {
            updatecheckbox();
        }

        private void lunchQTY_Leave(object sender, EventArgs e)
        {
            updatecheckbox();
        }

        private void dinnerQTY_TextChanged(object sender, EventArgs e)
        {

        }

        private void dinnerQTY_Leave(object sender, EventArgs e)
        {
            updatecheckbox();
        }
    }
}
