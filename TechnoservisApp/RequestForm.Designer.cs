namespace TechnoservisApp
{
    partial class RequestForm
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
            textBoxDescriptionProblem = new TextBox();
            textBoxSerialNumber = new TextBox();
            textBoxEquipmentType = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            comboBoxFailureType = new ComboBox();
            textBoxComment = new TextBox();
            label5 = new Label();
            flowLayoutPanelParts = new FlowLayoutPanel();
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            label6 = new Label();
            buttonAddPart = new Button();
            buttonToReport = new Button();
            buttonSave = new Button();
            buttonBack = new Button();
            buttonAddSpecialist = new Button();
            label7 = new Label();
            flowLayoutPanelSpecialists = new FlowLayoutPanel();
            panel2 = new Panel();
            comboBox3 = new ComboBox();
            label8 = new Label();
            textBoxSpecialist = new TextBox();
            label9 = new Label();
            dateTimePickerDateFinish = new DateTimePicker();
            dateTimePickerDateStart = new DateTimePicker();
            label10 = new Label();
            comboBoxPhase = new ComboBox();
            label11 = new Label();
            flowLayoutPanelParts.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            flowLayoutPanelSpecialists.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDescriptionProblem
            // 
            textBoxDescriptionProblem.Location = new Point(194, 245);
            textBoxDescriptionProblem.Multiline = true;
            textBoxDescriptionProblem.Name = "textBoxDescriptionProblem";
            textBoxDescriptionProblem.Size = new Size(235, 198);
            textBoxDescriptionProblem.TabIndex = 11;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(183, 130);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(246, 27);
            textBoxSerialNumber.TabIndex = 10;
            // 
            // textBoxEquipmentType
            // 
            textBoxEquipmentType.Location = new Point(183, 83);
            textBoxEquipmentType.Name = "textBoxEquipmentType";
            textBoxEquipmentType.Size = new Size(246, 27);
            textBoxEquipmentType.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 245);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 8;
            label3.Text = "Описание проблемы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 137);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 7;
            label2.Text = "Серийный номер";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 86);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 6;
            label1.Text = "Тип оборудования";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 194);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 12;
            label4.Text = "Тип неисправности";
            // 
            // comboBoxFailureType
            // 
            comboBoxFailureType.FormattingEnabled = true;
            comboBoxFailureType.Location = new Point(183, 191);
            comboBoxFailureType.Name = "comboBoxFailureType";
            comboBoxFailureType.Size = new Size(246, 28);
            comboBoxFailureType.TabIndex = 13;
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(671, 326);
            textBoxComment.Multiline = true;
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(278, 81);
            textBoxComment.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(531, 329);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 15;
            label5.Text = "Комментарий";
            // 
            // flowLayoutPanelParts
            // 
            flowLayoutPanelParts.AutoScroll = true;
            flowLayoutPanelParts.Controls.Add(panel1);
            flowLayoutPanelParts.Location = new Point(531, 121);
            flowLayoutPanelParts.Name = "flowLayoutPanelParts";
            flowLayoutPanelParts.Size = new Size(419, 144);
            flowLayoutPanelParts.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(comboBox2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 77);
            panel1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(320, 14);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 13);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(259, 28);
            comboBox2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(531, 83);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 17;
            label6.Text = "Запчасти";
            // 
            // buttonAddPart
            // 
            buttonAddPart.Location = new Point(632, 67);
            buttonAddPart.Name = "buttonAddPart";
            buttonAddPart.Size = new Size(94, 42);
            buttonAddPart.TabIndex = 18;
            buttonAddPart.Text = "Добавить";
            buttonAddPart.UseVisualStyleBackColor = true;
            buttonAddPart.Click += buttonAddPart_Click;
            // 
            // buttonToReport
            // 
            buttonToReport.Location = new Point(605, 416);
            buttonToReport.Name = "buttonToReport";
            buttonToReport.Size = new Size(259, 40);
            buttonToReport.TabIndex = 19;
            buttonToReport.Text = "Перейти к отчету";
            buttonToReport.UseVisualStyleBackColor = true;
            buttonToReport.Click += buttonToReport_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(1300, 449);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(176, 52);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Сохранить изменения";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(31, 34);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 49);
            buttonBack.TabIndex = 21;
            buttonBack.Text = "<- Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAddSpecialist
            // 
            buttonAddSpecialist.Location = new Point(1199, 67);
            buttonAddSpecialist.Name = "buttonAddSpecialist";
            buttonAddSpecialist.Size = new Size(94, 41);
            buttonAddSpecialist.TabIndex = 24;
            buttonAddSpecialist.Text = "Добавить";
            buttonAddSpecialist.UseVisualStyleBackColor = true;
            buttonAddSpecialist.Click += buttonAddSpecialist_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1044, 84);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 23;
            label7.Text = "Доп. специалисты";
            // 
            // flowLayoutPanelSpecialists
            // 
            flowLayoutPanelSpecialists.AutoScroll = true;
            flowLayoutPanelSpecialists.Controls.Add(panel2);
            flowLayoutPanelSpecialists.Location = new Point(1044, 122);
            flowLayoutPanelSpecialists.Name = "flowLayoutPanelSpecialists";
            flowLayoutPanelSpecialists.Size = new Size(419, 144);
            flowLayoutPanelSpecialists.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 76);
            panel2.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(15, 13);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(361, 28);
            comboBox3.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1047, 296);
            label8.Name = "label8";
            label8.Size = new Size(209, 20);
            label8.TabIndex = 25;
            label8.Text = "Ответственный исполнитель";
            // 
            // textBoxSpecialist
            // 
            textBoxSpecialist.Enabled = false;
            textBoxSpecialist.Location = new Point(1262, 293);
            textBoxSpecialist.Name = "textBoxSpecialist";
            textBoxSpecialist.Size = new Size(205, 27);
            textBoxSpecialist.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1051, 387);
            label9.Name = "label9";
            label9.Size = new Size(166, 20);
            label9.TabIndex = 27;
            label9.Text = "Дата окончания работ";
            // 
            // dateTimePickerDateFinish
            // 
            dateTimePickerDateFinish.Location = new Point(1262, 382);
            dateTimePickerDateFinish.Name = "dateTimePickerDateFinish";
            dateTimePickerDateFinish.Size = new Size(205, 27);
            dateTimePickerDateFinish.TabIndex = 28;
            // 
            // dateTimePickerDateStart
            // 
            dateTimePickerDateStart.Enabled = false;
            dateTimePickerDateStart.Location = new Point(1262, 336);
            dateTimePickerDateStart.Name = "dateTimePickerDateStart";
            dateTimePickerDateStart.Size = new Size(205, 27);
            dateTimePickerDateStart.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1051, 341);
            label10.Name = "label10";
            label10.Size = new Size(139, 20);
            label10.TabIndex = 29;
            label10.Text = "Дата начала работ";
            // 
            // comboBoxPhase
            // 
            comboBoxPhase.FormattingEnabled = true;
            comboBoxPhase.Location = new Point(670, 290);
            comboBoxPhase.Name = "comboBoxPhase";
            comboBoxPhase.Size = new Size(280, 28);
            comboBoxPhase.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(531, 293);
            label11.Name = "label11";
            label11.Size = new Size(133, 20);
            label11.TabIndex = 31;
            label11.Text = "Этап выполнения";
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 513);
            Controls.Add(comboBoxPhase);
            Controls.Add(label11);
            Controls.Add(dateTimePickerDateStart);
            Controls.Add(label10);
            Controls.Add(dateTimePickerDateFinish);
            Controls.Add(label9);
            Controls.Add(textBoxSpecialist);
            Controls.Add(label8);
            Controls.Add(buttonAddSpecialist);
            Controls.Add(label7);
            Controls.Add(flowLayoutPanelSpecialists);
            Controls.Add(buttonBack);
            Controls.Add(buttonSave);
            Controls.Add(buttonToReport);
            Controls.Add(buttonAddPart);
            Controls.Add(label6);
            Controls.Add(flowLayoutPanelParts);
            Controls.Add(textBoxComment);
            Controls.Add(label5);
            Controls.Add(comboBoxFailureType);
            Controls.Add(label4);
            Controls.Add(textBoxDescriptionProblem);
            Controls.Add(textBoxSerialNumber);
            Controls.Add(textBoxEquipmentType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RequestForm";
            Text = "Заявка";
            flowLayoutPanelParts.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            flowLayoutPanelSpecialists.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDescriptionProblem;
        private TextBox textBoxSerialNumber;
        private TextBox textBoxEquipmentType;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox comboBoxFailureType;
        private TextBox textBoxComment;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanelParts;
        private Panel panel1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private Label label6;
        private Button buttonAddPart;
        private Button buttonToReport;
        private Button buttonSave;
        private Button buttonBack;
        private Button buttonAddSpecialist;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanelSpecialists;
        private Panel panel2;
        private ComboBox comboBox3;
        private Label label8;
        private TextBox textBoxSpecialist;
        private Label label9;
        private DateTimePicker dateTimePickerDateFinish;
        private DateTimePicker dateTimePickerDateStart;
        private Label label10;
        private ComboBox comboBoxPhase;
        private Label label11;
    }
}