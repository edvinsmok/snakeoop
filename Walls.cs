using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine top = new HorizontalLine(0, 80, 0, '-');

            VerticalLine left = new VerticalLine(0, 25, 0, '|');

            HorizontalLine bot = new HorizontalLine(0, 80, 26, '-');

            VerticalLine right = new VerticalLine(0, 25, 80, '|');

            VerticalLine obstacle = new VerticalLine(10, 20, 55, '@');
            Console.ForegroundColor = ConsoleColor.Magenta;
            HorizontalLine obstacle2 = new HorizontalLine(5, 24, 20, '!');

            wallList.Add(top);
            wallList.Add(left);
            wallList.Add(bot);
            wallList.Add(right);
            wallList.Add(obstacle);
            wallList.Add(obstacle2);
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}