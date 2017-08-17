﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Harmanpreet Singh
 * Date: 17 August, 2017  
 * StudentID: 300931446
 * Description: This is the Splash Form for the application
 */
namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SplashForm : Form
    {
        //Public Properties
        public PickHighestCardForm PickHighestCardForm
        {
            get {
                return Program.pickHighestCardForm;
                }
        }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            this.PickHighestCardForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false; //This enables the PickCardHighestForm to be displayed only once
        }
    }
}
