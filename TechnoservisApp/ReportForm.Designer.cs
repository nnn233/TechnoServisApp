namespace TechnoservisApp
{
    partial class ReportForm
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
            labelRequestId = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxCause = new TextBox();
            textBoxHelp = new TextBox();
            buttonSave = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelRequestId
            // 
            labelRequestId.AutoSize = true;
            labelRequestId.Location = new Point(50, 109);
            labelRequestId.Name = "labelRequestId";
            labelRequestId.Size = new Size(141, 20);
            labelRequestId.TabIndex = 0;
            labelRequestId.Text = "Отчет по заявке №";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 170);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 2;
            label2.Text = "Причина поломки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 299);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 3;
            label3.Text = "Оказанная помощь";
            // 
            // textBoxCause
            // 
            textBoxCause.Location = new Point(217, 170);
            textBoxCause.Multiline = true;
            textBoxCause.Name = "textBoxCause";
            textBoxCause.Size = new Size(555, 105);
            textBoxCause.TabIndex = 5;
            // 
            // textBoxHelp
            // 
            textBoxHelp.Location = new Point(217, 299);
            textBoxHelp.Multiline = true;
            textBoxHelp.Name = "textBoxHelp";
            textBoxHelp.Size = new Size(555, 111);
            textBoxHelp.TabIndex = 6;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(635, 439);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(137, 44);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(50, 28);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 44);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "<- Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(buttonBack);
            Controls.Add(buttonSave);
            Controls.Add(textBoxHelp);
            Controls.Add(textBoxCause);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelRequestId);
            Name = "ReportForm";
            Text = "Отчет по заявке";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRequestId;
        private Label label2;
        private Label label3;
        private TextBox textBoxCause;
        private TextBox textBoxHelp;
        private Button buttonSave;
        private Button buttonBack;
    }
}