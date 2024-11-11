namespace ElevatorSystemApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_lift_down = new System.Windows.Forms.Timer(this.components);
            this.timer_lift_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_up = new System.Windows.Forms.Timer(this.components);
            this.database_listbox = new System.Windows.Forms.ListBox();
            this.btn_clearlog = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displaylog = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.door_left_up = new System.Windows.Forms.PictureBox();
            this.door_right_up = new System.Windows.Forms.PictureBox();
            this.door_left_down = new System.Windows.Forms.PictureBox();
            this.door_right_down = new System.Windows.Forms.PictureBox();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_G = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.display_bottom = new System.Windows.Forms.PictureBox();
            this.display_panel = new System.Windows.Forms.PictureBox();
            this.display_top = new System.Windows.Forms.PictureBox();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.bg_panel = new System.Windows.Forms.PictureBox();
            this.picture_lift = new System.Windows.Forms.PictureBox();
            this.concrete = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concrete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_lift_down
            // 
            this.timer_lift_down.Interval = 15;
            this.timer_lift_down.Tick += new System.EventHandler(this.timer_lift_down_Tick);
            // 
            // timer_lift_up
            // 
            this.timer_lift_up.Interval = 15;
            this.timer_lift_up.Tick += new System.EventHandler(this.timer_lift_up_Tick);
            // 
            // timer_door_open_down
            // 
            this.timer_door_open_down.Interval = 5;
            this.timer_door_open_down.Tick += new System.EventHandler(this.door_open_down_Tick);
            // 
            // timer_door_close_down
            // 
            this.timer_door_close_down.Interval = 5;
            this.timer_door_close_down.Tick += new System.EventHandler(this.door_close_down_Tick);
            // 
            // timer_door_open_up
            // 
            this.timer_door_open_up.Interval = 5;
            this.timer_door_open_up.Tick += new System.EventHandler(this.timer_door_open_up_Tick);
            // 
            // timer_door_close_up
            // 
            this.timer_door_close_up.Interval = 5;
            this.timer_door_close_up.Tick += new System.EventHandler(this.timer_door_close_up_Tick);
            // 
            // database_listbox
            // 
            this.database_listbox.FormattingEnabled = true;
            this.database_listbox.ItemHeight = 14;
            this.database_listbox.Location = new System.Drawing.Point(10, 39);
            this.database_listbox.Name = "database_listbox";
            this.database_listbox.Size = new System.Drawing.Size(490, 550);
            this.database_listbox.TabIndex = 20;
            // 
            // btn_clearlog
            // 
            this.btn_clearlog.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearlog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clearlog.Location = new System.Drawing.Point(308, 448);
            this.btn_clearlog.Name = "btn_clearlog";
            this.btn_clearlog.Size = new System.Drawing.Size(143, 35);
            this.btn_clearlog.TabIndex = 22;
            this.btn_clearlog.Text = "Clear Log";
            this.btn_clearlog.UseVisualStyleBackColor = true;
            this.btn_clearlog.Click += new System.EventHandler(this.btn_clearlog_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_exit.Location = new System.Drawing.Point(308, 508);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(143, 35);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(154, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(269, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Event Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.database_listbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(468, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 604);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elevator Log";
            // 
            // displaylog
            // 
            this.displaylog.Font = new System.Drawing.Font("Sylfaen", 11.25F);
            this.displaylog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displaylog.Location = new System.Drawing.Point(308, 407);
            this.displaylog.Name = "displaylog";
            this.displaylog.Size = new System.Drawing.Size(143, 35);
            this.displaylog.TabIndex = 27;
            this.displaylog.Text = "Display Log";
            this.displaylog.UseVisualStyleBackColor = true;
            this.displaylog.Click += new System.EventHandler(this.btn_displaylog_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ElevatorControl.Properties.Resources._1319;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // door_left_up
            // 
            this.door_left_up.BackColor = System.Drawing.SystemColors.Control;
            this.door_left_up.Image = global::ElevatorControl.Properties.Resources.lift_door_left;
            this.door_left_up.Location = new System.Drawing.Point(74, 63);
            this.door_left_up.Name = "door_left_up";
            this.door_left_up.Size = new System.Drawing.Size(66, 196);
            this.door_left_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_left_up.TabIndex = 18;
            this.door_left_up.TabStop = false;
            // 
            // door_right_up
            // 
            this.door_right_up.Image = global::ElevatorControl.Properties.Resources.lift_door_right;
            this.door_right_up.Location = new System.Drawing.Point(139, 63);
            this.door_right_up.Name = "door_right_up";
            this.door_right_up.Size = new System.Drawing.Size(65, 196);
            this.door_right_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_right_up.TabIndex = 19;
            this.door_right_up.TabStop = false;
            // 
            // door_left_down
            // 
            this.door_left_down.BackColor = System.Drawing.SystemColors.Control;
            this.door_left_down.Image = global::ElevatorControl.Properties.Resources.lift_door_left;
            this.door_left_down.Location = new System.Drawing.Point(74, 377);
            this.door_left_down.Name = "door_left_down";
            this.door_left_down.Size = new System.Drawing.Size(66, 196);
            this.door_left_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_left_down.TabIndex = 16;
            this.door_left_down.TabStop = false;
            // 
            // door_right_down
            // 
            this.door_right_down.Image = global::ElevatorControl.Properties.Resources.lift_door_right;
            this.door_right_down.Location = new System.Drawing.Point(139, 377);
            this.door_right_down.Name = "door_right_down";
            this.door_right_down.Size = new System.Drawing.Size(65, 196);
            this.door_right_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_right_down.TabIndex = 17;
            this.door_right_down.TabStop = false;
            // 
            // btn_alarm
            // 
            this.btn_alarm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_alarm.BackgroundImage")));
            this.btn_alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_alarm.Location = new System.Drawing.Point(359, 321);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(37, 36);
            this.btn_alarm.TabIndex = 15;
            this.btn_alarm.UseVisualStyleBackColor = true;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.White;
            this.btn_open.BackgroundImage = global::ElevatorControl.Properties.Resources.opendoorbutton;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_open.Location = new System.Drawing.Point(386, 258);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(46, 42);
            this.btn_open.TabIndex = 14;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.BackgroundImage = global::ElevatorControl.Properties.Resources.closedoorsbutton;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Location = new System.Drawing.Point(326, 258);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(46, 42);
            this.btn_close.TabIndex = 13;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_G
            // 
            this.btn_G.BackColor = System.Drawing.Color.White;
            this.btn_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_G.BackgroundImage")));
            this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_G.Location = new System.Drawing.Point(386, 187);
            this.btn_G.Name = "btn_G";
            this.btn_G.Size = new System.Drawing.Size(46, 46);
            this.btn_G.TabIndex = 12;
            this.btn_G.UseVisualStyleBackColor = false;
            this.btn_G.Click += new System.EventHandler(this.btn_G_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_1.BackgroundImage")));
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_1.Location = new System.Drawing.Point(326, 187);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(46, 46);
            this.btn_1.TabIndex = 11;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // display_bottom
            // 
            this.display_bottom.BackColor = System.Drawing.Color.Transparent;
            this.display_bottom.Image = global::ElevatorControl.Properties.Resources.black;
            this.display_bottom.Location = new System.Drawing.Point(131, 357);
            this.display_bottom.Name = "display_bottom";
            this.display_bottom.Size = new System.Drawing.Size(18, 18);
            this.display_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_bottom.TabIndex = 9;
            this.display_bottom.TabStop = false;
            // 
            // display_panel
            // 
            this.display_panel.BackColor = System.Drawing.Color.Black;
            this.display_panel.BackgroundImage = global::ElevatorControl.Properties.Resources.black;
            this.display_panel.Location = new System.Drawing.Point(347, 91);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(64, 71);
            this.display_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_panel.TabIndex = 10;
            this.display_panel.TabStop = false;
            // 
            // display_top
            // 
            this.display_top.BackColor = System.Drawing.Color.Black;
            this.display_top.Location = new System.Drawing.Point(132, 43);
            this.display_top.Name = "display_top";
            this.display_top.Size = new System.Drawing.Size(18, 18);
            this.display_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_top.TabIndex = 8;
            this.display_top.TabStop = false;
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_down.BackgroundImage")));
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_down.Location = new System.Drawing.Point(206, 476);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(29, 30);
            this.btn_down.TabIndex = 7;
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_up.BackgroundImage")));
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_up.Location = new System.Drawing.Point(206, 162);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(29, 30);
            this.btn_up.TabIndex = 6;
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // bg_panel
            // 
            this.bg_panel.Image = global::ElevatorControl.Properties.Resources.panel;
            this.bg_panel.Location = new System.Drawing.Point(308, 68);
            this.bg_panel.Name = "bg_panel";
            this.bg_panel.Size = new System.Drawing.Size(143, 307);
            this.bg_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_panel.TabIndex = 4;
            this.bg_panel.TabStop = false;
            // 
            // picture_lift
            // 
            this.picture_lift.BackColor = System.Drawing.Color.Transparent;
            this.picture_lift.Image = global::ElevatorControl.Properties.Resources.Inside_of_the_lift;
            this.picture_lift.Location = new System.Drawing.Point(74, 63);
            this.picture_lift.Name = "picture_lift";
            this.picture_lift.Size = new System.Drawing.Size(130, 192);
            this.picture_lift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_lift.TabIndex = 3;
            this.picture_lift.TabStop = false;
            // 
            // concrete
            // 
            this.concrete.Image = global::ElevatorControl.Properties.Resources.concrete;
            this.concrete.Location = new System.Drawing.Point(1, 317);
            this.concrete.Name = "concrete";
            this.concrete.Size = new System.Drawing.Size(290, 27);
            this.concrete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.concrete.TabIndex = 2;
            this.concrete.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ElevatorControl.Properties.Resources._1319;
            this.pictureBox2.Location = new System.Drawing.Point(-12, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 336);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ElevatorControl.Properties.Resources.black;
            this.pictureBox3.Location = new System.Drawing.Point(111, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 18);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ElevatorControl.Properties.Resources.black;
            this.pictureBox4.Location = new System.Drawing.Point(110, 357);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 18);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox5.Location = new System.Drawing.Point(76, 65);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(127, 193);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox6.Location = new System.Drawing.Point(75, 379);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(127, 193);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(985, 626);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.displaylog);
            this.Controls.Add(this.display_bottom);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.display_top);
            this.Controls.Add(this.btn_clearlog);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.door_left_up);
            this.Controls.Add(this.door_right_up);
            this.Controls.Add(this.door_left_down);
            this.Controls.Add(this.door_right_down);
            this.Controls.Add(this.btn_alarm);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_G);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.bg_panel);
            this.Controls.Add(this.picture_lift);
            this.Controls.Add(this.concrete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Control ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concrete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox concrete;
        private System.Windows.Forms.PictureBox picture_lift;
        private System.Windows.Forms.Timer timer_lift_down;
        private System.Windows.Forms.PictureBox bg_panel;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Timer timer_lift_up;
        private System.Windows.Forms.PictureBox display_top;
        private System.Windows.Forms.PictureBox display_bottom;
        private System.Windows.Forms.PictureBox display_panel;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.PictureBox door_left_down;
        private System.Windows.Forms.PictureBox door_right_down;
        private System.Windows.Forms.Timer timer_door_open_down;
        private System.Windows.Forms.Timer timer_door_close_down;
        private System.Windows.Forms.PictureBox door_left_up;
        private System.Windows.Forms.PictureBox door_right_up;
        private System.Windows.Forms.Timer timer_door_open_up;
        private System.Windows.Forms.Timer timer_door_close_up;
        private System.Windows.Forms.ListBox database_listbox;
        private System.Windows.Forms.Button btn_clearlog;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button displaylog;
    }
}

