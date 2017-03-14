using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class HammingNet
    {
        private int size;
        private int[,] W; // матрица весов (связей).
        private List<int[]> patterns;
        int count;

        public HammingNet(ref List<int[]> p)
        {
            patterns = p;
            count = patterns.Count;
            size = patterns[0].Length;
            W = new int[size, count];
            SetWeightMatrix();
        }

        public void SetWeightMatrix()
        {
            for (int j = 0; j < count; j++)
                for (int i = 0; i < size; i++)
                    W[i, j] = patterns[j][i];
        }

        private double ThresholdFunction(double x, double F)
        {
            if (x <= 0)
                return 0;
            else // x > 0
            {
                if (x < F)
                    return x;
                else // x >= F, x > 0
                    return F;
            }
        }

        private bool HammingDistance(ref double[] x, ref double[] y, double eps)
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
                sum += x[i] * y[i];
            double diff = 0.5 * (size - sum);
            return diff < eps;
        }


        // m- количество образцов
        public int Recognize(ref int[] input)
        {
            double[] prev = new double[count];

            for (int j = 0; j < count; j++)
            {
                double sum = 0;
                for (int i = 0; i < size; i++)
                    sum += W[i, j] * input[i];
                prev[j] = sum + size / 2;
            }

            double[] cur = prev;
            double eps = 0.01;
            double F = 150 * 100;
            while (true)
            {
                double sum = 0;
                for (int j = 0; j < count; j++)
                {
                    for (int i = 0; i < count; i++)
                        if (i != j) sum += prev[i];
                    cur[j] = ThresholdFunction(prev[j] - eps * sum,F);
                }

                if (HammingDistance(ref cur, ref prev, 10)) break;
                prev = cur;
            }

            // find result
            double max = -1;
            int index = 0;
            for (int i = 0; i < cur.Length; i++)
            {
                if (cur[i] > max)
                {
                    max = cur[i];
                    index = i;
                }
            }

            return index;

        }

        }
}
