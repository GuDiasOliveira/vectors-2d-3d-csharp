using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class Vector2D
    {
        public double X { set; get; } = 0.0;
        public double Y { set; get; } = 0.0;

        public Vector2D()
        {
        }

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector2D FromPolarCoords(double module, double angle)
        {
            return new Vector2D
            {
                X = module * Math.Cos(angle),
                Y = module * Math.Sin(angle)
            };
        }

        public static explicit operator Vector2D(Vector3D v)
        {
            return new Vector2D { X = v.X, Y = v.Y };
        }

        public double Module
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
            set
            {
                double multip = value / Module;
                X *= multip;
                Y *= multip;
            }
        }

        public double Angle
        {
            get
            {
                return Math.Atan2(Y, X);
            }
            set
            {
                double module = Module;
                X = module * Math.Cos(value);
                Y = module * Math.Sin(value);
            }
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D{ X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }

        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D { X = v1.X - v2.X, Y = v1.Y - v2.Y };
        }

        public static Vector2D operator *(Vector2D v, double val)
        {
            return new Vector2D { X = v.X * val, Y = v.Y * val };
        }

        public static Vector2D operator /(Vector2D v, double val)
        {
            return new Vector2D { X = v.X / val, Y = v.Y / val };
        }

        public static Vector2D operator -(Vector2D v)
        {
            return new Vector2D { X = -v.X, Y = -v.Y };
        }

        /// <summary>
        /// This does the <b>dot product</b>
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static double operator *(Vector2D v1, Vector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        /// <summary>
        /// This does <b>cross product</b>
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector3D operator &(Vector2D v1, Vector3D v2)
        {
            return new Vector3D
            {
                X = v1.Y * v2.Z,
                Y = -v1.X * v2.Z,
                Z = v1.X * v2.Y - v2.X * v1.Y
            };
        }

        public Vector2D Unit
        {
            get
            {
                return this / Module;
            }
        }

        public override string ToString()
        {
            return "(" + X + "; " + Y + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector2D)
            {
                Vector2D v = obj as Vector2D;
                if (X != v.X)
                    return false;
                if (Y != v.Y)
                    return false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
