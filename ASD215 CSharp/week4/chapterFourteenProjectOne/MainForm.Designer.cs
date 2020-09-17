using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace chapterFourteenProjectOne
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        private DataGridView DisplayFullAccountTable_DataGridView;
        private Label AccountNumberInput_Label;
        private TextBox AccountNumberInput_TextBox;
        private Button GetAccountInformation_Button;
        private Label AccountInformationDisplay_Label;

        private void InitializeComponent()
        {
            this.components = new Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Text = "Chapter 14 Project 1";
            this.Load += new EventHandler(MainForm_Load);

            //
            // DisplayFullAccountTable_DataGridView
            //
            this.DisplayFullAccountTable_DataGridView = new DataGridView();
            this.DisplayFullAccountTable_DataGridView.AutoSize = true;
            this.Controls.Add(this.DisplayFullAccountTable_DataGridView);

            //
            // AccountNumberInput_Label
            //
            this.AccountNumberInput_Label = new Label();
            this.AccountNumberInput_Label.Location = new Point(50, 300);
            this.AccountNumberInput_Label.AutoSize = true;
            this.AccountNumberInput_Label.Text = "Enter Account Number";
            this.Controls.Add(this.AccountNumberInput_Label);

            //
            // AccountNumberInput_TextBox
            //
            this.AccountNumberInput_TextBox = new TextBox();
            this.AccountNumberInput_TextBox.Location = new Point(200, 300);
            this.AccountNumberInput_TextBox.AutoSize = true;
            this.Controls.Add(this.AccountNumberInput_TextBox);

            //
            // GetAccountInformation_Button
            //
            this.GetAccountInformation_Button = new Button();
            this.GetAccountInformation_Button.Location = new Point(310, 300);
            this.GetAccountInformation_Button.AutoSize = true;
            this.GetAccountInformation_Button.Text = "Get Data";
            this.GetAccountInformation_Button.Click += new EventHandler(this.GetAccountInformation_Button_Click);
            this.Controls.Add(this.GetAccountInformation_Button);

            //
            // AccountInformationDisplay_Label
            //
            this.AccountInformationDisplay_Label = new Label();
            this.AccountInformationDisplay_Label.Location = new Point(400, 300);
            this.AccountInformationDisplay_Label.AutoSize = true;
            this.AccountInformationDisplay_Label.Text = "";
            this.Controls.Add(this.AccountInformationDisplay_Label);
        }

        #endregion
    }
}

