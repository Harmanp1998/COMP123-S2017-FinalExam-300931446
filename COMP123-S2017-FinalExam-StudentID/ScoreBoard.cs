using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Harmanpreet Singh
 * Date: 17 August,2017
 * StudentID: 300931446
 * Description: This is the Scoreboard Class
 * Version 0.1: Scaffoled out version of the Diagram
 */
namespace COMP123_S2017_FinalExam_300931446
{
    class ScoreBoard
    {
        //Instance Variables(Fields)
        public TextBox _finalScoreTextBox;
        public int _score;
        public TextBox _scoreTextBox;
        public int _time;
        public TextBox _timeTextBox;
        //Properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
               
            }
            set
            {
                ScoreTextBox.Text = Convert.ToString(this._score);
                FinalScoreTextBox.Text = Convert.ToString(this._score);
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                TimeTextBox.Text = Convert.ToString(this._time);
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }
        //Methods
        /// <summary>
        ///This method will update the timer 
        /// </summary>
        public void UpdateTime()
        {
            int time = int.Parse(TimeTextBox.Text);
            time = time - 1;
            Time = time;
        }
    }
}
