using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2s_2.Model
{
    /// <summary>
    /// Проверяет объекты на пересечения.
    /// </summary>
    internal class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если прямоугольники пересекаются.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            //Разница координат по модулю
            double deltaX = Math.Abs(rectangle1.getCenterX() - rectangle2.getCenterX());
            double deltaY = Math.Abs(rectangle1.getCenterY() - rectangle2.getCenterY());

            //Сумма половин ширин и высот
            double sumHalfWidths = (rectangle1.getWidth() + rectangle2.getWidth()) / 2;
            double sumHalfHeights = (rectangle1.getHeight() + rectangle2.getHeight()) / 2;

            return deltaX < sumHalfWidths && deltaY < sumHalfHeights;

        }

        /// <summary>
        /// Проверяет, пересекаются ли кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если кольца пересекаются.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            //Расстояние между центрами колец
            double deltaX = ring1.getCenterX() - ring2.getCenterX();
            double deltaY = ring1.getCenterY() - ring2.getCenterY();
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            //Сумма внешних радиусов
            double sumOuterRadius = ring1.getradius_external() + ring2.getradius_external();

            //Разница внешних радиусов вложенности
            double diffOuterRadius = Math.Abs(ring1.getradius_external() - ring2.getradius_external());

            if (distance < sumOuterRadius)
            {
                if (distance > diffOuterRadius)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
