namespace studentregistration
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.header = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.submit_button = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.qualification_label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.hobbies_textBox = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.hobbies_label = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.DOB_label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Female_radioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gender_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.phone_pictureBox = new System.Windows.Forms.PictureBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.emailpictureBox = new System.Windows.Forms.PictureBox();
            this.mailtextbox = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.Namepanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NamepictureBox = new System.Windows.Forms.PictureBox();
            this.Nametextbox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.header.SuspendLayout();
            this.body.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_pictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailpictureBox)).BeginInit();
            this.Namepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamepictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.LightSkyBlue;
            this.header.Controls.Add(this.Exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1561, 48);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(1493, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(68, 48);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.Black;
            this.body.Controls.Add(this.submit_button);
            this.body.Controls.Add(this.panel8);
            this.body.Controls.Add(this.panel7);
            this.body.Controls.Add(this.panel6);
            this.body.Controls.Add(this.panel5);
            this.body.Controls.Add(this.panel4);
            this.body.Controls.Add(this.panel3);
            this.body.Controls.Add(this.Namepanel);
            this.body.Location = new System.Drawing.Point(437, 78);
            this.body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(796, 730);
            this.body.TabIndex = 1;
            this.body.Paint += new System.Windows.Forms.PaintEventHandler(this.body_Paint);
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.Color.Black;
            this.submit_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submit_button.Location = new System.Drawing.Point(299, 660);
            this.submit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(203, 44);
            this.submit_button.TabIndex = 11;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.flowLayoutPanel6);
            this.panel8.Controls.Add(this.comboBox1);
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Controls.Add(this.qualification_label);
            this.panel8.Location = new System.Drawing.Point(55, 556);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(573, 76);
            this.panel8.TabIndex = 10;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(269, 43);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(284, 1);
            this.flowLayoutPanel6.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "High School(10th)",
            "Higher School(12th)",
            "Grauation(Bachelors)",
            "Post Graduation(Masters)",
            "Phd"});
            this.comboBox1.Location = new System.Drawing.Point(269, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // qualification_label
            // 
            this.qualification_label.AutoSize = true;
            this.qualification_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualification_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qualification_label.Location = new System.Drawing.Point(85, 17);
            this.qualification_label.Name = "qualification_label";
            this.qualification_label.Size = new System.Drawing.Size(119, 25);
            this.qualification_label.TabIndex = 0;
            this.qualification_label.Text = "Qualification";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.flowLayoutPanel5);
            this.panel7.Controls.Add(this.hobbies_textBox);
            this.panel7.Controls.Add(this.checkBox4);
            this.panel7.Controls.Add(this.checkBox3);
            this.panel7.Controls.Add(this.checkBox2);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.checkBox1);
            this.panel7.Controls.Add(this.hobbies_label);
            this.panel7.Location = new System.Drawing.Point(48, 410);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(691, 140);
            this.panel7.TabIndex = 8;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(347, 106);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(284, 1);
            this.flowLayoutPanel5.TabIndex = 12;
            // 
            // hobbies_textBox
            // 
            this.hobbies_textBox.BackColor = System.Drawing.Color.Black;
            this.hobbies_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hobbies_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hobbies_textBox.ForeColor = System.Drawing.Color.Gray;
            this.hobbies_textBox.Location = new System.Drawing.Point(347, 80);
            this.hobbies_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hobbies_textBox.Name = "hobbies_textBox";
            this.hobbies_textBox.Size = new System.Drawing.Size(284, 23);
            this.hobbies_textBox.TabIndex = 11;
            this.hobbies_textBox.Text = "        EX : Painting";
            this.hobbies_textBox.Click += new System.EventHandler(this.hobbies_textBox_Click);
            this.hobbies_textBox.TextChanged += new System.EventHandler(this.hobbies_textBox_TextChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Black;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(232, 80);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 29);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Others";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Black;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(509, 25);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 29);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Singing";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Black;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Magenta;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(371, 25);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 29);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Dancing";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(232, 25);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 29);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Swimming";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // hobbies_label
            // 
            this.hobbies_label.AutoSize = true;
            this.hobbies_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hobbies_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hobbies_label.Location = new System.Drawing.Point(93, 27);
            this.hobbies_label.Name = "hobbies_label";
            this.hobbies_label.Size = new System.Drawing.Size(84, 25);
            this.hobbies_label.TabIndex = 0;
            this.hobbies_label.Text = "Hobbies";
            this.hobbies_label.Click += new System.EventHandler(this.hobbies_label_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimePicker);
            this.panel6.Controls.Add(this.flowLayoutPanel4);
            this.panel6.Controls.Add(this.DOB_label);
            this.panel6.Location = new System.Drawing.Point(48, 338);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(573, 65);
            this.panel6.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(271, 7);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 30);
            this.dateTimePicker.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(269, 43);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(284, 1);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // DOB_label
            // 
            this.DOB_label.AutoSize = true;
            this.DOB_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DOB_label.Location = new System.Drawing.Point(100, 18);
            this.DOB_label.Name = "DOB_label";
            this.DOB_label.Size = new System.Drawing.Size(55, 25);
            this.DOB_label.TabIndex = 0;
            this.DOB_label.Text = "DOB";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.Gender_label);
            this.panel5.Location = new System.Drawing.Point(48, 273);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 60);
            this.panel5.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Female_radioButton);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(251, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 57);
            this.panel1.TabIndex = 5;
            // 
            // Female_radioButton
            // 
            this.Female_radioButton.AutoSize = true;
            this.Female_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female_radioButton.ForeColor = System.Drawing.Color.White;
            this.Female_radioButton.Location = new System.Drawing.Point(129, 18);
            this.Female_radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Female_radioButton.Name = "Female_radioButton";
            this.Female_radioButton.Size = new System.Drawing.Size(98, 29);
            this.Female_radioButton.TabIndex = 5;
            this.Female_radioButton.TabStop = true;
            this.Female_radioButton.Tag = "";
            this.Female_radioButton.Text = "Female";
            this.Female_radioButton.UseVisualStyleBackColor = true;
            this.Female_radioButton.CheckedChanged += new System.EventHandler(this.Female_radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(23, 18);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 29);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "";
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gender_label.Location = new System.Drawing.Point(100, 18);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(77, 25);
            this.Gender_label.TabIndex = 0;
            this.Gender_label.Text = "Gender";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanel3);
            this.panel4.Controls.Add(this.phone_pictureBox);
            this.panel4.Controls.Add(this.phone_textBox);
            this.panel4.Controls.Add(this.phone_label);
            this.panel4.Location = new System.Drawing.Point(48, 202);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 65);
            this.panel4.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(269, 43);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(284, 1);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // phone_pictureBox
            // 
            this.phone_pictureBox.BackColor = System.Drawing.Color.White;
            this.phone_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("phone_pictureBox.Image")));
            this.phone_pictureBox.Location = new System.Drawing.Point(17, 2);
            this.phone_pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_pictureBox.Name = "phone_pictureBox";
            this.phone_pictureBox.Size = new System.Drawing.Size(51, 41);
            this.phone_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.phone_pictureBox.TabIndex = 1;
            this.phone_pictureBox.TabStop = false;
            // 
            // phone_textBox
            // 
            this.phone_textBox.BackColor = System.Drawing.Color.Black;
            this.phone_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_textBox.ForeColor = System.Drawing.Color.Gray;
            this.phone_textBox.Location = new System.Drawing.Point(271, 18);
            this.phone_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(284, 23);
            this.phone_textBox.TabIndex = 2;
            this.phone_textBox.Text = "       9845xxxxxx";
            this.phone_textBox.Click += new System.EventHandler(this.phone_textBox_Click);
            this.phone_textBox.TextChanged += new System.EventHandler(this.phone_textBox_TextChanged);
            this.phone_textBox.Leave += new System.EventHandler(this.phone_textBox_Leave);
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phone_label.Location = new System.Drawing.Point(100, 18);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(144, 25);
            this.phone_label.TabIndex = 0;
            this.phone_label.Text = "Mobile Number";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.emailpictureBox);
            this.panel3.Controls.Add(this.mailtextbox);
            this.panel3.Controls.Add(this.label_email);
            this.panel3.Location = new System.Drawing.Point(48, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 65);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(269, 43);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(284, 1);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // emailpictureBox
            // 
            this.emailpictureBox.BackColor = System.Drawing.Color.White;
            this.emailpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("emailpictureBox.Image")));
            this.emailpictureBox.Location = new System.Drawing.Point(17, 5);
            this.emailpictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailpictureBox.Name = "emailpictureBox";
            this.emailpictureBox.Size = new System.Drawing.Size(51, 39);
            this.emailpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emailpictureBox.TabIndex = 1;
            this.emailpictureBox.TabStop = false;
            // 
            // mailtextbox
            // 
            this.mailtextbox.BackColor = System.Drawing.Color.Black;
            this.mailtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailtextbox.ForeColor = System.Drawing.Color.Gray;
            this.mailtextbox.Location = new System.Drawing.Point(271, 18);
            this.mailtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mailtextbox.Name = "mailtextbox";
            this.mailtextbox.Size = new System.Drawing.Size(284, 23);
            this.mailtextbox.TabIndex = 2;
            this.mailtextbox.Text = "       demo@gmail.com";
            this.mailtextbox.Click += new System.EventHandler(this.mailtextbox_Click);
            this.mailtextbox.TextChanged += new System.EventHandler(this.mailtextbox_TextChanged);
            this.mailtextbox.Leave += new System.EventHandler(this.mailtextbox_Leave);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_email.Location = new System.Drawing.Point(100, 18);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(86, 25);
            this.label_email.TabIndex = 0;
            this.label_email.Text = "Email_id";
            // 
            // Namepanel
            // 
            this.Namepanel.Controls.Add(this.flowLayoutPanel1);
            this.Namepanel.Controls.Add(this.NamepictureBox);
            this.Namepanel.Controls.Add(this.Nametextbox);
            this.Namepanel.Controls.Add(this.namelabel);
            this.Namepanel.Location = new System.Drawing.Point(48, 60);
            this.Namepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Namepanel.Name = "Namepanel";
            this.Namepanel.Size = new System.Drawing.Size(573, 65);
            this.Namepanel.TabIndex = 0;
            this.Namepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Namepanel_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(269, 43);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 1);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // NamepictureBox
            // 
            this.NamepictureBox.BackColor = System.Drawing.Color.White;
            this.NamepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NamepictureBox.Image")));
            this.NamepictureBox.Location = new System.Drawing.Point(17, 10);
            this.NamepictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NamepictureBox.Name = "NamepictureBox";
            this.NamepictureBox.Size = new System.Drawing.Size(51, 52);
            this.NamepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NamepictureBox.TabIndex = 1;
            this.NamepictureBox.TabStop = false;
            // 
            // Nametextbox
            // 
            this.Nametextbox.BackColor = System.Drawing.Color.Black;
            this.Nametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametextbox.ForeColor = System.Drawing.Color.Gray;
            this.Nametextbox.Location = new System.Drawing.Point(271, 18);
            this.Nametextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(284, 23);
            this.Nametextbox.TabIndex = 2;
            this.Nametextbox.Text = "           Enter Name";
            this.Nametextbox.Click += new System.EventHandler(this.Nametextbox_Click);
            this.Nametextbox.TextChanged += new System.EventHandler(this.Nametextbox_TextChanged);
            this.Nametextbox.Leave += new System.EventHandler(this.Nametextbox_Leave);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namelabel.Location = new System.Drawing.Point(100, 18);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(148, 25);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Student Name :";
            this.namelabel.Click += new System.EventHandler(this.namelabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 1040);
            this.panel2.TabIndex = 4;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Black;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(352, 32);
            this.title.TabIndex = 2;
            this.title.Text = " Student Registration Form";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 837);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 238);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1561, 1088);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.body);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Mainform_Paint);
            this.header.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_pictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailpictureBox)).EndInit();
            this.Namepanel.ResumeLayout(false);
            this.Namepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamepictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel Namepanel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.PictureBox NamepictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Nametextbox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox emailpictureBox;
        private System.Windows.Forms.TextBox mailtextbox;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox phone_pictureBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label DOB_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton Female_radioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label hobbies_label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox hobbies_textBox;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label qualification_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}

