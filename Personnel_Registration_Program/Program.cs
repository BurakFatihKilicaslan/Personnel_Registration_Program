using Personnel_Registration_Program.Forms;

namespace Personnel_Registration_Program
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginScreen());
            //Application.Run(new EmployeeRegistrationScreen());
            //Application.Run(new InformationEditScreen(2));
            //Application.Run(new EmployeeInformationScreen());
            //Application.Run(new EmployeeRegistrationScreen());
        }
    }
}