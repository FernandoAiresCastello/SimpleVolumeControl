namespace SimpleVolumeControl
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BtnVolDown = new System.Windows.Forms.Button();
            this.BtnVolUp = new System.Windows.Forms.Button();
            this.BtnMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVolDown
            // 
            this.BtnVolDown.FlatAppearance.BorderSize = 0;
            this.BtnVolDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolDown.Image = global::SimpleVolumeControl.Properties.Resources.sound_delete;
            this.BtnVolDown.Location = new System.Drawing.Point(0, 0);
            this.BtnVolDown.Name = "BtnVolDown";
            this.BtnVolDown.Size = new System.Drawing.Size(60, 60);
            this.BtnVolDown.TabIndex = 0;
            this.BtnVolDown.UseVisualStyleBackColor = true;
            this.BtnVolDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnDec_MouseDown);
            this.BtnVolDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnDec_MouseUp);
            // 
            // BtnVolUp
            // 
            this.BtnVolUp.FlatAppearance.BorderSize = 0;
            this.BtnVolUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolUp.Image = global::SimpleVolumeControl.Properties.Resources.sound_add;
            this.BtnVolUp.Location = new System.Drawing.Point(118, 0);
            this.BtnVolUp.Name = "BtnVolUp";
            this.BtnVolUp.Size = new System.Drawing.Size(60, 60);
            this.BtnVolUp.TabIndex = 1;
            this.BtnVolUp.UseVisualStyleBackColor = true;
            this.BtnVolUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnInc_MouseDown);
            this.BtnVolUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnInc_MouseUp);
            // 
            // BtnMute
            // 
            this.BtnMute.FlatAppearance.BorderSize = 0;
            this.BtnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMute.Image = global::SimpleVolumeControl.Properties.Resources.sound_mute;
            this.BtnMute.Location = new System.Drawing.Point(59, 0);
            this.BtnMute.Name = "BtnMute";
            this.BtnMute.Size = new System.Drawing.Size(60, 60);
            this.BtnMute.TabIndex = 2;
            this.BtnMute.UseVisualStyleBackColor = true;
            this.BtnMute.Click += new System.EventHandler(this.BtnMute_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(178, 60);
            this.Controls.Add(this.BtnMute);
            this.Controls.Add(this.BtnVolUp);
            this.Controls.Add(this.BtnVolDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolDown;
        private System.Windows.Forms.Button BtnVolUp;
        private System.Windows.Forms.Button BtnMute;
    }
}

