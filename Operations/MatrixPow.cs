using System;

namespace MatrixAll.Operations
{
    public static class MatrixPow
    {
        public static Matrix PowMatrix(Matrix a, float value)
        {
            int m = a.M;
            int n = a.N;
            
            float[,] c = new float[m, n];
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    c[i, j] = (float) Math.Pow(a[i, j], value);
            }

            return new Matrix(c);
        }
    }
}