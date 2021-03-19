using System;
using MatrixAll.Exceptions;

namespace MatrixAll.Generation
{
    public static class ExistingMatrices
    {
        public static Matrix GenerateInverseMatrix(Matrix a)
        {
            int m = a.M;
            int n = a.N;

            throw new NotImplementedException();
        }

        public static Matrix GenerateTransposeMatrix(Matrix a)
        {
            int m = a.M;
            int n = a.N;
            
            float[,] b = new float[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    b[i, j] = a[j, i];
            }

            return new Matrix(b);
        }

        public static float GetDeterminant(Matrix a)
        {
            if (!a.IsSquare)
                throw new IllegalArgumentException(IllegalTypes.MatrixNotSquare);
            
            int p = 1;
            int order = a.N;
            Matrix b = a;
            
            for (int k = 0; k < order - 1; k++)
            {
                float max = Math.Abs(b[k, k]);
                int maxIndex = k;

                for (int i = k + 1; i < order; i++)
                {
                    if (!(max < Math.Abs(b[i, k]))) continue;
                    max = Math.Abs(b[i, k]);
                    maxIndex = i;
                }

                if (maxIndex != k)
                {
                    p *= -1;
                    for (int j = 0; j < order; j++)
                    {
                        float temp = a[k, j];
                        b[k, j] = b[maxIndex, j];
                        b[maxIndex, j] = temp;
                    }
                }

                if (a[k, k] == 0f)
                    return 0f;
                
                for (int m = k + 1; m < order; m++)
                {
                    float f = (-1) * b[m, k] / b[k, k];
                    b[m, k] = 0f;
                    for (int l = k + 1; l < order; l++)
                        b[m, l] = b[m, l] + f * b[k, l];
                }
            }

            float det = 1f;
            for (int q = 0; q < order; q++)
                det *= b[q, q];

            return p * det;
        }
    }
}