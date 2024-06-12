namespace TechnoservisApp
{
    partial class AllRequestsForm
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
            dataGridViewRequests = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date_start = new DataGridViewTextBoxColumn();
            Date_finish = new DataGridViewTextBoxColumn();
            EquipmentType = new DataGridViewTextBoxColumn();
            Failure_type = new DataGridViewTextBoxColumn();
            Problem = new DataGridViewTextBoxColumn();
            Phase = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            buttonFormRequest = new Button();
            textBoxRequestId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxEquipmentType = new TextBox();
            buttonLookStatistics = new Button();
            linkLabelReview = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.AllowUserToAddRows = false;
            dataGridViewRequests.AllowUserToDeleteRows = false;
            dataGridViewRequests.AllowUserToResizeColumns = false;
            dataGridViewRequests.AllowUserToResizeRows = false;
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Columns.AddRange(new DataGridViewColumn[] { Id, Date_start, Date_finish, EquipmentType, Failure_type, Problem, Phase, Status });
            dataGridViewRequests.Location = new Point(37, 103);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.RowHeadersVisible = false;
            dataGridViewRequests.RowHeadersWidth = 51;
            dataGridViewRequests.RowTemplate.Height = 29;
            dataGridViewRequests.Size = new Size(896, 305);
            dataGridViewRequests.TabIndex = 0;
            dataGridViewRequests.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Date_start
            // 
            Date_start.HeaderText = "Дата формирования";
            Date_start.MinimumWidth = 6;
            Date_start.Name = "Date_start";
            Date_start.ReadOnly = true;
            // 
            // Date_finish
            // 
            Date_finish.HeaderText = "Дата окончания работ";
            Date_finish.MinimumWidth = 6;
            Date_finish.Name = "Date_finish";
            Date_finish.ReadOnly = true;
            // 
            // EquipmentType
            // 
            EquipmentType.HeaderText = "Тип оборудования";
            EquipmentType.MinimumWidth = 6;
            EquipmentType.Name = "EquipmentType";
            EquipmentType.ReadOnly = true;
            // 
            // Failure_type
            // 
            Failure_type.HeaderText = "Тип неисправности";
            Failure_type.MinimumWidth = 6;
            Failure_type.Name = "Failure_type";
            Failure_type.ReadOnly = true;
            // 
            // Problem
            // 
            Problem.HeaderText = "Описание проблемы";
            Problem.MinimumWidth = 6;
            Problem.Name = "Problem";
            Problem.ReadOnly = true;
            // 
            // Phase
            // 
            Phase.HeaderText = "Этап выполнения";
            Phase.MinimumWidth = 6;
            Phase.Name = "Phase";
            Phase.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // buttonFormRequest
            // 
            buttonFormRequest.Location = new Point(725, 430);
            buttonFormRequest.Name = "buttonFormRequest";
            buttonFormRequest.Size = new Size(208, 45);
            buttonFormRequest.TabIndex = 1;
            buttonFormRequest.Text = "Сформировать заявку";
            buttonFormRequest.UseVisualStyleBackColor = true;
            buttonFormRequest.Visible = false;
            buttonFormRequest.Click += buttonFormRequest_Click;
            // 
            // textBoxRequestId
            // 
            textBoxRequestId.Location = new Point(152, 42);
            textBoxRequestId.Name = "textBoxRequestId";
            textBoxRequestId.Size = new Size(180, 27);
            textBoxRequestId.TabIndex = 2;
            textBoxRequestId.TextChanged += textBoxRequestId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Номер заявки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 41);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 5;
            label2.Text = "Тип оборудования";
            // 
            // textBoxEquipmentType
            // 
            textBoxEquipmentType.Location = new Point(523, 41);
            textBoxEquipmentType.Name = "textBoxEquipmentType";
            textBoxEquipmentType.Size = new Size(180, 27);
            textBoxEquipmentType.TabIndex = 4;
            textBoxEquipmentType.TextChanged += textBoxEquipmentType_TextChanged;
            // 
            // buttonLookStatistics
            // 
            buttonLookStatistics.Location = new Point(37, 430);
            buttonLookStatistics.Name = "buttonLookStatistics";
            buttonLookStatistics.Size = new Size(208, 45);
            buttonLookStatistics.TabIndex = 6;
            buttonLookStatistics.Text = "Посмотреть статистику";
            buttonLookStatistics.UseVisualStyleBackColor = true;
            buttonLookStatistics.Click += buttonLookStatistics_Click;
            // 
            // linkLabelReview
            // 
            linkLabelReview.AutoSize = true;
            linkLabelReview.Location = new Point(809, 46);
            linkLabelReview.Name = "linkLabelReview";
            linkLabelReview.Size = new Size(117, 20);
            linkLabelReview.TabIndex = 7;
            linkLabelReview.TabStop = true;
            linkLabelReview.Text = "Оставить отзыв";
            linkLabelReview.Visible = false;
            linkLabelReview.LinkClicked += linkLabelReview_LinkClicked;
            // 
            // AllRequestsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 487);
            Controls.Add(linkLabelReview);
            Controls.Add(buttonLookStatistics);
            Controls.Add(label2);
            Controls.Add(textBoxEquipmentType);
            Controls.Add(label1);
            Controls.Add(textBoxRequestId);
            Controls.Add(buttonFormRequest);
            Controls.Add(dataGridViewRequests);
            Name = "AllRequestsForm";
            Text = "Заявки";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRequests;
        private Button buttonFormRequest;
        private TextBox textBoxRequestId;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date_start;
        private DataGridViewTextBoxColumn Date_finish;
        private DataGridViewTextBoxColumn EquipmentType;
        private DataGridViewTextBoxColumn Failure_type;
        private DataGridViewTextBoxColumn Problem;
        private DataGridViewTextBoxColumn Phase;
        private DataGridViewTextBoxColumn Status;
        private Label label1;
        private Label label2;
        private TextBox textBoxEquipmentType;
        private Button buttonLookStatistics;
        private LinkLabel linkLabelReview;
    }
}