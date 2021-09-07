
namespace ScreenDimmer.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.IgnoreFullscreenCb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IgnorePrimaryCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IgnoreFullscreenCb
            // 
            this.IgnoreFullscreenCb.AutoSize = true;
            this.IgnoreFullscreenCb.Location = new System.Drawing.Point(12, 35);
            this.IgnoreFullscreenCb.Name = "IgnoreFullscreenCb";
            this.IgnoreFullscreenCb.Size = new System.Drawing.Size(104, 17);
            this.IgnoreFullscreenCb.TabIndex = 0;
            this.IgnoreFullscreenCb.Text = "Ignore fullscreen";
            this.IgnoreFullscreenCb.UseVisualStyleBackColor = true;
            this.IgnoreFullscreenCb.Visible = false;
            this.IgnoreFullscreenCb.CheckedChanged += new System.EventHandler(this.IgnoreFullscreenCb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.MaximumSize = new System.Drawing.Size(220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press Ctrl + NumDecimal (NumPeriod / NumDelete) to toggle dimming.";
            // 
            // IgnorePrimaryCb
            // 
            this.IgnorePrimaryCb.AutoSize = true;
            this.IgnorePrimaryCb.Checked = true;
            this.IgnorePrimaryCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IgnorePrimaryCb.Location = new System.Drawing.Point(12, 12);
            this.IgnorePrimaryCb.Name = "IgnorePrimaryCb";
            this.IgnorePrimaryCb.Size = new System.Drawing.Size(92, 17);
            this.IgnorePrimaryCb.TabIndex = 2;
            this.IgnorePrimaryCb.Text = "Ignore primary";
            this.IgnorePrimaryCb.UseVisualStyleBackColor = true;
            this.IgnorePrimaryCb.Visible = false;
            this.IgnorePrimaryCb.CheckedChanged += new System.EventHandler(this.IgnorePrimaryCb_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.IgnorePrimaryCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IgnoreFullscreenCb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings - ScreenDimmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IgnoreFullscreenCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IgnorePrimaryCb;
    }
}