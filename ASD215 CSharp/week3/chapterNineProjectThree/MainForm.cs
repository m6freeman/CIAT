using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }


        #region EVENTS
        public void addButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(input1.Text, out int first) && Int32.TryParse(input2.Text, out int second))
            {
                resultsLabel.ForeColor = Color.FromName("Yellow");
                resultsLabel.Text = (first + second).ToString();
            }
            else
            {
                resultsLabel.ForeColor = Color.FromName("Red");
                resultsLabel.Text = "Value must be numeric and > 0.";
            }
        }

        public void multiplyButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(input1.Text, out int first) && Int32.TryParse(input2.Text, out int second))
            {
                resultsLabel.ForeColor = Color.FromName("Yellow");
                resultsLabel.Text = (first * second).ToString();
            }
            else
            {
                resultsLabel.ForeColor = Color.FromName("Red");
                resultsLabel.Text = "Value must be numeric and > 0.";
            }
        }

        public void resetButton_Click(object sender, EventArgs e)
        {
            resultsLabel.Text = "";
            input1.Text = "";
            input2.Text = "";
        }
        #endregion



        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}