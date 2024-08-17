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
            hoursLabel = new Label();
            minutesLabel = new Label();
            secondsLabel = new Label();
            hoursDropdownList = new ComboBox();
            minutesDropDownList = new ComboBox();
            secondsDropDownList = new ComboBox();
            countdownDisplay = new Label();
            startBtn = new Button();
            stopBtn = new Button();
            resetBtn = new Button();
            SuspendLayout();
            // 
            // countdownTimer
            // 
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += countdownTimer_Tick;
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            hoursLabel.Location = new Point(39, 46);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(75, 23);
            hoursLabel.TabIndex = 0;
            hoursLabel.Text = "Hours:";
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
            // hoursDropdownList
            // 
            hoursDropdownList.DropDownStyle = ComboBoxStyle.DropDownList;
            hoursDropdownList.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hoursDropdownList.FormattingEnabled = true;
            hoursDropdownList.Location = new Point(12, 85);
            hoursDropdownList.Name = "hoursDropdownList";
            hoursDropdownList.Size = new Size(121, 26);
            hoursDropdownList.TabIndex = 3;
            hoursDropdownList.SelectedIndexChanged += hoursDropdownList_SelectedIndexChanged;
            // 
            // minutesDropDownList
            // 
            minutesDropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            minutesDropDownList.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minutesDropDownList.FormattingEnabled = true;
            minutesDropDownList.Location = new Point(193, 85);
            minutesDropDownList.Name = "minutesDropDownList";
            minutesDropDownList.Size = new Size(121, 26);
            minutesDropDownList.TabIndex = 4;
            minutesDropDownList.SelectedIndexChanged += minutesDropDownList_SelectedIndexChanged;
            // 
            // secondsDropDownList
            // 
            secondsDropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            secondsDropDownList.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            secondsDropDownList.FormattingEnabled = true;
            secondsDropDownList.Location = new Point(382, 85);
            secondsDropDownList.Name = "secondsDropDownList";
            secondsDropDownList.Size = new Size(121, 26);
            secondsDropDownList.TabIndex = 5;
            secondsDropDownList.SelectedIndexChanged += secondsDropDownList_SelectedIndexChanged;
            // 
            // countdownDisplay
            // 
            countdownDisplay.AutoSize = true;
            countdownDisplay.Font = new Font("Verdana", 50F, FontStyle.Bold, GraphicsUnit.Point);
            countdownDisplay.Location = new Point(55, 149);
            countdownDisplay.Name = "countdownDisplay";
            countdownDisplay.Size = new Size(376, 80);
            countdownDisplay.TabIndex = 7;
            countdownDisplay.Text = "00:00:00";
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.LightGreen;
            startBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startBtn.Location = new Point(12, 286);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(195, 45);
            startBtn.TabIndex = 8;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.BackColor = Color.LightCoral;
            stopBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stopBtn.Location = new Point(303, 286);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(195, 45);
            stopBtn.TabIndex = 9;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = false;
            stopBtn.Click += stopBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Gold;
            resetBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(12, 370);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(486, 45);
            resetBtn.TabIndex = 10;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // TimerForm
            // 
            AcceptButton = startBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 436);
            Controls.Add(resetBtn);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            Controls.Add(countdownDisplay);
            Controls.Add(secondsDropDownList);
            Controls.Add(minutesDropDownList);
            Controls.Add(hoursDropdownList);
            Controls.Add(secondsLabel);
            Controls.Add(minutesLabel);
            Controls.Add(hoursLabel);
            Name = "TimerForm";
            Text = "Countdown Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer countdownTimer;
        private Label hoursLabel;
        private Label minutesLabel;
        private Label secondsLabel;
        private ComboBox hoursDropdownList;
        private ComboBox minutesDropDownList;
        private ComboBox secondsDropDownList;
        private Label countdownDisplay;
        private Button startBtn;
        private Button stopBtn;
        private Button resetBtn;
    }
}
