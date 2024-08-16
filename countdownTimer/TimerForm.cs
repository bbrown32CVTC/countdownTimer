/*
 * Created by: Bruce Brown 
 * Date Created: 8/16/2024
 */

namespace countdownTimer
{

    /// <summary>
    /// A proof of concept C# WinForm application for counting down the time set by the user.
    /// The "Start" button starts the timer, "Stop" button stops the timer, and "Reset" will 
    /// reset the timer to the amount originally set by the user. The "Reset" button will only
    /// display after the "Stop" button has been clicked.
    /// </summary>
    /// 
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }
    }
}
