/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.02.
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tutorial
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Geometry
	{
		// constant declaration
		const double pi = 3.14159;
		
		public Geometry()
		{
			Console.WriteLine("I am alive");
		}
		
		public void CalculateArea()
		{
			double r;
			Console.WriteLine("Enter Radius: ");
			r = Convert.ToDouble(Console.ReadLine());
			double areaCircle = pi * r * r;
			Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
			Console.ReadLine();
		}
		
		public void CalculatePerimeter(string value)
		{
			double rad = Convert.ToDouble(value);
			double perimeter = pi * rad * 2;
			Console.WriteLine("Radius: {0}, Perimeter: {1}", rad, perimeter);
			Console.ReadLine();
		}
	}
}
