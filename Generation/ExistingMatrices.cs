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
            Matrix upperTriangularA = a.ToUpperTriangular();
            
            float result = 1f;
            for(int i = 0; i < upperTriangularA.M; i++)
                result *= upperTriangularA[i, i];
            		
            return result;
        }
        
        public static Matrix ConvertToUpperTriangular(Matrix a)
        {
	        if(!a.IsSquare)
                throw new IllegalArgumentException(IllegalTypes.MatrixNotSquare);
                
            Matrix b = a;
        	int length = a.M;
        	
        	for(int k = 0; k < length; k++)
        	{
        		for(int i = k + 1; i < length; i++)
        		{
        			float multiplier = b[i, k] / b[k, k] * -1f;
        			
        			for(int j = k; j < length; j++)
        				b[i, j] = multiplier * b[k, j] + b[i, j];
        		}
        	}
        	
        	return b;
        }
    }
}