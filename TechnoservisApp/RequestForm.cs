using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TechnoservisApp
{
    public partial class RequestForm : Form
    {
        private readonly int userId;
        private readonly int userGroupId;
        private readonly int? requestId;

        public RequestForm(int userId, int userGroup, int? requestId = null)
        {
            InitializeComponent();
            this.userId = userId;
            userGroupId = userGroup;
            this.requestId = requestId;
            switch (userGroup)
            {
                case 2:
                    Size = new Size(1019, 560);
                    textBoxEquipmentType.Enabled = false;
                    comboBoxFailureType.Enabled = false;
                    textBoxSerialNumber.Enabled = false;
                    break;
                case 3:
                    Size = new Size(1511, 560);
                    textBoxEquipmentType.Enabled = false;
                    comboBoxFailureType.Enabled = false;
                    textBoxSerialNumber.Enabled = false;
                    textBoxDescriptionProblem.Enabled = false;
                    buttonAddPart.Enabled = false;
                    flowLayoutPanelParts.Enabled = false;
                    textBoxComment.Enabled = false;
                    buttonToReport.Enabled = false;
                    comboBoxPhase.Enabled = false;
                    dateTimePickerDateFinish.MinDate = dateTimePickerDateStart.Value.Date;
                    break;
                default:
                    Size = new Size(473, 560);
                    if (requestId != null)
                    {
                        textBoxEquipmentType.Enabled = false;
                        comboBoxFailureType.Enabled = false;
                        textBoxSerialNumber.Enabled = false;
                        textBoxDescriptionProblem.Enabled = false;
                        buttonSave.Enabled = false;
                    }
                    break;
            }
            flowLayoutPanelParts.Controls.Clear();
            flowLayoutPanelSpecialists.Controls.Clear();
            comboBoxFailureType.Items.AddRange(GetFailures());
            comboBoxPhase.Items.AddRange(GetPhases());
            foreach(Control item in Controls)
            {
                if (item is Button)
                    item.BackColor = Program.buttonColor;
                if (item is Panel)
                    item.BackColor = Program.additionalBackground;
            }
            if (requestId != null)
                LoadRequest();
        }

        private void LoadRequest()
        {
            Program.con.Open();
            var sql = "select date_start, date_finish, equipment_type, serial_number, failure_type, description_problem, " +
                $"phase, comment, specialization || ' ' || fio from request " +
                $"join specialist on request.specialist=specialist.id join public.user on specialist.id=public.user.id " +
                $"where request.id = {requestId}";
            var cmd = new NpgsqlCommand(sql, Program.con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dateTimePickerDateStart.Value = (DateTime)reader.GetValue(0);
                dateTimePickerDateFinish.Value = (DateTime)reader.GetValue(1);
                textBoxEquipmentType.Text = (string)reader.GetValue(2);
                textBoxSerialNumber.Text = (string)reader.GetValue(3);
                comboBoxFailureType.SelectedIndex = (int)reader.GetValue(4) - 1;
                textBoxDescriptionProblem.Text = (string)reader.GetValue(5);
                comboBoxPhase.SelectedIndex = (int)reader.GetValue(6) - 1;
                if (reader.GetValue(7) != DBNull.Value)
                    textBoxComment.Text = (string)reader.GetValue(7);
                textBoxSpecialist.Text = (string)reader.GetValue(8);
            }
            Program.con.Close();
            LoadParts();
            LoadSpecialists();
        }

        private void LoadParts()
        {
            var items = GetParts();
            Program.con.Open();
            var sql = $"select part, part.title, count from order_parts join part on order_parts.part=part.id where request = {requestId}";
            var cmd = new NpgsqlCommand(sql, Program.con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var panel = new Panel()
                {
                    Location = new Point(3, 3),
                    Name = "" + (int)reader.GetValue(0),
                    Size = new Size(402, 77)
                };
                var comboBox = new ComboBox()
                {
                    FormattingEnabled = true,
                    Location = new Point(15, 13),
                    Size = new Size(259, 28)
                };
                comboBox.Items.AddRange(items);
                comboBox.SelectedItem = (string)reader.GetValue(1);
                var numeric = new NumericUpDown()
                {
                    Location = new Point(320, 14),
                    Size = new Size(70, 27)
                };
                numeric.Value = (int)reader.GetValue(2);
                panel.Controls.Add(comboBox);
                panel.Controls.Add(numeric);
                flowLayoutPanelParts.Controls.Add(panel);
            }
            Program.con.Close();
        }

        private void LoadSpecialists()
        {
            var items = GetSpecialists();
            Program.con.Open();
            var sql = $"select specialist, specialization || ' ' || fio from additional_specialist " +
                $"join specialist on additional_specialist.specialist=specialist.id " +
                $"join public.user on specialist.id=public.user.id where request = {requestId}";
            var cmd = new NpgsqlCommand(sql, Program.con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var panel = new Panel()
                {
                    Location = new Point(3, 3),
                    Name = "" + (int)reader.GetValue(0),
                    Size = new Size(402, 77)
                };
                var comboBox = new ComboBox()
                {
                    FormattingEnabled = true,
                    Location = new Point(15, 13),
                    Size = new Size(361, 28)
                };
                comboBox.Items.AddRange(items);
                comboBox.SelectedItem = (string)reader.GetValue(1);
                panel.Controls.Add(comboBox);
                flowLayoutPanelSpecialists.Controls.Add(panel);
            }
            Program.con.Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, new AllRequestsForm(userGroupId, userId));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var sql = "";
            if (requestId == null)
            {
                if (string.IsNullOrEmpty(textBoxEquipmentType.Text) || string.IsNullOrEmpty(textBoxSerialNumber.Text) ||
                    comboBoxFailureType.SelectedIndex == -1 || string.IsNullOrEmpty(textBoxDescriptionProblem.Text))
                {
                    MessageBox.Show("Заполните все поля!", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                sql = $"insert into request(equipment_type, serial_number, description_problem, specialist, client, " +
                    $"date_finish, failure_type) values ('{textBoxEquipmentType.Text}', '{textBoxSerialNumber.Text}', " +
                    $"'{textBoxDescriptionProblem.Text}', " +
                    $"(select specialist.id from specialist left join request on request.specialist=specialist.id group by specialist.id " +
                    $"order by count(request.id) limit 1), " +
                    $"{userId}, '{DateTime.Now.AddDays(1)}', {comboBoxFailureType.SelectedIndex + 1})";
            }
            else if (userGroupId == 2)
            {
                if (string.IsNullOrEmpty(textBoxDescriptionProblem.Text) || comboBoxPhase.SelectedIndex == -1)
                {
                    MessageBox.Show("Поля описание проблемы и этап выполнения не могут быть пусты!", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                sql = $"update request set comment = '{textBoxComment.Text}', description_problem = '{textBoxDescriptionProblem.Text}', " +
                    $"phase={comboBoxPhase.SelectedIndex + 1}, status={comboBoxPhase.SelectedIndex + 1}  where id = {requestId}";
            }
            else
            {
                sql = $"update request set date_finish='{dateTimePickerDateFinish.Value}' where id = {requestId}";
            }
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
            if (flowLayoutPanelParts.Controls.Count > 0)
                foreach (Panel item in flowLayoutPanelParts.Controls)
                {
                    var comboBox = (ComboBox)item.Controls[0];
                    var numeric = (NumericUpDown)item.Controls[1];
                    if (comboBox.SelectedIndex != -1)
                    {
                        if (item.Name == "" && numeric.Value != 0)
                            sql = $"insert into order_parts(request, part, count) values({requestId}, " +
                                $"(select id from part where title='{(string)comboBox.SelectedItem}'), {numeric.Value})";
                        else if (numeric.Value == 0)
                            sql = $"delete from order_parts where request={requestId} and part={int.Parse(item.Name)}";
                        else
                            sql = $"update order_parts set part=(select id from part where title='{(string)comboBox.SelectedItem}'), " +
                                    $"count={numeric.Value} where request={requestId} and part={int.Parse(item.Name)}";
                        Program.con.Open();
                        cmd = new NpgsqlCommand(sql, Program.con);
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
                    }
                }
            if (flowLayoutPanelSpecialists.Controls.Count > 0)
                foreach (Panel item in flowLayoutPanelSpecialists.Controls)
                {
                    var comboBox = (ComboBox)item.Controls[0];
                    if (comboBox.SelectedIndex != -1)
                    {
                        if (item.Name == "")
                            sql = $"insert into additional_specialist(request, specialist) values({requestId}, " +
                                $"(select specialist.id from specialist join public.user on specialist.id=public.user.id where " +
                                $"specialization='{((string)comboBox.SelectedItem).Split(" ", 2)[0]}' and " +
                                $"fio='{((string)comboBox.SelectedItem).Split(" ", 2)[1]}'))";
                        else
                            sql = $"update additional_specialist set specialist=" +
                                $"(select specialist.id from specialist join public.user on specialist.id=public.user.id where " +
                                $"specialization='{((string)comboBox.SelectedItem).Split(" ", 2)[0]}' and " +
                                $"fio='{((string)comboBox.SelectedItem).Split(" ", 2)[1]}') where request={requestId} " +
                                $"and specialist={int.Parse(item.Name)}";
                        Program.con.Open();
                        cmd = new NpgsqlCommand(sql, Program.con);
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
                    }
                    Program.ChangeForm(this, new AllRequestsForm(userGroupId, userId));
                }
        }

        private void buttonToReport_Click(object sender, EventArgs e)
        {
            if (requestId != null)
                Program.ChangeForm(this, new ReportForm(userId, (int)requestId));
        }

        private void buttonAddPart_Click(object sender, EventArgs e)
        {
            var panel = new Panel()
            {
                Location = new Point(3, 3),
                Name = "",
                Size = new Size(402, 77)
            };
            var comboBox = new ComboBox()
            {
                FormattingEnabled = true,
                Location = new Point(15, 13),
                Size = new Size(259, 28)
            };
            comboBox.Items.AddRange(GetParts());
            var numeric = new NumericUpDown()
            {
                Location = new Point(320, 14),
                Size = new Size(70, 27)
            };
            panel.Controls.Add(comboBox);
            panel.Controls.Add(numeric);
            flowLayoutPanelParts.Controls.Add(panel);
        }

        private string[] GetParts()
        {
            Program.con.Open();
            var cmd = new NpgsqlCommand("select title from part", Program.con);
            var reader = cmd.ExecuteReader();
            var result = new List<string>();
            while (reader.Read())
                result.Add((string)reader.GetValue(0));
            Program.con.Close();
            return result.ToArray();
        }

        private string[] GetSpecialists()
        {
            Program.con.Open();
            var cmd = new NpgsqlCommand("select specialization || ' ' || fio from public.user join specialist on public.user.id=specialist.id", Program.con);
            var reader = cmd.ExecuteReader();
            var result = new List<string>();
            while (reader.Read())
                result.Add((string)reader.GetValue(0));
            Program.con.Close();
            return result.ToArray();
        }

        private void buttonAddSpecialist_Click(object sender, EventArgs e)
        {
            var panel = new Panel()
            {
                Location = new Point(3, 3),
                Name = "",
                Size = new Size(402, 77)
            };
            var comboBox = new ComboBox()
            {
                FormattingEnabled = true,
                Location = new Point(15, 13),
                Size = new Size(361, 28)
            };
            comboBox.Items.AddRange(GetSpecialists());
            panel.Controls.Add(comboBox);
            flowLayoutPanelSpecialists.Controls.Add(panel);
        }

        private string[] GetPhases()
        {
            Program.con.Open();
            var cmd = new NpgsqlCommand("select title from phase", Program.con);
            var reader = cmd.ExecuteReader();
            var result = new List<string>();
            while (reader.Read())
                result.Add((string)reader.GetValue(0));
            Program.con.Close();
            return result.ToArray();
        }

        private string[] GetFailures()
        {
            Program.con.Open();
            var cmd = new NpgsqlCommand("select title from failure_type", Program.con);
            var reader = cmd.ExecuteReader();
            var result = new List<string>();
            while (reader.Read())
                result.Add((string)reader.GetValue(0));
            Program.con.Close();
            return result.ToArray();
        }
    }
}
