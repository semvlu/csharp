﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Ball:Shape3D, IRollable
    {
        private new static int amount;
        private double radius;
        public Ball() : base() { geo = ShapeType.Geo.BALL;radius = 0; amount++; }
        public Ball(double radius, ShapeType.Material m):base(m)
        {
            geo= ShapeType.Geo.BALL;
            this.radius = radius;
            amount++;
        }
        public new static int Amount {  get { return amount; } }
        public double Radius { get { return radius; } set { if (value < 0) value = 0; else radius = value; } }
        public override double Volume() { return 4.0 / 3 * Math.PI * Math.Pow(radius, 3); }
        public override string ShapeProperty()
        {
            string s = string.Format("{0,8}", "Ball");
            s += '\t';
            s += string.Format("{0,8:F2}", radius);
            s += '\t';
            s += string.Format("{0,8}", "");
            s += '\t';
            s += Property();
            return s;
        }
        public double Distance() { return radius * radius; }
        public string RollShapeProperty()
        {
            return ShapeProperty() + string.Format("{0,8:F2}", Distance());
        }
    }
}