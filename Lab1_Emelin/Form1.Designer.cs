
namespace Lab1_Emelin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLaunch = new System.Windows.Forms.Button();
            this.CheckTrajectories = new System.Windows.Forms.CheckBox();
            this.LblTimeStepTracker = new System.Windows.Forms.Label();
            this.EdSize = new System.Windows.Forms.NumericUpDown();
            this.EdWeight = new System.Windows.Forms.NumericUpDown();
            this.LblWeight = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.TrackTimeStep = new System.Windows.Forms.TrackBar();
            this.EdSpeed = new System.Windows.Forms.NumericUpDown();
            this.EdAngle = new System.Windows.Forms.NumericUpDown();
            this.LblAngle = new System.Windows.Forms.Label();
            this.LblSpeed = new System.Windows.Forms.Label();
            this.EdHeight = new System.Windows.Forms.NumericUpDown();
            this.LblHeight = new System.Windows.Forms.Label();
            this.LblSpeedAtTheEndPointOutp = new System.Windows.Forms.Label();
            this.LblSpeedAtTheEndPoint = new System.Windows.Forms.Label();
            this.LblTimeStepOutp = new System.Windows.Forms.Label();
            this.LblTimeStep = new System.Windows.Forms.Label();
            this.LblMaxHeightOutp = new System.Windows.Forms.Label();
            this.LblDistanceOutp = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblMaxHeight = new System.Windows.Forms.Label();
            this.LblDistance = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLaunch);
            this.panel1.Controls.Add(this.CheckTrajectories);
            this.panel1.Controls.Add(this.LblTimeStepTracker);
            this.panel1.Controls.Add(this.EdSize);
            this.panel1.Controls.Add(this.EdWeight);
            this.panel1.Controls.Add(this.LblWeight);
            this.panel1.Controls.Add(this.LblArea);
            this.panel1.Controls.Add(this.TrackTimeStep);
            this.panel1.Controls.Add(this.EdSpeed);
            this.panel1.Controls.Add(this.EdAngle);
            this.panel1.Controls.Add(this.LblAngle);
            this.panel1.Controls.Add(this.LblSpeed);
            this.panel1.Controls.Add(this.EdHeight);
            this.panel1.Controls.Add(this.LblHeight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 122);
            this.panel1.TabIndex = 0;
            // 
            // BtnLaunch
            // 
            this.BtnLaunch.Location = new System.Drawing.Point(841, 65);
            this.BtnLaunch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLaunch.Name = "BtnLaunch";
            this.BtnLaunch.Size = new System.Drawing.Size(106, 37);
            this.BtnLaunch.TabIndex = 1;
            this.BtnLaunch.Text = "Launch";
            this.BtnLaunch.UseVisualStyleBackColor = true;
            this.BtnLaunch.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // CheckTrajectories
            // 
            this.CheckTrajectories.AutoSize = true;
            this.CheckTrajectories.Location = new System.Drawing.Point(699, 73);
            this.CheckTrajectories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckTrajectories.Name = "CheckTrajectories";
            this.CheckTrajectories.Size = new System.Drawing.Size(122, 17);
            this.CheckTrajectories.TabIndex = 1;
            this.CheckTrajectories.Text = "Compare trajectories";
            this.CheckTrajectories.UseVisualStyleBackColor = true;
            // 
            // LblTimeStepTracker
            // 
            this.LblTimeStepTracker.AutoSize = true;
            this.LblTimeStepTracker.Location = new System.Drawing.Point(21, 77);
            this.LblTimeStepTracker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTimeStepTracker.Name = "LblTimeStepTracker";
            this.LblTimeStepTracker.Size = new System.Drawing.Size(92, 13);
            this.LblTimeStepTracker.TabIndex = 8;
            this.LblTimeStepTracker.Text = "Time step tracker:";
            // 
            // EdSize
            // 
            this.EdSize.DecimalPlaces = 2;
            this.EdSize.Location = new System.Drawing.Point(626, 22);
            this.EdSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EdSize.Name = "EdSize";
            this.EdSize.Size = new System.Drawing.Size(90, 20);
            this.EdSize.TabIndex = 4;
            this.EdSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EdWeight
            // 
            this.EdWeight.DecimalPlaces = 2;
            this.EdWeight.Location = new System.Drawing.Point(262, 24);
            this.EdWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EdWeight.Name = "EdWeight";
            this.EdWeight.Size = new System.Drawing.Size(90, 20);
            this.EdWeight.TabIndex = 6;
            this.EdWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EdWeight.ValueChanged += new System.EventHandler(this.EdWeight_ValueChanged);
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Location = new System.Drawing.Point(198, 24);
            this.LblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(44, 13);
            this.LblWeight.TabIndex = 5;
            this.LblWeight.Text = "Weight:";
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Location = new System.Drawing.Point(572, 24);
            this.LblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(30, 13);
            this.LblArea.TabIndex = 7;
            this.LblArea.Text = "Size:";
            // 
            // TrackTimeStep
            // 
            this.TrackTimeStep.LargeChange = 1;
            this.TrackTimeStep.Location = new System.Drawing.Point(124, 73);
            this.TrackTimeStep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackTimeStep.Minimum = 1;
            this.TrackTimeStep.Name = "TrackTimeStep";
            this.TrackTimeStep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrackTimeStep.Size = new System.Drawing.Size(168, 45);
            this.TrackTimeStep.SmallChange = 10;
            this.TrackTimeStep.TabIndex = 1;
            this.TrackTimeStep.Value = 1;
            // 
            // EdSpeed
            // 
            this.EdSpeed.DecimalPlaces = 2;
            this.EdSpeed.Location = new System.Drawing.Point(841, 22);
            this.EdSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EdSpeed.Name = "EdSpeed";
            this.EdSpeed.Size = new System.Drawing.Size(90, 20);
            this.EdSpeed.TabIndex = 2;
            this.EdSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // EdAngle
            // 
            this.EdAngle.DecimalPlaces = 2;
            this.EdAngle.Location = new System.Drawing.Point(443, 22);
            this.EdAngle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EdAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.EdAngle.Name = "EdAngle";
            this.EdAngle.Size = new System.Drawing.Size(90, 20);
            this.EdAngle.TabIndex = 3;
            this.EdAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // LblAngle
            // 
            this.LblAngle.AutoSize = true;
            this.LblAngle.Location = new System.Drawing.Point(386, 24);
            this.LblAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAngle.Name = "LblAngle";
            this.LblAngle.Size = new System.Drawing.Size(37, 13);
            this.LblAngle.TabIndex = 2;
            this.LblAngle.Text = "Angle:";
            // 
            // LblSpeed
            // 
            this.LblSpeed.AutoSize = true;
            this.LblSpeed.Location = new System.Drawing.Point(767, 24);
            this.LblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSpeed.Name = "LblSpeed";
            this.LblSpeed.Size = new System.Drawing.Size(41, 13);
            this.LblSpeed.TabIndex = 3;
            this.LblSpeed.Text = "Speed:";
            // 
            // EdHeight
            // 
            this.EdHeight.DecimalPlaces = 2;
            this.EdHeight.Location = new System.Drawing.Point(77, 22);
            this.EdHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EdHeight.Name = "EdHeight";
            this.EdHeight.Size = new System.Drawing.Size(90, 20);
            this.EdHeight.TabIndex = 1;
            this.EdHeight.ValueChanged += new System.EventHandler(this.EdHeight_ValueChanged);
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(21, 24);
            this.LblHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(41, 13);
            this.LblHeight.TabIndex = 1;
            this.LblHeight.Text = "Height:";
            // 
            // LblSpeedAtTheEndPointOutp
            // 
            this.LblSpeedAtTheEndPointOutp.AutoSize = true;
            this.LblSpeedAtTheEndPointOutp.Location = new System.Drawing.Point(133, 254);
            this.LblSpeedAtTheEndPointOutp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSpeedAtTheEndPointOutp.Name = "LblSpeedAtTheEndPointOutp";
            this.LblSpeedAtTheEndPointOutp.Size = new System.Drawing.Size(0, 13);
            this.LblSpeedAtTheEndPointOutp.TabIndex = 18;
            // 
            // LblSpeedAtTheEndPoint
            // 
            this.LblSpeedAtTheEndPoint.AutoSize = true;
            this.LblSpeedAtTheEndPoint.Location = new System.Drawing.Point(11, 254);
            this.LblSpeedAtTheEndPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSpeedAtTheEndPoint.Name = "LblSpeedAtTheEndPoint";
            this.LblSpeedAtTheEndPoint.Size = new System.Drawing.Size(118, 13);
            this.LblSpeedAtTheEndPoint.TabIndex = 17;
            this.LblSpeedAtTheEndPoint.Text = "Speed at the end point:";
            // 
            // LblTimeStepOutp
            // 
            this.LblTimeStepOutp.AutoSize = true;
            this.LblTimeStepOutp.Location = new System.Drawing.Point(77, 167);
            this.LblTimeStepOutp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTimeStepOutp.Name = "LblTimeStepOutp";
            this.LblTimeStepOutp.Size = new System.Drawing.Size(0, 13);
            this.LblTimeStepOutp.TabIndex = 16;
            this.LblTimeStepOutp.Click += new System.EventHandler(this.LblMaxHeightOutp_Click);
            // 
            // LblTimeStep
            // 
            this.LblTimeStep.AutoSize = true;
            this.LblTimeStep.Location = new System.Drawing.Point(11, 167);
            this.LblTimeStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTimeStep.Name = "LblTimeStep";
            this.LblTimeStep.Size = new System.Drawing.Size(56, 13);
            this.LblTimeStep.TabIndex = 15;
            this.LblTimeStep.Text = "Time step:";
            this.LblTimeStep.Click += new System.EventHandler(this.LblTimeStep_Click);
            // 
            // LblMaxHeightOutp
            // 
            this.LblMaxHeightOutp.AutoSize = true;
            this.LblMaxHeightOutp.Location = new System.Drawing.Point(91, 227);
            this.LblMaxHeightOutp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMaxHeightOutp.Name = "LblMaxHeightOutp";
            this.LblMaxHeightOutp.Size = new System.Drawing.Size(0, 13);
            this.LblMaxHeightOutp.TabIndex = 13;
            // 
            // LblDistanceOutp
            // 
            this.LblDistanceOutp.AutoSize = true;
            this.LblDistanceOutp.Location = new System.Drawing.Point(87, 195);
            this.LblDistanceOutp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDistanceOutp.Name = "LblDistanceOutp";
            this.LblDistanceOutp.Size = new System.Drawing.Size(0, 13);
            this.LblDistanceOutp.TabIndex = 12;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(9, 134);
            this.LblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(40, 13);
            this.LblResult.TabIndex = 11;
            this.LblResult.Text = "Result:";
            // 
            // LblMaxHeight
            // 
            this.LblMaxHeight.AutoSize = true;
            this.LblMaxHeight.Location = new System.Drawing.Point(11, 227);
            this.LblMaxHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMaxHeight.Name = "LblMaxHeight";
            this.LblMaxHeight.Size = new System.Drawing.Size(76, 13);
            this.LblMaxHeight.TabIndex = 10;
            this.LblMaxHeight.Text = "Max height (y):";
            // 
            // LblDistance
            // 
            this.LblDistance.AutoSize = true;
            this.LblDistance.Location = new System.Drawing.Point(11, 195);
            this.LblDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDistance.Name = "LblDistance";
            this.LblDistance.Size = new System.Drawing.Size(66, 13);
            this.LblDistance.TabIndex = 9;
            this.LblDistance.Text = "Distance (x):";
            // 
            // Chart1
            // 
            chartArea5.AxisX.Maximum = 25D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisY.Maximum = 10D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Chart1.Legends.Add(legend5);
            this.Chart1.Location = new System.Drawing.Point(262, 124);
            this.Chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series25.BorderWidth = 3;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series25.Color = System.Drawing.Color.Blue;
            series25.Legend = "Legend1";
            series25.Name = "Trajectory1";
            series26.BorderWidth = 3;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series26.Legend = "Legend1";
            series26.Name = "Trajectory2";
            series27.BorderWidth = 3;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Legend = "Legend1";
            series27.Name = "Trajectory3";
            series28.BorderWidth = 3;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Legend = "Legend1";
            series28.Name = "Trajectory4";
            series29.BorderWidth = 3;
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Legend = "Legend1";
            series29.Name = "Trajectory5";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Legend = "Legend1";
            series30.Name = "Trajectory6";
            this.Chart1.Series.Add(series25);
            this.Chart1.Series.Add(series26);
            this.Chart1.Series.Add(series27);
            this.Chart1.Series.Add(series28);
            this.Chart1.Series.Add(series29);
            this.Chart1.Series.Add(series30);
            this.Chart1.Size = new System.Drawing.Size(708, 553);
            this.Chart1.TabIndex = 1;
            this.Chart1.Text = "Chart";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 675);
            this.Controls.Add(this.LblSpeedAtTheEndPointOutp);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.LblSpeedAtTheEndPoint);
            this.Controls.Add(this.LblTimeStepOutp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTimeStep);
            this.Controls.Add(this.LblDistance);
            this.Controls.Add(this.LblMaxHeightOutp);
            this.Controls.Add(this.LblMaxHeight);
            this.Controls.Add(this.LblDistanceOutp);
            this.Controls.Add(this.LblResult);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar TrackTimeStep;
        private System.Windows.Forms.NumericUpDown EdSpeed;
        private System.Windows.Forms.NumericUpDown EdAngle;
        private System.Windows.Forms.Label LblAngle;
        private System.Windows.Forms.Label LblSpeed;
        private System.Windows.Forms.NumericUpDown EdHeight;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.NumericUpDown EdSize;
        private System.Windows.Forms.NumericUpDown EdWeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Label LblTimeStepTracker;
        private System.Windows.Forms.Button BtnLaunch;
        private System.Windows.Forms.CheckBox CheckTrajectories;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label LblMaxHeightOutp;
        private System.Windows.Forms.Label LblDistanceOutp;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblMaxHeight;
        private System.Windows.Forms.Label LblDistance;
        private System.Windows.Forms.Label LblTimeStep;
        private System.Windows.Forms.Label LblTimeStepOutp;
        private System.Windows.Forms.Label LblSpeedAtTheEndPoint;
        private System.Windows.Forms.Label LblSpeedAtTheEndPointOutp;
    }
}

