/* FrmFileAccess.cs
 * This application reads
 * integers from a text file,
 * displays the number of values,
 * the average, smallest and largest
 * value.
 */
using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace FileAccessApp
{
    public partial class FileAccessForm : Form
    {
        private string fileName = "numbers.txt";
        private StreamReader inFile;
        private int[] numbers;
        private string[] names;
        private Dictionary<string, int> entries = new Dictionary<string, int>();

        public FileAccessForm()
        {
            InitializeComponent();
        }

        private void FileAccessForm_Load(object sender, EventArgs e)
        {
            string inValue;
            int fileCount = File.ReadLines(fileName).Count();
            numbers = new int[fileCount];
            names = new string[fileCount];
            int i = 0;

            if (File.Exists(fileName))
            {
                try
                {
                    inFile = new StreamReader("numbers.txt");
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        names[i] += inValue.Split(',')[0];
                        numbers[i] += int.Parse(inValue.Split(',')[1]);
                        entries.Add(names[i], numbers[i]);
                        i++;
                    }
                    ResultsLabel.Text = "Number of values in file: " + i;
                }

                catch (System.IO.IOException exc)
                {
                    ResultsLabel.Text = exc.Message;
                }
            }
            else ResultsLabel.Text = "File Unavailable";

            ResultsLabel.Visible = true;
        }

        private void FileAccessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                inFile.Close();
            }
            catch (Exception ex)
            {
                ResultsLabel.Text = ex.Message;
            }
        }

        private void GetAverageButton_Click(object sender, EventArgs e) => ResultsLabel.Text = "Average value: " + entries.Values.Average().ToString("F2");

        private void GetSmallestButton_Click(object sender, EventArgs e) => ResultsLabel.Text = $"Smallest value: {entries.FirstOrDefault(x => x.Value == entries.Values.Min()).Key} {entries.Values.Min()}";

        private void GetLargestButton_Click(object sender, EventArgs e) => ResultsLabel.Text = $"Largest value: {entries.FirstOrDefault(x => x.Value == entries.Values.Max()).Key} {entries.Values.Max()}";
    }
}