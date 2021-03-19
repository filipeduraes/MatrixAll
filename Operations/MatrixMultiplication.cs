namespace MatrixAll.Operations
{
    public static class MatrixMultiplication
    {
        public static Matrix MultiplyMatrices(Matrix a, Matrix b)
        {
            if(a.M != b.N || a.N != b.M)
                return null;
		
            int m = a.M;
            int n = b.N;
            int p = a.N;
		
            float[,] c = new float[m, n];
		
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    float element = 0;
				
                    for(int x = 0; x < p; x++)
                        element += a[i, x] * b[x, j];
				
                    c[i, j] = element;
                }
            }
		
            return new Matrix(c);
        }
        
        public static Matrix MultiplyMatrixAndFloat(Matrix a, float value)
        {
            int m = a.M;
            int n = a.N;
		
            float[,] c = new float[m, n];
		
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                    c[i, j] = a[i, j] * value;
            }
		
            return new Matrix(c);
        }
    }
}