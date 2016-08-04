/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.05.
 * Time: 11:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("sorozat ");
			Sorozat s = new Sorozat();
			s.MakeForLoop();
			s.MakeWhileLoop();
			
			Console.Write("háromszög ");
			Triangle t = new Triangle();
			t.CalculateTriangle();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}