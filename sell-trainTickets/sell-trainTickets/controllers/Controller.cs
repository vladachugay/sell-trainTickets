using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sellTrainTickets.Views;
using sellTrainTickets.Models;
using System.Net;

namespace sellTrainTickets.Controllers
{
    class Controller
    {
        private static DataService dataService = new DataService();
        private static ViewForms view = new ViewForms();
        private static Validator validator = new Validator();
        public void run()
        {
            //DBSource.openConnection();
            view.show();
        }

        [Obsolete]
        private static string getIP()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST 
            // Get the IP  
            return Dns.GetHostByName(hostName).AddressList[0].ToString();
        }

        [Obsolete]
        public static void login(string email, string pass, Form AuthorizationForm)
        {
            if (!validator.checkAuthorization(dataService.getUserWithLogPass(email, pass)))
            {
                view.toMainForm(AuthorizationForm, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()));
            }
            else
            {
                //добавити текст про помилку в формі
            }
        }

        [Obsolete]
        public static void closeApplication()
        {
            try
            {
                DBSource.closeConnection();
                dataService.deleteSession(getIP());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            } 
        }

        [Obsolete]
        public static void registrate(string fullName, string email, string pass, Form RegistrationForm)
        {
            try
            {
                dataService.addUser(fullName, email, pass);
                dataService.addSession(email, getIP());
                view.fromRegistrationToMainForm(RegistrationForm);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                // вивести помилку 
            }
        }




        
    }
}
