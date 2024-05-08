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

namespace ManagementSystem
{
    public partial class FinalizePayment : Form
    {
        public  int finalprice;
        public  int finalfoodbill;
        public  string paymentType;
        public  string paymentCardNumber;
        public  string MM_YY_Of_Card;
        public  string CVC_Of_Card;
        public  string CardType;
        public bool confirmed = false;
        public  int tax;

        public FinalizePayment()
        {
            InitializeComponent();
            CenterToScreen();
            List<string> paymentMethods = new List<string> { "Cash", "Credit Card", "Debit Card" };
            foreach (string method in paymentMethods)
            {
                paymentComboBox.Items.Add(method);
            }
            List<string> Months = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            foreach (string month in Months)
            {
                monthComboBox.Items.Add(month);
            }
            List<string> Years = new List<string>();
            for (int year = 2024; year <= 2030; year++)
            {
                Years.Add(year.ToString());
            }

            foreach (string year in Years)
            {
                yearComboBox.Items.Add(year);
            }


        }
        float totalbill;
        public void GetTotalAmount(int _finalprice, int _finalfoodbill, int _tax,float _total)
        {
            this.finalprice = _finalprice;
            this.finalfoodbill = _finalfoodbill;
            tax = _tax;
            totalbill = _total;
        }
        private void FinalizePayment_Load(object sender, EventArgs e)
        {
            currentBillAmount.Text = "200";
            foodBillAmount.Text = finalfoodbill.ToString();
            taxAmount.Text = tax.ToString();
            totalAmount.Text = totalbill.ToString();
            paymentCardNumber = this.phoneNComboBox.Text;
            paymentType = paymentComboBox.SelectedText;
            MM_YY_Of_Card = $"{monthComboBox.SelectedText} - {yearComboBox.SelectedText}";
            CVC_Of_Card = cvcComboBox.Text;
            if (CVC_Of_Card == "111")
            {
                CardType = "Visa";
            }
            else
                CardType = "ma3rafsh";

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            confirmed = true;
            if (this.Owner is Frontend frontendForm)
            {
                frontendForm.SaveChanges.Enabled = true;
            }
            this.Hide();
        }
    }
}
