/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.02.
 * Time: 10:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tutorial
{
	class Program
	{
		public static void Main(string[] args)
		{
			//practice loops
			Looper l = new Looper();
			l.MakeForLoop();
			l.MakeWhileLoop();
			l.MakeWhileLoop2(5);
			
			//conversions
			Converter c = new Converter();
			c.Convert();
			c.ConvertParams(3, 1.2f, 1234.1234);
			c.DoCasting();
			
			//practice geometry
			Geometry g= new Geometry();
			//g.CalculateArea();
			g.CalculatePerimeter(args[0]);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}