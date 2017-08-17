using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Harmanpreet Singh
 * Date: 17 August, 2017  
 * StudentID: 300931446
 * Description: This is the main program for the Pick Hisghest Card Application
 * Version 0.1 : Created an instance of pickHighestCard object
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        // Create Reference to Forms
        public static PickHighestCardForm pickHighestCardForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Instantiate a new object of type PickHighestCardForm
            pickHighestCardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
