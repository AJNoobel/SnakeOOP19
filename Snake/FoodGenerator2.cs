using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class FoodGenerator2
    {
        int mapWidth;
        int mapHeight;
        char symb;

        Random rnd = new Random();

        public FoodGenerator2(int _mapWidth, int _mapHeight, char _symb)
        {
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            symb = _symb;

        }

        public Point GenerateFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new Point(x, y, symb);
        }
    }
}
