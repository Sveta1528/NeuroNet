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
            System.IO.StreamWriter matrix = new System.IO.StreamWriter(@"..\..\matrix.txt");
        }

        public void SetWeightMatrix()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    var sum = 0;
                    for (int k = 0; k < count; k++)
                        sum += patterns[k][i] * patterns[k][j];
                    W[i, j] = sum;
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
            double sum = 0;
            for (int i = 0; i < size; i++)
                sum += x[i]*y[i];
            double diff = 0.5*(size - sum);
            return diff < eps;
        }


        public int[] Recognize(ref int[] input)
        {
            int[] prev = input;
            int[] cur = prev;

            bool flag = true;

            while (true)
            {

                for (int j = 0; j < size; j++)
                {
                    for (int i = 0; i < size; i++)
                        cur[j] += W[i, j]*prev[i];
                    cur[j] = ThresholdFunction(cur[j]);
                }

                flag = HammingDistance(ref cur, ref prev, 10);
                if (flag) return cur;
                prev = cur;
            }
        }

        }

    }