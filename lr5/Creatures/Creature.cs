using lr5.Creatures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace lr5
{
    public class Creature
    {
        protected List<Neuron> neurons = new List<Neuron>();
        protected Perception perception;
        protected int eatHerbIndex;
        protected int eatPlantIndex;
        protected int health = 10;
        protected Direction direction;
        public Point Location { get; set; }
        public Creature(int X, int Y) 
        {
            perception = new Perception();
            direction = Direction.North;
            Location = new Point(X, Y);
            for (int i = 0; i < 4; i++)
            {
                neurons.Add(new Neuron());
            }
            perception.UpdatePerceptionFacingNorth(Location);
        }
        public void Damage(List<Creature> creatures,Creature creature)
        {
            creature.health--;
            if (health <= 0) creatures.Remove(creature);
        }
        public virtual Pen GetCreaturePen()
        {
            return new Pen(Color.Transparent);
        }
        private int[] GetNeuronOutput()
        {
            int[] output = new int[4];
            int neuronIndex = -1;
            double tmpMax = Double.MinValue;
            for (int i = 0; i < 4; i++)
            {
                Neuron neuron = neurons[i];
                double tmpOutput = neuron.CalculatePotential();
                if (tmpOutput >= tmpMax)
                {
                    tmpMax = tmpOutput;
                    neuronIndex = i;
                }
            }
            output[neuronIndex] = 1;
            return output;
        }
        public void ScanNearbyWorld(List<Creature> creatures)
        {
            int[] neuronInputArray = new int[12];
            this.eatHerbIndex = -1;
            eatPlantIndex = -1;
            for (int i = 0; i < creatures.Count; i++)
            {
                var creature = creatures[i];
                foreach (Point frontPoint in perception.frontPerception)
                {
                    if (creature.Location == frontPoint)
                    {
                        if (creature.GetType() == typeof(Herbivore))
                        {
                            neuronInputArray[0] = 1;
                        }
                        else if (creature.GetType() == typeof(Predator))
                        {
                            neuronInputArray[1] = 1;
                        }
                        else
                        {
                            neuronInputArray[2] = 1;
                        }
                    }
                }
                foreach (Point leftPoint in perception.leftPerception)
                {
                    if (creature.Location == leftPoint)
                    {
                        if (creature.GetType() == typeof(Herbivore))
                        {
                            neuronInputArray[3] = 1;
                        }
                        else if (creature.GetType() == typeof(Predator))
                        {
                            neuronInputArray[4] = 1;
                        }
                        else
                        {
                            neuronInputArray[5] = 1;
                        }
                    }
                }
                foreach (Point rightPoint in perception.rightPerception)
                {
                    if (creature.Location == rightPoint)
                    {
                        if (creature.GetType() == typeof(Herbivore))
                        {
                            neuronInputArray[6] = 1;
                        }
                        else if (creature.GetType() == typeof(Predator))
                        {
                            neuronInputArray[7] = 1;
                        }
                        else
                        {
                            neuronInputArray[8] = 1;
                        }
                    }
                }
                foreach (Point nearPoint in perception.nearPerception)
                {
                    if (creature.Location == nearPoint)
                    {
                        if (creature.GetType() == typeof(Herbivore))
                        {
                            neuronInputArray[9] = 1;
                            this.eatHerbIndex = i;
                        }
                        else if (creature.GetType() == typeof(Predator))
                        {
                            neuronInputArray[10] = 1;
                        }
                        else
                        {
                            neuronInputArray[11] = 1;
                            this.eatPlantIndex = i;
                        }
                    }
                }
            }
            foreach(Neuron n in neurons)
            {
                n.Input = neuronInputArray;
            }
        }
        public void Act(List<Creature> creatures)
        {
            int[] neuronOutput = GetNeuronOutput();
                for (int i = 0; i < neuronOutput.Length; i++)
                {
                    if (neuronOutput[i] != 0 && i == 0)
                    {
                        this.TurnLeft();
                    Move();
                    }
                    else if (neuronOutput[i] != 0 && i == 1)
                    {
                        this.TurnRight();
                    Move();
                    }
                    else if (neuronOutput[i] != 0 && i == 2)
                    {
                        this.Move();
                    }
                    else if (neuronOutput[i] != 0 && i == 3)
                    {
                        this.Eat(creatures);
                    }          
            }
        }
        public void TurnLeft()
        {
            switch (direction)
            {
                case Direction.North:
                    direction = Direction.West;
                    perception.UpdatePerceptionFacingWest(Location);
                    break;
                case Direction.West:
                    direction = Direction.South;
                    perception.UpdatePerceptionFacingSouth(Location);
                    break;
                case Direction.South:
                    direction = Direction.East;
                    perception.UpdatePerceptionFacingEast(Location);
                    break;
                case Direction.East:
                    direction = Direction.North;
                    perception.UpdatePerceptionFacingNorth(Location);
                    break;
            }
        }
        public void TurnRight()
        {
            switch (direction)
            {
                case Direction.North:
                    direction = Direction.East;
                    perception.UpdatePerceptionFacingEast(Location);
                    break;
                case Direction.West:
                    direction = Direction.North;
                    perception.UpdatePerceptionFacingNorth(Location);
                    break;
                case Direction.South:
                    direction = Direction.West;
                    perception.UpdatePerceptionFacingWest(Location);
                    break;
                case Direction.East:
                    direction = Direction.South;
                    perception.UpdatePerceptionFacingSouth(Location);
                    break;
            }
        }
        public virtual void Move()
        {
            switch (direction)
            {
                case Direction.North:
                    int newCoordYNorth = this.Location.Y + 1;
                    if (newCoordYNorth > Utilities.WorldSizeY)
                        this.Location = new Point(this.Location.X, 0);
                    else this.Location = new Point(this.Location.X, newCoordYNorth);
                    break;
                case Direction.West:
                    int newCoordXWest = this.Location.X - 1;
                    if (newCoordXWest < 0)
                        this.Location = new Point(Utilities.WorldSizeX, this.Location.Y);
                    else this.Location = new Point(newCoordXWest, this.Location.Y);
                    break;
                case Direction.South:
                    int newCoordYSouth = this.Location.Y - 1;
                    if (newCoordYSouth < 0)
                        this.Location = new Point(this.Location.X, Utilities.WorldSizeY);
                    else this.Location = new Point(this.Location.X, newCoordYSouth);
                    break;
                case Direction.East:
                    int newCoordXEast = this.Location.X + 1;
                    if (newCoordXEast > Utilities.WorldSizeX)
                        this.Location = new Point(0, this.Location.Y);
                    else this.Location = new Point(newCoordXEast, this.Location.Y);
                    break;
            }
        }
        public virtual void Eat(List<Creature> creatures)
        {
            return;
        }
        protected virtual void MakeNewCreature(List<Creature> creatures)
        {
            return;
        }
    }
}
