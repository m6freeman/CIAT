namespace hands
{
    partial class Form1
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

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button ChangeBackColorToGreenButton;
        private System.Windows.Forms.Button ChangeBackColorToGrayButton;
        private System.Windows.Forms.Button ResetBackColorButton;
        private System.Windows.Forms.Label MoveWindowLabel;
        private System.Windows.Forms.Label NewXLabel;
        private System.Windows.Forms.Label NewYLabel;
        private System.Windows.Forms.TextBox X_TextBox;
        private System.Windows.Forms.TextBox Y_TextBox;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.BackColor = System.Drawing.Color.Blue;
			this.ForeColor = System.Drawing.Color.White;
            this.Text = "Week 3 Hands On";
			this.Name = "Week_3_Hands_On";

            #region FirstWindowsApp_Design
            this.NameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.AnswerLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			// NameLabel
			//
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(25, 37);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Name:";
			//
			// NameTextBox
			//
			this.NameTextBox.Location = new System.Drawing.Point(100, 37);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(200, 25);
			this.NameTextBox.TabIndex = 1;
			//
			// OkButton
			//
			this.OkButton.ForeColor = System.Drawing.Color.White;
			this.OkButton.Location = new System.Drawing.Point(125, 100);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(100, 50);
			this.OkButton.TabIndex = 2;
			this.OkButton.Text = "Submit";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			//
			// AnswerLabel
			//
			this.AnswerLabel.AutoSize = true;
			this.AnswerLabel.Location = new System.Drawing.Point(25, 175);
			this.AnswerLabel.Name = "AnswerLabel";
			this.AnswerLabel.Size = new System.Drawing.Size(0, 24);
			this.AnswerLabel.TabIndex = 3;
			//
			// FirstWindowsApp
			//
			this.ResumeLayout(false);
            #endregion

            #region ColorChangeApp_Design
            this.ChangeBackColorToGreenButton = new System.Windows.Forms.Button();
            this.ChangeBackColorToGrayButton = new System.Windows.Forms.Button();
            this.ResetBackColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // ChangeBackColorToGreenButton
            //
            this.ChangeBackColorToGreenButton.Location = new System.Drawing.Point(350, 25);
            this.ChangeBackColorToGreenButton.Name = "ChangeColorToGreenButton";
            this.ChangeBackColorToGreenButton.Size = new System.Drawing.Size(100, 50);
            this.ChangeBackColorToGreenButton.TabIndex = 4;
            this.ChangeBackColorToGreenButton.Text = "Green";
            this.ChangeBackColorToGreenButton.UseVisualStyleBackColor = true;
            this.ChangeBackColorToGreenButton.Click += new System.EventHandler(this.ChangeBackColorToGreenButton_Click);
            //
            // ChangeBackColorToGrayButton
            //
            this.ChangeBackColorToGrayButton.Location = new System.Drawing.Point(500, 25);
            this.ChangeBackColorToGrayButton.Name = "ChangeBackColorToGrayButton";
            this.ChangeBackColorToGrayButton.Size = new System.Drawing.Size(100, 50);
            this.ChangeBackColorToGrayButton.TabIndex = 5;
            this.ChangeBackColorToGrayButton.Text = "Gray";
            this.ChangeBackColorToGrayButton.UseVisualStyleBackColor = true;
            this.ChangeBackColorToGrayButton.Click += new System.EventHandler(this.ChangeBackColorToGrayButton_Click);
            //
            // ResetBackColorButton
            //
            this.ResetBackColorButton.Location = new System.Drawing.Point(425, 100);
            this.ResetBackColorButton.Name = "ResetBackColorButton";
            this.ResetBackColorButton.Size = new System.Drawing.Size(100, 50);
            this.ResetBackColorButton.TabIndex = 6;
            this.ResetBackColorButton.Text = "Reset";
            this.ResetBackColorButton.UseVisualStyleBackColor = true;
            this.ResetBackColorButton.Click += new System.EventHandler(this.ResetBackColorButton_Click);
            //
            // ColorChangeAppForm
            //
            this.ResumeLayout(false);
            #endregion

            #region MovingApp_Design
            this.MoveWindowLabel = new System.Windows.Forms.Label();
            this.NewXLabel = new System.Windows.Forms.Label();
            this.NewYLabel = new System.Windows.Forms.Label();
            this.X_TextBox = new System.Windows.Forms.TextBox();
            this.Y_TextBox = new System.Windows.Forms.TextBox();
            this.MoveButton = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // MoveWindowLabel
            //
            this.MoveWindowLabel.AutoSize = true;
            this.MoveWindowLabel.Location = new System.Drawing.Point(25, 200);
            this.MoveWindowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoveWindowLabel.Name = "MoveWindowLabel";
            this.MoveWindowLabel.Size = new System.Drawing.Size(277, 29);
            this.MoveWindowLabel.TabIndex = 7;
            this.MoveWindowLabel.Text = "Change Form Location";
            //
            // NewXLabel
            //
            this.NewXLabel.AutoSize = true;
            this.NewXLabel.Location = new System.Drawing.Point(25, 250);
            this.NewXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewXLabel.Name = "NewXLabel";
            this.NewXLabel.Size = new System.Drawing.Size(158, 20);
            this.NewXLabel.TabIndex = 8;
            this.NewXLabel.Text = "New X Coordinate:";
            //
            // NewYLabel
            //
            this.NewYLabel.AutoSize = true;
            this.NewYLabel.Location = new System.Drawing.Point(25, 300);
            this.NewYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewYLabel.Name = "NewYLabel";
            this.NewYLabel.Size = new System.Drawing.Size(158, 20);
            this.NewYLabel.TabIndex = 9;
            this.NewYLabel.Text = "New Y Coordinate:";
            //
            // X_TextBox
            //
            this.X_TextBox.Location = new System.Drawing.Point(200, 250);
            this.X_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.X_TextBox.Name = "X_TextBox";
            this.X_TextBox.Size = new System.Drawing.Size(98, 26);
            this.X_TextBox.TabIndex = 10;
            //
            // Y_TextBox
            //
            this.Y_TextBox.Location = new System.Drawing.Point(200, 300);
            this.Y_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Y_TextBox.Name = "Y_TextBox";
            this.Y_TextBox.Size = new System.Drawing.Size(98, 26);
            this.Y_TextBox.TabIndex = 11;
            //
            // MoveButton
            //
            this.MoveButton.Location = new System.Drawing.Point(350, 250);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(101, 34);
            this.MoveButton.TabIndex = 12;
            this.MoveButton.Text = "Move Form";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            //
            // ErrorMessageLabel
            //
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(350, 300);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorMessageLabel.TabIndex = 13;
            //
            // MovingAppForm
            //
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion

			this.Controls.Add(this.AnswerLabel);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ResetBackColorButton);
            this.Controls.Add(this.ChangeBackColorToGrayButton);
            this.Controls.Add(this.ChangeBackColorToGreenButton);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.Y_TextBox);
            this.Controls.Add(this.X_TextBox);
            this.Controls.Add(this.NewYLabel);
            this.Controls.Add(this.NewXLabel);
            this.Controls.Add(this.MoveWindowLabel);

        }

        #endregion
    }
}

