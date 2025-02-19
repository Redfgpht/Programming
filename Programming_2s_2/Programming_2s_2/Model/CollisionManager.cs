using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2s_2.Model
{
    internal class CollisionManager
    {
        public CollisionManager() { }
        public static bool IsCollisionRectangle(Rectangle rectangle1,Rectangle rectangle2)
        {
            if ( Math.Abs((rectangle1.getWidth() - rectangle2.getWidth())/2) < Math.Abs(Convert.ToDouble(rectangle1.getCenter()) - Convert.ToDouble(rectangle2.getCenter()) ))
            {

                if ((Math.Abs((rectangle1.getWidth() - rectangle2.getWidth()) / 2) < Math.Abs(Convert.ToDouble(rectangle1.getCenter()) - Convert.ToDouble(rectangle2.getCenter()))))
                    return true;

            }
            return false;

        }

        public static bool IsCollisionRing(Rectangle rectangle1, Rectangle rectangle2)
        {
            if (Math.Abs((rectangle1.getWidth() - rectangle2.getWidth()) / 2) < Math.Abs(Convert.ToDouble(rectangle1.getCenter()) - Convert.ToDouble(rectangle2.getCenter())))
            {

                if ((Math.Abs((rectangle1.getWidth() - rectangle2.getWidth()) / 2) < Math.Abs(Convert.ToDouble(rectangle1.getCenter()) - Convert.ToDouble(rectangle2.getCenter()))))
                    return true;

            }
            return false;

        }

    }
}
