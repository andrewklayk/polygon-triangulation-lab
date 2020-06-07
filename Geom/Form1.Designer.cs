namespace Geom
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.butGen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nbox = new System.Windows.Forms.TextBox();
            this.vertexbox = new System.Windows.Forms.TextBox();
            this.but_manual = new System.Windows.Forms.Button();
            this.but_random = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.but_man_done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Poly";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.Name = "Vertices";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(588, 447);
            this.chart.TabIndex = 0;
            this.chart.Text = "Polygon";
            // 
            // butGen
            // 
            this.butGen.Location = new System.Drawing.Point(646, 80);
            this.butGen.Name = "butGen";
            this.butGen.Size = new System.Drawing.Size(142, 31);
            this.butGen.TabIndex = 1;
            this.butGen.Text = "Generate polygon";
            this.butGen.UseVisualStyleBackColor = true;
            this.butGen.Visible = false;
            this.butGen.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "Triangulate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nbox
            // 
            this.nbox.Location = new System.Drawing.Point(646, 54);
            this.nbox.Name = "nbox";
            this.nbox.Size = new System.Drawing.Size(142, 20);
            this.nbox.TabIndex = 4;
            this.nbox.Visible = false;
            // 
            // vertexbox
            // 
            this.vertexbox.Location = new System.Drawing.Point(646, 138);
            this.vertexbox.Name = "vertexbox";
            this.vertexbox.Size = new System.Drawing.Size(142, 20);
            this.vertexbox.TabIndex = 5;
            this.vertexbox.Visible = false;
            // 
            // but_manual
            // 
            this.but_manual.Location = new System.Drawing.Point(723, 12);
            this.but_manual.Name = "but_manual";
            this.but_manual.Size = new System.Drawing.Size(65, 36);
            this.but_manual.TabIndex = 6;
            this.but_manual.Text = "Manual input";
            this.but_manual.UseVisualStyleBackColor = true;
            this.but_manual.Click += new System.EventHandler(this.but_manual_Click);
            // 
            // but_random
            // 
            this.but_random.Location = new System.Drawing.Point(646, 12);
            this.but_random.Name = "but_random";
            this.but_random.Size = new System.Drawing.Size(71, 36);
            this.but_random.TabIndex = 7;
            this.but_random.Text = "Random";
            this.but_random.UseVisualStyleBackColor = true;
            this.but_random.Click += new System.EventHandler(this.but_random_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(646, 164);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(142, 23);
            this.but_add.TabIndex = 8;
            this.but_add.Text = "Add vertex";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Visible = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_man_done
            // 
            this.but_man_done.Location = new System.Drawing.Point(646, 193);
            this.but_man_done.Name = "but_man_done";
            this.but_man_done.Size = new System.Drawing.Size(142, 23);
            this.but_man_done.TabIndex = 9;
            this.but_man_done.Text = "Done";
            this.but_man_done.UseVisualStyleBackColor = true;
            this.but_man_done.Visible = false;
            this.but_man_done.Click += new System.EventHandler(this.but_man_done_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_man_done);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_random);
            this.Controls.Add(this.but_manual);
            this.Controls.Add(this.vertexbox);
            this.Controls.Add(this.nbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butGen);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button butGen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nbox;
        private System.Windows.Forms.TextBox vertexbox;
        private System.Windows.Forms.Button but_manual;
        private System.Windows.Forms.Button but_random;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_man_done;
    }
}

