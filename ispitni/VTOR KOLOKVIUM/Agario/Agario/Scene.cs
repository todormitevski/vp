using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Agario
{
    [Serializable]
    public class Scene
    {
        public List<Enemy> Enemies { get; set; }
        public Player Player { get; set; }
        public Random rand { get; set; }
        public int Width;
        public int Height;

        public Scene(int width, int height)
        {
            Width = width;
            Height = height;
            Enemies = new List<Enemy>();
            Player = new Player();
            rand = new Random();
            Enemies.Add(new Enemy(new Point(rand.Next(50, Width - 50), rand.Next(50, Height - 50)), rand.Next(1,5)));
            Enemies.Add(new Enemy(new Point(rand.Next(50, Width - 50), rand.Next(50, Height - 50)), rand.Next(1,5)));
            Enemies.Add(new Enemy(new Point(rand.Next(50, Width - 50), rand.Next(50, Height - 50)), rand.Next(1,5)));
        }

        public void AddEnemy(Enemy enemy)
        {
            Enemies.Add(enemy);
        }

        public void Draw(Graphics g)
        {
            foreach (Enemy enemy in Enemies)
            {
                enemy.Draw(g);
            }
            if (Player.Alive)
            {
                Player.Draw(g);
            }
        }

        public void MoveEnemies()
        {
            foreach (Enemy enemy in Enemies)
            {
                if(enemy.Point.X > Width - 50 || enemy.Point.X < 15)
                {
                    enemy.Bounce();
                }

                if(enemy.Point.Y > Height - 50 || enemy.Point.Y < 15)
                {
                    enemy.Bounce();
                }

                enemy.Move();
            }
            
        }

        public void checkForDeletion(Player player)
        {
            for(int i = Enemies.Count - 1; i >= 0; i--)
            {
                if (player.CheckCollision(Enemies[i].Point))
                {
                    Enemies.RemoveAt(i);
                    player.PopBall();
                }
            }
        }
    }
}
