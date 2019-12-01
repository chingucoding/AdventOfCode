﻿namespace AdventOfCode2018.Model
{

    public class Rectangle
    {
        public int x, y, width, height;
        public string rootData;
        public Rectangle(int x, int y, int width, int height, string rootData)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.rootData = rootData;
        }
    }

}
