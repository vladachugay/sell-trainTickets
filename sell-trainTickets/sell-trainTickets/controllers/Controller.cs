using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sellTrainTickets.Views;

namespace sellTrainTickets.Controllers
{
    class Controller
    {
        private static ViewForms view = new ViewForms();
        public void run()
        {
            view.show();
        }

        public static void login(string log, string pass, Form form)
        {
            if (true)
            {
                view.createForm2(form);
            }
        }
    }
}
