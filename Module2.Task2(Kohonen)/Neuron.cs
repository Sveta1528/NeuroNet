using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Task2_Kohonen_
{
    class Neuron
    {
        public List<double> weigth;
        public double x, y;

        public Neuron(int x, int y, int count, ref Random randomizer)
        {

            weigth = new List<double>(count);

            for (int i = 0; i < count; ++i)
                weigth.Add(randomizer.Next(0, 255));

            this.x = x;
            this.y = y;
        }

        public double GetDistance(List<double> input)
        {
            double distance = 0;
            for (int i = 0; i < weigth.Count; ++i)
                distance += Math.Pow(input[i] - weigth[i], 2);
            return Math.Sqrt(distance); 
        }

        public void SetNewWeightVector(List<double> inputVector, double learningRate)
        {
            for (int i = 0; i < weigth.Count; i++)
                weigth[i] += (inputVector[i] - weigth[i]) * learningRate;
        }
    }
}
