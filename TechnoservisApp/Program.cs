namespace TechnoservisApp
{
    internal static class Program
    {
        private static ApplicationContext context;
        public static Color buttonColor;
        public static Color additionalBackground;
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
            buttonColor = ColorTranslator.FromHtml("#00CC76");
            additionalBackground = ColorTranslator.FromHtml("#CEFFF9");
            Application.Run(context);
        }

        private static void ChangeForm(Form oldForm, Form newForm)
        {
            context.MainForm = newForm;
            context.MainForm.BackColor = Color.White;
            context.MainForm.Font = new Font("Gabriola", 12);
            newForm.Show();
            oldForm.Close();
        }
    }
}