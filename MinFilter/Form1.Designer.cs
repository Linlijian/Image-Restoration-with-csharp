namespace MinFilter
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Open = new System.Windows.Forms.Button();
            this.MinFilter = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MaxFilter = new System.Windows.Forms.Button();
            this.Midpoint = new System.Windows.Forms.Button();
            this.ContraFilter = new System.Windows.Forms.Button();
            this.Alpha = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 247);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(274, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 247);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 265);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // MinFilter
            // 
            this.MinFilter.Location = new System.Drawing.Point(93, 265);
            this.MinFilter.Name = "MinFilter";
            this.MinFilter.Size = new System.Drawing.Size(75, 23);
            this.MinFilter.TabIndex = 1;
            this.MinFilter.Text = "MinFilter";
            this.MinFilter.UseVisualStyleBackColor = true;
            this.MinFilter.Click += new System.EventHandler(this.MinFilter_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 303);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(519, 125);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(12, 434);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(518, 125);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // MaxFilter
            // 
            this.MaxFilter.Location = new System.Drawing.Point(174, 265);
            this.MaxFilter.Name = "MaxFilter";
            this.MaxFilter.Size = new System.Drawing.Size(75, 23);
            this.MaxFilter.TabIndex = 4;
            this.MaxFilter.Text = "MaxFilter";
            this.MaxFilter.UseVisualStyleBackColor = true;
            this.MaxFilter.Click += new System.EventHandler(this.MaxFilter_Click);
            // 
            // Midpoint
            // 
            this.Midpoint.Location = new System.Drawing.Point(255, 265);
            this.Midpoint.Name = "Midpoint";
            this.Midpoint.Size = new System.Drawing.Size(75, 23);
            this.Midpoint.TabIndex = 5;
            this.Midpoint.Text = "Midpoint";
            this.Midpoint.UseVisualStyleBackColor = true;
            this.Midpoint.Click += new System.EventHandler(this.Midpoint_Click);
            // 
            // ContraFilter
            // 
            this.ContraFilter.Location = new System.Drawing.Point(336, 265);
            this.ContraFilter.Name = "ContraFilter";
            this.ContraFilter.Size = new System.Drawing.Size(75, 23);
            this.ContraFilter.TabIndex = 6;
            this.ContraFilter.Text = "Contra";
            this.ContraFilter.UseVisualStyleBackColor = true;
            this.ContraFilter.Click += new System.EventHandler(this.ContraFilter_Click);
            // 
            // Alpha
            // 
            this.Alpha.Location = new System.Drawing.Point(417, 265);
            this.Alpha.Name = "Alpha";
            this.Alpha.Size = new System.Drawing.Size(75, 23);
            this.Alpha.TabIndex = 7;
            this.Alpha.Text = "Alpha";
            this.Alpha.UseVisualStyleBackColor = true;
            this.Alpha.Click += new System.EventHandler(this.Alpha_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 568);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Alpha);
            this.Controls.Add(this.ContraFilter);
            this.Controls.Add(this.Midpoint);
            this.Controls.Add(this.MaxFilter);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.MinFilter);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button MinFilter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button MaxFilter;
        private System.Windows.Forms.Button Midpoint;
        private System.Windows.Forms.Button ContraFilter;
        private System.Windows.Forms.Button Alpha;
        private System.Windows.Forms.TextBox textBox1;
    }
}

