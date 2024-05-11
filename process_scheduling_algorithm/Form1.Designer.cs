namespace process_scheduling_algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NOPTB = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PTB = new System.Windows.Forms.TextBox();
            this.BTTB = new System.Windows.Forms.TextBox();
            this.ATTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.processCounterLabel = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowDetailsBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of processes";
            // 
            // NOPTB
            // 
            this.NOPTB.Location = new System.Drawing.Point(6, 30);
            this.NOPTB.Name = "NOPTB";
            this.NOPTB.Size = new System.Drawing.Size(54, 22);
            this.NOPTB.TabIndex = 1;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(80, 30);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(73, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PTB);
            this.panel2.Controls.Add(this.BTTB);
            this.panel2.Controls.Add(this.ATTB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.processCounterLabel);
            this.panel2.Controls.Add(this.createBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(6, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 188);
            this.panel2.TabIndex = 3;
            // 
            // PTB
            // 
            this.PTB.Location = new System.Drawing.Point(317, 37);
            this.PTB.Name = "PTB";
            this.PTB.Size = new System.Drawing.Size(100, 22);
            this.PTB.TabIndex = 15;
            // 
            // BTTB
            // 
            this.BTTB.Location = new System.Drawing.Point(126, 83);
            this.BTTB.Name = "BTTB";
            this.BTTB.Size = new System.Drawing.Size(100, 22);
            this.BTTB.TabIndex = 14;
            // 
            // ATTB
            // 
            this.ATTB.Location = new System.Drawing.Point(126, 37);
            this.ATTB.Name = "ATTB";
            this.ATTB.Size = new System.Drawing.Size(100, 22);
            this.ATTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Burst Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Arrival Time";
            // 
            // processCounterLabel
            // 
            this.processCounterLabel.AutoSize = true;
            this.processCounterLabel.Location = new System.Drawing.Point(10, 10);
            this.processCounterLabel.Name = "processCounterLabel";
            this.processCounterLabel.Size = new System.Drawing.Size(89, 16);
            this.processCounterLabel.TabIndex = 7;
            this.processCounterLabel.Text = "Process Data";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(612, 155);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(73, 23);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, -19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(533, 155);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(73, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NOPTB);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 59);
            this.panel1.TabIndex = 4;
            // 
            // ShowDetailsBtn
            // 
            this.ShowDetailsBtn.Location = new System.Drawing.Point(565, 262);
            this.ShowDetailsBtn.Name = "ShowDetailsBtn";
            this.ShowDetailsBtn.Size = new System.Drawing.Size(126, 23);
            this.ShowDetailsBtn.TabIndex = 7;
            this.ShowDetailsBtn.Text = "Show Details";
            this.ShowDetailsBtn.UseVisualStyleBackColor = true;
            this.ShowDetailsBtn.Visible = false;
            this.ShowDetailsBtn.Click += new System.EventHandler(this.ShowDetailsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 310);
            this.Controls.Add(this.ShowDetailsBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Scheduling (Priority non-preemptive)";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NOPTB;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PTB;
        private System.Windows.Forms.TextBox BTTB;
        private System.Windows.Forms.TextBox ATTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label processCounterLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowDetailsBtn;
    }
}

