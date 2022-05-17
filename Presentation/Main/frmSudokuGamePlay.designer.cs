
namespace SudokuInterViewCaseStudy
{
    partial class frmSudokuGamePlay
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSudokuGamePlay));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmbBoxMode = new System.Windows.Forms.ComboBox();
            this.cmbBoxGrid = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblGrid = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnValidate = new System.Windows.Forms.Button();
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.lbllinkAuthorName = new System.Windows.Forms.LinkLabel();
            this.lblAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(548, 144);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(200, 44);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolve.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolve.FlatAppearance.BorderSize = 0;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnSolve.ForeColor = System.Drawing.Color.White;
            this.btnSolve.Location = new System.Drawing.Point(548, 330);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(200, 44);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(548, 421);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 44);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTimer.Location = new System.Drawing.Point(548, 12);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Padding = new System.Windows.Forms.Padding(17, 13, 17, 13);
            this.lblTimer.Size = new System.Drawing.Size(200, 57);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cmbBoxMode
            // 
            this.cmbBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxMode.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cmbBoxMode.FormattingEnabled = true;
            this.cmbBoxMode.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbBoxMode.Location = new System.Drawing.Point(71, 38);
            this.cmbBoxMode.Name = "cmbBoxMode";
            this.cmbBoxMode.Size = new System.Drawing.Size(103, 24);
            this.cmbBoxMode.TabIndex = 4;
            this.cmbBoxMode.SelectedIndexChanged += new System.EventHandler(this.CmbBoxMode_SelectedIndexChanged);
            // 
            // cmbBoxGrid
            // 
            this.cmbBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxGrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxGrid.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cmbBoxGrid.FormattingEnabled = true;
            this.cmbBoxGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBoxGrid.Items.AddRange(new object[] {
            "3 X 3",
            "2 X 2"});
            this.cmbBoxGrid.Location = new System.Drawing.Point(71, 11);
            this.cmbBoxGrid.Name = "cmbBoxGrid";
            this.cmbBoxGrid.Size = new System.Drawing.Size(103, 24);
            this.cmbBoxGrid.TabIndex = 5;
            this.cmbBoxGrid.SelectedIndexChanged += new System.EventHandler(this.CmbBoxGrid_SelectedIndexChanged);
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.Color.Transparent;
            this.lblMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMode.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(27, 40);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(38, 16);
            this.lblMode.TabIndex = 6;
            this.lblMode.Text = "Mode";
            // 
            // lblGrid
            // 
            this.lblGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrid.AutoSize = true;
            this.lblGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGrid.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblGrid.ForeColor = System.Drawing.Color.White;
            this.lblGrid.Location = new System.Drawing.Point(27, 14);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(35, 16);
            this.lblGrid.TabIndex = 7;
            this.lblGrid.Text = "Type";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(183, 12);
            this.lblStatus.MinimumSize = new System.Drawing.Size(250, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(305, 49);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Start Solving Sudoku";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.GridColor = System.Drawing.Color.White;
            this.gridView.Location = new System.Drawing.Point(29, 73);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 25;
            this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridView.Size = new System.Drawing.Size(459, 456);
            this.gridView.TabIndex = 6;
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnValidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(548, 236);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(200, 44);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // messageTimer
            // 
            this.messageTimer.Enabled = true;
            this.messageTimer.Interval = 5000;
            this.messageTimer.Tick += new System.EventHandler(this.MessageTimer_Tick);
            // 
            // lbllinkAuthorName
            // 
            this.lbllinkAuthorName.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lbllinkAuthorName.AutoSize = true;
            this.lbllinkAuthorName.BackColor = System.Drawing.Color.Transparent;
            this.lbllinkAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinkAuthorName.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbllinkAuthorName.Location = new System.Drawing.Point(72, 539);
            this.lbllinkAuthorName.Name = "lbllinkAuthorName";
            this.lbllinkAuthorName.Size = new System.Drawing.Size(127, 13);
            this.lbllinkAuthorName.TabIndex = 10;
            this.lbllinkAuthorName.TabStop = true;
            this.lbllinkAuthorName.Text = "https://AminAmiriDarban.ir";
            this.lbllinkAuthorName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllinkAuthorName_LinkClicked);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAuthor.Location = new System.Drawing.Point(28, 539);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 13);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "Author : ";
            // 
            // frmSudokuGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::SudokuInterViewCaseStudy.Properties.Resources.BackgroundWallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(799, 561);
            this.Controls.Add(this.lbllinkAuthorName);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.cmbBoxGrid);
            this.Controls.Add(this.cmbBoxMode);
            this.Controls.Add(this.lblTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSudokuGamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SudokuForm_FormClosing);
            this.Load += new System.EventHandler(this.SudokuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cmbBoxMode;
        private System.Windows.Forms.ComboBox cmbBoxGrid;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.LinkLabel lbllinkAuthorName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblStatus;
    }
}

