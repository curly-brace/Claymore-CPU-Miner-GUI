namespace CPUMinerGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.poolsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.notesText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.lowCpuCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.threadsText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.instancesList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.win32Check = new System.Windows.Forms.RadioButton();
            this.win64Check = new System.Windows.Forms.RadioButton();
            this.lowCPUText = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.hashrateTimer = new System.Windows.Forms.Timer(this.components);
            this.fullHashrateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hashChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashChart)).BeginInit();
            this.SuspendLayout();
            // 
            // poolsList
            // 
            this.poolsList.FormattingEnabled = true;
            this.poolsList.Location = new System.Drawing.Point(12, 528);
            this.poolsList.Name = "poolsList";
            this.poolsList.Size = new System.Drawing.Size(610, 121);
            this.poolsList.TabIndex = 0;
            this.poolsList.SelectedIndexChanged += new System.EventHandler(this.poolsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address (stratum+tcp://xxx.pool.com:1234)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(14, 450);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(500, 20);
            this.addressText.TabIndex = 4;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(46, 476);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(200, 20);
            this.userText.TabIndex = 5;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(314, 476);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(200, 20);
            this.passwordText.TabIndex = 6;
            // 
            // notesText
            // 
            this.notesText.Location = new System.Drawing.Point(52, 502);
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(462, 20);
            this.notesText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Notes";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(520, 448);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(520, 474);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(520, 500);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(102, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // lowCpuCheck
            // 
            this.lowCpuCheck.AutoSize = true;
            this.lowCpuCheck.Location = new System.Drawing.Point(81, 15);
            this.lowCpuCheck.Name = "lowCpuCheck";
            this.lowCpuCheck.Size = new System.Drawing.Size(67, 17);
            this.lowCpuCheck.TabIndex = 12;
            this.lowCpuCheck.Text = "low CPU";
            this.lowCpuCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Threads";
            // 
            // threadsText
            // 
            this.threadsText.Location = new System.Drawing.Point(53, 13);
            this.threadsText.Name = "threadsText";
            this.threadsText.Size = new System.Drawing.Size(20, 20);
            this.threadsText.TabIndex = 14;
            this.threadsText.Text = "0";
            this.threadsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "threads = L3 cache / 2\r\n0 means autoselection";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 52);
            this.label7.TabIndex = 16;
            this.label7.Text = "low CPU mode uses single thread\r\nbut it is better than threads=1\r\ntwo variants ar" +
    "e possible (1 or 2)\r\nwhich is better, depends on CPU";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instancesList
            // 
            this.instancesList.FormattingEnabled = true;
            this.instancesList.Location = new System.Drawing.Point(12, 12);
            this.instancesList.Name = "instancesList";
            this.instancesList.Size = new System.Drawing.Size(430, 121);
            this.instancesList.TabIndex = 17;
            this.instancesList.SelectedIndexChanged += new System.EventHandler(this.instancesList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.win32Check);
            this.groupBox1.Controls.Add(this.win64Check);
            this.groupBox1.Controls.Add(this.lowCPUText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.threadsText);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lowCpuCheck);
            this.groupBox1.Location = new System.Drawing.Point(448, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 153);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New instance";
            // 
            // win32Check
            // 
            this.win32Check.AutoSize = true;
            this.win32Check.Location = new System.Drawing.Point(6, 115);
            this.win32Check.Name = "win32Check";
            this.win32Check.Size = new System.Drawing.Size(53, 17);
            this.win32Check.TabIndex = 26;
            this.win32Check.Text = "win32";
            this.win32Check.UseVisualStyleBackColor = true;
            // 
            // win64Check
            // 
            this.win64Check.AutoSize = true;
            this.win64Check.Checked = true;
            this.win64Check.Location = new System.Drawing.Point(6, 131);
            this.win64Check.Name = "win64Check";
            this.win64Check.Size = new System.Drawing.Size(53, 17);
            this.win64Check.TabIndex = 27;
            this.win64Check.TabStop = true;
            this.win64Check.Text = "win64";
            this.win64Check.UseVisualStyleBackColor = true;
            // 
            // lowCPUText
            // 
            this.lowCPUText.Location = new System.Drawing.Point(148, 13);
            this.lowCPUText.Name = "lowCPUText";
            this.lowCPUText.Size = new System.Drawing.Size(20, 20);
            this.lowCPUText.TabIndex = 18;
            this.lowCPUText.Text = "1";
            this.lowCPUText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(63, 117);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 31);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "Start instance";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(351, 139);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(91, 23);
            this.stopButton.TabIndex = 20;
            this.stopButton.Text = "Stop instance";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // showButton
            // 
            this.showButton.Enabled = false;
            this.showButton.Location = new System.Drawing.Point(157, 139);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(91, 23);
            this.showButton.TabIndex = 21;
            this.showButton.Text = "Show window";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Enabled = false;
            this.hideButton.Location = new System.Drawing.Point(254, 139);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(91, 23);
            this.hideButton.TabIndex = 22;
            this.hideButton.Text = "Hide window";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // hashrateTimer
            // 
            this.hashrateTimer.Interval = 2000;
            this.hashrateTimer.Tick += new System.EventHandler(this.hashrateTimer_Tick);
            // 
            // fullHashrateLabel
            // 
            this.fullHashrateLabel.AutoSize = true;
            this.fullHashrateLabel.Location = new System.Drawing.Point(86, 144);
            this.fullHashrateLabel.Name = "fullHashrateLabel";
            this.fullHashrateLabel.Size = new System.Drawing.Size(13, 13);
            this.fullHashrateLabel.TabIndex = 23;
            this.fullHashrateLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Full Hashrate";
            // 
            // hashChart
            // 
            this.hashChart.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.SpringGreen;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.PaleGreen;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.SpringGreen;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            chartArea1.BorderColor = System.Drawing.Color.Red;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.ForestGreen;
            this.hashChart.ChartAreas.Add(chartArea1);
            this.hashChart.Location = new System.Drawing.Point(12, 168);
            this.hashChart.Name = "hashChart";
            this.hashChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.BorderColor = System.Drawing.Color.Lime;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.hashChart.Series.Add(series1);
            this.hashChart.Size = new System.Drawing.Size(607, 263);
            this.hashChart.TabIndex = 25;
            this.hashChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.hashChart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fullHashrateLabel);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.instancesList);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notesText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poolsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Claymore CPU miner GUI by Curly Brace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox poolsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox notesText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.CheckBox lowCpuCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox threadsText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox instancesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Timer hashrateTimer;
        private System.Windows.Forms.Label fullHashrateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lowCPUText;
        private System.Windows.Forms.RadioButton win32Check;
        private System.Windows.Forms.RadioButton win64Check;
        private System.Windows.Forms.DataVisualization.Charting.Chart hashChart;
    }
}

