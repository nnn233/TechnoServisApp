namespace TechnoservisApp
{
    partial class AuthorizationForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 113);
            label1.Name = "label1";
            label1.Size = new Size(57, 37);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 171);
            label2.Name = "label2";
            label2.Size = new Size(64, 37);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(291, 110);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(235, 41);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(291, 168);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(235, 41);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.White;
            buttonLogIn.Location = new Point(180, 237);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(346, 46);
            buttonLogIn.TabIndex = 4;
            buttonLogIn.Text = "Войти";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 411);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 6, 3, 6);
            Name = "AuthorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonLogIn;
    }
}