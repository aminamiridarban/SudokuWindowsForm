using SudokuInterViewCaseStudy.Common.Constants;
using SudokuInterViewCaseStudy.Common.Helpers;
using SudokuInterViewCaseStudy.Constants;
using SudokuInterViewCaseStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuInterViewCaseStudy.Helpers
{
    /// <summary>
    /// Generator Class will be used to generate Sudoku Grid.
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// The Grid instance.
        /// </summary>
        readonly Grid grid;
        /// <summary>
        /// The Mode.
        /// </summary>
        private readonly Enums.Modes mode;
        /// <summary>
        /// The Solver instance.
        /// </summary>
        private readonly Solver solver;
        /// <summary>
        /// Random object to use creating random numbers.
        /// </summary>
        private readonly Random random = new Random();
       
        /// <summary>
        /// Generator Constructor
        /// </summary>
        /// <param name="gridInstance">The grid instance.</param>
        public Generator(Grid gridInstance, Enums.Modes gridMode)
        {
            grid = gridInstance ?? new Grid(Enums.GridCells.ThreeCells.GetIntValue(), Enums.GridCells.ThreeCells.GetIntValue());
            mode = gridMode;
            solver = new Solver(grid);
        }

        /// <summary>
        /// Generates the Sudoku Grid.
        /// </summary>
        /// <returns><c>true</c> if the sudoku grid is generated; otherwise, <c>false</c>.</returns>
        public bool Generate()
        {
            solver.Solve();
            GenerateGrid();

            return true;
        }

        

        /// <summary>
        /// Generate Sudoku Grid with few empty cells.
        /// </summary>
        private void GenerateGrid()
        {
            List<int> cellValueIndexes = new List<int>();

            switch (mode)
            {
                case Enums.Modes.Hard:
                    if (grid.GridSize == Enums.GridCells.ThreeCells.GetIntValue())
                        cellValueIndexes = GenerateRandomIndexes(random.Next(16, 24));
                    else if (grid.GridSize == Enums.GridCells.TwoCells.GetIntValue())
                        cellValueIndexes = GenerateRandomIndexes(random.Next(1, 4));

                    break;
                case Enums.Modes.Medium:
                    if (grid.GridSize == Enums.GridCells.ThreeCells.GetIntValue())
                        cellValueIndexes = GenerateRandomIndexes(random.Next(24, 31));
                    else if (grid.GridSize == Enums.GridCells.TwoCells.GetIntValue())
                        cellValueIndexes = GenerateRandomIndexes(random.Next(4, 7));

                    break;
                case Enums.Modes.Easy:
                    if (grid.GridSize == Enums.GridCells.ThreeCells.GetIntValue())
                        cellValueIndexes = GenerateRandomIndexes(random.Next(31, 39));
                    else if (grid.GridSize == Enums.GridCells.TwoCells.GetIntValue())
                        cellValueIndexes = GenerateRandomIndexes(random.Next(5, 9));

                    break;
                default:
                    cellValueIndexes = GenerateRandomIndexes(random.Next(5, 9));
                    break;
            }

            grid.Cells.ForEach(cell => cell.Value = !cellValueIndexes.Contains(cell.Index) ? -1 : cell.Value);
            grid.PreFilledCells = cellValueIndexes;
        }

        /// <summary>
        /// Generate random indexes which will have cell values.
        /// </summary>
        /// <param name="requiredNumbers"></param>
        /// <returns></returns>
        private List<int> GenerateRandomIndexes(int requiredNumbers)
        {
            return Enumerable.Range(0, requiredNumbers).Select(x => random.Next(0, grid.TotalCells)).ToList();
        }
    }
}