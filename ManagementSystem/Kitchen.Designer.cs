namespace ManagementSystem
{
    partial class Kitchen
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
        private Label FrontendHeader;
        private TabControl resPanel;
        private TabPage Overview;
        private TabPage ToDo;
        private Panel panel1;
        private TextBox phoneNumberTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label phoneNumberLabel;
        private Label nameLabel;
        private PictureBox breakfastPicture;
        private Button Tsubtn;
        private void InitializeComponent()
        {
            FrontendHeader = new Label();
            resPanel = new TabControl();
            ToDo = new TabPage();
            listBox1 = new ListBox();
            label8 = new Label();
            updateButton = new MaterialSkin.Controls.MaterialButton();
            label7 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            foodSelectionButton = new MaterialSkin.Controls.MaterialButton();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            breakfastQtyLabel = new Label();
            dinnerQTY = new TextBox();
            lunchQTY = new TextBox();
            breakfastQTY = new TextBox();
            surpriseCheckBox = new CheckBox();
            towelsCheckBox = new CheckBox();
            cleaningCheckBox = new CheckBox();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            phoneNumberTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            phoneNumberLabel = new Label();
            nameLabel = new Label();
            Overview = new TabPage();
            Refreshbtn = new Button();
            dataGridView1 = new DataGridView();
            breakfastPicture = new PictureBox();
            Tsubtn = new Button();
            resPanel.SuspendLayout();
            ToDo.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            Overview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).BeginInit();
            SuspendLayout();
            // 
            // FrontendHeader
            // 
            FrontendHeader.AutoSize = true;
            FrontendHeader.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FrontendHeader.ForeColor = Color.Crimson;
            FrontendHeader.Location = new Point(11, 6);
            FrontendHeader.Name = "FrontendHeader";
            FrontendHeader.Size = new Size(676, 25);
            FrontendHeader.TabIndex = 8;
            FrontendHeader.Text = "Welcome to the best Hotel Management System in the world!";
            // 
            // resPanel
            // 
            resPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resPanel.Controls.Add(ToDo);
            resPanel.Controls.Add(Overview);
            resPanel.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resPanel.Location = new Point(11, 46);
            resPanel.Name = "resPanel";
            resPanel.SelectedIndex = 0;
            resPanel.Size = new Size(1117, 497);
            resPanel.TabIndex = 9;
            // 
            // ToDo
            // 
            ToDo.BackColor = Color.White;
            ToDo.Controls.Add(listBox1);
            ToDo.Controls.Add(label8);
            ToDo.Controls.Add(updateButton);
            ToDo.Controls.Add(label7);
            ToDo.Controls.Add(label6);
            ToDo.Controls.Add(panel3);
            ToDo.Controls.Add(panel1);
            ToDo.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToDo.ForeColor = Color.Black;
            ToDo.Location = new Point(4, 28);
            ToDo.Name = "ToDo";
            ToDo.Padding = new Padding(3);
            ToDo.Size = new Size(1109, 465);
            ToDo.TabIndex = 0;
            ToDo.Text = "          To-Do          ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(359, 356);
            listBox1.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 18);
            label8.Name = "label8";
            label8.Size = new Size(79, 16);
            label8.TabIndex = 62;
            label8.Text = "On the line";
            // 
            // updateButton
            // 
            updateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateButton.Depth = 0;
            updateButton.HighEmphasis = true;
            updateButton.Icon = null;
            updateButton.Location = new Point(111, 408);
            updateButton.Margin = new Padding(4, 6, 4, 6);
            updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            updateButton.Name = "updateButton";
            updateButton.NoAccentTextColor = Color.Empty;
            updateButton.Size = new Size(146, 36);
            updateButton.TabIndex = 61;
            updateButton.Text = "Submit Changes";
            updateButton.TextAlign = ContentAlignment.MiddleLeft;
            updateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateButton.UseAccentColor = false;
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(741, 18);
            label7.Name = "label7";
            label7.Size = new Size(46, 16);
            label7.TabIndex = 58;
            label7.Text = "To-Do";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(377, 18);
            label6.Name = "label6";
            label6.Size = new Size(95, 16);
            label6.TabIndex = 57;
            label6.Text = "Guest Details";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(foodSelectionButton);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(breakfastQtyLabel);
            panel3.Controls.Add(dinnerQTY);
            panel3.Controls.Add(lunchQTY);
            panel3.Controls.Add(breakfastQTY);
            panel3.Controls.Add(surpriseCheckBox);
            panel3.Controls.Add(towelsCheckBox);
            panel3.Controls.Add(cleaningCheckBox);
            panel3.Location = new Point(741, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 396);
            panel3.TabIndex = 38;
            // 
            // foodSelectionButton
            // 
            foodSelectionButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            foodSelectionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            foodSelectionButton.Depth = 0;
            foodSelectionButton.HighEmphasis = true;
            foodSelectionButton.Icon = null;
            foodSelectionButton.Location = new Point(76, 240);
            foodSelectionButton.Margin = new Padding(4, 6, 4, 6);
            foodSelectionButton.MouseState = MaterialSkin.MouseState.HOVER;
            foodSelectionButton.Name = "foodSelectionButton";
            foodSelectionButton.NoAccentTextColor = Color.Empty;
            foodSelectionButton.Size = new Size(203, 36);
            foodSelectionButton.TabIndex = 55;
            foodSelectionButton.Text = "Change food selection";
            foodSelectionButton.TextAlign = ContentAlignment.MiddleLeft;
            foodSelectionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            foodSelectionButton.UseAccentColor = false;
            foodSelectionButton.UseVisualStyleBackColor = true;
            foodSelectionButton.Click += foodSelectionButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(99, 155);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(157, 20);
            checkBox1.TabIndex = 54;
            checkBox1.Text = "Food/Supply Status";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 59);
            label5.Name = "label5";
            label5.Size = new Size(91, 16);
            label5.TabIndex = 53;
            label5.Text = "Dinner [QTY]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 12);
            label4.Name = "label4";
            label4.Size = new Size(91, 16);
            label4.TabIndex = 52;
            label4.Text = "Dinner [QTY]";
            // 
            // breakfastQtyLabel
            // 
            breakfastQtyLabel.AutoSize = true;
            breakfastQtyLabel.Location = new Point(10, 9);
            breakfastQtyLabel.Name = "breakfastQtyLabel";
            breakfastQtyLabel.Size = new Size(111, 16);
            breakfastQtyLabel.TabIndex = 51;
            breakfastQtyLabel.Text = "Breakfast [QTY]";
            // 
            // dinnerQTY
            // 
            dinnerQTY.Location = new Point(10, 80);
            dinnerQTY.Name = "dinnerQTY";
            dinnerQTY.PlaceholderText = "3ayez kam?";
            dinnerQTY.Size = new Size(330, 23);
            dinnerQTY.TabIndex = 47;
            // 
            // lunchQTY
            // 
            lunchQTY.Location = new Point(179, 31);
            lunchQTY.Name = "lunchQTY";
            lunchQTY.PlaceholderText = "3ayez kam?";
            lunchQTY.Size = new Size(161, 23);
            lunchQTY.TabIndex = 46;
            // 
            // breakfastQTY
            // 
            breakfastQTY.Location = new Point(10, 31);
            breakfastQTY.Name = "breakfastQTY";
            breakfastQTY.PlaceholderText = "3ayez kam?";
            breakfastQTY.Size = new Size(161, 23);
            breakfastQTY.TabIndex = 45;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.AutoSize = true;
            surpriseCheckBox.BackColor = Color.Transparent;
            surpriseCheckBox.Location = new Point(211, 109);
            surpriseCheckBox.Margin = new Padding(4, 3, 4, 3);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new Size(144, 20);
            surpriseCheckBox.TabIndex = 50;
            surpriseCheckBox.Text = "Sweetest surprise";
            surpriseCheckBox.UseVisualStyleBackColor = false;
            // 
            // towelsCheckBox
            // 
            towelsCheckBox.AutoSize = true;
            towelsCheckBox.BackColor = Color.Transparent;
            towelsCheckBox.Location = new Point(123, 109);
            towelsCheckBox.Margin = new Padding(4, 3, 4, 3);
            towelsCheckBox.Name = "towelsCheckBox";
            towelsCheckBox.Size = new Size(72, 20);
            towelsCheckBox.TabIndex = 49;
            towelsCheckBox.Text = "Towels";
            towelsCheckBox.UseVisualStyleBackColor = false;
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.AutoSize = true;
            cleaningCheckBox.BackColor = Color.Transparent;
            cleaningCheckBox.Location = new Point(13, 109);
            cleaningCheckBox.Margin = new Padding(4, 3, 4, 3);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new Size(85, 20);
            cleaningCheckBox.TabIndex = 48;
            cleaningCheckBox.Text = "Cleaning";
            cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(phoneNumberTextBox);
            panel1.Controls.Add(lastNameTextBox);
            panel1.Controls.Add(firstNameTextBox);
            panel1.Controls.Add(phoneNumberLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Location = new Point(377, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 396);
            panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 151);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "+2-999 999 99";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 40;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 151);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "+2-999 999 99";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 95);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "+2-999 999 99";
            textBox1.Size = new Size(330, 23);
            textBox1.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(40, 16);
            label3.TabIndex = 37;
            label3.Text = "Floor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 132);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 36;
            label2.Text = "Room Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(80, 16);
            label1.TabIndex = 35;
            label1.Text = "Room Type";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(10, 203);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.PlaceholderText = "+2-999 999 99";
            phoneNumberTextBox.Size = new Size(330, 23);
            phoneNumberTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.ForeColor = Color.Black;
            lastNameTextBox.Location = new Point(177, 31);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Last Name";
            lastNameTextBox.Size = new Size(163, 23);
            lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(10, 31);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "First Name";
            firstNameTextBox.Size = new Size(161, 23);
            firstNameTextBox.TabIndex = 5;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(10, 183);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(106, 16);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(10, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(47, 16);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // Overview
            // 
            Overview.BackColor = Color.FromArgb(255, 240, 255);
            Overview.Controls.Add(Refreshbtn);
            Overview.Controls.Add(dataGridView1);
            Overview.Controls.Add(breakfastPicture);
            Overview.Location = new Point(4, 28);
            Overview.Name = "Overview";
            Overview.Padding = new Padding(3);
            Overview.Size = new Size(1109, 465);
            Overview.TabIndex = 1;
            Overview.Text = "         OverView          ";
            // 
            // Refreshbtn
            // 
            Refreshbtn.BackColor = Color.LightSteelBlue;
            Refreshbtn.Location = new Point(-3, 8);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(1106, 33);
            Refreshbtn.TabIndex = 32;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = false;
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1109, 418);
            dataGridView1.TabIndex = 10;
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
            // Tsubtn
            // 
            Tsubtn.Location = new Point(1005, 12);
            Tsubtn.Name = "Tsubtn";
            Tsubtn.Size = new Size(119, 23);
            Tsubtn.TabIndex = 10;
            Tsubtn.Text = "Technical Support";
            Tsubtn.UseVisualStyleBackColor = true;
            // 
            // Kitchen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1141, 552);
            Controls.Add(Tsubtn);
            Controls.Add(resPanel);
            Controls.Add(FrontendHeader);
            Name = "Kitchen";
            Text = "Frontend";
            Load += Kitchen_Load;
            resPanel.ResumeLayout(false);
            ToDo.ResumeLayout(false);
            ToDo.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Overview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        public TextBox breakfastQTY;
        public CheckBox surpriseCheckBox;
        public CheckBox towelsCheckBox;
        public CheckBox cleaningCheckBox;
        public MaterialSkin.Controls.MaterialButton foodSelectionButton;
        public CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private Label breakfastQtyLabel;
        public TextBox dinnerQTY;
        public TextBox lunchQTY;
        private Label label7;
        private Label label6;
        private Label label8;
        public MaterialSkin.Controls.MaterialButton updateButton;
        private ListBox listBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button Refreshbtn;
    }
}