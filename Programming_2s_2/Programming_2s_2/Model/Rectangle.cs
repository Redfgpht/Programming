﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2s_2.Model
{
    internal class Rectangle
    {
        private double width;
        private double height;
        private String color;
        private Point2D center;
        private static int _allRectanglesCount = 0;
        private int _id;

        public Rectangle(double width, double height, string color, Point2D center)
        {
            setWidth(width);
            setHeight(height);
            this.color = color;
            this.center = center;
            _id = _allRectanglesCount++;
        }

        public Rectangle()
        {
        }
        public int id()
        {
            return _id;
        }
        public static int allRectanglesCount()
        {
            return _allRectanglesCount;
        }
        public Point2D getCenter()
        {
            return center;
        }

        public double getCenterX()
        {
            return center.getX();
        }

        public double getCenterY() 
        { 
            return center.getY();
        }
        public double getWidth()
        {
            return width;
        }
        public void setWidth(double width)
        {
            if (Validator.assertOnPositiveValue(width))
            {
                this.width = width;
            }
        }
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            if (Validator.assertOnPositiveValue(height))
            {
                this.height = height;
            }
        }
        public String getColor()
        {
            return color;
        }
        public void setColor(String color)
        {
            this.color = color;
        }
    }
}
