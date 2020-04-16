using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        public MainForm MainForm { get; private set; }
        public void createForm2(string log, string pass, Form form1)
        {
            form1.Hide();
            MainForm = new MainForm();
            MainForm.LabelText1 = log;
            MainForm.LabelText2 = pass;
            MainForm.StartPosition = FormStartPosition.CenterScreen;
            MainForm.ShowDialog();
           
        }
    }
}