using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
    // column are set to 0.
    public static class ZeroMatrix
    {
        public static void SetZeros(int[][] matrix)
        {
            // initialize boolean arr for row and column
            var row = new bool[matrix.Length];
            var col = new bool[matrix[0].Length];

            // Store row and col index with value 0
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        row[i] = true;
                        col[j] = true;
                    }
                }
            }

            // nullify rows
            for(int i = 0; i < row.Length; i++)
            {
                if (row[i]) NullifyRow(matrix, i);
            }

            // nullify cols
            for (int j = 0; j < col.Length; j++)
            {
                if (col[j]) NullifyColumn(matrix, j);
            }
        }

        public static void SetZeros2(int[][] matrix)
        {
            bool rowHasZero = false;
            bool colHasZero = false;

            // check if first row has a zero
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0)
                {
                    rowHasZero = true;
                    break;
                }
            }


            // check if first column has a zero
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    colHasZero = true;
                    break;
                }
            }

            // check for zeros in the rest of the array
            for (int i = 1; i < matrix.Length; i++)
            {
                for(int j = 1; j < matrix[0].Length; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            // nullify rows based on values in first column
            for (var i = 1; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    NullifyRow(matrix, i);
                }
            }

            // nullify columns based on values in first row
            for (var j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0)
                {
                    NullifyColumn(matrix, j);
                }
            }

            // nullify first row
            if (rowHasZero)
            {
                NullifyRow(matrix, 0);
            }

            // nullify first column
            if (colHasZero)
            {
                NullifyColumn(matrix, 0);
            }
        }

            public static void NullifyRow(int[][] matrix, int row)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                matrix[row][i] = 0;
            }
        }

        public static void NullifyColumn(int[][] matrix, int col)
        {
            for (int j = 0; j < matrix.Length; j++)
            {
                matrix[j][col] = 0;
            }
        }
    }
}
