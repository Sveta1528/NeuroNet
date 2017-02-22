using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class HopfieldNet
    {
        private int size;
        private int[,] W; // матрица весов (связей).
        private List<int[]> patterns;
        int count;

        public HopfieldNet(ref List<int[]> p)
        {
            patterns = p;
            count = patterns.Count;
            size = patterns[0].Length;
            W = new int[size, size];
            SetWeightMatrix();
        }

        public void SetWeightMatrix()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    var sum = 0;
                    for (int k = 0; k < count; k++)
                        sum += patterns[k][i] * patterns[k][j];
                    W[i, j] = sum / size;
                }

            for (int i = 0; i < size; i++)
                W[i, i] = 0;
        }

        private int ThresholdFunction(int x)
        {
            return x >= 0 ? 1 : -1;
        }

        private bool HammingDistance(ref int[] x, ref int[] y, double eps)
        {
            int n = x.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += x[i]*y[i];
            return 1 / 2 * (n - sum) < eps;
        }


        public int[] Recognize(ref int[] input)
        {
            int[] first = input;
            int[] second = first;
            //int[] third = second;

            bool flag = true;

            while (true)
            { 

                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        second[i] += W[i, j] * first[j];

                for (int i = 0; i < size; i++)
                    second[i] = ThresholdFunction(second[i]);


                flag = HammingDistance(ref first, ref second, 0.00001);
                if (flag) return second;
                //if (first==third) return third;
                first = second;
                //second = third;
            }

        }

    }
}
