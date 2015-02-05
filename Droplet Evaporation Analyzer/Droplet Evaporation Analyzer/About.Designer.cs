namespace Droplet_Evaporation_Analyzer
{
    partial class About
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
            this.label_header = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.label_GNU_GPL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Location = new System.Drawing.Point(68, 75);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(142, 13);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Droplet evaporation analyzer";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(113, 102);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(59, 13);
            this.label_version.TabIndex = 1;
            this.label_version.Text = "v. 0.5 Beta";
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Location = new System.Drawing.Point(11, 217);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(199, 13);
            this.label_copyright.TabIndex = 2;
            this.label_copyright.Text = "Copyright (c) 2015 Jakob Berg Johansen";
            // 
            // label_GNU_GPL
            // 
            this.label_GNU_GPL.AutoSize = true;
            this.label_GNU_GPL.Location = new System.Drawing.Point(11, 240);
            this.label_GNU_GPL.Name = "label_GNU_GPL";
            this.label_GNU_GPL.Size = new System.Drawing.Size(148, 13);
            this.label_GNU_GPL.TabIndex = 3;
            this.label_GNU_GPL.Text = "Released under GNU GPL v3";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_GNU_GPL);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_header);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.Label label_GNU_GPL;
    }
}