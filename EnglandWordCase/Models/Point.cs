﻿namespace EnglandWordCase.Models
{
    internal struct Point
    {
        private int x;
        private int y;

        public Point(int x,int y) : this()
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
     
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }


    }
}
