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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectionStateLabel = new System.Windows.Forms.Label();
            this.currentDurationLabel = new System.Windows.Forms.Label();
            this.outageCountLabel = new System.Windows.Forms.Label();
            this.percentagesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectionStateLabel
            // 
            this.connectionStateLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.connectionStateLabel.Location = new System.Drawing.Point(6, 12);
            this.connectionStateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.connectionStateLabel.Name = "connectionStateLabel";
            this.connectionStateLabel.Size = new System.Drawing.Size(374, 23);
            this.connectionStateLabel.TabIndex = 0;
            this.connectionStateLabel.Text = "label1";
            // 
            // currentDurationLabel
            // 
            this.currentDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.currentDurationLabel.Location = new System.Drawing.Point(6, 51);
            this.currentDurationLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.currentDurationLabel.Name = "currentDurationLabel";
            this.currentDurationLabel.Size = new System.Drawing.Size(183, 21);
            this.currentDurationLabel.TabIndex = 1;
            this.currentDurationLabel.Text = "00:00:00";
            // 
            // outageCountLabel
            // 
            this.outageCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.outageCountLabel.Location = new System.Drawing.Point(6, 94);
            this.outageCountLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.outageCountLabel.Name = "outageCountLabel";
            this.outageCountLabel.Size = new System.Drawing.Size(374, 21);
            this.outageCountLabel.TabIndex = 2;
            // 
            // percentagesLabel
            // 
            this.percentagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.percentagesLabel.Location = new System.Drawing.Point(6, 141);
            this.percentagesLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.percentagesLabel.Name = "percentagesLabel";
            this.percentagesLabel.Size = new System.Drawing.Size(374, 21);
            this.percentagesLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.percentagesLabel);
            this.Controls.Add(this.outageCountLabel);
            this.Controls.Add(this.currentDurationLabel);
            this.Controls.Add(this.connectionStateLabel);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label currentDurationLabel;

        private System.Windows.Forms.Label connectionStateLabel;

        #endregion

        private System.Windows.Forms.Label outageCountLabel;
        private System.Windows.Forms.Label percentagesLabel;
    }
}