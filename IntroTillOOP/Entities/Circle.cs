using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace IntroTillOOP.Entities
{
    internal class Circle
    {
        public Circle()
        {
            float pi = 3.14f;
            int Radius = 5;


        }
        
        public float Area(float Radius)
        {
            float pi = 3.14f;
            return pi * Radius * Radius;
        }

    }
}
