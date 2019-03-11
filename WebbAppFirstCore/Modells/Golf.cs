using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppFirstCore.Modells
{
    /*Algorithms
     * Angle Radians :(Math.PI/180)*angle
     Distance: mmath.Pow(velocity,2)/GRAVITY*Math.sin(2*angleRadians)
     Gravity is Equal to 9.8
     Ex: at 45 and 56 m/s the ball 320m*/
    public class Golf
    {
        static readonly double GRAVITY = 9.8;

        private static double AngleInRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
        public static double Distance(Double Velocity, Double angle)
        {
            return Math.Pow(Velocity, 2) / GRAVITY * Math.Sin(2 * AngleInRadians(angle));
        }
    }
}
