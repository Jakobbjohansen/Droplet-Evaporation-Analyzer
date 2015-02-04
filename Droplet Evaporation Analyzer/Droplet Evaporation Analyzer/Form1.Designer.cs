namespace Droplet_Evaporation_Analyzer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialConstantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_d_p_i = new System.Windows.Forms.Label();
            this.textBox_d_p_i = new System.Windows.Forms.TextBox();
            this.textBox_T_d_i = new System.Windows.Forms.TextBox();
            this.label_T_d_i = new System.Windows.Forms.Label();
            this.textBox_V_w = new System.Windows.Forms.TextBox();
            this.label_V_w = new System.Windows.Forms.Label();
            this.textBox_phi_inf_i = new System.Windows.Forms.TextBox();
            this.label_phi_inf_i = new System.Windows.Forms.Label();
            this.textBox_T_inf_i = new System.Windows.Forms.TextBox();
            this.label_T_inf_i = new System.Windows.Forms.Label();
            this.textBox_V_a = new System.Windows.Forms.TextBox();
            this.label_V_a = new System.Windows.Forms.Label();
            this.textBox_delta_t = new System.Windows.Forms.TextBox();
            this.label_delta_t = new System.Windows.Forms.Label();
            this.textBox_tf = new System.Windows.Forms.TextBox();
            this.label_tf = new System.Windows.Forms.Label();
            this.button_Run = new System.Windows.Forms.Button();
            this.label_Error = new System.Windows.Forms.Label();
            this.textBox_number_of_data_points = new System.Windows.Forms.TextBox();
            this.label_number_of_data_points = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 265);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialConstantsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // materialConstantsToolStripMenuItem
            // 
            this.materialConstantsToolStripMenuItem.Name = "materialConstantsToolStripMenuItem";
            this.materialConstantsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.materialConstantsToolStripMenuItem.Text = "Material constants";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label_d_p_i
            // 
            this.label_d_p_i.AutoSize = true;
            this.label_d_p_i.Location = new System.Drawing.Point(13, 28);
            this.label_d_p_i.Name = "label_d_p_i";
            this.label_d_p_i.Size = new System.Drawing.Size(84, 13);
            this.label_d_p_i.TabIndex = 2;
            this.label_d_p_i.Text = "Droplet diameter";
            // 
            // textBox_d_p_i
            // 
            this.textBox_d_p_i.Location = new System.Drawing.Point(13, 45);
            this.textBox_d_p_i.Name = "textBox_d_p_i";
            this.textBox_d_p_i.Size = new System.Drawing.Size(100, 20);
            this.textBox_d_p_i.TabIndex = 3;
            this.textBox_d_p_i.Text = "100";
            // 
            // textBox_T_d_i
            // 
            this.textBox_T_d_i.Location = new System.Drawing.Point(119, 45);
            this.textBox_T_d_i.Name = "textBox_T_d_i";
            this.textBox_T_d_i.Size = new System.Drawing.Size(100, 20);
            this.textBox_T_d_i.TabIndex = 5;
            this.textBox_T_d_i.Text = "293.15";
            // 
            // label_T_d_i
            // 
            this.label_T_d_i.AutoSize = true;
            this.label_T_d_i.Location = new System.Drawing.Point(119, 28);
            this.label_T_d_i.Name = "label_T_d_i";
            this.label_T_d_i.Size = new System.Drawing.Size(100, 13);
            this.label_T_d_i.TabIndex = 4;
            this.label_T_d_i.Text = "Droplet temperature";
            // 
            // textBox_V_w
            // 
            this.textBox_V_w.Location = new System.Drawing.Point(225, 45);
            this.textBox_V_w.Name = "textBox_V_w";
            this.textBox_V_w.Size = new System.Drawing.Size(100, 20);
            this.textBox_V_w.TabIndex = 7;
            this.textBox_V_w.Text = "0.75";
            // 
            // label_V_w
            // 
            this.label_V_w.AutoSize = true;
            this.label_V_w.Location = new System.Drawing.Point(225, 28);
            this.label_V_w.Name = "label_V_w";
            this.label_V_w.Size = new System.Drawing.Size(73, 13);
            this.label_V_w.TabIndex = 6;
            this.label_V_w.Text = "Water volume";
            // 
            // textBox_phi_inf_i
            // 
            this.textBox_phi_inf_i.Location = new System.Drawing.Point(13, 90);
            this.textBox_phi_inf_i.Name = "textBox_phi_inf_i";
            this.textBox_phi_inf_i.Size = new System.Drawing.Size(100, 20);
            this.textBox_phi_inf_i.TabIndex = 9;
            this.textBox_phi_inf_i.Text = "40";
            // 
            // label_phi_inf_i
            // 
            this.label_phi_inf_i.AutoSize = true;
            this.label_phi_inf_i.Location = new System.Drawing.Point(13, 70);
            this.label_phi_inf_i.Name = "label_phi_inf_i";
            this.label_phi_inf_i.Size = new System.Drawing.Size(87, 13);
            this.label_phi_inf_i.TabIndex = 8;
            this.label_phi_inf_i.Text = "Relative humidity";
            // 
            // textBox_T_inf_i
            // 
            this.textBox_T_inf_i.Location = new System.Drawing.Point(119, 90);
            this.textBox_T_inf_i.Name = "textBox_T_inf_i";
            this.textBox_T_inf_i.Size = new System.Drawing.Size(100, 20);
            this.textBox_T_inf_i.TabIndex = 11;
            this.textBox_T_inf_i.Text = "303.15";
            // 
            // label_T_inf_i
            // 
            this.label_T_inf_i.AutoSize = true;
            this.label_T_inf_i.Location = new System.Drawing.Point(119, 70);
            this.label_T_inf_i.Name = "label_T_inf_i";
            this.label_T_inf_i.Size = new System.Drawing.Size(78, 13);
            this.label_T_inf_i.TabIndex = 10;
            this.label_T_inf_i.Text = "Air temperature";
            // 
            // textBox_V_a
            // 
            this.textBox_V_a.Location = new System.Drawing.Point(225, 90);
            this.textBox_V_a.Name = "textBox_V_a";
            this.textBox_V_a.Size = new System.Drawing.Size(100, 20);
            this.textBox_V_a.TabIndex = 13;
            this.textBox_V_a.Text = "40";
            // 
            // label_V_a
            // 
            this.label_V_a.AutoSize = true;
            this.label_V_a.Location = new System.Drawing.Point(228, 69);
            this.label_V_a.Name = "label_V_a";
            this.label_V_a.Size = new System.Drawing.Size(56, 13);
            this.label_V_a.TabIndex = 12;
            this.label_V_a.Text = "Air volume";
            // 
            // textBox_delta_t
            // 
            this.textBox_delta_t.Location = new System.Drawing.Point(13, 135);
            this.textBox_delta_t.Name = "textBox_delta_t";
            this.textBox_delta_t.Size = new System.Drawing.Size(100, 20);
            this.textBox_delta_t.TabIndex = 15;
            this.textBox_delta_t.Text = "0.001";
            // 
            // label_delta_t
            // 
            this.label_delta_t.AutoSize = true;
            this.label_delta_t.Location = new System.Drawing.Point(12, 118);
            this.label_delta_t.Name = "label_delta_t";
            this.label_delta_t.Size = new System.Drawing.Size(53, 13);
            this.label_delta_t.TabIndex = 14;
            this.label_delta_t.Text = "Time step";
            // 
            // textBox_tf
            // 
            this.textBox_tf.Location = new System.Drawing.Point(119, 135);
            this.textBox_tf.Name = "textBox_tf";
            this.textBox_tf.Size = new System.Drawing.Size(100, 20);
            this.textBox_tf.TabIndex = 17;
            this.textBox_tf.Text = "1";
            // 
            // label_tf
            // 
            this.label_tf.AutoSize = true;
            this.label_tf.Location = new System.Drawing.Point(119, 118);
            this.label_tf.Name = "label_tf";
            this.label_tf.Size = new System.Drawing.Size(30, 13);
            this.label_tf.TabIndex = 16;
            this.label_tf.Text = "Time";
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(16, 162);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(75, 23);
            this.button_Run.TabIndex = 18;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Location = new System.Drawing.Point(344, 51);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(71, 13);
            this.label_Error.TabIndex = 19;
            this.label_Error.Text = "Error: no error";
            // 
            // textBox_number_of_data_points
            // 
            this.textBox_number_of_data_points.Location = new System.Drawing.Point(13, 218);
            this.textBox_number_of_data_points.Name = "textBox_number_of_data_points";
            this.textBox_number_of_data_points.Size = new System.Drawing.Size(100, 20);
            this.textBox_number_of_data_points.TabIndex = 20;
            // 
            // label_number_of_data_points
            // 
            this.label_number_of_data_points.AutoSize = true;
            this.label_number_of_data_points.Location = new System.Drawing.Point(13, 202);
            this.label_number_of_data_points.Name = "label_number_of_data_points";
            this.label_number_of_data_points.Size = new System.Drawing.Size(111, 13);
            this.label_number_of_data_points.TabIndex = 21;
            this.label_number_of_data_points.Text = "Number of data points";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 784);
            this.Controls.Add(this.label_number_of_data_points);
            this.Controls.Add(this.textBox_number_of_data_points);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.textBox_tf);
            this.Controls.Add(this.label_tf);
            this.Controls.Add(this.textBox_delta_t);
            this.Controls.Add(this.label_delta_t);
            this.Controls.Add(this.textBox_V_a);
            this.Controls.Add(this.label_V_a);
            this.Controls.Add(this.textBox_T_inf_i);
            this.Controls.Add(this.label_T_inf_i);
            this.Controls.Add(this.textBox_phi_inf_i);
            this.Controls.Add(this.label_phi_inf_i);
            this.Controls.Add(this.textBox_V_w);
            this.Controls.Add(this.label_V_w);
            this.Controls.Add(this.textBox_T_d_i);
            this.Controls.Add(this.label_T_d_i);
            this.Controls.Add(this.textBox_d_p_i);
            this.Controls.Add(this.label_d_p_i);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Droplet Evaporation Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialConstantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label_d_p_i;
        private System.Windows.Forms.TextBox textBox_d_p_i;
        private System.Windows.Forms.TextBox textBox_T_d_i;
        private System.Windows.Forms.Label label_T_d_i;
        private System.Windows.Forms.TextBox textBox_V_w;
        private System.Windows.Forms.Label label_V_w;
        private System.Windows.Forms.TextBox textBox_phi_inf_i;
        private System.Windows.Forms.Label label_phi_inf_i;
        private System.Windows.Forms.TextBox textBox_T_inf_i;
        private System.Windows.Forms.Label label_T_inf_i;
        private System.Windows.Forms.TextBox textBox_V_a;
        private System.Windows.Forms.Label label_V_a;
        private System.Windows.Forms.TextBox textBox_delta_t;
        private System.Windows.Forms.Label label_delta_t;
        private System.Windows.Forms.TextBox textBox_tf;
        private System.Windows.Forms.Label label_tf;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.TextBox textBox_number_of_data_points;
        private System.Windows.Forms.Label label_number_of_data_points;
    }
}

