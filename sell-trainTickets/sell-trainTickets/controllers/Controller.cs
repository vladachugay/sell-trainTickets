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
using System.Net.NetworkInformation;

namespace sellTrainTickets.Controllers
{
    class Controller
    {
        private static DataService dataService = new DataService();
        private static ViewForms view = new ViewForms();
        private static Validator validator = new Validator();
        public void run()
        {
            DBSource.openConnection();
            view.show();
        }

        private static string getMAC()
        {
            string addr = "";
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (n.OperationalStatus == OperationalStatus.Up)
                {
                    addr += n.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return addr;
        }

        public static void login(string email, string pass, AuthorizationForm authorizationForm)
        {
            try
            {
                if (validator.checkAuthorization(dataService.getUserWithLogPass(email, pass)))
                {
                    dataService.addSession(email, getMAC());
                    view.toMainForm(authorizationForm, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()));
                }
                else
                {
                    view.getAuthorizationError(authorizationForm);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }  

        }
        public static void closeApplication()
        {
            try
            {
                dataService.deleteSession(getMAC());
                DBSource.closeConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            } 
        }

        public static void registrate(string fullName, string email, string pass, RegistrationForm registrationForm)
        {
            try
            {
                dataService.addUser(fullName, email, pass);
                dataService.addSession(email, getMAC());
                view.fromRegistrationToMainForm(registrationForm);
            }
            catch (Npgsql.PostgresException e)
            {
                registrationForm.showRegistrationError();
                Console.WriteLine(e.MessageText);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnSearchRacesButton(Form form)
        {
            try
            {
                view.toMainForm(form, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnAvailableRacesButton(string departureCity, string arrivalCity, DateTime date, MainForm mainForm)
        {
            try
            {
                List<Race> availableRaces = dataService.findRaces(departureCity, arrivalCity, date);
                int[] departureStationIndexes = new int[availableRaces.Count];
                int[] arrivalStationIndexes = new int[availableRaces.Count];
                for (int i = 0; i < availableRaces.Count; i++)
                {
                    departureStationIndexes[i] = availableRaces[i].Stations.FindIndex(x => x.Contains(departureCity));
                    arrivalStationIndexes[i] = availableRaces[i].Stations.FindIndex(x => x.Contains(arrivalCity));
                }
                if (availableRaces.Count > 0)
                {
                    view.toAvailableRacesForm(mainForm, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()),
                        availableRaces, departureStationIndexes, arrivalStationIndexes, date);
                }
                else
                {
                    mainForm.showNoResultError();
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }

        public static void clickOnRace(int raceId, DateTime date, string departureCity, string arrivalCity, AvailableRacesForm availableRacesForm)
        {
            try
            {
                User user = dataService.getUser(getMAC());
                Ticket ticket = dataService.createTicket(raceId, date, departureCity, arrivalCity, user.FullName);
                view.toPayForm(availableRacesForm, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()), ticket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnPayButton(int raceId, DateTime date, string deprtureCity, string arrivalCity, PayForm payForm)
        {
            try
            {
                User user = dataService.getUser(getMAC());
                Ticket boughtTicket = dataService.createTicket(raceId, date, deprtureCity, arrivalCity, user.FullName);
                dataService.buyTicket(boughtTicket, user.Email);
                List<Ticket> userTickets = dataService.getUsersTickets(user.Email);
                view.toInfoForm(payForm, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()), userTickets, user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnInfoButton(Form form)
        {
            try
            {
                User user = dataService.getUser(getMAC());
                List<Ticket> userTickets = dataService.getUsersTickets(user.Email);
                view.toInfoForm(form, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()), userTickets, user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnReturnTicket(int id, InfoForm infoForm)
        {
            try
            {

                DialogResult result = MessageBox.Show("Ви бажаєте повернути квиток? Ця дія не є зворотньою.", "Попередження", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    dataService.returnTicket(id);
                    clickOnInfoButton(infoForm);
                }    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnAddRaceOption(Form form)
        {
            try
            {
                view.toAddRaceForm(form, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnAddRaceButton(AddRaceForm addRaceForm, int id, string name, string stations, string arrivalTime, string departureTime, int numOfSeats, int price)
        {
            try
            {
                bool issuccessful = dataService.addRace(id, name, stations, arrivalTime, departureTime, numOfSeats, price);
                if (issuccessful)
                {
                    MessageBox.Show("Рейс був успішно добавлений.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    view.toAddRaceForm(addRaceForm, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()));
                }
                else MessageBox.Show("ID повинен бути унікальним. Перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.ToString());
            }    
        }

        public static void clickOnDeleteRaceOption(Form form)
        {
            try
            {
                view.toDeleteRaceForm(form, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()));
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
                bool issuccessful = dataService.deleteRace(id);
                if(issuccessful)
                {
                    MessageBox.Show("Рейс був успішно видалений.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Помилка при видаленні рейсу. Перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnAddAdminOption(Form form)
        {
            try
            {
                view.toAddAdminForm(form, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()));
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
                bool isSuccessful = dataService.addAdmin(email);
                if(isSuccessful)
                {
                    MessageBox.Show("Адміністратор був успішно добавлений.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Помилка при додаванні адміністратора. Перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnDeleteAdminOption(Form form)
        {
            try
            {
                view.toDeleteAdminForm(form, dataService.isAdmin(getMAC()), dataService.isSuperAdmin(getMAC()));
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
                bool isSuccessful = dataService.deleteAdmin(email);
                if (isSuccessful)
                {
                    MessageBox.Show("Адміністратор був успішно видалений.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Помилка при видаленні адміністратора. Перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        public static void clickOnRefreshButton()
        {
            try
            {
                dataService.refreshSchedule();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnFillButton()
        {
            try
            {
                dataService.fillSchedule();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void clickOnExitButton(InfoForm infoForm)
        {
            dataService.deleteSession(getMAC());
            view.toAuthorizationForm(infoForm);
        }
    }
}
