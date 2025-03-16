namespace Clockeate
{
    partial class MainScreen
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
            clockin_button = new Button();
            Timelabel = new Label();
            clockout_button = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // clockin_button
            // 
            clockin_button.BackColor = Color.ForestGreen;
            clockin_button.Location = new Point(32, 63);
            clockin_button.Name = "clockin_button";
            clockin_button.Size = new Size(194, 68);
            clockin_button.TabIndex = 0;
            clockin_button.Text = "Clock-In";
            clockin_button.UseVisualStyleBackColor = false;
            // 
            // Timelabel
            // 
            Timelabel.AutoSize = true;
            Timelabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Timelabel.Location = new Point(327, 9);
            Timelabel.Name = "Timelabel";
            Timelabel.Size = new Size(138, 30);
            Timelabel.TabIndex = 1;
            Timelabel.Text = "DisplayTime:";
            // 
            // clockout_button
            // 
            clockout_button.BackColor = Color.Orange;
            clockout_button.Location = new Point(32, 155);
            clockout_button.Name = "clockout_button";
            clockout_button.Size = new Size(194, 68);
            clockout_button.TabIndex = 2;
            clockout_button.Text = "Clock-Out";
            clockout_button.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clockout_button);
            Controls.Add(Timelabel);
            Controls.Add(clockin_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLOCKEATE";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clockin_button;
        private Label Timelabel;
        private Button clockout_button;
        private System.Windows.Forms.Timer timer1;
    }
}
