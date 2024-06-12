using Npgsql;

namespace TechnoservisApp
{
    public partial class StatisticsForm : Form
    {
        private readonly int userId;
        private readonly int userGroupId;

        public StatisticsForm(int userId, int userGroup)
        {
            InitializeComponent();
            this.userId = userId;
            userGroupId = userGroup;
            buttonBack.BackColor = Program.buttonColor;
            dataGridViewFailures.BackgroundColor = Program.additionalBackground;
            labelRequestsCount.Text += GetCountRequests();
            labelAverageTime.Text += (double)GetAllTime()/GetCountRequests();
            GetFailuresTypeCount();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, new AllRequestsForm(userGroupId, userId));
        }

        private Int64 GetCountRequests()
        {
            Program.con.Open();
            var cmd = new NpgsqlCommand("select count(id) from request where status=3", Program.con);
            var result = (Int64)cmd.ExecuteScalar();
            Program.con.Close();
            return result;
        }

        private Int64 GetAllTime()
        {
            Program.con.Open();
            var cmd = new NpgsqlCommand("select sum(date_finish-date_start) from request where status=3", Program.con);
            var result = (Int64)cmd.ExecuteScalar();
            Program.con.Close();
            return result;
        }

        private void GetFailuresTypeCount()
        {
            Program.con.Open();
            var cmd = new NpgsqlCommand("select failure_type.title, count(request.id) from failure_type " +
                "join request on failure_type.id=request.failure_type where status=3 group by failure_type.title", Program.con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
                dataGridViewFailures.Rows.Add((string)reader.GetValue(0), (Int64)reader.GetValue(1));
            Program.con.Close();
        }
    }
}
