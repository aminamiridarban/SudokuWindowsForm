﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SudokuInterViewCaseStudy.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SudokuInterViewCaseStudy.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap BackgroundWallpaper {
            get {
                object obj = ResourceManager.GetObject("BackgroundWallpaper", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Congratulations!, the sudoku puzzle is solved..
        /// </summary>
        internal static string CongratulationsMessage {
            get {
                return ResourceManager.GetString("CongratulationsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tahoma.
        /// </summary>
        internal static string FontFamily {
            get {
                return ResourceManager.GetString("FontFamily", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sudoku puzzle grid cleared..
        /// </summary>
        internal static string PuzzleCleared {
            get {
                return ResourceManager.GetString("PuzzleCleared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sudoku new puzzle generated successfully!.
        /// </summary>
        internal static string PuzzleGenerated {
            get {
                return ResourceManager.GetString("PuzzleGenerated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Sudoku puzzle grid is empty..
        /// </summary>
        internal static string PuzzleGridEmpty {
            get {
                return ResourceManager.GetString("PuzzleGridEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, the sudoku puzzle is not solved correctly..
        /// </summary>
        internal static string PuzzleInvalidSolve {
            get {
                return ResourceManager.GetString("PuzzleInvalidSolve", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, the current state of the sudoku puzzle is incorrect..
        /// </summary>
        internal static string PuzzleInvalidSolveState {
            get {
                return ResourceManager.GetString("PuzzleInvalidSolveState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No solution for this sudoku puzzle..
        /// </summary>
        internal static string PuzzleNoSolution {
            get {
                return ResourceManager.GetString("PuzzleNoSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sudoku puzzle solved  successfully!.
        /// </summary>
        internal static string PuzzleSolved {
            get {
                return ResourceManager.GetString("PuzzleSolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current state of the sudoku puzzle is correct, but not completed yet..
        /// </summary>
        internal static string PuzzleValidButNotCompleted {
            get {
                return ResourceManager.GetString("PuzzleValidButNotCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Sudoku {
            get {
                object obj = ResourceManager.GetObject("Sudoku", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}