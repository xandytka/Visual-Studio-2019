namespace MultiThread
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
            this.btnThread1 = new System.Windows.Forms.Button();
            this.btnThread2 = new System.Windows.Forms.Button();
            this.btnTh1Abort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTh2Abort = new System.Windows.Forms.Button();
            this.btnTh1Suspend = new System.Windows.Forms.Button();
            this.btnTh2Suspend = new System.Windows.Forms.Button();
            this.btnTh1Resume = new System.Windows.Forms.Button();
            this.btnTh2Resume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThread1
            // 
            this.btnThread1.Location = new System.Drawing.Point(3, 3);
            this.btnThread1.Name = "btnThread1";
            this.btnThread1.Size = new System.Drawing.Size(75, 23);
            this.btnThread1.TabIndex = 0;
            this.btnThread1.Text = "Thread1";
            this.btnThread1.UseVisualStyleBackColor = true;
            this.btnThread1.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // btnThread2
            // 
            this.btnThread2.Location = new System.Drawing.Point(84, 3);
            this.btnThread2.Name = "btnThread2";
            this.btnThread2.Size = new System.Drawing.Size(75, 23);
            this.btnThread2.TabIndex = 1;
            this.btnThread2.Text = "Thread2";
            this.btnThread2.UseVisualStyleBackColor = true;
            this.btnThread2.Click += new System.EventHandler(this.btnThread2_Click);
            // 
            // btnTh1Abort
            // 
            this.btnTh1Abort.Location = new System.Drawing.Point(505, 3);
            this.btnTh1Abort.Name = "btnTh1Abort";
            this.btnTh1Abort.Size = new System.Drawing.Size(75, 23);
            this.btnTh1Abort.TabIndex = 2;
            this.btnTh1Abort.Text = "Th1 Abort";
            this.btnTh1Abort.UseVisualStyleBackColor = true;
            this.btnTh1Abort.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // btnTh2Abort
            // 
            this.btnTh2Abort.Location = new System.Drawing.Point(586, 3);
            this.btnTh2Abort.Name = "btnTh2Abort";
            this.btnTh2Abort.Size = new System.Drawing.Size(75, 23);
            this.btnTh2Abort.TabIndex = 5;
            this.btnTh2Abort.Text = "Th2Abort";
            this.btnTh2Abort.UseVisualStyleBackColor = true;
            this.btnTh2Abort.Click += new System.EventHandler(this.btnTh2Abort_Click);
            // 
            // btnTh1Suspend
            // 
            this.btnTh1Suspend.Location = new System.Drawing.Point(165, 3);
            this.btnTh1Suspend.Name = "btnTh1Suspend";
            this.btnTh1Suspend.Size = new System.Drawing.Size(83, 23);
            this.btnTh1Suspend.TabIndex = 6;
            this.btnTh1Suspend.Text = "Th1Suspend";
            this.btnTh1Suspend.UseVisualStyleBackColor = true;
            this.btnTh1Suspend.Click += new System.EventHandler(this.btnTh1Suspend_Click);
            // 
            // btnTh2Suspend
            // 
            this.btnTh2Suspend.Location = new System.Drawing.Point(254, 3);
            this.btnTh2Suspend.Name = "btnTh2Suspend";
            this.btnTh2Suspend.Size = new System.Drawing.Size(83, 23);
            this.btnTh2Suspend.TabIndex = 7;
            this.btnTh2Suspend.Text = "Th2Suspend";
            this.btnTh2Suspend.UseVisualStyleBackColor = true;
            this.btnTh2Suspend.Click += new System.EventHandler(this.btnTh2Suspend_Click);
            // 
            // btnTh1Resume
            // 
            this.btnTh1Resume.Location = new System.Drawing.Point(343, 3);
            this.btnTh1Resume.Name = "btnTh1Resume";
            this.btnTh1Resume.Size = new System.Drawing.Size(75, 23);
            this.btnTh1Resume.TabIndex = 8;
            this.btnTh1Resume.Text = "Th1Resume";
            this.btnTh1Resume.UseVisualStyleBackColor = true;
            this.btnTh1Resume.Click += new System.EventHandler(this.btnTh1Resume_Click);
            // 
            // btnTh2Resume
            // 
            this.btnTh2Resume.Location = new System.Drawing.Point(424, 3);
            this.btnTh2Resume.Name = "btnTh2Resume";
            this.btnTh2Resume.Size = new System.Drawing.Size(75, 23);
            this.btnTh2Resume.TabIndex = 9;
            this.btnTh2Resume.Text = "Th2Resume";
            this.btnTh2Resume.UseVisualStyleBackColor = true;
            this.btnTh2Resume.Click += new System.EventHandler(this.btnTh2Resume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 373);
            this.Controls.Add(this.btnTh2Resume);
            this.Controls.Add(this.btnTh1Resume);
            this.Controls.Add(this.btnTh2Suspend);
            this.Controls.Add(this.btnTh1Suspend);
            this.Controls.Add(this.btnTh2Abort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTh1Abort);
            this.Controls.Add(this.btnThread2);
            this.Controls.Add(this.btnThread1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThread1;
        private System.Windows.Forms.Button btnThread2;
        private System.Windows.Forms.Button btnTh1Abort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTh2Abort;
        private System.Windows.Forms.Button btnTh1Suspend;
        private System.Windows.Forms.Button btnTh2Suspend;
        private System.Windows.Forms.Button btnTh1Resume;
        private System.Windows.Forms.Button btnTh2Resume;
    }
}

