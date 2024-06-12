using Npgsql;

namespace TechnoservisApp
{
    public partial class ReportForm : Form
    {
        private readonly int? requestId;
        private readonly int userId;

        public ReportForm(int userId, int requestId)
        {
            InitializeComponent();
            this.userId = userId;
            this.requestId = requestId;
            labelRequestId.Text += requestId;
            buttonSave.BackColor = Program.buttonColor;
            Program.con.Open();
            var cmd = new NpgsqlCommand($"select cause, help from report where id = {requestId}", Program.con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBoxCause.Text = (string)reader.GetValue(0);
                textBoxHelp.Text = (string)reader.GetValue(1);
            }
            Program.con.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, new RequestForm(userId, 2, requestId));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCause.Text) || string.IsNullOrEmpty(textBoxHelp.Text) )
            {
                MessageBox.Show("Заполните все поля!", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var sql = $"insert into report values ({requestId}, '{textBoxCause.Text}', '{textBoxHelp.Text}')";
            Program.con.Open();
            var cmd = new NpgsqlCommand(sql, Program.con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show("Произошла ошибка " + ex.MessageText, "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.con.Close();
            }
            Program.ChangeForm(this, new AllRequestsForm(2, userId));
        }
    }
}
