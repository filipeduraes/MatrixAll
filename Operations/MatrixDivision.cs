using System;

namespace MatrixAll.Operations
{
    public static class MatrixDivision
    {
        public static Matrix DivideMatrices(Matrix a, Matrix b) => a * (b ^ -1f);
        
        public static Matrix DivideMatrixAndFloat(Matrix a, float value) => a * (float) Math.Pow(value, -1f);
    }
}