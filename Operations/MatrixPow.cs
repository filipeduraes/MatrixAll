using System;
using MatrixAll.Exceptions;

namespace MatrixAll.Operations
{
    public static class MatrixPow
    {
        public static Matrix PowMatrix(Matrix a, int value)
        {
            if (!a.IsSquare) throw new IllegalArgumentException(IllegalTypes.MatrixNotSquare);
            if (value == 0) return Matrix.Identity(a.M);

            Matrix c = PowMatrix(a, value / 2);
            
            if (value % 2 == 0)
                return c * c;
            
            Matrix b = c * c;
            return a * b;
        }
    }
}