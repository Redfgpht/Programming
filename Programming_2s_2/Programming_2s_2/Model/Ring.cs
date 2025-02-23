using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2s_2.Model
{
    internal class Ring
    {
        private Point2D center;
        private double radius_external;
        private double radius_internal;
        private double area;

        public double getCenterX()
        {
            return center.getX();
        }

        public double getCenterY()
        {
            return center.getY();
        }

        public double getradius_external()
        {
            return radius_external;
        }

        public double getradius_internal()
        {
            return radius_internal;
        }

        public Ring(Point2D center, double radius_external, double radius_internal, double area)
        {
            this.center = center;
            setRadius_external(radius_external);
            setRadius_internal(radius_internal);
            findArea(radius_internal, radius_external);
        }

        public Ring() { }

        public void setRadius_external(double radius_external)
        {
            if (Validator.assertOnPositiveValue(radius_external) && radius_external>radius_internal)
                this.radius_external = radius_external;
            else
            {
                throw new ArgumentException("Неверный радиус");
            }
        }

        public void setRadius_internal(double radius_internal)
        {
            if (Validator.assertOnPositiveValue(radius_internal) && radius_external > radius_internal)
                this.radius_internal = radius_internal;
            else
            {
                throw new ArgumentException("Неверный радиус");
            }
        }

        public void findArea(double radius_internal, double radius_external)
        {
            this.area = 3.14 * ((radius_external)* (radius_external) - (radius_internal)*(radius_internal));
        }

    }
}
