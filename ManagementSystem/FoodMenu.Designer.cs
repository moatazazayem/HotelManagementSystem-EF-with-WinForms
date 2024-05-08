namespace ManagementSystem
{
    partial class FoodMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            needPanel = new Panel();
            surpriseCheckBox = new CheckBox();
            towelsCheckBox = new CheckBox();
            cleaningCheckBox = new CheckBox();
            metroLabel2 = new Label();
            nextButton = new Button();
            FrontendHeader = new Label();
            metroLabel1 = new Label();
            breakfastCheckBox = new CheckBox();
            lunchCheckBox = new CheckBox();
            dinnerCheckBox = new CheckBox();
            breakfastPicture = new PictureBox();
            lunchPicture = new PictureBox();
            dinnerPicture = new PictureBox();
            foodPanel = new Panel();
            dinnerQTY = new TextBox();
            lunchQTY = new TextBox();
            breakfastQTY = new TextBox();
            test = new Label();
            needPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).BeginInit();
            foodPanel.SuspendLayout();
            SuspendLayout();
            // 
            // needPanel
            // 
            needPanel.BackColor = Color.Transparent;
            needPanel.Controls.Add(surpriseCheckBox);
            needPanel.Controls.Add(towelsCheckBox);
            needPanel.Controls.Add(cleaningCheckBox);
            needPanel.Controls.Add(metroLabel2);
            needPanel.Location = new Point(18, 227);
            needPanel.Margin = new Padding(4, 3, 4, 3);
            needPanel.Name = "needPanel";
            needPanel.Size = new Size(552, 108);
            needPanel.TabIndex = 6;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.AutoSize = true;
            surpriseCheckBox.BackColor = Color.Transparent;
            surpriseCheckBox.Location = new Point(351, 12);
            surpriseCheckBox.Margin = new Padding(4, 3, 4, 3);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new Size(116, 19);
            surpriseCheckBox.TabIndex = 44;
            surpriseCheckBox.Text = "Sweetest surprise";
            surpriseCheckBox.UseVisualStyleBackColor = false;
            // 
            // towelsCheckBox
            // 
            towelsCheckBox.AutoSize = true;
            towelsCheckBox.BackColor = Color.Transparent;
            towelsCheckBox.Location = new Point(263, 12);
            towelsCheckBox.Margin = new Padding(4, 3, 4, 3);
            towelsCheckBox.Name = "towelsCheckBox";
            towelsCheckBox.Size = new Size(61, 19);
            towelsCheckBox.TabIndex = 42;
            towelsCheckBox.Text = "Towels";
            towelsCheckBox.UseVisualStyleBackColor = false;
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.AutoSize = true;
            cleaningCheckBox.BackColor = Color.Transparent;
            cleaningCheckBox.Location = new Point(153, 12);
            cleaningCheckBox.Margin = new Padding(4, 3, 4, 3);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new Size(73, 19);
            cleaningCheckBox.TabIndex = 41;
            cleaningCheckBox.Text = "Cleaning";
            cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // metroLabel2
            // 
            metroLabel2.BackColor = Color.Transparent;
            metroLabel2.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            metroLabel2.Location = new Point(0, 9);
            metroLabel2.Margin = new Padding(4, 0, 4, 0);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(141, 32);
            metroLabel2.TabIndex = 41;
            metroLabel2.Text = "Special needs:";
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.LightGreen;
            nextButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextButton.Location = new Point(199, 296);
            nextButton.Margin = new Padding(4, 3, 4, 3);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(191, 39);
            nextButton.TabIndex = 45;
            nextButton.Text = "Confirm";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // FrontendHeader
            // 
            FrontendHeader.AutoSize = true;
            FrontendHeader.Font = new Font("Oswald", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FrontendHeader.Location = new Point(16, 9);
            FrontendHeader.Name = "FrontendHeader";
            FrontendHeader.Size = new Size(137, 31);
            FrontendHeader.TabIndex = 46;
            FrontendHeader.Text = "Food And Menu";
            // 
            // metroLabel1
            // 
            metroLabel1.BackColor = Color.Transparent;
            metroLabel1.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            metroLabel1.Location = new Point(18, 11);
            metroLabel1.Margin = new Padding(4, 0, 4, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(202, 32);
            metroLabel1.TabIndex = 2;
            metroLabel1.Text = "Food Selection:";
            // 
            // breakfastCheckBox
            // 
            breakfastCheckBox.AutoSize = true;
            breakfastCheckBox.BackColor = Color.Transparent;
            breakfastCheckBox.Location = new Point(18, 161);
            breakfastCheckBox.Margin = new Padding(4, 3, 4, 3);
            breakfastCheckBox.Name = "breakfastCheckBox";
            breakfastCheckBox.Size = new Size(105, 19);
            breakfastCheckBox.TabIndex = 3;
            breakfastCheckBox.Text = "Break Fast  ($7)";
            breakfastCheckBox.UseVisualStyleBackColor = false;
            // 
            // lunchCheckBox
            // 
            lunchCheckBox.AutoSize = true;
            lunchCheckBox.BackColor = Color.Transparent;
            lunchCheckBox.Location = new Point(213, 160);
            lunchCheckBox.Margin = new Padding(4, 3, 4, 3);
            lunchCheckBox.Name = "lunchCheckBox";
            lunchCheckBox.Size = new Size(94, 19);
            lunchCheckBox.TabIndex = 4;
            lunchCheckBox.Text = "Lunch   ($15)";
            lunchCheckBox.UseVisualStyleBackColor = false;
            // 
            // dinnerCheckBox
            // 
            dinnerCheckBox.AutoSize = true;
            dinnerCheckBox.BackColor = Color.Transparent;
            dinnerCheckBox.Location = new Point(408, 160);
            dinnerCheckBox.Margin = new Padding(4, 3, 4, 3);
            dinnerCheckBox.Name = "dinnerCheckBox";
            dinnerCheckBox.Size = new Size(96, 19);
            dinnerCheckBox.TabIndex = 5;
            dinnerCheckBox.Text = "Dinner   ($15)";
            dinnerCheckBox.UseVisualStyleBackColor = false;
            // 
            // breakfastPicture
            // 
            breakfastPicture.Image = Properties.Resources.tiny_breakfast_feature;
            breakfastPicture.Location = new Point(18, 44);
            breakfastPicture.Margin = new Padding(4, 3, 4, 3);
            breakfastPicture.Name = "breakfastPicture";
            breakfastPicture.Size = new Size(161, 106);
            breakfastPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            breakfastPicture.TabIndex = 6;
            breakfastPicture.TabStop = false;
            // 
            // lunchPicture
            // 
            lunchPicture.Image = Properties.Resources.eba4dbd4683ee353eba42ff3139816f8_w750_h500;
            lunchPicture.Location = new Point(213, 44);
            lunchPicture.Margin = new Padding(4, 3, 4, 3);
            lunchPicture.Name = "lunchPicture";
            lunchPicture.Size = new Size(161, 106);
            lunchPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lunchPicture.TabIndex = 7;
            lunchPicture.TabStop = false;
            // 
            // dinnerPicture
            // 
            dinnerPicture.Image = Properties.Resources.istockphoto_182147903_612x612;
            dinnerPicture.Location = new Point(408, 44);
            dinnerPicture.Margin = new Padding(4, 3, 4, 3);
            dinnerPicture.Name = "dinnerPicture";
            dinnerPicture.Size = new Size(162, 106);
            dinnerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            dinnerPicture.TabIndex = 8;
            dinnerPicture.TabStop = false;
            // 
            // foodPanel
            // 
            foodPanel.BackColor = Color.Transparent;
            foodPanel.Controls.Add(dinnerQTY);
            foodPanel.Controls.Add(nextButton);
            foodPanel.Controls.Add(lunchQTY);
            foodPanel.Controls.Add(breakfastQTY);
            foodPanel.Controls.Add(dinnerPicture);
            foodPanel.Controls.Add(lunchPicture);
            foodPanel.Controls.Add(needPanel);
            foodPanel.Controls.Add(dinnerCheckBox);
            foodPanel.Controls.Add(breakfastPicture);
            foodPanel.Controls.Add(lunchCheckBox);
            foodPanel.Controls.Add(breakfastCheckBox);
            foodPanel.Controls.Add(metroLabel1);
            foodPanel.Location = new Point(16, 53);
            foodPanel.Margin = new Padding(4, 3, 4, 3);
            foodPanel.Name = "foodPanel";
            foodPanel.Size = new Size(589, 338);
            foodPanel.TabIndex = 5;
            // 
            // dinnerQTY
            // 
            dinnerQTY.Location = new Point(408, 185);
            dinnerQTY.Name = "dinnerQTY";
            dinnerQTY.PlaceholderText = "3ayez kam?";
            dinnerQTY.Size = new Size(161, 23);
            dinnerQTY.TabIndex = 11;
            dinnerQTY.TextChanged += dinnerQTY_TextChanged;
            dinnerQTY.Leave += dinnerQTY_Leave;
            // 
            // lunchQTY
            // 
            lunchQTY.Location = new Point(213, 185);
            lunchQTY.Name = "lunchQTY";
            lunchQTY.PlaceholderText = "3ayez kam?";
            lunchQTY.Size = new Size(161, 23);
            lunchQTY.TabIndex = 10;
            lunchQTY.Leave += lunchQTY_Leave;
            // 
            // breakfastQTY
            // 
            breakfastQTY.Location = new Point(18, 186);
            breakfastQTY.Name = "breakfastQTY";
            breakfastQTY.PlaceholderText = "3ayez kam?";
            breakfastQTY.Size = new Size(161, 23);
            breakfastQTY.TabIndex = 9;
            breakfastQTY.Leave += breakfastQTY_Leave;
            // 
            // test
            // 
            test.AutoSize = true;
            test.Location = new Point(232, 26);
            test.Name = "test";
            test.Size = new Size(38, 15);
            test.TabIndex = 47;
            test.Text = "label1";
            // 
            // FoodMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(623, 421);
            Controls.Add(test);
            Controls.Add(FrontendHeader);
            Controls.Add(foodPanel);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FoodMenu";
            ShowInTaskbar = false;
            Text = "Food and Menu";
            needPanel.ResumeLayout(false);
            needPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).EndInit();
            foodPanel.ResumeLayout(false);
            foodPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        public System.Windows.Forms.Panel needPanel;
       public System.Windows.Forms.CheckBox surpriseCheckBox;
       public System.Windows.Forms.CheckBox towelsCheckBox;
       public System.Windows.Forms.CheckBox cleaningCheckBox;
       public System.Windows.Forms.Label metroLabel2;
       public System.Windows.Forms.Button nextButton;
       public Label FrontendHeader;
       public Label metroLabel1;
       public CheckBox breakfastCheckBox;
       public CheckBox lunchCheckBox;
       public CheckBox dinnerCheckBox;
       public PictureBox breakfastPicture;
       public PictureBox lunchPicture;
       public PictureBox dinnerPicture;
       public Panel foodPanel;
       public TextBox dinnerQTY;
       public TextBox lunchQTY;
       public TextBox breakfastQTY;
        private Label test;
    }
}