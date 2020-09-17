using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region FirstWindowApp_Functionality
        private void OkButton_Click(object sender, EventArgs e) => AnswerLabel.Text = $"Congratulations {NameTextBox.Text}, you retrieved the data!";

        #endregion

        #region ColorChangeApp_Functionality
        private void ResetBackColorButton_Click(object sender, EventArgs e) => this.BackColor = System.Drawing.Color.Blue;

        private void ChangeBackColorToGreenButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;
            MessageBox.Show("Color selection was: " + BackColor);
        }

        private void ChangeBackColorToGrayButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Gray;
            MessageBox.Show("Color selection was: " + BackColor);
        }

        #endregion

        #region MoveingApp_Functionality
        private void MoveButton_Click(object sender, EventArgs e)
        {
            int x, y;

            while (!int.TryParse(X_TextBox.Text, out x))
            {
                ErrorMessageLabel.Text = "Value entered must be numeric";
                X_TextBox.Text = "0";
                X_TextBox.Focus();
            }

            while (!int.TryParse(Y_TextBox.Text, out y))
            {
                ErrorMessageLabel.Text = "Value entered must be numeric";
                Y_TextBox.Text = "0";
                Y_TextBox.Focus();
            }

            if (X_TextBox.Text != "0" && Y_TextBox.Text != "0") Location = new Point(x, y);
        }

        #endregion

    }
}
