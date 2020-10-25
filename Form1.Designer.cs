namespace InternetMonitor
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
            this.connectionStateLabel = new System.Windows.Forms.Label();
            this.currentDurationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectionStateLabel
            // 
            this.connectionStateLabel.Location = new System.Drawing.Point(12, 23);
            this.connectionStateLabel.Name = "connectionStateLabel";
            this.connectionStateLabel.Size = new System.Drawing.Size(366, 44);
            this.connectionStateLabel.TabIndex = 0;
            this.connectionStateLabel.Text = "label1";
            // 
            // currentDurationLabel
            // 
            this.currentDurationLabel.Location = new System.Drawing.Point(12, 97);
            this.currentDurationLabel.Name = "currentDurationLabel";
            this.currentDurationLabel.Size = new System.Drawing.Size(365, 41);
            this.currentDurationLabel.TabIndex = 1;
            this.currentDurationLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentDurationLabel);
            this.Controls.Add(this.connectionStateLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label currentDurationLabel;

        private System.Windows.Forms.Label connectionStateLabel;

        #endregion
    }
}