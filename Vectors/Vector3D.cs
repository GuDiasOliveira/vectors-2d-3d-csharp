using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class Vector3D
    {
        public double X { get; set; } = 0.0;
        public double Y { get; set; } = 0.0;
        public double Z { get; set; } = 0.0;

        public Vector3D()
        {
        }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector3D FromSphericalCoords(double module, double theta, double phi)
        {
            return new Vector3D
            {
                X = module * Math.Cos(theta) * Math.Sin(phi),
                Y = module * Math.Sin(theta) * Math.Sin(phi),
                Z = module * Math.Cos(phi)
            };
        }

        public static implicit operator Vector3D(Vector2D v)
        {
            return new Vector3D { X = v.X, Y = v.Y, Z = 0 };
        }

        public double Module
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
            set
            {
                double multip = value / Module;
                X *= multip;
                Y *= multip;
                Z *= multip;
            }
        }

        public double Theta
        {
            get
            {
                return Math.Atan2(Y, X);
            }
            set
            {
                double module = Module;
                double phi = Phi;
                X = module * Math.Sin(phi) * Math.Cos(value);
                Y = module * Math.Sin(phi) * Math.Sin(value);
            }
        }

        public double Phi
        {
            get
            {
                return Math.Acos(Z / Module);
            }
            set
            {
                double module = Module;
                double theta = Theta;
                X = module * Math.Sin(value) * Math.Cos(theta);
                Y = module * Math.Sin(value) * Math.Sin(theta);
                Z = module * Math.Cos(value);
            }
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y,
                Z = v1.Z + v2.Z
            };
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D
            {
                X = v1.X - v2.X,
                Y = v1.Y - v2.Y,
                Z = v1.Z - v2.Z
            };
        }

        public static Vector3D operator *(Vector3D v, double val)
        {
            return new Vector3D
            {
                X = v.X * val,
                Y = v.Y * val,
                Z = v.Z * val
            };
        }

        public static Vector3D operator /(Vector3D v, double val)
        {
            return new Vector3D
            {
                X = v.X / val,
                Y = v.Y / val,
                Z = v.Z / val
            };
        }

        public static Vector3D operator -(Vector3D v)
        {
            return new Vector3D { X = -v.X, Y = -v.Y, Z = -v.Z };
        }

        /// <summary>
        /// This does the <b>dot product</b>
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static double operator *(Vector3D v1, Vector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        /// <summary>
        /// This does <b>cross product</b>
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector3D operator &(Vector3D v1, Vector3D v2)
        {
            return new Vector3D
            {
                X = v1.Y * v2.Z - v2.Y * v1.Z,
                Y = v2.X * v1.Z - v1.X * v2.Z,
                Z = v1.X * v2.Y - v2.X * v1.Y
            };
        }

        public Vector3D Unit
        {
            get
            {
                return this / Module;
            }
        }

        public override string ToString()
        {
            return "(" + X + "; " + Y + "; " + Z + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector3D)
            {
                Vector3D v = obj as Vector3D;
                if (X != v.X)
                    return false;
                if (Y != v.Y)
                    return false;
                if (Z != v.Z)
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
