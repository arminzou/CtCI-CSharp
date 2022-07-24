using ctci.Contracts;
using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes,
    // write a method to rotate the image by 90 degrees.Can you do this in place?
    public class RotateMatrix : Question
    {
        // pseudo code
        // for i = 0 to n
        //  temp = top[i]
        //  top[i] = left[i]
        //  left[i] = bottom[i]
        //  bottom[i] = right[i]
        //  right[i] = temp
        public bool Rotate(int[][] matrix)
        {
            // check if the matrix is a square matrix
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length) return false;

            int matrixSize = matrix.Length;
            for(int layer = 0; layer < matrixSize / 2; layer++)
            {
                int startIndex = layer;
                int lastIndex = (matrixSize - 1) - layer;

                for(int elementIndex = startIndex; elementIndex < lastIndex; elementIndex++)
                {
                    // need this offset so we don't refernce the incorrect rows and columns when more layers occur
                    int offset = elementIndex - layer;

                    // Write a diagram to help visualise and understand what occur below
                    // store top row element 
                    int topRowElement = matrix[startIndex][elementIndex];

                    // left -> top
                    matrix[startIndex][elementIndex] = matrix[lastIndex - offset][startIndex];

                    // bottom -> left
                    matrix[lastIndex - offset][startIndex] = matrix[lastIndex][lastIndex - offset];

                    // right -> bottom
                    matrix[lastIndex][lastIndex - offset] = matrix[elementIndex][lastIndex];

                    // top -> right
                    matrix[elementIndex][lastIndex] = topRowElement;
                }
            }
            return false;
        }

        public override void Run()
        {
            const int size = 3;

            var matrix = AssortedMethods.RandomMatrix(size, size, 0, 9);

            AssortedMethods.PrintMatrix(matrix);

            Rotate(matrix);
            Console.WriteLine();
            AssortedMethods.PrintMatrix(matrix);
        }
    }
}
