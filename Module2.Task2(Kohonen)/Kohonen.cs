using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Module2.Task2_Kohonen_
{
    class Kohonen
    {
        List<List<Neuron>> Nodes;

        public Kohonen(int numNodesI, int numNodesJ, int numberWeights)
        {
            Random randomizer = new Random();
            Nodes = new List<List<Neuron>>();
            for (int i = 0; i < numNodesI; ++i)
                Nodes.Add(new List<Neuron>());
            for (int i = 0; i < numNodesI; ++i)
                for (int j = 0; j < numNodesJ; ++j)
                    Nodes[i].Add(new Neuron(i, j, numberWeights, ref randomizer));
        }

        public Neuron FindBMU(List<double> inputVector)
        {
            double minDistance = double.MaxValue;
            int iBMU = 0, jBMU = 0;
            for (int i = 0; i < Nodes.Count; ++i)
                for (int j = 0; j < Nodes[i].Count; ++j)
                    if (Nodes[i][j].GetDistance(inputVector) < minDistance)
                    {
                        minDistance = Nodes[i][j].GetDistance(inputVector);
                        iBMU = i;
                        jBMU = j;
                    }
            return Nodes[iBMU][jBMU];
        }

        private double calcError(List<double> v1, List<double> v2)
        {
            double answer = 0.0;
            for (int i = 0; i < v1.Count; i++)
                answer += (v1[i] - v2[i]) * (v1[i] - v2[i]);
            answer = Math.Sqrt(answer);
            return answer;
        }

        public void Learn(ref List<List<double>> data, int numIterations, ref MetroProgressBar pb)
        {
            Random randomizer = new Random();
            double mapRadius = Nodes.Count;
            double timeConstant = numIterations / Math.Log(mapRadius);
            double startLearningRate = 0.6;

            int currentIteration = 1;
            double learningRate = startLearningRate;
            int currentInputVector = -1;
            double neighbourhoodRadius = mapRadius;
            double error = 1.0;

            while (currentIteration < numIterations && error >= 0.0001)
            {
                currentInputVector = (1 + currentInputVector) % data.Count;
                Neuron bmu = FindBMU(data[currentInputVector]);
                error = calcError(bmu.weigth, data[currentInputVector]);

                for (int i = 0; i < Nodes.Count; ++i)
                    for (int j = 0; j < Nodes[i].Count; ++j)
                    {
                        double distanceToNode = Math.Sqrt(Math.Pow(bmu.x - Nodes[i][j].x, 2)
                            + Math.Pow(bmu.y - Nodes[i][j].y, 2));

                        if (distanceToNode < neighbourhoodRadius)
                            Nodes[i][j].SetNewWeightVector(data[currentInputVector], learningRate);
                    }
                currentIteration += 1;
                learningRate = startLearningRate * Math.Exp(-currentIteration / numIterations);
                neighbourhoodRadius = mapRadius * Math.Exp(-(double)currentIteration / timeConstant);
                pb.Increment(1);
            }
        }

        public List<List<Color>> NewRender()
        {
            List<List<Color>> renderPicture = new List<List<Color>>();
            for (int i = 0; i < Nodes.Count; ++i)
                renderPicture.Add(new List<Color>());

            for (int i = 0; i < Nodes.Count; ++i)
            for (int j = 0; j < Nodes[i].Count; ++j)
                renderPicture[i].Add(Color.FromArgb(255, Convert.ToInt32(Nodes[i][j].weigth[0]),
                    Convert.ToInt32(Nodes[i][j].weigth[1]), Convert.ToInt32(Nodes[i][j].weigth[2])));
            return renderPicture;
        }
    }
}
