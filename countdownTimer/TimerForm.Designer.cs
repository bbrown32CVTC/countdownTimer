namespace countdownTimer
{
    partial class TimerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            countdownTimer = new System.Windows.Forms.Timer(components);
            hourLabel = new Label();
            minutesLabel = new Label();
            secondsLabel = new Label();
            hourDropdownList = new ComboBox();
            minutesDropDown = new ComboBox();
            secondsDropDown = new ComboBox();
            setBtn = new Button();
            countdownDisplay = new Label();
            startBtn = new Button();
            stopBtn = new Button();
            resetBtn = new Button();
            SuspendLayout();
            // 
            // hourLabel
            // 
            hourLabel.AutoSize = true;
            hourLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            hourLabel.Location = new Point(39, 46);
            hourLabel.Name = "hourLabel";
            hourLabel.Size = new Size(65, 23);
            hourLabel.TabIndex = 0;
            hourLabel.Text = "Hour:";
            // 
            // minutesLabel
            // 
            minutesLabel.AutoSize = true;
            minutesLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minutesLabel.Location = new Point(205, 46);
            minutesLabel.Name = "minutesLabel";
            minutesLabel.Size = new Size(93, 23);
            minutesLabel.TabIndex = 1;
            minutesLabel.Text = "Minutes:";
            // 
            // secondsLabel
            // 
            secondsLabel.AutoSize = true;
            secondsLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            secondsLabel.Location = new Point(389, 46);
            secondsLabel.Name = "secondsLabel";
            secondsLabel.Size = new Size(99, 23);
            secondsLabel.TabIndex = 2;
            secondsLabel.Text = "Seconds:";
            // 
            // hourDropdownList
            // 
            hourDropdownList.DropDownStyle = ComboBoxStyle.DropDownList;
            hourDropdownList.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hourDropdownList.FormattingEnabled = true;
            hourDropdownList.Location = new Point(12, 85);
            hourDropdownList.Name = "hourDropdownList";
            hourDropdownList.Size = new Size(121, 26);
            hourDropdownList.TabIndex = 3;
            // 
            // minutesDropDown
            // 
            minutesDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            minutesDropDown.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minutesDropDown.FormattingEnabled = true;
            minutesDropDown.Location = new Point(193, 85);
            minutesDropDown.Name = "minutesDropDown";
            minutesDropDown.Size = new Size(121, 26);
            minutesDropDown.TabIndex = 4;
            // 
            // secondsDropDown
            // 
            secondsDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            secondsDropDown.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            secondsDropDown.FormattingEnabled = true;
            secondsDropDown.Location = new Point(377, 85);
            secondsDropDown.Name = "secondsDropDown";
            secondsDropDown.Size = new Size(121, 26);
            secondsDropDown.TabIndex = 5;
            // 
            // setBtn
            // 
            setBtn.BackColor = Color.LightCyan;
            setBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            setBtn.Location = new Point(12, 151);
            setBtn.Name = "setBtn";
            setBtn.Size = new Size(486, 45);
            setBtn.TabIndex = 6;
            setBtn.Text = "Set Timer";
            setBtn.UseVisualStyleBackColor = false;
            setBtn.Click += this.setBtn_Click;
            // 
            // countdownDisplay
            // 
            countdownDisplay.AutoSize = true;
            countdownDisplay.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point);
            countdownDisplay.Location = new Point(39, 230);
            countdownDisplay.Name = "countdownDisplay";
            countdownDisplay.Size = new Size(407, 78);
            countdownDisplay.TabIndex = 7;
            countdownDisplay.Text = "100:59:59";
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.LightGreen;
            startBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startBtn.Location = new Point(39, 345);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(195, 45);
            startBtn.TabIndex = 8;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            // 
            // stopBtn
            // 
            stopBtn.BackColor = Color.LightCoral;
            stopBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stopBtn.Location = new Point(251, 345);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(195, 45);
            stopBtn.TabIndex = 9;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Gold;
            resetBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(12, 458);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(486, 45);
            resetBtn.TabIndex = 10;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            // 
            // TimerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 551);
            Controls.Add(resetBtn);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            Controls.Add(countdownDisplay);
            Controls.Add(setBtn);
            Controls.Add(secondsDropDown);
            Controls.Add(minutesDropDown);
            Controls.Add(hourDropdownList);
            Controls.Add(secondsLabel);
            Controls.Add(minutesLabel);
            Controls.Add(hourLabel);
            Name = "TimerForm";
            Text = "Countdown Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer countdownTimer;
        private Label hourLabel;
        private Label minutesLabel;
        private Label secondsLabel;
        private ComboBox hourDropdownList;
        private ComboBox minutesDropDown;
        private ComboBox secondsDropDown;
        private Button setBtn;
        private Label countdownDisplay;
        private Button startBtn;
        private Button stopBtn;
        private Button resetBtn;
    }
}
