using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sellTrainTickets.Models;


namespace sellTrainTickets.Views
{
    class ViewForms
    {
        public void show()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }

        private void hideOptionsForAdmin(Form form)
        {
            //
        }

        private void hideOptionsForUser(Form form)
        {
            hideOptionsForAdmin(form);
            //
        }

        public void toMainForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            MainForm mainForm = new MainForm();
            if(!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(mainForm);
            }
            else if(isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(mainForm);
            }
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.ShowDialog();
            
        }

        public void fromRegistrationToMainForm(Form RegistrationForm)
        {
            RegistrationForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.ShowDialog();
        }

        public AvailableRacesForm AvailableRacesForm { get; private set; }

        public void toAvailableRacesForm(Form form, bool isAdmin, bool isSuperAdmin, ArrayList availableRaces)
        {
            form.Hide();
            AvailableRacesForm = new AvailableRacesForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(AvailableRacesForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(AvailableRacesForm);
            }
            foreach (var availableRace in availableRaces)
            {
                //
            }
            AvailableRacesForm.StartPosition = FormStartPosition.CenterScreen;
            AvailableRacesForm.ShowDialog();
        }

        //public PayForm PayForm { get; private set; }
        public void toPayForm(Form form, bool isAdmin, bool isSuperAdmin, Ticket ticket)
        {
            form.Hide();
            PayForm payForm = new PayForm();
            AvailableRacesForm = new AvailableRacesForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(AvailableRacesForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(AvailableRacesForm);
            }
            //вивести квиток
            AvailableRacesForm.StartPosition = FormStartPosition.CenterScreen;
            AvailableRacesForm.ShowDialog();
        }

        public void toInfoForm(Form form, bool isAdmin, bool isSuperAdmin, List<Ticket> tickets, User user)
        {
            form.Hide();
            InfoForm infoForm = new InfoForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(infoForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(infoForm);
            }
            //вивсти інфрмацію про користувача та його квитки
            infoForm.StartPosition = FormStartPosition.CenterScreen;
            infoForm.ShowDialog();
        }

        public void toAddRaceForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            AddRaceForm addRaceForm = new AddRaceForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser (addRaceForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(addRaceForm);
            }
            addRaceForm.StartPosition = FormStartPosition.CenterScreen;
            addRaceForm.ShowDialog();

        }

        public void toDeleteRaceForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            DeleteRaceForm deleteRaceForm = new DeleteRaceForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(deleteRaceForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(deleteRaceForm);
            }
            deleteRaceForm.StartPosition = FormStartPosition.CenterScreen;
            deleteRaceForm.ShowDialog();

        }

        public void toAddAdminForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            AddAdminForm addAdminForm = new AddAdminForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(addAdminForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(addAdminForm);
            }
            addAdminForm.StartPosition = FormStartPosition.CenterScreen;
            addAdminForm.ShowDialog();

        }

        public void toDeleteAdminForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            DeleteAdminForm deleteAdminForm = new DeleteAdminForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(deleteAdminForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(deleteAdminForm);
            }
            deleteAdminForm.StartPosition = FormStartPosition.CenterScreen;
            deleteAdminForm.ShowDialog();

        }

        public void deleteTicket(Form InfoForm)
        {

        }
    }
}