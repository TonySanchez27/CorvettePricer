namespace CorvettePricer
{
    partial class TrimLevelForm
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
            this.picbox2LT = new System.Windows.Forms.PictureBox();
            this.picbox1LT = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rad1LT = new System.Windows.Forms.RadioButton();
            this.rad2LT = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2LT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1LT)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox2LT
            // 
            this.picbox2LT.Image = global::CorvettePricer.Properties.Resources.Trim2LT;
            this.picbox2LT.Location = new System.Drawing.Point(406, 77);
            this.picbox2LT.Name = "picbox2LT";
            this.picbox2LT.Size = new System.Drawing.Size(388, 332);
            this.picbox2LT.TabIndex = 1;
            this.picbox2LT.TabStop = false;
            // 
            // picbox1LT
            // 
            this.picbox1LT.Image = global::CorvettePricer.Properties.Resources.Trim1LT;
            this.picbox1LT.Location = new System.Drawing.Point(22, 77);
            this.picbox1LT.Name = "picbox1LT";
            this.picbox1LT.Size = new System.Drawing.Size(369, 332);
            this.picbox1LT.TabIndex = 0;
            this.picbox1LT.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "1LT Trim Level (no charge)\r\nIncludes the following Items:";
            // 
            // rad1LT
            // 
            this.rad1LT.AutoSize = true;
            this.rad1LT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad1LT.Location = new System.Drawing.Point(84, 23);
            this.rad1LT.Name = "rad1LT";
            this.rad1LT.Size = new System.Drawing.Size(14, 13);
            this.rad1LT.TabIndex = 6;
            this.rad1LT.TabStop = true;
            this.rad1LT.UseVisualStyleBackColor = true;
            this.rad1LT.UseWaitCursor = true;
            this.rad1LT.CheckedChanged += new System.EventHandler(this.Rad1LT_CheckedChanged);
            // 
            // rad2LT
            // 
            this.rad2LT.AutoSize = true;
            this.rad2LT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad2LT.Location = new System.Drawing.Point(501, 23);
            this.rad2LT.Name = "rad2LT";
            this.rad2LT.Size = new System.Drawing.Size(14, 13);
            this.rad2LT.TabIndex = 7;
            this.rad2LT.TabStop = true;
            this.rad2LT.UseVisualStyleBackColor = true;
            this.rad2LT.UseWaitCursor = true;
            this.rad2LT.CheckedChanged += new System.EventHandler(this.Rad2LT_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "2LT Trim Level ($6,800)\r\nIncludes 1LT items plus:";
            // 
            // TrimLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rad2LT);
            this.Controls.Add(this.rad1LT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbox2LT);
            this.Controls.Add(this.picbox1LT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrimLevelForm";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "TrimLevelForm";
            this.Load += new System.EventHandler(this.TrimLevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox2LT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1LT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox1LT;
        private System.Windows.Forms.PictureBox picbox2LT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad1LT;
        private System.Windows.Forms.RadioButton rad2LT;
        private System.Windows.Forms.Label label2;
    }
}