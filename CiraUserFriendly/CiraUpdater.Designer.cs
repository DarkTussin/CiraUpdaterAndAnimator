namespace CiraUserFriendly
{
    partial class CIRAUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIRAUpdater));
            this.label1 = new System.Windows.Forms.Label();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.useHighRes = new System.Windows.Forms.CheckBox();
            this.daysToGet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentImageLabel = new System.Windows.Forms.Label();
            this.animationDelay = new System.Windows.Forms.TextBox();
            this.animateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.styleDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Save Location:";
            // 
            // saveLocation
            // 
            this.saveLocation.BackColor = System.Drawing.Color.Black;
            this.saveLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveLocation.Location = new System.Drawing.Point(130, 10);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.ReadOnly = true;
            this.saveLocation.Size = new System.Drawing.Size(277, 20);
            this.saveLocation.TabIndex = 1;
            this.saveLocation.TabStop = false;
            this.saveLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveLocation_MouseClick);
            this.saveLocation.Enter += new System.EventHandler(this.saveLocation_Enter);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(254, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get Images";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // useHighRes
            // 
            this.useHighRes.AutoSize = true;
            this.useHighRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.useHighRes.Location = new System.Drawing.Point(16, 36);
            this.useHighRes.Name = "useHighRes";
            this.useHighRes.Size = new System.Drawing.Size(216, 17);
            this.useHighRes.TabIndex = 1;
            this.useHighRes.Text = "Get Hi-Res Images (Not Recommended)";
            this.useHighRes.UseVisualStyleBackColor = true;
            // 
            // daysToGet
            // 
            this.daysToGet.FormattingEnabled = true;
            this.daysToGet.Location = new System.Drawing.Point(130, 59);
            this.daysToGet.Name = "daysToGet";
            this.daysToGet.Size = new System.Drawing.Size(45, 21);
            this.daysToGet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Past days to download:";
            // 
            // currentImageLabel
            // 
            this.currentImageLabel.AutoSize = true;
            this.currentImageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.currentImageLabel.Location = new System.Drawing.Point(7, 92);
            this.currentImageLabel.Name = "currentImageLabel";
            this.currentImageLabel.Size = new System.Drawing.Size(0, 13);
            this.currentImageLabel.TabIndex = 15;
            // 
            // animationDelay
            // 
            this.animationDelay.BackColor = System.Drawing.Color.Black;
            this.animationDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.animationDelay.Location = new System.Drawing.Point(195, 127);
            this.animationDelay.MaxLength = 6;
            this.animationDelay.Name = "animationDelay";
            this.animationDelay.Size = new System.Drawing.Size(55, 20);
            this.animationDelay.TabIndex = 5;
            this.animationDelay.Text = "0";
            // 
            // animateButton
            // 
            this.animateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.animateButton.Location = new System.Drawing.Point(10, 122);
            this.animateButton.Name = "animateButton";
            this.animateButton.Size = new System.Drawing.Size(114, 28);
            this.animateButton.TabIndex = 4;
            this.animateButton.Text = "Animate Directory";
            this.animateButton.UseVisualStyleBackColor = true;
            this.animateButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(130, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Delay (ms):";
            // 
            // styleDropdown
            // 
            this.styleDropdown.FormattingEnabled = true;
            this.styleDropdown.Location = new System.Drawing.Point(323, 127);
            this.styleDropdown.Name = "styleDropdown";
            this.styleDropdown.Size = new System.Drawing.Size(84, 21);
            this.styleDropdown.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(256, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Back Style:";
            // 
            // CIRAUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(419, 162);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.styleDropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.animateButton);
            this.Controls.Add(this.animationDelay);
            this.Controls.Add(this.currentImageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.daysToGet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.useHighRes);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CIRAUpdater";
            this.Text = "CIRA Updater and Animator by DarkTussin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CIRAUpdater_FormClosed);
            this.Load += new System.EventHandler(this.CIRAUpdater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox useHighRes;
        private System.Windows.Forms.ComboBox daysToGet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentImageLabel;
        private System.Windows.Forms.TextBox animationDelay;
        private System.Windows.Forms.Button animateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox styleDropdown;
        private System.Windows.Forms.Label label4;
    }
}

