using System;


namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = 777;
            //int res = 0;
            //string b = Convert.ToString(N, 2);
            //int l = b.Length;
            //for(int i=0; i<l; i++)
            //{
            //    if (b[i] == '0')
            //    {
            //        int j = i + 1;
            //        while (j < l && b[j] == '0') j++;
            //        if (j - i > res && j != l ) res = j - i;
            //        i = j;
            //    }
            //}
            //Console.WriteLine("Number = {0}, Binary = {1} Res = {2} ", N, b, res);
            int[] A = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;
            int l = A.Length;
            if (K <= 0) return; // A;
            for (int i = 0; i < K; i++)
            {
                int last = A[l - 1];
                for (int j = l - 1; j > 0; j--)
                    A[j] = A[j - 1];
                A[0] = last;

            }
        }
    }
}
