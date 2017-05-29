using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        private void AssertEquals(Vector3D expected, Vector3D actual)
        {
            Assert.AreEqual(expected.X, actual.X, 1e-3);
            Assert.AreEqual(expected.Y, actual.Y, 1e-3);
            Assert.AreEqual(expected.Z, actual.Z, 1e-3);
        }

        [TestMethod()]
        public void Test2Dto3D()
        {
            Vector2D v = new Vector2D { X = 3, Y = -4 };
            Vector3D v3 = v;
            AssertEquals(new Vector3D(3, -4, 0), v3);
            string s = ((Vector3D)v).ToString();
            Assert.AreEqual("(3; -4; 0)", ((Vector3D) v).ToString());
        }

        [TestMethod()]
        public void Test3Dto2D()
        {
            Vector3D v3 = new Vector3D(2.5, -5.5, 7);
            Vector2D v = (Vector2D) v3;
            AssertEquals(new Vector2D(2.5, -5.5), v);
        }

        [TestMethod()]
        public void TestUnit()
        {
            Vector2D v1 = new Vector2D(2, -3.1).Unit;
            AssertEquals(new Vector2D(0.542, -0.840), v1);
            Assert.AreEqual(1, v1.Module);

            Vector3D v2 = new Vector3D(2, -3.1, 3).Unit;
            AssertEquals(new Vector3D(0.420, -0.652, 0.630), v2);
            Assert.AreEqual(1, v2.Module);
        }

        [TestMethod()]
        public void TestMulDiv()
        {
            Vector2D v2 = new Vector2D(2, 3);
            v2 *= 10;
            AssertEquals(new Vector2D(20, 30), v2);
            v2 /= 2;
            AssertEquals(new Vector2D(10, 15), v2);

            Vector3D v3 = new Vector3D(2, 3, 5);
            v3 *= 10;
            AssertEquals(new Vector3D(20, 30, 50), v3);
            v3 /= 2;
            AssertEquals(new Vector3D(10, 15, 25), v3);
        }

        [TestMethod()]
        public void TestMinus()
        {
            AssertEquals(-new Vector2D(2, -3), new Vector2D(-2, 3));
            AssertEquals(-new Vector3D(1, -2, -4.4), new Vector3D(-1, 2, 4.4));
        }

        [TestMethod()]
        public void TestPolarCoords()
        {
            Vector2D v = Vector2D.FromPolarCoords(-10, -78.96 * Math.PI / 180);
            AssertEquals(new Vector2D(-1.914, 9.814), v);
            Assert.AreEqual(10, v.Module, 1e-3);
            Assert.AreEqual(101.035 * Math.PI / 180, v.Angle, 1e-3);
        }

        [TestMethod()]
        public void TestSphericalCoords()
        {
            Vector3D v = Vector3D.FromSphericalCoords(-21.1, -50 * Math.PI / 180, -75 * Math.PI / 180);
            AssertEquals(new Vector3D(13.100, -15.612, -5.461), v);
            Assert.AreEqual(21.1, v.Module, 1e-3);
            Assert.AreEqual(-50 * Math.PI / 180, v.Theta, 1e-3);
            Assert.AreEqual(105 * Math.PI / 180, v.Phi, 1e-3);
        }

        [TestMethod()]
        public void TestSetAngles()
        {
            Vector2D v = new Vector2D(1, 1);
            v.Angle = 35 * Math.PI / 180;
            v.Module = 27.89;
            AssertEquals(Vector2D.FromPolarCoords(27.89, 35 * Math.PI / 180), v);

            Vector3D v3 = new Vector3D(1, 1, 1);
            v3.Module = 78.9;
            v3.Theta = 40 * Math.PI / 180;
            v3.Phi = 77 * Math.PI / 180;
            AssertEquals(Vector3D.FromSphericalCoords(78.9, 40 * Math.PI / 180, 77 * Math.PI / 180), v3);
        }

        [TestMethod()]
        public void TestOperations()
        {
            Vector2D v1 = new Vector2D(2, -5);
            Vector2D v2 = new Vector2D(-1.1, 7);
            Vector3D v3 = new Vector3D(12, -6.6, 3);
            Vector3D v4 = new Vector3D(-1, 3, 5);

            AssertEquals(new Vector2D(0.9, 2), v1 + v2);
            AssertEquals(new Vector2D(3.1, -12), v1 - v2);
            Assert.AreEqual(-37.2, v1 * v2, 1e-3);

            AssertEquals(new Vector3D(11, -3.6, 8), v3 + v4);
            AssertEquals(new Vector3D(13, -9.6, -2), v3 - v4);
            Assert.AreEqual(-16.8, v3 * v4, 1e-3);

            AssertEquals(new Vector3D(0, 0, 8.5), v1 & v2);
            AssertEquals(new Vector3D(-25, -10, 1), v1 & v4);
            AssertEquals(new Vector3D(15, 6, -46.8), v3 & v1);
            AssertEquals(new Vector3D(-42, -63, 29.4), v3 & v4);
        }
    }
}