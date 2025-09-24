namespace Basic_Threading_Lab_Execercise_03_Navarro
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStartandStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(98)))), ((int)(((byte)(106)))));
            this.lblStatus.Location = new System.Drawing.Point(32, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(293, 31);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "-Before starting thread-";
       
            // 
            // btnStartandStop
            // 
            this.btnStartandStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.btnStartandStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartandStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnStartandStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(98)))), ((int)(((byte)(106)))));
            this.btnStartandStop.Location = new System.Drawing.Point(92, 72);
            this.btnStartandStop.Name = "btnStartandStop";
            this.btnStartandStop.Size = new System.Drawing.Size(160, 84);
            this.btnStartandStop.TabIndex = 1;
            this.btnStartandStop.Text = "Start";
            this.btnStartandStop.UseVisualStyleBackColor = false;
            this.btnStartandStop.Click += new System.EventHandler(this.btnStartandStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(356, 217);
            this.Controls.Add(this.btnStartandStop);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Form1";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStartandStop;
    }
}

