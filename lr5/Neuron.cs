using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Neuron
    {
        public int[] Input { get; set; }
        public double[] Weights { get; set; }
        public Neuron()
        {
            Weights = new double[12];
            Input = new int[12];
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                Weights[i] = rnd.NextDouble()*2-1;
            }
        }
        public double CalculatePotential()
        {
            double result = 0;
            for (int i = 0; i < Weights.Length; i++)
            {
                result += Weights[i] * Input[i];
            }
            return result;
        }
    }
}
