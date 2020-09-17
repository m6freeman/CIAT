using System;
using System.Drawing;
using System.Windows.Forms;

namespace chapterTwelveProjectNine
{
    partial class MainForm
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

        private MenuStrip mainMenu;
        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Button getCharacterCountButton;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 370);
            this.ForeColor = Color.GhostWhite;
            this.Text = "Character Frequency App";

            //
            // mainMenu
            //
            this.mainMenu = new MenuStrip();
            ToolStripMenuItem menuOptionFile = new ToolStripMenuItem("File");
            this.mainMenu.Items.Add(menuOptionFile);
                ToolStripMenuItem menuOptionFileImport = new ToolStripMenuItem("Import");
                menuOptionFileImport.Click += new EventHandler(this.menuOptionFileImport_Click);
                menuOptionFile.DropDownItems.Add(menuOptionFileImport);
                ToolStripMenuItem menuOptionFileExit = new ToolStripMenuItem("Exit");
                menuOptionFileExit.Click += new EventHandler(this.menuOptionFileQuit_Click);
                menuOptionFile.DropDownItems.Add(menuOptionFileExit);
            ToolStripMenuItem menuOptionEdit = new ToolStripMenuItem("Edit");
            this.mainMenu.Items.Add(menuOptionEdit);
            this.mainMenu.ForeColor = Color.GhostWhite;
            this.Controls.Add(mainMenu);

            //
            // inputTextBox
            //
            this.inputTextBox = new TextBox();
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Location = new Point(10, 35);
            this.inputTextBox.Size = new Size(300, 300);
            this.inputTextBox.ForeColor = Color.DarkSlateGray;
            this.Controls.Add(inputTextBox);

            //
            // outputTextBox
            //
            this.outputTextBox = new TextBox();
            this.outputTextBox.Multiline = true;
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Location = new Point(315, 35);
            this.outputTextBox.Size = new Size(300, 300);
            this.outputTextBox.ForeColor = Color.GhostWhite;
            this.Controls.Add(outputTextBox);

            //
            // getCharacterCountButton
            //
            this.getCharacterCountButton = new Button();
            this.getCharacterCountButton.Location = new Point(130, 340);
            this.getCharacterCountButton.AutoSize = true;
            this.getCharacterCountButton.Text = "Count";
            this.getCharacterCountButton.Click += new EventHandler(this.getCharacterCountButton_Click);
            this.Controls.Add(getCharacterCountButton);
        }

        #endregion
    }
}

