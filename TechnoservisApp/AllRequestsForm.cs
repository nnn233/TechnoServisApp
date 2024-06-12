using Npgsql;

namespace TechnoservisApp
{
    public partial class AllRequestsForm : Form
    {
        private readonly int userId;
        private readonly int userGroupId;

        public AllRequestsForm(int userGroup, int userId)
        {
            InitializeComponent();
            this.userId = userId;
            userGroupId = userGroup;
            buttonFormRequest.BackColor = Program.buttonColor;
            buttonLookStatistics.BackColor = Program.buttonColor;
            dataGridViewRequests.BackgroundColor = Program.additionalBackground;
            if (userGroup == 1)
            {
                buttonFormRequest.Visible = true;
                linkLabelReview.Visible = true;
            }
            textBoxRequestId.KeyPress += TextBoxRequestId_KeyPress;
            LoadRequests();
        }

        private void TextBoxRequestId_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back)
                e.Handled = true;
        }

        private void LoadRequests()
        {
            dataGridViewRequests.Rows.Clear();
            Program.con.Open();
            var sql = "select request.id, date_start, date_finish, equipment_type, failure_type.title, description_problem, " +
                "phase.title, status.title from request join failure_type on request.failure_type=failure_type.id " +
                $"join phase on request.phase=phase.id join status on request.status=status.id " +
                $"where lower(equipment_type) like '%{textBoxEquipmentType.Text.ToLower()}%'";
            if (int.TryParse(textBoxRequestId.Text, out int id))
                sql += $" and request.id={id}";
            if (userGroupId == 1)
                sql += $" and request.client={userId}";
            else if (userGroupId == 2)
                sql += $" and request.specialist={userId}";
            var cmd = new NpgsqlCommand(sql, Program.con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
                dataGridViewRequests.Rows.Add((int)reader.GetValue(0), ((DateTime)reader.GetValue(1)).ToShortDateString(),
                    ((DateTime)reader.GetValue(2)).ToShortDateString(), (string)reader.GetValue(3), (string)reader.GetValue(4),
                    (string)reader.GetValue(5), (string)reader.GetValue(6), (string)reader.GetValue(7));
            Program.con.Close();
        }

        private void buttonFormRequest_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, new RequestForm(userId, userGroupId));
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var request = (int)dataGridViewRequests.Rows[e.RowIndex].Cells[0].Value;
            Program.ChangeForm(this, new RequestForm(userId, userGroupId, request));
        }

        private void textBoxRequestId_TextChanged(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void textBoxEquipmentType_TextChanged(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void buttonLookStatistics_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, new StatisticsForm(userId, userGroupId));
        }

        private void linkLabelReview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new ReviewForm();
            form.Show();
        }
    }
}
