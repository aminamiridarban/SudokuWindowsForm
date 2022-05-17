using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SudokuInterViewCaseStudy
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void lbllinkAuthorName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            lbllinkAuthorName.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.aminamiridarban.ir");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void timeSplash_Tick(object sender, EventArgs e)
        {
            StartGame();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timeSplash.Start();
        }

        private void StartGame()
        {
            this.Hide();
           // frmSudokuGamePlay sudokuGame = new frmSudokuGamePlay();
           frmSudokuGamePlay sudokuGame = new frmSudokuGamePlay();

            sudokuGame.Show();
            timeSplash.Stop();
        }
    }
}
