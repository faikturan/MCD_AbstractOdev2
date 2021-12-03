﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractOdev2
{
    public class Circle : Shape
    {

        private float _radius;

        public float Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle(float radius)
        {
            _radius = radius;
        }

        public override void CalculateArea()
        {
            this.Area = (float)(Math.PI * Math.Pow(_radius, 2));
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = (float)(2 * Math.PI * _radius);
        }
    }
}
