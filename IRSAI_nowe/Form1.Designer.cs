namespace IRSAI_nowe
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_Get = new System.Windows.Forms.Button();
            this.textBox_Vactual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Current = new System.Windows.Forms.TextBox();
            this.button_Set = new System.Windows.Forms.Button();
            this.textBox_Vset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manual_control = new System.Windows.Forms.CheckBox();
            this.button_Ramp = new System.Windows.Forms.Button();
            this.cw_button = new System.Windows.Forms.RadioButton();
            this.ccw_button = new System.Windows.Forms.RadioButton();
            this.textBox_Ramp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Ramp_Read = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_Draw_Chart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(70, 12);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(114, 36);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(231, 12);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(114, 36);
            this.button_disconnect.TabIndex = 1;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.Button_disconnect_Click);
            // 
            // button_Get
            // 
            this.button_Get.Location = new System.Drawing.Point(70, 306);
            this.button_Get.Name = "button_Get";
            this.button_Get.Size = new System.Drawing.Size(114, 36);
            this.button_Get.TabIndex = 2;
            this.button_Get.Text = "Get";
            this.button_Get.UseVisualStyleBackColor = true;
            this.button_Get.Click += new System.EventHandler(this.Button_Get_Click);
            // 
            // textBox_Vactual
            // 
            this.textBox_Vactual.Location = new System.Drawing.Point(70, 348);
            this.textBox_Vactual.Name = "textBox_Vactual";
            this.textBox_Vactual.Size = new System.Drawing.Size(114, 20);
            this.textBox_Vactual.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "V actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current";
            // 
            // textBox_Current
            // 
            this.textBox_Current.Location = new System.Drawing.Point(70, 374);
            this.textBox_Current.Name = "textBox_Current";
            this.textBox_Current.Size = new System.Drawing.Size(114, 20);
            this.textBox_Current.TabIndex = 6;
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(70, 76);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(114, 36);
            this.button_Set.TabIndex = 9;
            this.button_Set.Text = "Set";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.Button_Set_Click);
            // 
            // textBox_Vset
            // 
            this.textBox_Vset.Location = new System.Drawing.Point(70, 118);
            this.textBox_Vset.Name = "textBox_Vset";
            this.textBox_Vset.Size = new System.Drawing.Size(114, 20);
            this.textBox_Vset.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "V set";
            // 
            // manual_control
            // 
            this.manual_control.AutoSize = true;
            this.manual_control.Checked = true;
            this.manual_control.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manual_control.Location = new System.Drawing.Point(213, 76);
            this.manual_control.Name = "manual_control";
            this.manual_control.Size = new System.Drawing.Size(95, 17);
            this.manual_control.TabIndex = 12;
            this.manual_control.Text = "manual control";
            this.manual_control.UseVisualStyleBackColor = true;
            this.manual_control.Click += new System.EventHandler(this.Manual_control_Checked);
            // 
            // button_Ramp
            // 
            this.button_Ramp.Location = new System.Drawing.Point(70, 164);
            this.button_Ramp.Name = "button_Ramp";
            this.button_Ramp.Size = new System.Drawing.Size(114, 36);
            this.button_Ramp.TabIndex = 13;
            this.button_Ramp.Text = "Ramp";
            this.button_Ramp.UseVisualStyleBackColor = true;
            this.button_Ramp.Click += new System.EventHandler(this.Button_Ramp_Click);
            // 
            // cw_button
            // 
            this.cw_button.AutoSize = true;
            this.cw_button.Checked = true;
            this.cw_button.Location = new System.Drawing.Point(213, 132);
            this.cw_button.Name = "cw_button";
            this.cw_button.Size = new System.Drawing.Size(40, 17);
            this.cw_button.TabIndex = 14;
            this.cw_button.TabStop = true;
            this.cw_button.Text = "Cw";
            this.cw_button.UseVisualStyleBackColor = true;
            this.cw_button.CheckedChanged += new System.EventHandler(this.Cw_button_Checked);
            // 
            // ccw_button
            // 
            this.ccw_button.AutoSize = true;
            this.ccw_button.Location = new System.Drawing.Point(213, 164);
            this.ccw_button.Name = "ccw_button";
            this.ccw_button.Size = new System.Drawing.Size(46, 17);
            this.ccw_button.TabIndex = 15;
            this.ccw_button.TabStop = true;
            this.ccw_button.Text = "Ccw";
            this.ccw_button.UseVisualStyleBackColor = true;
            this.ccw_button.CheckedChanged += new System.EventHandler(this.Ccw_button_Checked);
            // 
            // textBox_Ramp
            // 
            this.textBox_Ramp.Location = new System.Drawing.Point(70, 206);
            this.textBox_Ramp.Name = "textBox_Ramp";
            this.textBox_Ramp.Size = new System.Drawing.Size(114, 20);
            this.textBox_Ramp.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ramp";
            // 
            // textBox_Ramp_Read
            // 
            this.textBox_Ramp_Read.Location = new System.Drawing.Point(70, 232);
            this.textBox_Ramp_Read.Name = "textBox_Ramp_Read";
            this.textBox_Ramp_Read.Size = new System.Drawing.Size(114, 20);
            this.textBox_Ramp_Read.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ramp read";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(317, 118);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "V_actual";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "V_set";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(453, 305);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // button_Draw_Chart
            // 
            this.button_Draw_Chart.Location = new System.Drawing.Point(477, 65);
            this.button_Draw_Chart.Name = "button_Draw_Chart";
            this.button_Draw_Chart.Size = new System.Drawing.Size(114, 36);
            this.button_Draw_Chart.TabIndex = 21;
            this.button_Draw_Chart.Text = "Draw Chart";
            this.button_Draw_Chart.UseVisualStyleBackColor = true;
            this.button_Draw_Chart.Click += new System.EventHandler(this.Button_Draw_Chart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(782, 435);
            this.Controls.Add(this.button_Draw_Chart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Ramp_Read);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Ramp);
            this.Controls.Add(this.ccw_button);
            this.Controls.Add(this.cw_button);
            this.Controls.Add(this.button_Ramp);
            this.Controls.Add(this.manual_control);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Vset);
            this.Controls.Add(this.button_Set);
            this.Controls.Add(this.textBox_Current);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Vactual);
            this.Controls.Add(this.button_Get);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_Get;
        private System.Windows.Forms.TextBox textBox_Vactual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Current;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.TextBox textBox_Vset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox manual_control;
        private System.Windows.Forms.Button button_Ramp;
        private System.Windows.Forms.RadioButton cw_button;
        private System.Windows.Forms.RadioButton ccw_button;
        private System.Windows.Forms.TextBox textBox_Ramp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Ramp_Read;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_Draw_Chart;
    }
}

