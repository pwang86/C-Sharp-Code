﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class PointComparision
	{
		class Point
		{
			protected int x, y;

			public Point() : this(0, 0) { }

			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
			}

			public override bool Equals(object obj)
			{
				if ((obj == null) || !this.GetType().Equals(obj.GetType()))
				{
					return false;
				}
				else {
					Point p = (Point)obj;
					return (x == p.x) && (y == p.y);
				}
			}

			public override int GetHashCode()
			{
				return (x << 2) ^ y;
			}

			public override string ToString()
			{
				return String.Format("Point({0},{1})", x, y);
			}
		}

		sealed class Point3D : Point
		{
			int z;

			public Point3D(int x, int y, int z) : base(x, y)
			{
				this.z = z;
			}

			public override bool Equals(object obj)
			{
				Point3D pt3 = obj as Point3D;
				if (pt3 == null)
					return false;
				else
					return base.Equals((Point)obj) && z== pt3.z;
			}

			public override int GetHashCode()
			{
				return (base.GetHashCode() << 2) ^ z;	
			}

			public override string ToString()
			{
				return String.Format("Point({0,{1},{2}})",x,y,z);
			}
		}

		class Example
		{
			public static void Main()
			{
				Point point2D = new Point(5, 5);
				Point3D point3Da = new Point3D(5, 5, 2);
				Point3D point3Db = new Point3D(5, 5, 2);
				Point3D point3Dc = new Point3D(5, 5, -1);

				Console.WriteLine("{0} = {1}: {2}",
								  point2D, point3Da, point2D.Equals(point3Da));
				Console.WriteLine("{0} = {1}: {2}",
								  point2D, point3Db, point2D.Equals(point3Db));
				Console.WriteLine("{0} = {1}: {2}",
								  point3Da, point3Db, point3Da.Equals(point3Db));
				Console.WriteLine("{0} = {1}: {2}",
								  point3Da, point3Dc, point3Da.Equals(point3Dc));
			}
		}
	
	}
}
