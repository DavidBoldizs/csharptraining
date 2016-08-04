/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.06.30.
 * Time: 10:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace start
{
	
	
	class Rectangle
	{
		// member variables
		double length;
		double width;
		public void Acceptdetails(double l, double h)
		{
			length = l;    
			width = h;
		}
      
		public double GetArea()
		{
			return length * width; 
		}
      
		public void Display()
		{
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
		
		
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello " + args[0] + " and " + args[1]);
			for (int i = 0; i < 10; i++) {
				Console.WriteLine("Hello " + i);
			}
			
			Rectangle r = new Rectangle();
			double length = Double.Parse(args[2]);
			double width = Double.Parse(args[3]);
			r.Acceptdetails(length, width);
			r.Display();
			
			Console.WriteLine("Size of int: {0}", sizeof(int));
			Console.WriteLine("Size of double: {0}", sizeof(double));
			Console.WriteLine("Size of char: {0}", sizeof(char));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}