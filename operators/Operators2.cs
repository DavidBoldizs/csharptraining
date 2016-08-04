/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.06.
 * Time: 16:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace operators
{
	
	public class Operators2
	{
		int n1, n2;
		public Operators2()
		{
			Console.WriteLine("Operators2 is created");
			Console.WriteLine("Enter the first number");
			n1 = Convert.ToInt32(Console.ReadLine());
	
			Console.WriteLine("Enter the second number");
			n2 = Convert.ToInt32(Console.ReadLine());
		}
		
		
		public void DoRelational()
		{
			if (n1 == n2) {
				Console.WriteLine("num1 is equal to num2");
			} else {
				Console.WriteLine("num1 is not equal to num2");
			}
      
			if (n1 < n2) {
				Console.WriteLine("num1 is less than num2");
			} else {
				Console.WriteLine("num1 is not less than num2");
			}
      
			if (n1 > n2) {
				Console.WriteLine("num1 is greater than num2");
			} else {
				Console.WriteLine("num1 is not greater than num2");
			}
			if (n1 <= n2) { 
				Console.WriteLine("num1 is either less than or equal to  num2");
			}
      
			if (n1 >= n2) {
				Console.WriteLine("num1 is either greater than or equal to num2");
			}
		}
			
	}
	     
}