namespace MatrixAll.Operations
{
    public static class MatrixSum
    {
        public static Matrix SumMatrices(Matrix a, Matrix b)
        {
            if (a.M != b.M || a.N != b.N)
                return null;

            float[,] c = new float[a.M, a.N];
            
            for (int i = 0; i < a.M; i++)
            {
                for (int j = 0; j < a.N; j++)
                    c[i, j] = a[i, j] + b[i, j];
            }
            
            return new Matrix(c);
        }
        
        public static Matrix SumMatrixAndFloat(Matrix a, float value)
        {
            float[,] c = new float[a.M, a.N];
            
            for (int i = 0; i < a.M; i++)
            {
                for (int j = 0; j < a.N; j++)
                    c[i, j] = a[i, j] + value;
            }
            
            return new Matrix(c);
        }
    }
}