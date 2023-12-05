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
using System.Windows.Forms;

namespace lr5
{
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
            creatures = WorldInitialiser(100, 20, 5);
        }
        private void DrawWorld()
        {
            g.Clear(Color.Black);
            foreach (Creature creature in creatures)
            {
                Point creaturePoint = creature.Location;
                g.DrawEllipse(creature.GetCreaturePen(), creaturePoint.X, creaturePoint.Y, 3, 3);
            }
        }
        private void MainSimulationCycle()
        {
            while (creatures.Any())
            {
                foreach (Creature creature in creatures)
                {
                    creature.ScanNearbyWorld(creatures);
                }
                for (int i = creatures.Count - 1; i >=0; i--)
                {
                    creatures[i].Act(creatures);
                    creatures[i].Damage(creatures);
                }
                DrawWorld();
                AddPlants(creatures, 2);
                Thread.Sleep(1000);
            }
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
            g.Clear(Color.Black);
            DrawWorld();
        }

        private void startSimButton_Click(object sender, EventArgs e)
        {
            MainSimulationCycle();
        }
    }
}
