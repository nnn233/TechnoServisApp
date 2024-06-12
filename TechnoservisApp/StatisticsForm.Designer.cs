namespace TechnoservisApp
{
    partial class StatisticsForm
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
            labelRequestsCount = new Label();
            buttonBack = new Button();
            labelAverageTime = new Label();
            label3 = new Label();
            dataGridViewFailures = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFailures).BeginInit();
            SuspendLayout();
            // 
            // labelRequestsCount
            // 
            labelRequestsCount.AutoSize = true;
            labelRequestsCount.Location = new Point(46, 124);
            labelRequestsCount.Name = "labelRequestsCount";
            labelRequestsCount.Size = new Size(250, 20);
            labelRequestsCount.TabIndex = 0;
            labelRequestsCount.Text = "Количество выполненных заявок: ";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(46, 35);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 48);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "<- Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelAverageTime
            // 
            labelAverageTime.AutoSize = true;
            labelAverageTime.Location = new Point(49, 180);
            labelAverageTime.Name = "labelAverageTime";
            labelAverageTime.Size = new Size(315, 20);
            labelAverageTime.TabIndex = 2;
            labelAverageTime.Text = "Среднее время выполения заявки (в днях): ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 230);
            label3.Name = "label3";
            label3.Size = new Size(275, 20);
            label3.TabIndex = 3;
            label3.Text = "Статистика по типам неисправностей:";
            // 
            // dataGridViewFailures
            // 
            dataGridViewFailures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFailures.BackgroundColor = Color.White;
            dataGridViewFailures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFailures.Columns.AddRange(new DataGridViewColumn[] { Type, Count });
            dataGridViewFailures.Location = new Point(53, 272);
            dataGridViewFailures.Name = "dataGridViewFailures";
            dataGridViewFailures.RowHeadersVisible = false;
            dataGridViewFailures.RowHeadersWidth = 51;
            dataGridViewFailures.RowTemplate.Height = 29;
            dataGridViewFailures.Size = new Size(701, 250);
            dataGridViewFailures.TabIndex = 4;
            // 
            // Type
            // 
            Type.HeaderText = "Тип неисправности";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Count
            // 
            Count.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Count.HeaderText = "Количество";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.ReadOnly = true;
            Count.Width = 119;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(dataGridViewFailures);
            Controls.Add(label3);
            Controls.Add(labelAverageTime);
            Controls.Add(buttonBack);
            Controls.Add(labelRequestsCount);
            Name = "StatisticsForm";
            Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFailures).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRequestsCount;
        private Button buttonBack;
        private Label labelAverageTime;
        private Label label3;
        private DataGridView dataGridViewFailures;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Count;
    }
}