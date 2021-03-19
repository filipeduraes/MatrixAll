using System;
using System.Collections.Generic;

namespace MatrixAll.Exceptions
{
    public class IllegalArgumentException : Exception
    {
        private static readonly Dictionary<IllegalTypes, string> MessagesDictionary = new Dictionary<IllegalTypes, string>()
        {
            {IllegalTypes.MatricesNotEqual, "Operation cannot be done because the matrices are not equal."},
            {IllegalTypes.MatrixNotSquare, "Operation cannot be done because the matrix has different collum and row quantities."},
            {IllegalTypes.MatrixNotAbleToMultiply, "Multiplication cannot be done because 'A' number of columns is different than 'B' number of rows."}
        };
        
        public IllegalArgumentException() { }
        public IllegalArgumentException(string message) : base(message) { }
        public IllegalArgumentException(string message, Exception inner) : base(message, inner) { }
        public IllegalArgumentException(IllegalTypes illegalType) : base(MessagesDictionary[illegalType]) { }
    }

    public enum IllegalTypes
    {
        MatrixNotSquare,
        MatrixNotAbleToMultiply,
        MatricesNotEqual
    }
}