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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_all = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialConstantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label_d_p_end = new System.Windows.Forms.Label();
            this.textBox_d_p_end = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_T_d_end = new System.Windows.Forms.Label();
            this.textBox_T_d_end = new System.Windows.Forms.TextBox();
            this.label_p_inf_end = new System.Windows.Forms.Label();
            this.textBox_p_inf_end = new System.Windows.Forms.TextBox();
            this.label_T_inf_end = new System.Windows.Forms.Label();
            this.textBox_T_inf_end = new System.Windows.Forms.TextBox();
            this.label_evap_end = new System.Windows.Forms.Label();
            this.textBox_evap_end = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_chart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_all)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_all
            // 
            chartArea5.Name = "ChartArea1";
            chartArea6.Name = "ChartArea2";
            this.chart_all.ChartAreas.Add(chartArea5);
            this.chart_all.ChartAreas.Add(chartArea6);
            legend3.Name = "Legend1";
            this.chart_all.Legends.Add(legend3);
            this.chart_all.Location = new System.Drawing.Point(343, 266);
            this.chart_all.Name = "chart_all";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Droplet diameter";
            series10.ChartArea = "ChartArea2";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Droplet temperature";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Air temperature";
            series12.ChartArea = "ChartArea2";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Partial pressure of water";
            this.chart_all.Series.Add(series9);
            this.chart_all.Series.Add(series10);
            this.chart_all.Series.Add(series11);
            this.chart_all.Series.Add(series12);
            this.chart_all.Size = new System.Drawing.Size(491, 448);
            this.chart_all.TabIndex = 0;
            this.chart_all.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
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
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialConstantsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // materialConstantsToolStripMenuItem
            // 
            this.materialConstantsToolStripMenuItem.Name = "materialConstantsToolStripMenuItem";
            this.materialConstantsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.materialConstantsToolStripMenuItem.Text = "Material constants";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label_d_p_i
            // 
            this.label_d_p_i.AutoSize = true;
            this.label_d_p_i.Location = new System.Drawing.Point(9, 55);
            this.label_d_p_i.Name = "label_d_p_i";
            this.label_d_p_i.Size = new System.Drawing.Size(84, 13);
            this.label_d_p_i.TabIndex = 2;
            this.label_d_p_i.Text = "Droplet diameter";
            // 
            // textBox_d_p_i
            // 
            this.textBox_d_p_i.Location = new System.Drawing.Point(9, 72);
            this.textBox_d_p_i.Name = "textBox_d_p_i";
            this.textBox_d_p_i.Size = new System.Drawing.Size(100, 20);
            this.textBox_d_p_i.TabIndex = 3;
            this.textBox_d_p_i.Text = "100";
            this.textBox_d_p_i.MouseHover += new System.EventHandler(this.textBox_d_p_i_MouseHover);
            // 
            // textBox_T_d_i
            // 
            this.textBox_T_d_i.Location = new System.Drawing.Point(115, 72);
            this.textBox_T_d_i.Name = "textBox_T_d_i";
            this.textBox_T_d_i.Size = new System.Drawing.Size(100, 20);
            this.textBox_T_d_i.TabIndex = 5;
            this.textBox_T_d_i.Text = "293.15";
            this.textBox_T_d_i.MouseHover += new System.EventHandler(this.textBox_T_d_i_MouseHover);
            // 
            // label_T_d_i
            // 
            this.label_T_d_i.AutoSize = true;
            this.label_T_d_i.Location = new System.Drawing.Point(115, 55);
            this.label_T_d_i.Name = "label_T_d_i";
            this.label_T_d_i.Size = new System.Drawing.Size(100, 13);
            this.label_T_d_i.TabIndex = 4;
            this.label_T_d_i.Text = "Droplet temperature";
            // 
            // textBox_V_w
            // 
            this.textBox_V_w.Location = new System.Drawing.Point(221, 72);
            this.textBox_V_w.Name = "textBox_V_w";
            this.textBox_V_w.Size = new System.Drawing.Size(100, 20);
            this.textBox_V_w.TabIndex = 7;
            this.textBox_V_w.Text = "0.75";
            this.textBox_V_w.MouseHover += new System.EventHandler(this.textBox_V_w_MouseHover);
            // 
            // label_V_w
            // 
            this.label_V_w.AutoSize = true;
            this.label_V_w.Location = new System.Drawing.Point(221, 55);
            this.label_V_w.Name = "label_V_w";
            this.label_V_w.Size = new System.Drawing.Size(73, 13);
            this.label_V_w.TabIndex = 6;
            this.label_V_w.Text = "Water volume";
            // 
            // textBox_phi_inf_i
            // 
            this.textBox_phi_inf_i.Location = new System.Drawing.Point(9, 117);
            this.textBox_phi_inf_i.Name = "textBox_phi_inf_i";
            this.textBox_phi_inf_i.Size = new System.Drawing.Size(100, 20);
            this.textBox_phi_inf_i.TabIndex = 9;
            this.textBox_phi_inf_i.Text = "40";
            this.textBox_phi_inf_i.MouseHover += new System.EventHandler(this.textBox_phi_inf_i_MouseHover);
            // 
            // label_phi_inf_i
            // 
            this.label_phi_inf_i.AutoSize = true;
            this.label_phi_inf_i.Location = new System.Drawing.Point(9, 97);
            this.label_phi_inf_i.Name = "label_phi_inf_i";
            this.label_phi_inf_i.Size = new System.Drawing.Size(87, 13);
            this.label_phi_inf_i.TabIndex = 8;
            this.label_phi_inf_i.Text = "Relative humidity";
            // 
            // textBox_T_inf_i
            // 
            this.textBox_T_inf_i.Location = new System.Drawing.Point(115, 117);
            this.textBox_T_inf_i.Name = "textBox_T_inf_i";
            this.textBox_T_inf_i.Size = new System.Drawing.Size(100, 20);
            this.textBox_T_inf_i.TabIndex = 11;
            this.textBox_T_inf_i.Text = "303.15";
            this.textBox_T_inf_i.MouseHover += new System.EventHandler(this.textBox_T_inf_i_MouseHover);
            // 
            // label_T_inf_i
            // 
            this.label_T_inf_i.AutoSize = true;
            this.label_T_inf_i.Location = new System.Drawing.Point(115, 97);
            this.label_T_inf_i.Name = "label_T_inf_i";
            this.label_T_inf_i.Size = new System.Drawing.Size(78, 13);
            this.label_T_inf_i.TabIndex = 10;
            this.label_T_inf_i.Text = "Air temperature";
            // 
            // textBox_V_a
            // 
            this.textBox_V_a.Location = new System.Drawing.Point(221, 117);
            this.textBox_V_a.Name = "textBox_V_a";
            this.textBox_V_a.Size = new System.Drawing.Size(100, 20);
            this.textBox_V_a.TabIndex = 13;
            this.textBox_V_a.Text = "40";
            this.textBox_V_a.MouseHover += new System.EventHandler(this.textBox_V_a_MouseHover);
            // 
            // label_V_a
            // 
            this.label_V_a.AutoSize = true;
            this.label_V_a.Location = new System.Drawing.Point(224, 96);
            this.label_V_a.Name = "label_V_a";
            this.label_V_a.Size = new System.Drawing.Size(56, 13);
            this.label_V_a.TabIndex = 12;
            this.label_V_a.Text = "Air volume";
            // 
            // textBox_delta_t
            // 
            this.textBox_delta_t.Location = new System.Drawing.Point(9, 162);
            this.textBox_delta_t.Name = "textBox_delta_t";
            this.textBox_delta_t.Size = new System.Drawing.Size(100, 20);
            this.textBox_delta_t.TabIndex = 15;
            this.textBox_delta_t.Text = "0.001";
            this.textBox_delta_t.MouseHover += new System.EventHandler(this.textBox_delta_t_MouseHover);
            // 
            // label_delta_t
            // 
            this.label_delta_t.AutoSize = true;
            this.label_delta_t.Location = new System.Drawing.Point(8, 145);
            this.label_delta_t.Name = "label_delta_t";
            this.label_delta_t.Size = new System.Drawing.Size(53, 13);
            this.label_delta_t.TabIndex = 14;
            this.label_delta_t.Text = "Time step";
            // 
            // textBox_tf
            // 
            this.textBox_tf.Location = new System.Drawing.Point(115, 162);
            this.textBox_tf.Name = "textBox_tf";
            this.textBox_tf.Size = new System.Drawing.Size(100, 20);
            this.textBox_tf.TabIndex = 17;
            this.textBox_tf.Text = "1";
            this.textBox_tf.MouseHover += new System.EventHandler(this.textBox_tf_MouseHover);
            // 
            // label_tf
            // 
            this.label_tf.AutoSize = true;
            this.label_tf.Location = new System.Drawing.Point(115, 145);
            this.label_tf.Name = "label_tf";
            this.label_tf.Size = new System.Drawing.Size(30, 13);
            this.label_tf.TabIndex = 16;
            this.label_tf.Text = "Time";
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(12, 189);
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
            this.label_Error.Location = new System.Drawing.Point(340, 78);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(71, 13);
            this.label_Error.TabIndex = 19;
            this.label_Error.Text = "Error: no error";
            // 
            // textBox_number_of_data_points
            // 
            this.textBox_number_of_data_points.Location = new System.Drawing.Point(8, 417);
            this.textBox_number_of_data_points.Name = "textBox_number_of_data_points";
            this.textBox_number_of_data_points.Size = new System.Drawing.Size(100, 20);
            this.textBox_number_of_data_points.TabIndex = 20;
            // 
            // label_number_of_data_points
            // 
            this.label_number_of_data_points.AutoSize = true;
            this.label_number_of_data_points.Location = new System.Drawing.Point(8, 401);
            this.label_number_of_data_points.Name = "label_number_of_data_points";
            this.label_number_of_data_points.Size = new System.Drawing.Size(111, 13);
            this.label_number_of_data_points.TabIndex = 21;
            this.label_number_of_data_points.Text = "Number of data points";
            // 
            // label_d_p_end
            // 
            this.label_d_p_end.AutoSize = true;
            this.label_d_p_end.Location = new System.Drawing.Point(9, 266);
            this.label_d_p_end.Name = "label_d_p_end";
            this.label_d_p_end.Size = new System.Drawing.Size(84, 13);
            this.label_d_p_end.TabIndex = 23;
            this.label_d_p_end.Text = "Droplet diameter";
            // 
            // textBox_d_p_end
            // 
            this.textBox_d_p_end.Location = new System.Drawing.Point(9, 282);
            this.textBox_d_p_end.Name = "textBox_d_p_end";
            this.textBox_d_p_end.Size = new System.Drawing.Size(100, 20);
            this.textBox_d_p_end.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Result";
            // 
            // label_T_d_end
            // 
            this.label_T_d_end.AutoSize = true;
            this.label_T_d_end.Location = new System.Drawing.Point(137, 266);
            this.label_T_d_end.Name = "label_T_d_end";
            this.label_T_d_end.Size = new System.Drawing.Size(100, 13);
            this.label_T_d_end.TabIndex = 26;
            this.label_T_d_end.Text = "Droplet temperature";
            // 
            // textBox_T_d_end
            // 
            this.textBox_T_d_end.Location = new System.Drawing.Point(137, 282);
            this.textBox_T_d_end.Name = "textBox_T_d_end";
            this.textBox_T_d_end.Size = new System.Drawing.Size(100, 20);
            this.textBox_T_d_end.TabIndex = 25;
            // 
            // label_p_inf_end
            // 
            this.label_p_inf_end.AutoSize = true;
            this.label_p_inf_end.Location = new System.Drawing.Point(9, 305);
            this.label_p_inf_end.Name = "label_p_inf_end";
            this.label_p_inf_end.Size = new System.Drawing.Size(120, 13);
            this.label_p_inf_end.TabIndex = 28;
            this.label_p_inf_end.Text = "Partial pressure of water";
            // 
            // textBox_p_inf_end
            // 
            this.textBox_p_inf_end.Location = new System.Drawing.Point(9, 321);
            this.textBox_p_inf_end.Name = "textBox_p_inf_end";
            this.textBox_p_inf_end.Size = new System.Drawing.Size(100, 20);
            this.textBox_p_inf_end.TabIndex = 27;
            // 
            // label_T_inf_end
            // 
            this.label_T_inf_end.AutoSize = true;
            this.label_T_inf_end.Location = new System.Drawing.Point(137, 305);
            this.label_T_inf_end.Name = "label_T_inf_end";
            this.label_T_inf_end.Size = new System.Drawing.Size(78, 13);
            this.label_T_inf_end.TabIndex = 30;
            this.label_T_inf_end.Text = "Air temperature";
            // 
            // textBox_T_inf_end
            // 
            this.textBox_T_inf_end.Location = new System.Drawing.Point(137, 321);
            this.textBox_T_inf_end.Name = "textBox_T_inf_end";
            this.textBox_T_inf_end.Size = new System.Drawing.Size(100, 20);
            this.textBox_T_inf_end.TabIndex = 29;
            // 
            // label_evap_end
            // 
            this.label_evap_end.AutoSize = true;
            this.label_evap_end.Location = new System.Drawing.Point(8, 352);
            this.label_evap_end.Name = "label_evap_end";
            this.label_evap_end.Size = new System.Drawing.Size(160, 13);
            this.label_evap_end.TabIndex = 32;
            this.label_evap_end.Text = "Percentage of water evaporated";
            // 
            // textBox_evap_end
            // 
            this.textBox_evap_end.Location = new System.Drawing.Point(8, 368);
            this.textBox_evap_end.Name = "textBox_evap_end";
            this.textBox_evap_end.Size = new System.Drawing.Size(100, 20);
            this.textBox_evap_end.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Initiate";
            // 
            // comboBox_chart
            // 
            this.comboBox_chart.FormattingEnabled = true;
            this.comboBox_chart.Items.AddRange(new object[] {
            "Droplet diameter and droplet temperature",
            "Air temperature and partial pressure of water"});
            this.comboBox_chart.Location = new System.Drawing.Point(343, 239);
            this.comboBox_chart.Name = "comboBox_chart";
            this.comboBox_chart.Size = new System.Drawing.Size(245, 21);
            this.comboBox_chart.TabIndex = 34;
            this.comboBox_chart.Text = "Droplet diameter and droplet temperature";
            this.comboBox_chart.SelectedIndexChanged += new System.EventHandler(this.comboBox_chart_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 784);
            this.Controls.Add(this.comboBox_chart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_evap_end);
            this.Controls.Add(this.textBox_evap_end);
            this.Controls.Add(this.label_T_inf_end);
            this.Controls.Add(this.textBox_T_inf_end);
            this.Controls.Add(this.label_p_inf_end);
            this.Controls.Add(this.textBox_p_inf_end);
            this.Controls.Add(this.label_T_d_end);
            this.Controls.Add(this.textBox_T_d_end);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_d_p_end);
            this.Controls.Add(this.textBox_d_p_end);
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
            this.Controls.Add(this.chart_all);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Droplet Evaporation Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.chart_all)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_all;
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
        private System.Windows.Forms.Label label_d_p_end;
        private System.Windows.Forms.TextBox textBox_d_p_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_T_d_end;
        private System.Windows.Forms.TextBox textBox_T_d_end;
        private System.Windows.Forms.Label label_p_inf_end;
        private System.Windows.Forms.TextBox textBox_p_inf_end;
        private System.Windows.Forms.Label label_T_inf_end;
        private System.Windows.Forms.TextBox textBox_T_inf_end;
        private System.Windows.Forms.Label label_evap_end;
        private System.Windows.Forms.TextBox textBox_evap_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_chart;
    }
}

