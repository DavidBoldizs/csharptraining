/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.06.
 * Time: 15:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace operators
{
	class Program
	{
		public static void Main(string[] args)
		{
			
		    Console.Write("operators ");
			Operators o = new Operators();
			o.CalculateAmount();
			o.CalculateDifference();
			o.CalculateDiv();
			o.CalculateMod();
			o.CalculateMult();
			Operators2 o2 = new Operators2();
			o2.DoRelational();
			Operators3 o3 = new Operators3();
			o3.DoLogical();
			Operators4 o4 = new Operators4();
			o4.DoBitwise();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}