﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Predator : Creature
    {
        public Predator(int X, int Y) : base(X, Y) { }
        public override void Eat(List<Creature> creatures)
        {
            if (eatHerbIndex > -1)
            {
                health += 4;
                MakeNewCreature(creatures);
            }
        }
        protected override void MakeNewCreature(List<Creature> creatures)
        {
            Random rnd = new Random();
            int childX = Location.X + rnd.Next(-2, 2);
            int chlidY = Location.Y + rnd.Next(-2, 2);
            if (health >= 20)
            {
                health = 10;
                Predator child = new Predator(childX, chlidY);
                for (int i = 0; i < neurons.Count; i++)
                {
                    double[] mutatedWeights = neurons[i].Weights;
                    for (int j = 0; j < mutatedWeights.Length; j++)
                    {
                        mutatedWeights[j] += (rnd.NextDouble() * 2 - 1) / 2.0;
                    }
                    child.neurons[i].Weights = mutatedWeights;
                }
                creatures.Add(child);
            }
        }
        public override Pen GetCreaturePen()
        {
            return new Pen(Color.Red);
        }
    }
}
