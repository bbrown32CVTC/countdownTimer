using System;

/*
 * Created by: Bruce Brown 
 * Date Created: 8/16/2024
 */

namespace countdownTimer
{

    /// <summary>
    /// A proof of concept C# WinForm application for counting down the time set by the user.The "Start" button 
    /// starts the timer, "Stop" button stops the timer, and "Reset" button will reset the timer to the time allotment 
    /// originally set by the user. The "Reset" button will only be enabled after the "Stop" button has been clicked. 
    /// The time dropdowns will be disabled after starting the timer and enabled again stopping. Timer will stop when 
    /// there are zero seconds remaining.
    /// </summary>
    /// 


    public partial class TimerForm : Form
    {
        private int totalTime, hours, minutes, seconds, remainingSeconds;
        private TimeSpan timeLeft;

        public TimerForm()
        {
            InitializeComponent();

            // Disable the stop and reset buttons
            //this.startBtn.Enabled = false;
            this.stopBtn.Enabled = false;
            this.resetBtn.Enabled = false;


            // Set the hours, minutes, and seconds in the dropdown list
            for (int i = 0; i < 100; i++)
            {
                // Set 0 through 100
                this.hoursDropdownList.Items.Add(i);
            }

            for(int i = 0; i <= 59; i++)
            {
                // Set 0 through 59
                this.minutesDropDownList.Items.Add(i);
            }

            for (int i = 0; i <= 59; i++)
            {
                // Set 0 through 59
                this.secondsDropDownList.Items.Add(i);
            }

            // Set the dropdown lists to the first item
            this.hoursDropdownList.SelectedIndex = 0;
            this.minutesDropDownList.SelectedIndex = 0;
            this.secondsDropDownList.SelectedIndex = 0;

        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            // Disable the start and resest buttons, as well as dropdown lists
            this.startBtn.Enabled = false;
            this.resetBtn.Enabled = false;
            this.hoursDropdownList.Enabled = false;
            this.minutesDropDownList.Enabled = false;
            this.secondsDropDownList.Enabled = false;

            // Enable the stop button
            this.stopBtn.Enabled = true;

            // Start the timer
            this.countdownTimer.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            // Enable the start and reset buttons
            this.startBtn.Enabled = true;
            this.resetBtn.Enabled = true;

            // Enable dropdown lists
            this.hoursDropdownList.Enabled = true;
            this.minutesDropDownList.Enabled = true;
            this.secondsDropDownList.Enabled = true;

            // Stop the timer
            this.countdownTimer.Stop();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // Reset the remaining time to the set countdown amount and display
            this.remainingSeconds = this.totalTime;
            this.timeLeft = new TimeSpan(0, 0, this.remainingSeconds);
            this.countdownDisplay.Text = Math.Truncate(this.timeLeft.TotalHours).ToString("00") + ":"
            + this.timeLeft.Minutes.ToString("00") + ":" + this.timeLeft.Seconds.ToString("00");

            // Enable dropdown lists
            this.hoursDropdownList.Enabled = true;
            this.minutesDropDownList.Enabled = true;
            this.secondsDropDownList.Enabled = true;

            // Disable the reset button
            this.resetBtn.Enabled = false;

        }

        private void hoursDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Convert input hours to an integer
            this.hours = Convert.ToInt32(this.hoursDropdownList.SelectedItem);

            // Calculate total time in seconds and set remaining seconds
            calcTotalTime();
            this.remainingSeconds = this.totalTime;

            // Set timespan remaining
            this.timeLeft = new TimeSpan(this.hours, this.minutes, this.seconds);

            // Calculate and format time to reflect more than 24 hours
            this.countdownDisplay.Text = Math.Truncate(this.timeLeft.TotalHours).ToString("00") + ":" 
                + this.timeLeft.Minutes.ToString("00") + ":" + this.timeLeft.Seconds.ToString("00");
        }

        private void minutesDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Convert input minutes to an integer
            this.minutes = Convert.ToInt32(this.minutesDropDownList.SelectedItem);

            // Calculate total time in seconds and set remaining seconds
            calcTotalTime();
            this.remainingSeconds = this.totalTime;

            // Set timespan remaining
            this.timeLeft = new TimeSpan(this.hours, this.minutes, this.seconds);

            // Calculate and format time to reflect more than 24 hours
            this.countdownDisplay.Text = Math.Truncate(this.timeLeft.TotalHours).ToString("00") + ":"
                + this.timeLeft.Minutes.ToString("00") + ":" + this.timeLeft.Seconds.ToString("00");
        }

        private void secondsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Convert input seconds to an integer
            this.seconds = Convert.ToInt32(this.secondsDropDownList.SelectedItem);

            // Calculate total time in seconds and set remaining seconds
            calcTotalTime();
            this.remainingSeconds = this.totalTime;

            // Set timespan remaining
            this.timeLeft = new TimeSpan(this.hours, this.minutes, this.seconds);

            // Calculate and format time to reflect more than 24 hours
            this.countdownDisplay.Text = Math.Truncate(this.timeLeft.TotalHours).ToString("00") + ":"
                + this.timeLeft.Minutes.ToString("00") + ":" + this.timeLeft.Seconds.ToString("00");
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (this.remainingSeconds > 0)
            {
                // Decrement the remaining seconds and display the remaining time
                this.remainingSeconds--;
                this.timeLeft = new TimeSpan(0, 0, this.remainingSeconds);
                this.countdownDisplay.Text = Math.Truncate(this.timeLeft.TotalHours).ToString("00") + ":"
                + this.timeLeft.Minutes.ToString("00") + ":" + this.timeLeft.Seconds.ToString("00");

            } else if (this.remainingSeconds == 0)
            {
                // Stop the timer from running
                this.countdownTimer.Stop();

                // Trigger Stop button
                stopBtn_Click(sender, e);
            }
        }

        private void calcTotalTime()
        {
            int inputHours, inputMinutes, inputSeconds;

            // Update all amounts to seconds
            inputHours = this.hours * 3600;
            inputMinutes = this.minutes * 60;
            inputSeconds = this.seconds;

            // Add to get total time
            this.totalTime = inputHours + inputMinutes + inputSeconds;
        }

    }

}
