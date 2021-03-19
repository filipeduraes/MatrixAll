using MatrixAll.Operations;
using MatrixAll.Generation;

namespace MatrixAll
{
    public class Matrix
    {
        public int M {get;}
        public int N {get;}
        public bool IsSquare => M == N;

        public delegate float FormationLaw(int i, int j);
        
        private readonly float[,] matrix;
        
        #region Constructors
        public Matrix(int m, int n, FormationLaw law)
        {
            M = m;
            N = n;
			
            matrix = new float[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    matrix[i, j] = law(i + 1, j + 1);
            }
        }

        public Matrix(float[,] matrixArray)
        {
            M = matrixArray.GetLength(0);
            N = matrixArray.GetLength(1);
            matrix = matrixArray;
        }
        #endregion

        public static Matrix NullMatrix(int m, int n) => NewMatrices.GenerateNullMatrix(m, n);
        public static Matrix Identity(int order) => NewMatrices.GenerateIdentityMatrix(order);
        public Matrix Inverse() => ExistingMatrices.GenerateInverseMatrix(this);
        public Matrix Transpose() => ExistingMatrices.GenerateTransposeMatrix(this);
        
        #region Operators
        public float this[int i, int j]
        {
            get => matrix[i, j];
            set => matrix[i, j] = value;
        }
        
        public static Matrix operator *(Matrix a, Matrix b) => MatrixMultiplication.MultiplyMatrices(a, b);
        public static Matrix operator *(Matrix a, float value) => MatrixMultiplication.MultiplyMatrixAndFloat(a, value);
        public static Matrix operator *(float value, Matrix a) => MatrixMultiplication.MultiplyMatrixAndFloat(a, value);
        
        public static Matrix operator +(Matrix a, Matrix b) => MatrixSum.SumMatrices(a, b);
        public static Matrix operator +(Matrix a, float value) => MatrixSum.SumMatrixAndFloat(a, value);
        public static Matrix operator +(float value, Matrix a) => MatrixSum.SumMatrixAndFloat(a, value);
        
        public static Matrix operator -(Matrix a, Matrix b) => MatrixSubtraction.SubtractMatrices(a, b);
        public static Matrix operator -(Matrix a, float value) => MatrixSubtraction.SubtractMatrixAndFloat(a, value);
        public static Matrix operator -(float value, Matrix a) => MatrixSubtraction.SubtractMatrixAndFloat(value, a);
        public static Matrix operator -(Matrix a) => MatrixSubtraction.NegateMatrix(a);

        public static Matrix operator ^(Matrix a, int value) => MatrixPow.PowMatrix(a, value);
        #endregion
    }
}