/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.12.
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat2
{
	class Const
	{
		private double length;
		public double width;
		public Const()
		{
			Console.WriteLine("Object is being created");
		}
		public void setLength(double len)
		{
			length = len;
		}
		 
		public double getLength()
		{
			return length;
		}
		public void MakeLine()
		{
			Const line = new Const();
			line.setLength(6.0);
			Console.WriteLine("Length of line : {0}", line.getLength());
			Console.ReadKey();
		}
	}
}
