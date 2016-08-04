/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.13.
 * Time: 13:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat2
{
	public class Poly
	{
		void print(int i)
		{
			Console.WriteLine("Printing int: {0}", i);
		}

		void print(double f)
		{
			Console.WriteLine("Printing double: {0}", f);
		}

		void print(string s)
		{
			Console.WriteLine("Printing string: {0}", s);
		}
		void print(bool b)
		{
			Console.WriteLine("Printing bool: {0}", b);
		}
		public void DoPrinting()
		{
			Poly p = new Poly();
         
			// Call print to print integer
			p.print(5);
         
			// Call print to print float
			p.print(500.263);
         
			// Call print to print string
			p.print("Hello David");
			p.print('a');
			p.print("a");
			p.print(false);
			Console.ReadKey();
		}
	}
}