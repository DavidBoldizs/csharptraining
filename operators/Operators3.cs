/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.09.
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace operators
{
	
	public class Operators3
	{
		bool a = true;
		bool b = true;
		bool c = false;
		bool d = false;
		public Operators3()
		{
		}
		public void DoLogical()
		{
			Console.WriteLine("a and b " + (a & b));
			Console.WriteLine("c and d " + (c | d));
			Console.WriteLine("a and d " + (a & d));
			Console.WriteLine("a and b " + (!(a & b)));
		}
	}
}