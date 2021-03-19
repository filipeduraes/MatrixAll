﻿using System;
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
    }
}