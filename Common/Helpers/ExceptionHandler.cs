using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SudokuInterViewCaseStudy
{
    internal class ExceptionHandler : Exception
    {

        public ExceptionHandler(Exception ex)
        {
            throw new Exception(
                string.Format("Some error occurs during intialization..! *==> {0} | {1} | {2}",
                ex.Message,
                ex.InnerException,
                ex.StackTrace)
                );

        }


    }
}
