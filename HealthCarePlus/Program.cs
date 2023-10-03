using Microsoft.VisualBasic.Logging;

namespace HealthCarePlus
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new login());

            //if (IsUserLoggedIn())
            //{
                //It'll check whether user loggedin, if yes the system shows the Menu
               // Application.Run(new Menu()); 
            //}
           // else
            //{
                //If the user is not logged in, the system runs the login form
              //  Application.Run(new login()); 
            //}
        }

        //static bool IsUserLoggedIn()
        //{
           
           // return !string.IsNullOrEmpty(Session.Username) && !string.IsNullOrEmpty(Session.Role);
        //}
    }
}