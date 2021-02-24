namespace MyVNR
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtbView = new System.Windows.Forms.TextBox();
            this.txtbTrans = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtbSub = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 307);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbView
            // 
            this.txtbView.Location = new System.Drawing.Point(12, 12);
            this.txtbView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbView.Name = "txtbView";
            this.txtbView.Size = new System.Drawing.Size(568, 20);
            this.txtbView.TabIndex = 1;
            // 
            // txtbTrans
            // 
            this.txtbTrans.Location = new System.Drawing.Point(12, 48);
            this.txtbTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbTrans.Name = "txtbTrans";
            this.txtbTrans.Size = new System.Drawing.Size(568, 20);
            this.txtbTrans.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // txtbSub
            // 
            this.txtbSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbSub.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtbSub.ForeColor = System.Drawing.Color.Cyan;
            this.txtbSub.Location = new System.Drawing.Point(12, 93);
            this.txtbSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbSub.Multiline = true;
            this.txtbSub.Name = "txtbSub";
            this.txtbSub.Size = new System.Drawing.Size(568, 20);
            this.txtbSub.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.txtbSub);
            this.Controls.Add(this.txtbTrans);
            this.Controls.Add(this.txtbView);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbView;
        private System.Windows.Forms.TextBox txtbTrans;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtbSub;
    }
}

