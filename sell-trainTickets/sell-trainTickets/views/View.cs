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

        public MainForm MainForm { get; private set; }
        public void toMainForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            MainForm = new MainForm();
            if(!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(MainForm);
            }
            else if(isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(MainForm);
            }
            MainForm.StartPosition = FormStartPosition.CenterScreen;
            MainForm.ShowDialog();
            
        }

        public void fromRegistrationToMainForm(Form RegistrationForm)
        {
            RegistrationForm.Hide();
            MainForm = new MainForm();
            MainForm.StartPosition = FormStartPosition.CenterScreen;
            MainForm.ShowDialog();
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

        public PayForm PayForm { get; private set; }
        public void toPayForm(Form form, bool isAdmin, bool isSuperAdmin, Ticket ticket)
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
            //вивести квиток
            AvailableRacesForm.StartPosition = FormStartPosition.CenterScreen;
            AvailableRacesForm.ShowDialog();
        }

        public InfoForm InfoForm { get; private set; }
        public void toInfoForm(Form form, bool isAdmin, bool isSuperAdmin, List<Ticket> tickets, User user)
        {
            form.Hide();
            InfoForm = new InfoForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(InfoForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(InfoForm);
            }
            //вивсти інфрмацію про користувача та його квитки
            InfoForm.StartPosition = FormStartPosition.CenterScreen;
            InfoForm.ShowDialog();
        }

        public AddRaceForm AddRaceForm { get; private set; }
        public void toAddRaceForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            AddRaceForm = new AddRaceForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser (AddRaceForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(AddRaceForm);
            }
            AddRaceForm.StartPosition = FormStartPosition.CenterScreen;
            AddRaceForm.ShowDialog();

        }

        public DeleteRaceForm DeleteRaceForm { get; private set; }
        public void toDeleteRaceForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            DeleteRaceForm = new DeleteRaceForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(DeleteRaceForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(DeleteRaceForm);
            }
            DeleteRaceForm.StartPosition = FormStartPosition.CenterScreen;
            DeleteRaceForm.ShowDialog();

        }

        public AddAdminForm AddAdminForm { get; private set; }
        public void toAddAdminForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            AddAdminForm = new AddAdminForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(AddAdminForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(AddAdminForm);
            }
            AddAdminForm.StartPosition = FormStartPosition.CenterScreen;
            AddAdminForm.ShowDialog();

        }

        public DeleteAdminForm DeleteAdminForm { get; private set; }
        public void toDeleteAdminForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            DeleteAdminForm = new DeleteAdminForm();
            if (!isAdmin && !isSuperAdmin)
            {
                hideOptionsForUser(DeleteAdminForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                hideOptionsForAdmin(DeleteAdminForm);
            }
            DeleteAdminForm.StartPosition = FormStartPosition.CenterScreen;
            DeleteAdminForm.ShowDialog();

        }
    }
}