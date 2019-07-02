using System;

namespace ProblemSolving
{
    class MatrixProblems
    {
        /// <summary>
        /// Algo: 
        /// </summary>
        /// <param name="givenMatrix"></param>
        /// <returns></returns>
        public void PrintPrincipleDiagonalElements(int[,] givenMatrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0} ", givenMatrix[i, j]);
                    }
                }

            }
        }

        /// <summary>
        /// Algo: 
        /// </summary>
        /// <param name="givenMatrix"></param>
        /// <returns></returns>
        public void PrintAllDiagonalElements0(int[,] givenMatrix, int rows, int columns)
        {
            // First the outpust should starts with [startOfRow,startOfColumn] ends with [startOfRow,endOfColumn]
            // By Increasing row
            // Printing first half of the matrix
            for (int k = 0; k <= rows - 1; k++)
            {
                Console.WriteLine("");
                int i = k;
                int j = 0;
                while (i >= 0)
                {
                    Console.Write(givenMatrix[i, j]);
                    i = i - 1;
                    j = j + 1;
                }
            }

            // Printing second half of the matrix
            for (int k = 1; k <= columns - 1; k++)
            {
                Console.WriteLine("");
                int i = rows - 1;
                int j = k;
                // this condition to print all diagonal at the i value is rows-1
                while (j <= columns - 1)
                {
                    Console.Write(givenMatrix[i, j]);
                    i = i - 1;
                    j = j + 1;
                }
            }
            // this will print
            //1
            //42
            //753
            //86
            //9
        }

        /// <summary>
        /// Algo: 
        /// </summary>
        /// <param name="givenMatrix"></param>
        /// <returns></returns>
        public void PrintAllDiagonalElements1(int[,] givenMatrix, int rows, int columns)
        {
            // First the output should starts with [2,0] i.e [endOFRow, startOfColmn] 
            // end with [startOfRow,endOfColumn]
            // Printing first half of the matrix
            for (int k = 0; k <= rows - 1; k++)
            {
                Console.WriteLine("");
                int i = k;
                int j = 0;
                while (i >= 0)
                {
                    Console.Write(givenMatrix[i, j]);
                    i = i - 1;
                    j = j + 1;
                }
            }

            // Printing second half of the matrix
            for (int k = 1; k <= columns - 1; k++)
            {
                Console.WriteLine("");
                int i = rows - 1;
                int j = k;
                // this condition to print all diagonal at the i value is rows-1
                while (j <= columns - 1)
                {
                    Console.Write(givenMatrix[i, j]);
                    i = i - 1;
                    j = j + 1;
                }
            }
            // this will print
            //3
            //26
            //159
            //48
            //7
        }

        /// <summary>
        /// Algo: 
        /// </summary>
        /// <param name="givenMatrix"></param>
        /// <returns></returns>
        public void PrintSpiralElements(int[,] givenMatrix, int rows, int columns)
        {
            // k is starting index of row, l is ending index of row, this is to keep track of row indexes
            int k = 0, endOfRow = rows - 1;
            // m is starting index of column, n is ending index of column, this is to keep track of column indexes
            int l = 0, endOfColumn = columns - 1;

            while (k < rows && l < columns)
            {
                // looping throw the first row until the last column
                // this is to display row elements
                for (int i = l; i <= endOfColumn; ++i)
                {
                    Console.Write(givenMatrix[k, i]);
                }
                k = k + 1;

                // returning the elements in last column from next row to the end. if the nextRow Exist
                if (k <= endOfRow)
                {
                    // looping throw the last column until the last row
                    for (int i = k; i <= endOfRow; ++i)
                    {
                        Console.Write(givenMatrix[i, endOfColumn]);
                    }
                    endOfColumn = endOfColumn - 1;
                }

                // returning the elements in last row from end of the colmn -1 to startOftheColumn if the previous column exist
                if (l < endOfColumn)
                {
                    for (int i = endOfColumn; i >= l; --i)
                    {
                        Console.Write(givenMatrix[endOfRow, i]);
                    }
                    endOfRow = endOfRow - 1;
                }

                // if the row exist before the endofRow then print until the start of thhe row
                if (l < endOfColumn)
                {
                    for (int i = endOfRow; i >= k; --i)
                    {
                        Console.Write(givenMatrix[i, l]);
                    }
                    // Incrementingg the length
                    l = l + 1;
                }
                Console.WriteLine("column:{0}, endColumn:{1}, row :{2},endRow:{3}", l,endOfColumn,k,endOfRow);
            }
        }
        public static void spiralPrint(int rows, int columns, int[,] a)
        {
            int i, k = 0, l = 0;
            /* k - starting row index 
            m - ending row index 
            l - starting column index 
            n - ending column index 
            i - iterator 
            */

            while (k < rows && l < columns)
            {
                // Print the first row  
                // from the remaining rows 
                for (i = l; i < columns; ++i)
                {
                    Console.Write(a[k, i] + " ");
                }
                k++;

                // Print the last column from the 
                // remaining columns 
                for (i = k; i < rows; ++i)
                {
                    Console.Write(a[i, columns - 1] + " ");
                }
                columns--;

                // Print the last row from  
                // the remaining rows  
                if (k < rows)
                {
                    for (i = columns - 1; i >= l; --i)
                    {
                        Console.Write(a[rows - 1, i] + " ");
                    }
                    rows--;
                }

                // Print the first column from  
                // the remaining columns 
                if (l < columns)
                {
                    for (i = rows - 1; i >= k; --i)
                    {
                        Console.Write(a[i, l] + " ");
                    }
                    l++;
                }
            }
        }
    }
}
