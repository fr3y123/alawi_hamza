namespace zoo_information_hub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            list_animals = new ListBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            animal_name = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label14 = new Label();
            label17 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            top_speed = new TextBox();
            weight = new TextBox();
            location = new TextBox();
            diet = new TextBox();
            label3 = new Label();
            animal_habitat = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label9 = new Label();
            event_date = new TextBox();
            label7 = new Label();
            event_name = new TextBox();
            label11 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // list_animals
            // 
            list_animals.BackColor = SystemColors.GradientInactiveCaption;
            list_animals.BorderStyle = BorderStyle.None;
            list_animals.Cursor = Cursors.Hand;
            list_animals.FormattingEnabled = true;
            list_animals.ItemHeight = 22;
            list_animals.Location = new Point(12, 55);
            list_animals.Margin = new Padding(3, 5, 3, 5);
            list_animals.Name = "list_animals";
            list_animals.Size = new Size(166, 176);
            list_animals.TabIndex = 0;
            list_animals.SelectedIndexChanged += list_animals_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(187, 22);
            label2.TabIndex = 3;
            label2.Text = "Choose your favourite animal";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1030, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // animal_name
            // 
            animal_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            animal_name.BackColor = SystemColors.ControlLightLight;
            animal_name.Location = new Point(147, 3);
            animal_name.Multiline = true;
            animal_name.Name = "animal_name";
            animal_name.ReadOnly = true;
            animal_name.Size = new Size(426, 50);
            animal_name.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(579, 112);
            label10.Name = "label10";
            label10.Size = new Size(72, 22);
            label10.TabIndex = 38;
            label10.Text = "Top Speed";
            label10.Click += label10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(579, 56);
            label8.Name = "label8";
            label8.Size = new Size(52, 22);
            label8.TabIndex = 33;
            label8.Text = "Weight";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(652, 254);
            label14.Name = "label14";
            label14.Size = new Size(61, 22);
            label14.TabIndex = 34;
            label14.Text = "Location";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 112);
            label17.Name = "label17";
            label17.Size = new Size(32, 22);
            label17.TabIndex = 37;
            label17.Text = "Diet";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.Controls.Add(top_speed, 3, 2);
            tableLayoutPanel1.Controls.Add(weight, 3, 1);
            tableLayoutPanel1.Controls.Add(location, 3, 0);
            tableLayoutPanel1.Controls.Add(diet, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(animal_habitat, 1, 1);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(label10, 2, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label17, 0, 2);
            tableLayoutPanel1.Controls.Add(animal_name, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 239);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1152, 169);
            tableLayoutPanel1.TabIndex = 39;
            // 
            // top_speed
            // 
            top_speed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top_speed.BackColor = SystemColors.ControlLightLight;
            top_speed.Location = new Point(723, 115);
            top_speed.Multiline = true;
            top_speed.Name = "top_speed";
            top_speed.ReadOnly = true;
            top_speed.Size = new Size(426, 51);
            top_speed.TabIndex = 47;
            // 
            // weight
            // 
            weight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            weight.BackColor = SystemColors.ControlLightLight;
            weight.Location = new Point(723, 59);
            weight.Multiline = true;
            weight.Name = "weight";
            weight.ReadOnly = true;
            weight.Size = new Size(426, 50);
            weight.TabIndex = 46;
            // 
            // location
            // 
            location.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            location.BackColor = SystemColors.ControlLightLight;
            location.Location = new Point(723, 3);
            location.Multiline = true;
            location.Name = "location";
            location.ReadOnly = true;
            location.Size = new Size(426, 50);
            location.TabIndex = 45;
            // 
            // diet
            // 
            diet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            diet.BackColor = SystemColors.ControlLightLight;
            diet.Location = new Point(147, 115);
            diet.Multiline = true;
            diet.Name = "diet";
            diet.ReadOnly = true;
            diet.Size = new Size(426, 51);
            diet.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 22);
            label3.TabIndex = 41;
            label3.Text = "Location";
            // 
            // animal_habitat
            // 
            animal_habitat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            animal_habitat.BackColor = SystemColors.ControlLightLight;
            animal_habitat.Location = new Point(147, 59);
            animal_habitat.Multiline = true;
            animal_habitat.Name = "animal_habitat";
            animal_habitat.ReadOnly = true;
            animal_habitat.Size = new Size(426, 50);
            animal_habitat.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 56);
            label6.Name = "label6";
            label6.Size = new Size(98, 22);
            label6.TabIndex = 42;
            label6.Text = "Animal Habitat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 42;
            label4.Text = "Animal Name";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(629, 184);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(715, 239);
            label5.Name = "label5";
            label5.Size = new Size(0, 22);
            label5.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(40, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 234);
            panel1.TabIndex = 42;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.8450966F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.1549F));
            tableLayoutPanel2.Controls.Add(label9, 0, 1);
            tableLayoutPanel2.Controls.Add(event_date, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(event_name, 1, 0);
            tableLayoutPanel2.Location = new Point(184, 55);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(623, 176);
            tableLayoutPanel2.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 88);
            label9.Name = "label9";
            label9.Size = new Size(37, 22);
            label9.TabIndex = 46;
            label9.Text = "Date";
            // 
            // event_date
            // 
            event_date.Location = new Point(89, 91);
            event_date.Multiline = true;
            event_date.Name = "event_date";
            event_date.Size = new Size(531, 35);
            event_date.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 44;
            label7.Text = "Event Name";
            // 
            // event_name
            // 
            event_name.Location = new Point(89, 3);
            event_name.Multiline = true;
            event_name.Name = "event_name";
            event_name.Size = new Size(531, 82);
            event_name.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(974, 30);
            label11.Name = "label11";
            label11.Size = new Size(90, 22);
            label11.TabIndex = 44;
            label11.Text = "Event options";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.GradientInactiveCaption;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Items.AddRange(new object[] { "Animal Encounters", "Educational Talks", "Animal Shows", "Conservation Awareness Events", "Seasonal or Holiday Events" });
            listBox1.Location = new Point(920, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 176);
            listBox1.TabIndex = 45;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 660);
            Controls.Add(listBox1);
            Controls.Add(label11);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(list_animals);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form1";
            Text = "Animal Hub";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox list_animals;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox animal_name;
        private Label label10;
        private Label label8;
        private Label label14;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox top_speed;
        private TextBox weight;
        private TextBox location;
        private TextBox diet;
        private TextBox animal_habitat;
        private Label label6;
        private Label label5;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private TextBox event_date;
        private Label label7;
        private TextBox event_name;
        private Label label11;
        private ListBox listBox1;
    }
}