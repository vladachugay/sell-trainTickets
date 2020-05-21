using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sellTrainTickets.Views;
using sellTrainTickets.Models;
using System.Net;
using System.Collections;

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
            try
            {
                if (validator.checkAuthorization(dataService.getUserWithLogPass(email, pass)))
                {
                    dataService.addSession(email, getIP());
                    view.toMainForm(AuthorizationForm, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()));
                }
                else
                {
                    //добавити текст про помилку в формі
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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

        [Obsolete]
        public static void clickOnSearchRacesButton(Form form)
        {
            try
            {
                view.toMainForm(form, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Obsolete]
        public static void clickOnAvailableRacesButton(string departureCity, string arrivalCity, DateTime date, Form MainForm)
        {
            try
            {
                ArrayList availableRaces = dataService.findRaces(departureCity, arrivalCity, date);
                view.toAvailableRacesForm(MainForm, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()), availableRaces);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Obsolete]
        public static void clickOnRace(int raceId, string date, string deprtureCity, string arrivalCity, Form AvailableRacesForm)
        {
            try
            {
                User user = dataService.getUser(getIP());
                Ticket ticket = dataService.createTicket(raceId, date, deprtureCity, arrivalCity, user.FullName);
                view.toPayForm(AvailableRacesForm, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()), ticket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Obsolete]
        public static void clickOnPayButton(int raceId, string date, string deprtureCity, string arrivalCity, Form PayForm)
        {
            try
            {
                User user = dataService.getUser(getIP());
                Ticket boughtTicket = dataService.createTicket(raceId, date, deprtureCity, arrivalCity, user.FullName);
                dataService.buyTicket(boughtTicket);
                List<Ticket> userTickets = dataService.getUsersTickets(user.Email);
                view.toInfoForm(PayForm, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()), userTickets, user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Obsolete]
        public static void clickOnInfoButton(Form form)
        {
            try
            {
                User user = dataService.getUser(getIP());
                List<Ticket> userTickets = dataService.getUsersTickets(user.Email);
                view.toInfoForm(form, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()), userTickets, user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnReturnTicket(int id, Form InfoForm)
        {
            try
            {
                dataService.returnTicket(id);
                view.deleteTicket(InfoForm);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Obsolete]
        public static void clickOnAddRaceOption(Form form)
        {
            try
            {
                view.toAddRaceForm(form, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnAddRaceButton(Form form, int id, string stations, string arrivalTime, string departureTime, int numOfSeats)
        {
            try
            {
                dataService.addRace(id, stations, arrivalTime, departureTime, numOfSeats);
                view.toMainForm(form, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Obsolete]
        public static void clickOnDeleteRaceOption(Form form)
        {
            try
            {
                view.toDeleteRaceForm(form, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnDeleteRaceButton(int id)
        {
            try
            {
                dataService.deleteRace(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Obsolete]
        public static void clickOnAddAdminOption(Form form)
        {
            try
            {
                view.toAddAdminForm(form, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnAddAdminButton(string email)
        {
            try
            {
                dataService.addAdmin(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Obsolete]
        public static void clickOnDeleteAdminOption(Form form)
        {
            try
            {
                view.toDeleteAdminForm(form, dataService.isAdmin(getIP()), dataService.isSuperAdmin(getIP()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnDeleteAdminButton(string email)
        {
            try
            {
                dataService.deleteAdmin(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
