namespace CorvettePricer
{
    partial class MainForm
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
            this.panelColor = new System.Windows.Forms.Panel();
            this.radColorRed = new System.Windows.Forms.RadioButton();
            this.radColorWhite = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panelHighWing = new System.Windows.Forms.Panel();
            this.radHighWing = new System.Windows.Forms.RadioButton();
            this.radNoHighWing = new System.Windows.Forms.RadioButton();
            this.lblHighWing = new System.Windows.Forms.Label();
            this.panelOtherOptions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFloorMats = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDoorPlates = new System.Windows.Forms.CheckBox();
            this.chkLiftKit = new System.Windows.Forms.CheckBox();
            this.lblOtherOptions = new System.Windows.Forms.Label();
            this.panelTrimLevel = new System.Windows.Forms.Panel();
            this.lblTrimDetails = new System.Windows.Forms.Label();
            this.rad2LT = new System.Windows.Forms.RadioButton();
            this.rad1LT = new System.Windows.Forms.RadioButton();
            this.lblTrimLevel = new System.Windows.Forms.Label();
            this.butTopUp = new System.Windows.Forms.Button();
            this.butTopDown = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblOptionsPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblstatusbar = new System.Windows.Forms.Label();
            this.panelColor.SuspendLayout();
            this.panelHighWing.SuspendLayout();
            this.panelOtherOptions.SuspendLayout();
            this.panelTrimLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelColor.Controls.Add(this.radColorRed);
            this.panelColor.Controls.Add(this.radColorWhite);
            this.panelColor.Controls.Add(this.lblColor);
            this.panelColor.Location = new System.Drawing.Point(18, 195);
            this.panelColor.Margin = new System.Windows.Forms.Padding(4);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(320, 108);
            this.panelColor.TabIndex = 2;
            // 
            // radColorRed
            // 
            this.radColorRed.AutoSize = true;
            this.radColorRed.Location = new System.Drawing.Point(19, 71);
            this.radColorRed.Margin = new System.Windows.Forms.Padding(4);
            this.radColorRed.Name = "radColorRed";
            this.radColorRed.Size = new System.Drawing.Size(236, 22);
            this.radColorRed.TabIndex = 2;
            this.radColorRed.TabStop = true;
            this.radColorRed.Text = "Long Beach Red Metallic ($995)";
            this.radColorRed.UseVisualStyleBackColor = true;
            this.radColorRed.CheckedChanged += new System.EventHandler(this.ColorChanged);
            // 
            // radColorWhite
            // 
            this.radColorWhite.AutoSize = true;
            this.radColorWhite.Checked = true;
            this.radColorWhite.Location = new System.Drawing.Point(19, 46);
            this.radColorWhite.Margin = new System.Windows.Forms.Padding(4);
            this.radColorWhite.Name = "radColorWhite";
            this.radColorWhite.Size = new System.Drawing.Size(224, 22);
            this.radColorWhite.TabIndex = 1;
            this.radColorWhite.TabStop = true;
            this.radColorWhite.Text = "Artic White (No Charge Color)";
            this.radColorWhite.UseVisualStyleBackColor = true;
            this.radColorWhite.CheckedChanged += new System.EventHandler(this.ColorChanged);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Navy;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(0, 0);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(320, 31);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeading.Location = new System.Drawing.Point(407, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(384, 37);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "2020 Chevrolet Corvette";
            // 
            // panelHighWing
            // 
            this.panelHighWing.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHighWing.Controls.Add(this.radHighWing);
            this.panelHighWing.Controls.Add(this.radNoHighWing);
            this.panelHighWing.Controls.Add(this.lblHighWing);
            this.panelHighWing.Location = new System.Drawing.Point(19, 323);
            this.panelHighWing.Margin = new System.Windows.Forms.Padding(4);
            this.panelHighWing.Name = "panelHighWing";
            this.panelHighWing.Size = new System.Drawing.Size(319, 108);
            this.panelHighWing.TabIndex = 3;
            // 
            // radHighWing
            // 
            this.radHighWing.AutoSize = true;
            this.radHighWing.Location = new System.Drawing.Point(19, 71);
            this.radHighWing.Margin = new System.Windows.Forms.Padding(4);
            this.radHighWing.Name = "radHighWing";
            this.radHighWing.Size = new System.Drawing.Size(188, 22);
            this.radHighWing.TabIndex = 2;
            this.radHighWing.TabStop = true;
            this.radHighWing.Text = "High Rear Wing ($1,150)";
            this.radHighWing.UseVisualStyleBackColor = true;
            this.radHighWing.CheckedChanged += new System.EventHandler(this.WingChanged);
            // 
            // radNoHighWing
            // 
            this.radNoHighWing.AutoSize = true;
            this.radNoHighWing.Checked = true;
            this.radNoHighWing.Location = new System.Drawing.Point(19, 46);
            this.radNoHighWing.Margin = new System.Windows.Forms.Padding(4);
            this.radNoHighWing.Name = "radNoHighWing";
            this.radNoHighWing.Size = new System.Drawing.Size(151, 22);
            this.radNoHighWing.TabIndex = 2;
            this.radNoHighWing.TabStop = true;
            this.radNoHighWing.Text = "No wing (standard)";
            this.radNoHighWing.UseVisualStyleBackColor = true;
            this.radNoHighWing.CheckedChanged += new System.EventHandler(this.WingChanged);
            // 
            // lblHighWing
            // 
            this.lblHighWing.BackColor = System.Drawing.Color.Navy;
            this.lblHighWing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHighWing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighWing.ForeColor = System.Drawing.Color.White;
            this.lblHighWing.Location = new System.Drawing.Point(0, 0);
            this.lblHighWing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighWing.Name = "lblHighWing";
            this.lblHighWing.Size = new System.Drawing.Size(319, 31);
            this.lblHighWing.TabIndex = 2;
            this.lblHighWing.Text = "High Wing Option";
            this.lblHighWing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOtherOptions
            // 
            this.panelOtherOptions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOtherOptions.Controls.Add(this.label1);
            this.panelOtherOptions.Controls.Add(this.chkFloorMats);
            this.panelOtherOptions.Controls.Add(this.label2);
            this.panelOtherOptions.Controls.Add(this.chkDoorPlates);
            this.panelOtherOptions.Controls.Add(this.chkLiftKit);
            this.panelOtherOptions.Controls.Add(this.lblOtherOptions);
            this.panelOtherOptions.Location = new System.Drawing.Point(19, 453);
            this.panelOtherOptions.Margin = new System.Windows.Forms.Padding(4);
            this.panelOtherOptions.Name = "panelOtherOptions";
            this.panelOtherOptions.Size = new System.Drawing.Size(319, 194);
            this.panelOtherOptions.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "with Stingray logo ($345)";
            // 
            // chkFloorMats
            // 
            this.chkFloorMats.AutoSize = true;
            this.chkFloorMats.Location = new System.Drawing.Point(16, 158);
            this.chkFloorMats.Name = "chkFloorMats";
            this.chkFloorMats.Size = new System.Drawing.Size(273, 22);
            this.chkFloorMats.TabIndex = 3;
            this.chkFloorMats.Text = "Premium Carpeted Floor Mats ($235)";
            this.chkFloorMats.UseVisualStyleBackColor = true;
            this.chkFloorMats.CheckedChanged += new System.EventHandler(this.ChkFloorMats_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "(only available for 2LT trim level)";
            // 
            // chkDoorPlates
            // 
            this.chkDoorPlates.AutoSize = true;
            this.chkDoorPlates.Location = new System.Drawing.Point(16, 102);
            this.chkDoorPlates.Name = "chkDoorPlates";
            this.chkDoorPlates.Size = new System.Drawing.Size(195, 22);
            this.chkDoorPlates.TabIndex = 2;
            this.chkDoorPlates.Text = "Illuminated door sill plates";
            this.chkDoorPlates.UseVisualStyleBackColor = true;
            this.chkDoorPlates.CheckedChanged += new System.EventHandler(this.ChkDoorPlates_CheckedChanged);
            // 
            // chkLiftKit
            // 
            this.chkLiftKit.AutoSize = true;
            this.chkLiftKit.Enabled = false;
            this.chkLiftKit.Location = new System.Drawing.Point(16, 47);
            this.chkLiftKit.Name = "chkLiftKit";
            this.chkLiftKit.Size = new System.Drawing.Size(279, 22);
            this.chkLiftKit.TabIndex = 1;
            this.chkLiftKit.Text = "Front lift system with memory ($1,495)";
            this.chkLiftKit.UseVisualStyleBackColor = true;
            this.chkLiftKit.CheckedChanged += new System.EventHandler(this.ChkLiftKit_CheckedChanged);
            // 
            // lblOtherOptions
            // 
            this.lblOtherOptions.BackColor = System.Drawing.Color.Navy;
            this.lblOtherOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOtherOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherOptions.ForeColor = System.Drawing.Color.White;
            this.lblOtherOptions.Location = new System.Drawing.Point(0, 0);
            this.lblOtherOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtherOptions.Name = "lblOtherOptions";
            this.lblOtherOptions.Size = new System.Drawing.Size(319, 31);
            this.lblOtherOptions.TabIndex = 2;
            this.lblOtherOptions.Text = "Other Options";
            this.lblOtherOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTrimLevel
            // 
            this.panelTrimLevel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTrimLevel.Controls.Add(this.lblTrimDetails);
            this.panelTrimLevel.Controls.Add(this.rad2LT);
            this.panelTrimLevel.Controls.Add(this.rad1LT);
            this.panelTrimLevel.Controls.Add(this.lblTrimLevel);
            this.panelTrimLevel.Location = new System.Drawing.Point(18, 59);
            this.panelTrimLevel.Margin = new System.Windows.Forms.Padding(4);
            this.panelTrimLevel.Name = "panelTrimLevel";
            this.panelTrimLevel.Size = new System.Drawing.Size(320, 115);
            this.panelTrimLevel.TabIndex = 1;
            // 
            // lblTrimDetails
            // 
            this.lblTrimDetails.AutoSize = true;
            this.lblTrimDetails.BackColor = System.Drawing.Color.Navy;
            this.lblTrimDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrimDetails.ForeColor = System.Drawing.Color.White;
            this.lblTrimDetails.Location = new System.Drawing.Point(207, 6);
            this.lblTrimDetails.Name = "lblTrimDetails";
            this.lblTrimDetails.Size = new System.Drawing.Size(62, 18);
            this.lblTrimDetails.TabIndex = 5;
            this.lblTrimDetails.Text = "details...";
            this.lblTrimDetails.Click += new System.EventHandler(this.LblTrimDetails_Click);
            // 
            // rad2LT
            // 
            this.rad2LT.AutoSize = true;
            this.rad2LT.Location = new System.Drawing.Point(18, 77);
            this.rad2LT.Name = "rad2LT";
            this.rad2LT.Size = new System.Drawing.Size(181, 22);
            this.rad2LT.TabIndex = 2;
            this.rad2LT.TabStop = true;
            this.rad2LT.Text = "2LT Trim Level ($6,800)";
            this.rad2LT.UseVisualStyleBackColor = true;
            this.rad2LT.CheckedChanged += new System.EventHandler(this.TrimLevelChanged);
            // 
            // rad1LT
            // 
            this.rad1LT.AutoSize = true;
            this.rad1LT.Checked = true;
            this.rad1LT.Location = new System.Drawing.Point(18, 49);
            this.rad1LT.Name = "rad1LT";
            this.rad1LT.Size = new System.Drawing.Size(270, 22);
            this.rad1LT.TabIndex = 1;
            this.rad1LT.TabStop = true;
            this.rad1LT.Text = "1LT Trim Level (Standard, no charge)";
            this.rad1LT.UseVisualStyleBackColor = true;
            this.rad1LT.CheckedChanged += new System.EventHandler(this.TrimLevelChanged);
            // 
            // lblTrimLevel
            // 
            this.lblTrimLevel.BackColor = System.Drawing.Color.Navy;
            this.lblTrimLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrimLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrimLevel.ForeColor = System.Drawing.Color.White;
            this.lblTrimLevel.Location = new System.Drawing.Point(0, 0);
            this.lblTrimLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrimLevel.Name = "lblTrimLevel";
            this.lblTrimLevel.Size = new System.Drawing.Size(319, 31);
            this.lblTrimLevel.TabIndex = 0;
            this.lblTrimLevel.Text = "Trim Level";
            this.lblTrimLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butTopUp
            // 
            this.butTopUp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTopUp.Location = new System.Drawing.Point(964, 433);
            this.butTopUp.Name = "butTopUp";
            this.butTopUp.Size = new System.Drawing.Size(91, 31);
            this.butTopUp.TabIndex = 11;
            this.butTopUp.TabStop = false;
            this.butTopUp.Text = "Top Up";
            this.butTopUp.UseVisualStyleBackColor = false;
            this.butTopUp.Click += new System.EventHandler(this.ButTopUp_Click);
            // 
            // butTopDown
            // 
            this.butTopDown.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butTopDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTopDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTopDown.Location = new System.Drawing.Point(1061, 433);
            this.butTopDown.Name = "butTopDown";
            this.butTopDown.Size = new System.Drawing.Size(91, 31);
            this.butTopDown.TabIndex = 12;
            this.butTopDown.TabStop = false;
            this.butTopDown.Text = "Top Down";
            this.butTopDown.UseVisualStyleBackColor = false;
            this.butTopDown.Click += new System.EventHandler(this.ButTopDown_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1044, 592);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(115, 30);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "$67,495";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(775, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total price as equipped:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(775, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Base convertible price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(1049, 507);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(110, 30);
            this.lblBasePrice.TabIndex = 15;
            this.lblBasePrice.Text = "$67,495";
            this.lblBasePrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine.Location = new System.Drawing.Point(1052, 584);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(100, 2);
            this.lblLine.TabIndex = 16;
            // 
            // lblOptionsPrice
            // 
            this.lblOptionsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionsPrice.Location = new System.Drawing.Point(1049, 547);
            this.lblOptionsPrice.Name = "lblOptionsPrice";
            this.lblOptionsPrice.Size = new System.Drawing.Size(110, 30);
            this.lblOptionsPrice.TabIndex = 17;
            this.lblOptionsPrice.Text = "0";
            this.lblOptionsPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(775, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total cost of options:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(1051, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 2);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(1051, 634);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 2);
            this.label9.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(356, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 102);
            this.label10.TabIndex = 22;
            this.label10.Text = "North American Car of the Year";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(814, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 10);
            this.label11.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(16, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(379, 10);
            this.label12.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CorvettePricer.Properties.Resources.flags;
            this.pictureBox2.Location = new System.Drawing.Point(593, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 110);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CorvettePricer.Properties.Resources.corvette_white_top_up;
            this.pictureBox1.ImageLocation = "https://rphillips.asp.radford.edu/corvette/corvette.white.top.up.bmp";
            this.pictureBox1.Location = new System.Drawing.Point(361, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 410);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1181, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblstatusbar
            // 
            this.lblstatusbar.AutoSize = true;
            this.lblstatusbar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblstatusbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatusbar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblstatusbar.Location = new System.Drawing.Point(358, 660);
            this.lblstatusbar.Name = "lblstatusbar";
            this.lblstatusbar.Size = new System.Drawing.Size(479, 13);
            this.lblstatusbar.TabIndex = 26;
            this.lblstatusbar.Text = "All corvette pictures copyright of Chevrolet.  Limited options presented for educ" +
    "ational purposes only.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 677);
            this.Controls.Add(this.lblstatusbar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOptionsPrice);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.butTopDown);
            this.Controls.Add(this.butTopUp);
            this.Controls.Add(this.panelTrimLevel);
            this.Controls.Add(this.panelOtherOptions);
            this.Controls.Add(this.panelHighWing);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.panelColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Corvette Pricer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.panelHighWing.ResumeLayout(false);
            this.panelHighWing.PerformLayout();
            this.panelOtherOptions.ResumeLayout(false);
            this.panelOtherOptions.PerformLayout();
            this.panelTrimLevel.ResumeLayout(false);
            this.panelTrimLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.RadioButton radColorRed;
        private System.Windows.Forms.RadioButton radColorWhite;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHighWing;
        private System.Windows.Forms.RadioButton radHighWing;
        private System.Windows.Forms.RadioButton radNoHighWing;
        private System.Windows.Forms.Label lblHighWing;
        private System.Windows.Forms.Panel panelOtherOptions;
        private System.Windows.Forms.CheckBox chkFloorMats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDoorPlates;
        private System.Windows.Forms.CheckBox chkLiftKit;
        private System.Windows.Forms.Label lblOtherOptions;
        private System.Windows.Forms.Panel panelTrimLevel;
        private System.Windows.Forms.Label lblTrimLevel;
        private System.Windows.Forms.Label lblTrimDetails;
        private System.Windows.Forms.Button butTopUp;
        private System.Windows.Forms.Button butTopDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblOptionsPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.RadioButton rad2LT;
        internal System.Windows.Forms.RadioButton rad1LT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblstatusbar;
    }
}

