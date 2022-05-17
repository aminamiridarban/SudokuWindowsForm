using System.Windows.Forms;

namespace SudokuInterViewCaseStudy
{
    partial class frmSplashScreen : Form
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbSplashScreen = new System.Windows.Forms.ProgressBar();
            this.lblIntroTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lbllinkAuthorName = new System.Windows.Forms.LinkLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.timeSplash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbSplashScreen
            // 
            this.pbSplashScreen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbSplashScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbSplashScreen.Location = new System.Drawing.Point(5, 350);
            this.pbSplashScreen.MarqueeAnimationSpeed = 50;
            this.pbSplashScreen.Name = "pbSplashScreen";
            this.pbSplashScreen.Size = new System.Drawing.Size(804, 23);
            this.pbSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbSplashScreen.TabIndex = 1;
            // 
            // lblIntroTitle
            // 
            this.lblIntroTitle.AutoSize = true;
            this.lblIntroTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIntroTitle.Location = new System.Drawing.Point(166, 12);
            this.lblIntroTitle.Name = "lblIntroTitle";
            this.lblIntroTitle.Size = new System.Drawing.Size(470, 23);
            this.lblIntroTitle.TabIndex = 3;
            this.lblIntroTitle.Text = "This Case Study Project Prepered for Sudoku Interview";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(315, 46);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author : ";
            // 
            // lbllinkAuthorName
            // 
            this.lbllinkAuthorName.AutoSize = true;
            this.lbllinkAuthorName.Location = new System.Drawing.Point(368, 46);
            this.lbllinkAuthorName.Name = "lbllinkAuthorName";
            this.lbllinkAuthorName.Size = new System.Drawing.Size(131, 13);
            this.lbllinkAuthorName.TabIndex = 5;
            this.lbllinkAuthorName.TabStop = true;
            this.lbllinkAuthorName.Text = "https://AminAmiriDarban.ir";
            this.lbllinkAuthorName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllinkAuthorName_LinkClicked);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStart.Location = new System.Drawing.Point(318, 291);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 35);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timeSplash
            // 
            this.timeSplash.Enabled = true;
            this.timeSplash.Interval = 10000;
            this.timeSplash.Tick += new System.EventHandler(this.timeSplash_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::SudokuInterViewCaseStudy.Properties.Resources.Sudoku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 378);
            this.ControlBox = false;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbllinkAuthorName);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblIntroTitle);
            this.Controls.Add(this.pbSplashScreen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplashScreen";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This Case Study Project Prepered for Sudoku Interview";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbSplashScreen;
        private Label lblIntroTitle;
        private Label lblAuthor;
        private LinkLabel lbllinkAuthorName;
        private Button btnStart;
        private Timer timeSplash;
    }
}

