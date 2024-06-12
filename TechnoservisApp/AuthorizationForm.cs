using Npgsql;

namespace TechnoservisApp
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            buttonLogIn.BackColor = Program.buttonColor;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
                MessageBox.Show("Все поля должны быть заполнены!", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (GetUser(textBoxLogin.Text, textBoxPassword.Text) == null)
                MessageBox.Show("Неверный логин или пароль!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var userId = (int)GetUser(textBoxLogin.Text, textBoxPassword.Text);
                Program.ChangeForm(this, new AllRequestsForm(GetUserGroup(userId), userId));
            }
        }

        private int? GetUser(string login, string password)
        {
            Program.con.Open();
            var cmd = new NpgsqlCommand($"select id from public.user where login='{login}' and password='{password}'", Program.con);
            var result = (int?)cmd.ExecuteScalar();
            Program.con.Close();
            return result;
        }

        private int GetUserGroup(int id)
        {
            Program.con.Open();
            var cmd = new NpgsqlCommand($"select user_group from public.user where id='{id}'", Program.con);
            var result = (int)cmd.ExecuteScalar();
            Program.con.Close();
            return result;
        }
    }
}
