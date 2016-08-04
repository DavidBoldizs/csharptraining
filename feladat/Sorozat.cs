/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.05.
 * Time: 11:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat
{
	public class Sorozat
	{
		public Sorozat()
		{
		}
		public void MakeForLoop()
		{
			int total = 0;
			for (int i = 0; i <= 15; i++) { 
				total += i;
				Console.WriteLine(" " + i);
			}
			Console.WriteLine("összeg: " + total);
				
			
			
		}
		
		public void MakeWhileLoop()
		{
			int i = 0;
			int total = 0;
			while (i <= 30) {
				Console.WriteLine(" " + i);
				i += 2;
				total += i;
			}
			Console.WriteLine("páros összeg: " + total);
		}

	}
}
	
	
