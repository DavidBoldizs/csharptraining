/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.05.
 * Time: 13:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat
{
	/// <summary>
	/// Description of Class2.
	/// </summary>
	public class Triangle
	{
		//sides
		double a;
		double b;
				
		public void CalculateTriangle()
		{
			 
			Console.WriteLine("Enter a."); 
			a = Convert.ToDouble(Console.ReadLine()); 
			Console.WriteLine("Enter b."); 
			b = Convert.ToDouble(Console.ReadLine()); 
			double sq = a * a + b * b; 
			double c = Math.Sqrt(sq);
			Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
			Console.WriteLine("perimeter = {0}", CalculatePerimeter(a,b,c));
			Console.WriteLine("area = {0}", CalculateArea(a,b));
			Console.ReadLine();
			

		}
		
		private double CalculatePerimeter(double a, double b, double c)
		{
			return (a + b + c);
			
		}
		
		private double CalculateArea(double a, double b)
		{
			return ((a * b) / 2);
		}

	}
}