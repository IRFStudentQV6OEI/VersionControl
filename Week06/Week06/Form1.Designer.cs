namespace Week06
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createtimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.carbtn = new System.Windows.Forms.Button();
            this.ballbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorbtn = new System.Windows.Forms.Button();
            this.presentbtn = new System.Windows.Forms.Button();
            this.boxcolbtn = new System.Windows.Forms.Button();
            this.ribboncolbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Location = new System.Drawing.Point(2, 199);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainPanel.Size = new System.Drawing.Size(1267, 433);
            this.mainPanel.TabIndex = 0;
            // 
            // createtimer
            // 
            this.createtimer.Enabled = true;
            this.createtimer.Interval = 3000;
            this.createtimer.Tick += new System.EventHandler(this.createtimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // carbtn
            // 
            this.carbtn.Location = new System.Drawing.Point(21, 12);
            this.carbtn.Name = "carbtn";
            this.carbtn.Size = new System.Drawing.Size(125, 61);
            this.carbtn.TabIndex = 1;
            this.carbtn.Text = "CAR";
            this.carbtn.UseVisualStyleBackColor = true;
            this.carbtn.Click += new System.EventHandler(this.carbtn_Click);
            // 
            // ballbtn
            // 
            this.ballbtn.Location = new System.Drawing.Point(152, 12);
            this.ballbtn.Name = "ballbtn";
            this.ballbtn.Size = new System.Drawing.Size(125, 61);
            this.ballbtn.TabIndex = 2;
            this.ballbtn.Text = "BALL";
            this.ballbtn.UseVisualStyleBackColor = true;
            this.ballbtn.Click += new System.EventHandler(this.ballbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comming next:";
            // 
            // colorbtn
            // 
            this.colorbtn.Location = new System.Drawing.Point(152, 79);
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(125, 23);
            this.colorbtn.TabIndex = 4;
            this.colorbtn.UseVisualStyleBackColor = true;
            this.colorbtn.Click += new System.EventHandler(this.colorbtn_Click);
            // 
            // presentbtn
            // 
            this.presentbtn.Location = new System.Drawing.Point(284, 13);
            this.presentbtn.Name = "presentbtn";
            this.presentbtn.Size = new System.Drawing.Size(103, 60);
            this.presentbtn.TabIndex = 5;
            this.presentbtn.Text = "PRESENT";
            this.presentbtn.UseVisualStyleBackColor = true;
            this.presentbtn.Click += new System.EventHandler(this.presentbtn_Click);
            // 
            // boxcolbtn
            // 
            this.boxcolbtn.Location = new System.Drawing.Point(284, 80);
            this.boxcolbtn.Name = "boxcolbtn";
            this.boxcolbtn.Size = new System.Drawing.Size(103, 23);
            this.boxcolbtn.TabIndex = 6;
            this.boxcolbtn.UseVisualStyleBackColor = true;
            this.boxcolbtn.Click += new System.EventHandler(this.boxcolbtn_Click);
            // 
            // ribboncolbtn
            // 
            this.ribboncolbtn.Location = new System.Drawing.Point(284, 109);
            this.ribboncolbtn.Name = "ribboncolbtn";
            this.ribboncolbtn.Size = new System.Drawing.Size(103, 23);
            this.ribboncolbtn.TabIndex = 7;
            this.ribboncolbtn.UseVisualStyleBackColor = true;
            this.ribboncolbtn.Click += new System.EventHandler(this.ribboncolbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 634);
            this.Controls.Add(this.ribboncolbtn);
            this.Controls.Add(this.boxcolbtn);
            this.Controls.Add(this.presentbtn);
            this.Controls.Add(this.colorbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ballbtn);
            this.Controls.Add(this.carbtn);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createtimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button carbtn;
        private System.Windows.Forms.Button ballbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button colorbtn;
        private System.Windows.Forms.Button presentbtn;
        private System.Windows.Forms.Button boxcolbtn;
        private System.Windows.Forms.Button ribboncolbtn;
    }
}

