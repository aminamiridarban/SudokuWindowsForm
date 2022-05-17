using SudokuInterViewCaseStudy.Common.Constants;
using SudokuInterViewCaseStudy.Common.Helpers;
using SudokuInterViewCaseStudy.Constants;
using SudokuInterViewCaseStudy.Helpers;
using SudokuInterViewCaseStudy.Models;
using SudokuInterViewCaseStudy.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuInterViewCaseStudy
{
    /// <summary>
    /// Sudoku Form Events Implementation Class.
    /// </summary>
    public partial class frmSudokuGamePlay : Form
    {
        int ticks = 0;
        bool timerStarted = false;
        bool gridCleared = false;
        int previousGridSize = 3;
        Enums.Modes gridMode = Enums.Modes.Easy;
        Grid grid;
        readonly List<Label> cellControls = new List<Label>();

        /// <summary>
        /// SudokuForm Constructor
        /// </summary>
        public frmSudokuGamePlay() => InitializeComponent();

        #region Form Loading Event

        /// <summary>
        /// Sudoku Form Load Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void SudokuForm_Load(object sender, EventArgs e)
        {
            cmbBoxMode.SelectedIndex = 0;
            cmbBoxMode.Items.Clear();
            cmbBoxMode.DataSource = Enum.GetValues(typeof(Enums.Modes));
            cmbBoxGrid.SelectedIndex = 0;
        }

        #endregion

        #region Timer tick Event

        /// <summary>
        /// Timer Tick Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            ticks = timerStarted ? ticks + 1 : 0;
            lblTimer.Text = TimeSpan.FromSeconds(ticks).ToString(@"hh\:mm\:ss");
            lblTimer.ForeColor = Color.LimeGreen;

            if (gridCleared)
            {
                gridCleared = false;
                timer.Stop();
            }
        }

        /// <summary>
        /// Message Timer Tick Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            ResetStatus();
            messageTimer.Stop();
        }

        #endregion

        #region Click Events

        /// <summary>
        /// Generate Button Click Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            timerStarted = false;
            ticks = 0;
            timer.Stop();

            timer.Start();
            timerStarted = true;

            ResetTheGrid();
            var generator = new Generator(grid, gridMode);
            generator.Generate();
            RefreshTheGrid();

            lblStatus.ForeColor = Color.DeepSkyBlue;
            lblStatus.Text = Resources.PuzzleGenerated;

            messageTimer.Start();
        }

        /// <summary>
        /// Validate Button Click Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void BtnValidate_Click(object sender, EventArgs e)
        {
            string message;
            var messageColor = Color.DodgerBlue;

            if (grid.IsGridEmpty())
            {
                messageColor = Color.Orange;
                message = Resources.PuzzleGridEmpty;
            }
            else if (grid.IsGridFilled() && grid.Solver.ValidateGrid())
            {
                messageColor = Color.LawnGreen;
                message = Resources.CongratulationsMessage;
                timer.Stop();
            }
            else if (grid.IsGridFilled() && !grid.Solver.ValidateGrid())
            {
                messageColor = Color.Red;
                message = Resources.PuzzleInvalidSolve;
            }
            else if (!grid.IsGridFilled() && grid.Solver.ValidateGrid(ignoreEmptyCells: true))
                message = Resources.PuzzleValidButNotCompleted;
            else
            {
                messageColor = Color.Red;
                message = Resources.PuzzleInvalidSolveState;
            }

            lblStatus.ForeColor = messageColor;
            lblStatus.Text = message;

            messageTimer.Interval = 10000;
            messageTimer.Start();
        }

        /// <summary>
        /// Solve Button Click Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void BtnSolve_Click(object sender, EventArgs e)
        {
            var solver = new Solver(grid);
            var solved = solver.Solve();

            if (solved)
            {
                RefreshTheGrid();

                lblStatus.ForeColor = Color.LawnGreen;
                lblStatus.Text = Resources.PuzzleSolved;

                timer.Stop();
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = Resources.PuzzleNoSolution;
            }

            messageTimer.Interval = 7000;
            messageTimer.Start();
        }

        /// <summary>
        /// Reset Button Click Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            timer.Start();
            timerStarted = false;
            gridCleared = true;

            ResetTheGrid();

            lblStatus.ForeColor = Color.White;
            lblStatus.Text = Resources.PuzzleCleared;

            messageTimer.Start();
        }

        #endregion

        #region Options Selection Events

        /// <summary>
        /// Mode ComboBox Selection Index Change Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void CmbBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbBoxMode.SelectedIndex)
            {
                case (byte)Enums.Modes.Easy: gridMode = Enums.Modes.Easy; break;
                case (byte)Enums.Modes.Medium: gridMode = Enums.Modes.Medium; break;
                case (byte)Enums.Modes.Hard: gridMode = Enums.Modes.Hard; break;
                default:
                    gridMode = (Enums.Modes)(byte)Enums.Modes.Easy;
                    break;
            }
        }

        /// <summary>
        /// Grid ComboBox Selection Index Change Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void CmbBoxGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int columns;
            int rows = columns = GetCellsCount(cmbBoxGrid.SelectedIndex);
            grid = new Grid(rows, columns);
            timerStarted = false;
            ResetStatus();
            CreateTheGrid();
        }

        private int GetCellsCount(int selectedIndex)
        {
            int retVal = 0;
            switch (selectedIndex)
            {
                case 0: retVal = Enums.GridCells.ThreeCells.GetIntValue(); break;
                case 1: retVal = Enums.GridCells.TwoCells.GetIntValue(); break;
                default:
                    retVal = 9; break;
            }
            return retVal;
        }

        #endregion

        #region Grid Events

        /// <summary>
        /// Creates the Sudoku Grid in Window Form UI
        /// </summary>
        private void CreateTheGrid()
        {
            ClearTheGrid();
            previousGridSize = grid.GridSize + 1;

            var cellTopLocation = FormConstants.CellTopLocation;
            var cellWidth = grid.GridSize == Enums.GridCells.ThreeCells.GetIntValue() ? FormConstants.CellSizeForThreeCells : FormConstants.CellSizeForTwoCells;
            var cellHeight = grid.GridSize == Enums.GridCells.ThreeCells.GetIntValue() ? FormConstants.CellSizeForThreeCells : FormConstants.CellSizeForTwoCells;
            var cellFontFamily = Resources.FontFamily;
            var cellFontSize = grid.GridSize == Enums.GridCells.ThreeCells.GetIntValue() ? FormConstants.FontSizeForThreeCells : FormConstants.FontSizeForTwoCells;

            // Iterates through Rows
            for (var x = 0; x < grid.TotalRows; x++)
            {
                var cellLeftLocation = 5;

                // Iterates through Columns and Place each cell side by side for the current row.
                for (var y = 0; y < grid.TotalColumns; y++)
                {
                    // Control Label within cell
                    var cell = new Label
                    {
                        // Index of the cell
                        Tag = x * grid.TotalRows + y,

                        // UI Properties
                        Width = cellWidth,
                        Height = cellHeight,
                        Left = cellLeftLocation,
                        Top = cellTopLocation,
                        Cursor = Cursors.Hand,
                        ForeColor = Color.Black,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font(cellFontFamily, cellFontSize),
                        BackColor = Color.GhostWhite,
                    };

                    // Click Event for the cell.
                    cell.MouseClick += Cell_Click;
                    // Mouse Hover Event for the cell
                    cell.MouseHover += Cell_Hover;
                    // Mouse Leave Event for the cell
                    cell.MouseLeave += Cell_Leave;

                    // Modify 'cellLeftLocation' with left padding for other cells w.r.t current column.
                    cellLeftLocation += cellWidth + ((y + 1) % grid.SubGridSize == 0 ? FormConstants.CellLeftLocation : FormConstants.CellTopLocation);

                    // Add the cell to the 'CellControls' list and to the Grid View.
                    cellControls.Add(cell);
                    gridView.Controls.Add(cell);
                }

                // Modify 'cellTopLocation' with top padding for other cells w.r.t current row.
                cellTopLocation += cellHeight + ((x + 1) % grid.SubGridSize == 0 ? FormConstants.CellLeftLocation : FormConstants.CellTopLocation);
            }
        }

        /// <summary>
        /// Hover Event for the cell.
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Mouse Event Args</param>
        private void Cell_Hover(object sender, EventArgs e)
        {
            Label cellControl = (sender as Label);
            cellControl.BackColor = Color.BlueViolet;
            cellControl.ForeColor = Color.GhostWhite;
        }

        /// <summary>
        /// Leave Event for the cell.
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Mouse Event Args</param>
        private void Cell_Leave(object sender, EventArgs e)
        {
            Label cellControl = (sender as Label);
            cellControl.BackColor = Color.GhostWhite;
            cellControl.ForeColor = Color.Black;
        }

        /// <summary>
        /// Click Event for the cell.
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Mouse Event Args</param>
        private void Cell_Click(object sender, MouseEventArgs e)
        {
            Label clickedCellControl = (sender as Label);
            int cellIndex = (int)clickedCellControl.Tag;
            if (grid.PreFilledCells == null || !grid.PreFilledCells.Contains(cellIndex))
                if (grid.GridSize == Enums.GridCells.ThreeCells.GetIntValue())
                {
                    var numpadGrid3Dialog = new subfrmNumpadGrid3Dialog();

                    #region Cell Click Location Calcutaion to display Numpad Grid 9 Dialog

                    int numpadLocationX = clickedCellControl.Location.X - (numpadGrid3Dialog.Width / 4) + this.Location.X;
                    int numpadLocationY = clickedCellControl.Location.Y - (numpadGrid3Dialog.Height / 4) + this.Location.Y;

                    if (numpadLocationX < 0) numpadLocationX = 0;
                    if (numpadLocationY < 0) numpadLocationY = 0;

                    if (Screen.PrimaryScreen.WorkingArea.Width < numpadGrid3Dialog.Width + numpadLocationX)
                        numpadLocationX = Screen.PrimaryScreen.WorkingArea.Width - numpadGrid3Dialog.Width;

                    if (Screen.PrimaryScreen.WorkingArea.Height < numpadGrid3Dialog.Height + numpadLocationY)
                        numpadLocationY = Screen.PrimaryScreen.WorkingArea.Height - numpadGrid3Dialog.Height;

                    Point numpadLocation = new Point(numpadLocationX, numpadLocationY);
                    numpadGrid3Dialog.Location = numpadLocation;

                    #endregion

                    // Show the numpad dialog.
                    numpadGrid3Dialog.Show();

                    // Handle the closed event of the numpad dialog to get the result.
                    numpadGrid3Dialog.FormClosed += (object s, FormClosedEventArgs ea) =>
                    {
                        if (numpadGrid3Dialog.Value != -1 && numpadGrid3Dialog.Value != 0)
                        {
                            grid.SetCellValue(cellIndex, numpadGrid3Dialog.Value);
                            RefreshTheGrid();
                        }
                        else if (numpadGrid3Dialog.Value == 0)
                        {
                            grid.SetCellValue(cellIndex, -1);
                            RefreshTheGrid();
                        }

                        // Dispose the numpad dialog.
                        numpadGrid3Dialog.Dispose();
                    };
                }
                else
                {
                    var numpadGrid2Dialog = new subfrmNumpadGrid2Dialog();

                    #region Cell Click Location Calcutaion to display Numpad Grid 9 Dialog

                    int numpadLocationX = clickedCellControl.Location.X - (numpadGrid2Dialog.Width / 4) + this.Location.X;
                    int numpadLocationY = clickedCellControl.Location.Y - (numpadGrid2Dialog.Height / 4) + this.Location.Y;

                    if (numpadLocationX < 0) numpadLocationX = 0;
                    if (numpadLocationY < 0) numpadLocationY = 0;

                    if (Screen.PrimaryScreen.WorkingArea.Width < numpadGrid2Dialog.Width + numpadLocationX)
                        numpadLocationX = Screen.PrimaryScreen.WorkingArea.Width - numpadGrid2Dialog.Width;

                    if (Screen.PrimaryScreen.WorkingArea.Height < numpadGrid2Dialog.Height + numpadLocationY)
                        numpadLocationY = Screen.PrimaryScreen.WorkingArea.Height - numpadGrid2Dialog.Height;

                    Point numpadLocation = new Point(numpadLocationX, numpadLocationY);
                    numpadGrid2Dialog.Location = numpadLocation;

                    #endregion

                    // Show the numpad dialog.
                    numpadGrid2Dialog.Show();

                    // Handle the closed event of the numpad dialog to get the result.
                    numpadGrid2Dialog.FormClosed += (object s, FormClosedEventArgs ea) =>
                    {
                        if (numpadGrid2Dialog.Value != -1 && numpadGrid2Dialog.Value != 0)
                        {
                            grid.SetCellValue(cellIndex, numpadGrid2Dialog.Value);
                            RefreshTheGrid();
                        }
                        else if (numpadGrid2Dialog.Value == 0)
                        {
                            grid.SetCellValue(cellIndex, -1);
                            RefreshTheGrid();
                        }

                        // Dispose the numpad dialog.
                        numpadGrid2Dialog.Dispose();
                    };

                }
        }

        /// <summary>
        /// Reset the Status Label
        /// </summary>
        private void ResetStatus() => lblStatus.Text = string.Empty;

        /// <summary>
        /// Refresh the Sudoku Grid in Window Form UI
        /// </summary>
        private void RefreshTheGrid()
            => cellControls.ForEach(cell =>
                {
                    var cellIndex = (int)cell.Tag;
                    var cellValue = grid.GetCell(cellIndex: cellIndex).Value;
                    cell.Text = cellValue != -1 ? cellValue.ToString() : string.Empty;
                });

        /// <summary>
        /// Reset the Sudoku Grid in Window Form UI
        /// </summary>
        private void ResetTheGrid()
            => Parallel.Invoke(
                () => cellControls.ForEach(cell => cell.Text = string.Empty),
                () => grid.Cells.ForEach(prop => prop.Value = -1));

        /// <summary>
        /// Clear the Sudoku Grid
        /// </summary>
        private void ClearTheGrid()
        {
            cellControls.Clear();
            for (int i = 0; i < previousGridSize; i++) gridView.Controls.Clear();
            gridView.BackgroundColor = Color.FromArgb(47, 47, 47);
            gridView.Refresh();
        }

        #endregion


        private void lbllinkAuthorName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            lbllinkAuthorName.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.aminamiridarban.ir");
        }

        private void SudokuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
                return;

            DialogResult dialogResult = MessageBox.Show("Sure to Exit Sudoku Game case study Application",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //this will terminate the application
                Application.Exit();
            }
        }
    }
}