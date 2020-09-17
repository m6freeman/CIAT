using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace chapterTwelveProjectNine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void menuOptionFileQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void menuOptionFileImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    this.inputTextBox.Text = sr.ReadToEnd();
                    characterCount = GetCharacterCount(sr.ReadToEnd());
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\nDetails:\n\n{ex.StackTrace}");
                }
            }
            OutputCharacterCount(characterCount);
        }

        public void getCharacterCountButton_Click(object sender, EventArgs e)
        {

            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            if (this.inputTextBox.Text.Length > 0)
                characterCount = GetCharacterCount(this.inputTextBox.Text);
            OutputCharacterCount(characterCount);
        }

        private Dictionary<char, int> GetCharacterCount(string input)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            string filteredInput = new String(input.ToUpper().Where(x => char.IsLetter(x)).ToArray());
            foreach (char letter in filteredInput)
            {
                if (characterCount.ContainsKey(letter))
                    characterCount[letter]++;
                else
                    characterCount.Add(letter, 1);
            }
            return new Dictionary<char, int>(characterCount.OrderBy(x => x.Key));
        }

        private void OutputCharacterCount(Dictionary<char, int> input)
        {
            string output = "";
            foreach (var entry in input.OrderBy(x => x.Key))
                output += $"{entry.Key} : {entry.Value}\n";
            this.outputTextBox.Text = output;
        }

    }
}
