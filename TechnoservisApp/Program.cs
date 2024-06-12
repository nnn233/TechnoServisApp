using Npgsql;

namespace TechnoservisApp
{
    internal static class Program
    {
        private static ApplicationContext context;
        public static Color buttonColor= ColorTranslator.FromHtml("#00CC76");
        public static Color additionalBackground = ColorTranslator.FromHtml("#CEFFF9");
        public static NpgsqlConnection con = new("host=127.0.0.1; port=5432; username=postgres; database=user01; password=25481;");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            context = new ApplicationContext(new AuthorizationForm());
            Application.Run(context);
        }

        public static void ChangeForm(Form oldForm, Form newForm)
        {
            context.MainForm = newForm;
            context.MainForm.AutoScaleMode = AutoScaleMode.None;
            context.MainForm.BackColor = Color.White;
            context.MainForm.Font = new Font("Gabriola", 12);
            newForm.Show();
            oldForm.Close();
        }
    }
}