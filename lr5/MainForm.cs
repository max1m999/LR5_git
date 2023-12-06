using lr5.Creatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace lr5
{
    public enum Direction
    {
        North, South, East, West
    }
    public partial class MainForm : Form
    {
        Graphics g;
        List<Creature> creatures;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            g = worldPictureBox.CreateGraphics();
        }
        private void DrawWorld()
        {
            g.Clear(Color.DarkGray);
            foreach (Creature creature in creatures)
            {
                Point creaturePoint = creature.Location;
                g.DrawEllipse(creature.GetCreaturePen(), creaturePoint.X, creaturePoint.Y, 4, 4);
            }
        }
        private void MainSimulationCycle()
        {
            int cycleCount = 0;
            System.Windows.Forms.Timer cycleDelay = new System.Windows.Forms.Timer
            {
                Interval = 500
            };
            cycleDelay.Tick += new EventHandler((_s, _e) =>
            {
                if (creatures.Any())
                {                    
                  foreach (Creature creature in creatures)
                  {
                      creature.ScanNearbyWorld(creatures);
                  }
                    foreach (Creature creature in creatures)
                    {
                        creature.Move();
                        //creature.Act(creatures);
                    }
                    //AddPlants(creatures, 2);
                    DrawWorld();
                    cycleCount++;
                    string s = Convert.ToString(cycleCount);
                    textBox1.Text = s;
                }
                else cycleDelay.Dispose();
            });
            cycleDelay.Start();
        }
        private void AddPlants(List<Creature> creatures, int numberPlants)
        {
            Random rnd = new Random();
            for (int i = 0; i < numberPlants; i++)
            {
                int x = rnd.Next(1, Utilities.WorldSizeX);
                int y = rnd.Next(1, Utilities.WorldSizeY);
                creatures.Add(new Plant(x, y));
            }
        }
        private List<Creature> WorldInitialiser(int plants, int herbivores, int predators)
        {
            Random rnd = new Random();
            List<Creature> creatureList = new List<Creature>();
            for (int i = 0; i < plants; i++)
            {
                int x = rnd.Next(1, Utilities.WorldSizeX);
                int y = rnd.Next(1, Utilities.WorldSizeY);
                creatureList.Add(new Plant(x,y));
            }
            for (int i = 0; i < herbivores; i++)
            {
                int x = rnd.Next(1, Utilities.WorldSizeX);
                int y = rnd.Next(1, Utilities.WorldSizeY);
                creatureList.Add(new Herbivore(x,y));
            }
            for (int i = 0; i < predators; i++)
            {
                int x = rnd.Next(1, Utilities.WorldSizeX);
                int y = rnd.Next(1, Utilities.WorldSizeY);
                creatureList.Add(new Predator(x,y));
            }
            return creatureList;
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            creatures = WorldInitialiser(1, 1, 1);
            DrawWorld();
        }

        private void startSimButton_Click(object sender, EventArgs e)
        {
            MainSimulationCycle();
        }
    }
}
