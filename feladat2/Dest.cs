/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.12.
 * Time: 16:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat2
{
	class Dest
	{
		
		private double length;
		 
		public Dest()
		{
			Console.WriteLine("Object is being created");
		}
		~Dest()
		{
			Console.WriteLine("Object is being destructed");
		}

		public void setLength(double len)
		{
			length = len;
		}
      
		public double getLength()
		{
			return length;
		}

		public void MakeLine2()
		{
			Dest line = new Dest();
			line.setLength(6.0);
			Console.WriteLine("Length of line : {0}", line.getLength());
			Console.ReadKey();      
		
		}
	}
}