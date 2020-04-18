using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using sellTrainTickets.Controllers;
using System.IO;

namespace sellTrainTickets
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
            //new Controller().run();
            string path = "C:\\Users\\user\\Desktop\\KPI\\4sem\\trpz\\project\\sell-trainTickets\\sell-trainTickets\\sell-trainTickets\\config.txt";
            string pass = File.ReadAllText(path);
            Console.WriteLine(pass);
            Console.ReadLine();
        }
    }
}