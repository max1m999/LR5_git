using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5.Creatures
{
    public class Perception
    {
        public Point[] frontPerception = new Point[50]; 
        public Point[] leftPerception = new Point[10];
        public Point[] rightPerception = new Point[10];
        public Point[] nearPerception = new Point[5];
        public void UpdatePerceptionFacingEast(Point location)
        {
            int X = location.X;
            int Y = location.Y;
            int frontBias = 2;
            int leftBias = 2;
            int rightBias = 2;
            for (int i = 0; i < frontPerception.Length; i += 5)
            {
                frontPerception[i] = new Point(X + frontBias, Y - 2);
                frontPerception[i+1] = new Point(X + frontBias, Y - 1);
                frontPerception[i+2] = new Point(X + frontBias, Y);
                frontPerception[i+3] = new Point(X + frontBias, Y + 1);
                frontPerception[i+4] = new Point(X + frontBias, Y + 2);
                frontBias += 1;
            }
            for (int i = 0; i < leftPerception.Length; i += 2)
            {
                leftPerception[i] = new Point(X + 1, Y + leftBias);
                leftPerception[i+1] = new Point(X, Y + leftBias);
                leftBias += 1;
            }
            for (int i = 0; i < rightPerception.Length; i += 2)
            {
                rightPerception[i] = new Point(X + 1, Y - rightBias);
                rightPerception[i+1] = new Point(X, Y - rightBias);
                rightBias += 1;
            }
            nearPerception[0] = new Point(X, Y + 1);
            nearPerception[1] = new Point(X + 1, Y + 1);
            nearPerception[2] = new Point(X + 1, Y);
            nearPerception[3] = new Point(X + 1, Y - 1);
            nearPerception[4] = new Point(X, Y - 1);
        }
        public void UpdatePerceptionFacingWest(Point location)
        {
            int X = location.X;
            int Y = location.Y;
            int frontBias = 2;
            int leftBias = 2;
            int rightBias = 2;
            for (int i = 0; i < frontPerception.Length; i += 5)
            {
                frontPerception[i] = new Point(X - frontBias, Y - 2);
                frontPerception[i+1] = new Point(X - frontBias, Y - 1);
                frontPerception[i+2] = new Point(X - frontBias, Y);
                frontPerception[i+3] = new Point(X - frontBias, Y + 1);
                frontPerception[i+4] = new Point(X - frontBias, Y + 2);
                frontBias += 1;
            }
            for (int i = 0; i < leftPerception.Length; i += 2)
            {
                leftPerception[i] = new Point(X - 1, Y - leftBias);
                leftPerception[i+1] = new Point(X, Y - leftBias);
                leftBias += 1;
            }
            for (int i = 0; i < rightPerception.Length; i += 2)
            {
                rightPerception[i] = new Point(X - 1, Y + rightBias);
                rightPerception[i + 1] = new Point(X, Y + rightBias);
                rightBias += 1;
            }
            nearPerception[0] = new Point(X, Y - 1);
            nearPerception[1] = new Point(X - 1, Y - 1);
            nearPerception[2] = new Point(X - 1, Y);
            nearPerception[3] = new Point(X - 1, Y + 1);
            nearPerception[4] = new Point(X, Y + 1);
        }
        public void UpdatePerceptionFacingSouth(Point location)
        {
            int X = location.X;
            int Y = location.Y;
            int frontBias = 2;
            int leftBias = 2;
            int rightBias = 2;
            for (int i = 0; i < frontPerception.Length; i += 5)
            {
                frontPerception[i] = new Point(X - 2, Y - frontBias);
                frontPerception[i+1] = new Point(X - 1, Y - frontBias);
                frontPerception[i+2] = new Point(X, Y - frontBias);
                frontPerception[i+3] = new Point(X + 1, Y - frontBias);
                frontPerception[i + 4] = new Point(X + 2, Y - frontBias);
                frontBias += 1;
            }
            for (int i = 0; i < leftPerception.Length; i += 2)
            {
                leftPerception[i] = new Point(X + leftBias, Y - 1);
                leftPerception[i + 1] = new Point(X + leftBias, Y);
                leftBias += 1;
            }
            for (int i = 0; i < rightPerception.Length; i += 2)
            {
                rightPerception[i] = new Point(X - rightBias, Y - 1);
                rightPerception[i + 1] = new Point(X - rightBias, Y);
                rightBias += 1;
            }
            nearPerception[0] = new Point(X - 1, Y);
            nearPerception[1] = new Point(X - 1, Y - 1);
            nearPerception[2] = new Point(X, Y - 1);
            nearPerception[3] = new Point(X + 1, Y - 1);
            nearPerception[4] = new Point(X + 1, Y);
        }
        public void UpdatePerceptionFacingNorth(Point location)
        {
            int X = location.X;
            int Y = location.Y;
            int frontBias = 2;
            int leftBias = 2;
            int rightBias = 2;
            for (int i = 0; i < frontPerception.Length; i+=5)
            {
                frontPerception[i] = new Point(X - 2, Y + frontBias);
                frontPerception[i + 1] = new Point(X - 1, Y + frontBias);
                frontPerception[i + 2] = new Point(X, Y + frontBias);
                frontPerception[i + 3] = new Point(X + 1, Y + frontBias);
                frontPerception[i + 4] = new Point(X + 2, Y + frontBias);
                frontBias += 1;
            }
            for (int i = 0; i < leftPerception.Length; i+=2)
            {
                leftPerception[i] = new Point(X - leftBias, Y + 1);
                leftPerception[i + 1] = new Point(X - leftBias, Y);
                leftBias += 1;
            }
            for (int i = 0; i < rightPerception.Length; i += 2)
            {
                rightPerception[i] = new Point(X + rightBias, Y);
                rightPerception[i + 1] = new Point(X + rightBias, Y + 1);
                rightBias += 1;
            }
            nearPerception[0] = new Point(X - 1, Y);
            nearPerception[1] = new Point(X - 1, Y + 1);
            nearPerception[2] = new Point(X, Y + 1);
            nearPerception[3] = new Point(X + 1, Y + 1);
            nearPerception[4] = new Point(X + 1, Y);
        }
    }
}
