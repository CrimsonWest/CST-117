namespace HelloWorldApp
{
    partial class HWApplication
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
            this.sellingSoulButton = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.helloWorldButton = new System.Windows.Forms.Button();
            this.sellSoulTime = new System.Windows.Forms.DateTimePicker();
            this.soulLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sellingSoulButton
            // 
            this.sellingSoulButton.Location = new System.Drawing.Point(132, 270);
            this.sellingSoulButton.Name = "sellingSoulButton";
            this.sellingSoulButton.Size = new System.Drawing.Size(165, 36);
            this.sellingSoulButton.TabIndex = 0;
            this.sellingSoulButton.Text = "Sell Your Soul With this Button";
            this.sellingSoulButton.UseVisualStyleBackColor = true;
            this.sellingSoulButton.Click += new System.EventHandler(this.HWButton_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(297, 46);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(0, 23);
            this.helloWorldLabel.TabIndex = 1;
            // 
            // helloWorldButton
            // 
            this.helloWorldButton.Location = new System.Drawing.Point(276, 87);
            this.helloWorldButton.Name = "helloWorldButton";
            this.helloWorldButton.Size = new System.Drawing.Size(226, 31);
            this.helloWorldButton.TabIndex = 2;
            this.helloWorldButton.Text = "Press Me";
            this.helloWorldButton.UseVisualStyleBackColor = true;
            this.helloWorldButton.Click += new System.EventHandler(this.helloWorldButton_Click);
            // 
            // sellSoulTime
            // 
            this.sellSoulTime.Location = new System.Drawing.Point(118, 229);
            this.sellSoulTime.Name = "sellSoulTime";
            this.sellSoulTime.Size = new System.Drawing.Size(203, 20);
            this.sellSoulTime.TabIndex = 3;
            // 
            // soulLabel
            // 
            this.soulLabel.AutoSize = true;
            this.soulLabel.Location = new System.Drawing.Point(193, 179);
            this.soulLabel.Name = "soulLabel";
            this.soulLabel.Size = new System.Drawing.Size(63, 13);
            this.soulLabel.TabIndex = 4;
            this.soulLabel.Text = "Pick a Date";
            // 
            // HWApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.soulLabel);
            this.Controls.Add(this.sellSoulTime);
            this.Controls.Add(this.helloWorldButton);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.sellingSoulButton);
            this.Name = "HWApplication";
            this.Text = "HWApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sellingSoulButton;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Button helloWorldButton;
        private System.Windows.Forms.DateTimePicker sellSoulTime;
        private System.Windows.Forms.Label soulLabel;
    }
}

