using System.Text;

namespace ZooManagementSystem
{

    // Interface for animals that can be fed
    public interface IFeedable
    {
        public string Feed(string food);
    }

    // Interface for animals that can move
    public interface IMovable
    {
        public string Move();
    }

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
            Application.Run(new frmMain());
        }
    }
}