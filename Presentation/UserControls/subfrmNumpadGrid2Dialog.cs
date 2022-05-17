using System;
using System.Windows.Forms;

namespace SudokuInterViewCaseStudy
{
    /// <summary>
    /// Numpad Grid 4 Dialog Form
    /// </summary>
    public partial class subfrmNumpadGrid2Dialog : Form
    {
        /// <summary>
        /// Value Field with default as -1.
        /// </summary>
        public int Value = -1;

        /// <summary>
        /// numpadGrid2Dialog Constructor
        /// </summary>
        public subfrmNumpadGrid2Dialog() => InitializeComponent();

        /// <summary>
        /// Numbers Button Click Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Value = Convert.ToInt32((sender as Button).Text);
            Close();
        }

        /// <summary>
        /// Clear Button Click Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Value = 0;
            Close();
        }

        /// <summary>
        /// Cancel Button Click Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void BtnCancel_Click(object sender, EventArgs e) => Close();

           }
}