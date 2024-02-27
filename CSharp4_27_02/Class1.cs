namespace CSharp4_27_02
{
    public class Matrix
    {
        private int[,] data;

        public int Rows { get; private set; }
        public int Columns { get; private set; }

        
        public int this[int row, int col]
        {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new int[Rows, Columns];
        }

        
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                throw new InvalidOperationException("Неможливо додати матриці різних розмірів");

            Matrix result = new Matrix(m1.Rows, m1.Columns);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }

        
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                throw new InvalidOperationException("Неможливо відняти матриці різних розмірів");

            Matrix result = new Matrix(m1.Rows, m1.Columns);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }

        
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Columns != m2.Rows)
                throw new InvalidOperationException("Неможливо перемножити матриці з такими розмірами");

            Matrix result = new Matrix(m1.Rows, m2.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m1.Columns; k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        
        public static Matrix operator *(Matrix m, int scalar)
        {
            Matrix result = new Matrix(m.Rows, m.Columns);
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Columns; j++)
                {
                    result[i, j] = m[i, j] * scalar;
                }
            }
            return result;
        }

        
        public static bool operator ==(Matrix m1, Matrix m2)
        {
            if (ReferenceEquals(m1, null))
                return ReferenceEquals(m2, null);
            if (ReferenceEquals(m2, null))
                return false;

            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                return false;

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    if (m1[i, j] != m2[i, j])
                        return false;
                }
            }
            return true;
        }

        
        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }

        
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Matrix))
                return false;

            Matrix other = (Matrix)obj;
            return this == other;
        }

        
        public override int GetHashCode()
        {
            return data.GetHashCode();
        }
    }
}
