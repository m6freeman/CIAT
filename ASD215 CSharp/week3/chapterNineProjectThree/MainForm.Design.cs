using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {
        #region CONTROLS FIELD

        Label resultsLabel;
        public TextBox input1;
        public TextBox input2;
        public Button addButton;
        public Button multiplyButton;
        public Button resetButton;

        #endregion

        public void InitializeComponent()
        {
            resultsLabel = new Label();
            input1 = new TextBox();
            input2 = new TextBox();
            addButton = new Button();
            multiplyButton = new Button();
            resetButton = new Button();

            Size textboxSize = new Size(150, 30);
            Size buttonSize = new Size(70, 30);
            input1.Size = textboxSize;
            input1.TextAlign = HorizontalAlignment.Right;
            input2.Size = textboxSize;
            input2.TextAlign = HorizontalAlignment.Right;
            addButton.Size = buttonSize;
            multiplyButton.Size = buttonSize;
            resetButton.Size = buttonSize;

            input1.Location = new Point(30, 30);
            input2.Location = new Point(30, 70);
            addButton.Location = new Point((int)(this.Width * 0.25) - (int)(addButton.Size.Width / 2), this.Height - addButton.Size.Width);
            multiplyButton.Location = new Point((int)(this.Width * 0.5) - (int)(multiplyButton.Size.Width / 2), this.Height - multiplyButton.Size.Width);
            resetButton.Location = new Point((int)(this.Width * 0.75) - (int)(resetButton.Size.Width / 2), this.Height - resetButton.Size.Width);

            resultsLabel.Text = "";
            addButton.Text = "Add";
            multiplyButton.Text = "Multiply";
            resetButton.Text = "Reset";

            this.Controls.Add(resultsLabel);
            this.Controls.Add(input1);
            this.Controls.Add(input2);
            this.Controls.Add(addButton);
            this.Controls.Add(multiplyButton);
            this.Controls.Add(resetButton);

            addButton.Click += new EventHandler(addButton_Click);
            multiplyButton.Click += new EventHandler(multiplyButton_Click);
            resetButton.Click += new EventHandler(resetButton_Click);
        }

    }
}