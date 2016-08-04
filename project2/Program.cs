/*
 * Created by SharpDevelop.
 * User: boldizsdavid
 * Date: 2016.08.04.
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace project2
{
	class Program
	{
		public static void Main(string[] args)
		{
			shapes s = new shapes();
			s.DoShaping();

			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}