namespace MatrixAll.Generation
{
    public static class NewMatrices
    {
        public static Matrix GenerateNullMatrix(int m, int n)
        {
            float[,] a = new float[m, n];
            return new Matrix(a);
        }

        public static Matrix GenerateIdentityMatrix(int order)
        {
            float[,] a = new float[order, order];

            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                    a[i, j] = i == j ? 1f : 0f;
            }
            
            return new Matrix(a);
        }
    }
}