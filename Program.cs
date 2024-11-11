namespace PascalTraingle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pascalTriangleVariation1(4,4);
            //pascalTriangleVariation2(6);
            //pascalTriangleVariation2Optimal(6);
            PascalTraingleVarition3(6);
        }

        /*
         Variation 1: Given row number r and column number c. Print the element at position (r, c) in Pascal’s triangle.

        Variation 2: Given the row number n. Print the n-th row of Pascal’s triangle.

        Variation 3: Given the number of rows n. Print the first n rows of Pascal’s triangle.

        */

        static void pascalTriangleVariation1(int r, int c)
        {
            Console.WriteLine(CalculateNCR(r - 1, c - 1));
        }

        static long CalculateNCR(int n, int r)
        {
            long result = 1;
            for(int i = 0; i < r; i++)
            {
                result = result * (n - i);
                result = result / (i + 1);
            }
            return result;
        }

        // printing the entire row n:
        static void pascalTriangleVariation2(int n)
        {
            for(int c = 1; c <= n; c++)
            {
                Console.WriteLine(CalculateNCR(n-1,c-1));
            }
        }

        static void pascalTriangleVariation2Optimal(int n)
        {
            long ans = 1;
            Console.WriteLine(ans);

            for(int i = 1; i <n; i++)
            {
                ans = ans * (n - i);
                ans = ans / i;
                Console.WriteLine(ans);
            }
        }

        static IList<IList<int>> PascalTraingleVarition3(int n)
        {
            var triangle = new List<IList<int>>();
            for(int i = 1; i <= n; i++)
            {
                triangle.Add(generateRow(i));
            }

            return triangle;
        }

        static List<int> generateRow(int row)
        {
            long ans = 1;
            List<int> ansRow = new List<int>();
            ansRow.Add(1);
            for(int col = 1; col < row; col++)
            {
                ans = ans * (row - col);
                ans = ans / col;
                ansRow.Add((int)ans);
            }


            return ansRow;

        }
    }
}
