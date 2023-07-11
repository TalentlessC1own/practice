namespace practice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CAtextBox = new System.Windows.Forms.TextBox();
            this.KtextBox = new System.Windows.Forms.TextBox();
            this.TtextBox = new System.Windows.Forms.TextBox();
            this.StepTextBox = new System.Windows.Forms.TextBox();
            this.tryFirstDrawButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.experimentDataGridView = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExperimentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearModelChartButton = new System.Windows.Forms.Button();
            this.ClearExperimentChartButton = new System.Windows.Forms.Button();
            this.TryDrawExperimentButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.meError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.experimentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperimentChart)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод исходных данных\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Концентрация A=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Константа скорости k =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время исследования t=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Шаг исследования =";
            // 
            // CAtextBox
            // 
            this.CAtextBox.Location = new System.Drawing.Point(158, 79);
            this.CAtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CAtextBox.Name = "CAtextBox";
            this.CAtextBox.Size = new System.Drawing.Size(118, 20);
            this.CAtextBox.TabIndex = 5;
            // 
            // KtextBox
            // 
            this.KtextBox.Location = new System.Drawing.Point(158, 106);
            this.KtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.KtextBox.Name = "KtextBox";
            this.KtextBox.Size = new System.Drawing.Size(118, 20);
            this.KtextBox.TabIndex = 6;
            // 
            // TtextBox
            // 
            this.TtextBox.Location = new System.Drawing.Point(158, 136);
            this.TtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TtextBox.Name = "TtextBox";
            this.TtextBox.Size = new System.Drawing.Size(118, 20);
            this.TtextBox.TabIndex = 7;
            // 
            // StepTextBox
            // 
            this.StepTextBox.Location = new System.Drawing.Point(158, 168);
            this.StepTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(118, 20);
            this.StepTextBox.TabIndex = 8;
            this.StepTextBox.TextChanged += new System.EventHandler(this.StepTextBox_TextChanged);
            // 
            // tryFirstDrawButton
            // 
            this.tryFirstDrawButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tryFirstDrawButton.Location = new System.Drawing.Point(171, 249);
            this.tryFirstDrawButton.Margin = new System.Windows.Forms.Padding(2);
            this.tryFirstDrawButton.Name = "tryFirstDrawButton";
            this.tryFirstDrawButton.Size = new System.Drawing.Size(88, 24);
            this.tryFirstDrawButton.TabIndex = 9;
            this.tryFirstDrawButton.Text = "Построить";
            this.tryFirstDrawButton.UseVisualStyleBackColor = true;
            this.tryFirstDrawButton.Click += new System.EventHandler(this.tryFirstDrawButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ввод данных эксперимента";
            // 
            // experimentDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.experimentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.experimentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.experimentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.C});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.experimentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.experimentDataGridView.Location = new System.Drawing.Point(22, 316);
            this.experimentDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.experimentDataGridView.Name = "experimentDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.experimentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.experimentDataGridView.RowHeadersWidth = 51;
            this.experimentDataGridView.RowTemplate.Height = 24;
            this.experimentDataGridView.Size = new System.Drawing.Size(314, 189);
            this.experimentDataGridView.TabIndex = 11;
            // 
            // t
            // 
            this.t.HeaderText = "t(время)";
            this.t.MinimumWidth = 6;
            this.t.Name = "t";
            this.t.Width = 125;
            // 
            // C
            // 
            this.C.HeaderText = "C(B)";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.Width = 125;
            // 
            // ModelChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ModelChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ModelChart.Legends.Add(legend1);
            this.ModelChart.Location = new System.Drawing.Point(442, 46);
            this.ModelChart.Margin = new System.Windows.Forms.Padding(2);
            this.ModelChart.Name = "ModelChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelForeColor = System.Drawing.Color.MediumBlue;
            series1.Legend = "Legend1";
            series1.Name = "Концентрация С(b)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Точки C(b)";
            this.ModelChart.Series.Add(series1);
            this.ModelChart.Series.Add(series2);
            this.ModelChart.Size = new System.Drawing.Size(394, 244);
            this.ModelChart.TabIndex = 12;
            this.ModelChart.Text = "chart1";
            // 
            // ExperimentChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ExperimentChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ExperimentChart.Legends.Add(legend2);
            this.ExperimentChart.Location = new System.Drawing.Point(442, 316);
            this.ExperimentChart.Margin = new System.Windows.Forms.Padding(2);
            this.ExperimentChart.Name = "ExperimentChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Концентрация С(b)";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.Name = "Точки C(b)";
            this.ExperimentChart.Series.Add(series3);
            this.ExperimentChart.Series.Add(series4);
            this.ExperimentChart.Size = new System.Drawing.Size(394, 244);
            this.ExperimentChart.TabIndex = 13;
            this.ExperimentChart.Text = "chart2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(440, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "График эксперимента";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(440, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "График идеальной модели";
            // 
            // ClearModelChartButton
            // 
            this.ClearModelChartButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearModelChartButton.Location = new System.Drawing.Point(56, 249);
            this.ClearModelChartButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearModelChartButton.Name = "ClearModelChartButton";
            this.ClearModelChartButton.Size = new System.Drawing.Size(88, 24);
            this.ClearModelChartButton.TabIndex = 16;
            this.ClearModelChartButton.Text = "Сброс";
            this.ClearModelChartButton.UseVisualStyleBackColor = true;
            this.ClearModelChartButton.Click += new System.EventHandler(this.ClearModelChartButton_Click);
            // 
            // ClearExperimentChartButton
            // 
            this.ClearExperimentChartButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearExperimentChartButton.Location = new System.Drawing.Point(56, 523);
            this.ClearExperimentChartButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearExperimentChartButton.Name = "ClearExperimentChartButton";
            this.ClearExperimentChartButton.Size = new System.Drawing.Size(88, 24);
            this.ClearExperimentChartButton.TabIndex = 17;
            this.ClearExperimentChartButton.Text = "Сброс";
            this.ClearExperimentChartButton.UseVisualStyleBackColor = true;
            this.ClearExperimentChartButton.Click += new System.EventHandler(this.ClearExperimentChartButton_Click);
            // 
            // TryDrawExperimentButton
            // 
            this.TryDrawExperimentButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TryDrawExperimentButton.Location = new System.Drawing.Point(171, 523);
            this.TryDrawExperimentButton.Margin = new System.Windows.Forms.Padding(2);
            this.TryDrawExperimentButton.Name = "TryDrawExperimentButton";
            this.TryDrawExperimentButton.Size = new System.Drawing.Size(88, 24);
            this.TryDrawExperimentButton.TabIndex = 18;
            this.TryDrawExperimentButton.Text = "Построить";
            this.TryDrawExperimentButton.UseVisualStyleBackColor = true;
            this.TryDrawExperimentButton.Click += new System.EventHandler(this.TryDrawExperimentButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(338, 540);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 39);
            this.button5.TabIndex = 19;
            this.button5.Text = "Анализ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(901, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Погрешность =";
            // 
            // meError
            // 
            this.meError.Location = new System.Drawing.Point(158, 197);
            this.meError.Margin = new System.Windows.Forms.Padding(2);
            this.meError.Name = "meError";
            this.meError.Size = new System.Drawing.Size(118, 20);
            this.meError.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 590);
            this.Controls.Add(this.meError);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.TryDrawExperimentButton);
            this.Controls.Add(this.ClearExperimentChartButton);
            this.Controls.Add(this.ClearModelChartButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExperimentChart);
            this.Controls.Add(this.ModelChart);
            this.Controls.Add(this.experimentDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tryFirstDrawButton);
            this.Controls.Add(this.StepTextBox);
            this.Controls.Add(this.TtextBox);
            this.Controls.Add(this.KtextBox);
            this.Controls.Add(this.CAtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Practice work";
            ((System.ComponentModel.ISupportInitialize)(this.experimentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperimentChart)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CAtextBox;
        private System.Windows.Forms.TextBox KtextBox;
        private System.Windows.Forms.TextBox TtextBox;
        private System.Windows.Forms.TextBox StepTextBox;
        private System.Windows.Forms.Button tryFirstDrawButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView experimentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataVisualization.Charting.Chart ModelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExperimentChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearModelChartButton;
        private System.Windows.Forms.Button ClearExperimentChartButton;
        private System.Windows.Forms.Button TryDrawExperimentButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox meError;
    }
}

