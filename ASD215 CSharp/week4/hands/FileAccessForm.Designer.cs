namespace FileAccessApp
{
    partial class FileAccessForm
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


        private System.Windows.Forms.Button GetAverageButton;
        private System.Windows.Forms.Button GetSmallestButton;
        private System.Windows.Forms.Button GetLargestButton;
        private System.Windows.Forms.Label ResultsLabel;
        private void InitializeComponent()
        {
            this.GetAverageButton = new System.Windows.Forms.Button();
            this.GetSmallestButton = new System.Windows.Forms.Button();
            this.GetLargestButton = new System.Windows.Forms.Button();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // GetAverageButton
            //
            this.GetAverageButton.Location = new System.Drawing.Point(50, 17);
            this.GetAverageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetAverageButton.Name = "GetAverageButton";
            this.GetAverageButton.Size = new System.Drawing.Size(188, 32);
            this.GetAverageButton.TabIndex = 0;
            this.GetAverageButton.Text = "Display Average";
            this.GetAverageButton.UseVisualStyleBackColor = true;
            this.GetAverageButton.Click += new System.EventHandler(this.GetAverageButton_Click);
            //
            // GetSmallestButton
            //
            this.GetSmallestButton.Location = new System.Drawing.Point(50, 91);
            this.GetSmallestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetSmallestButton.Name = "GetSmallestButton";
            this.GetSmallestButton.Size = new System.Drawing.Size(188, 32);
            this.GetSmallestButton.TabIndex = 1;
            this.GetSmallestButton.Text = "Display Smallest Value";
            this.GetSmallestButton.UseVisualStyleBackColor = true;
            this.GetSmallestButton.Click += new System.EventHandler(this.GetSmallestButton_Click);
            //
            // GetLargestButton
            //
            this.GetLargestButton.Location = new System.Drawing.Point(50, 165);
            this.GetLargestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetLargestButton.Name = "GetLargestButton";
            this.GetLargestButton.Size = new System.Drawing.Size(188, 32);
            this.GetLargestButton.TabIndex = 2;
            this.GetLargestButton.Text = "Display Largest Value";
            this.GetLargestButton.UseVisualStyleBackColor = true;
            this.GetLargestButton.Click += new System.EventHandler(this.GetLargestButton_Click);
            //
            // ResultsLabel
            //
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(47, 227);
            this.ResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(0, 18);
            this.ResultsLabel.TabIndex = 3;
            //
            // FileAccessForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(312, 285);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.GetLargestButton);
            this.Controls.Add(this.GetSmallestButton);
            this.Controls.Add(this.GetAverageButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FileAccessForm";
            this.Text = "File Access App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileAccessForm_FormClosing);
            this.Load += new System.EventHandler(this.FileAccessForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}

