/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.06.
 * Time: 10:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace operators
{
	
	public class Operators
	{
		int num1, num2;
		int add, sub, mul, div, mod;
		
		public Operators()
		{
			//aritmetic operators
			
			Console.WriteLine("Operators is created");
			Console.Write("Enter the first number:\n");
			num1 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter the second number:\n");
			num2 = Convert.ToInt32(Console.ReadLine());
		}
			
		public void CalculateAmount()
		{
			add = num1 + num2;
			Console.WriteLine("Összeadás {0}", add);
		}
			
		public void CalculateDifference()
		{
			sub = num1 - num2;
			Console.WriteLine("Kivonás {0}", sub);
		}
			
		public void CalculateMult()
		{
			mul = num1 * num2;
			Console.WriteLine("Szorzás {0}", mul);
		}
			
		public void CalculateDiv()
		{
			div = num1 / num2;
			Console.WriteLine("Osztás {0}", div);
		}
			
		public void CalculateMod()
		{
			mod = num1 % num2;
			Console.WriteLine("Maradékos Osztás {0}", mod);
		}

	}

}