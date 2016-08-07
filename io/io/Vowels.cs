/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.08.06.
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace io
{
	public class Vowels
	{
		//                0    1    2    3    4
		char[] vowels = { 'a', 'e', 'o', 'i', 'u' };
		int numA, numE, numO, numI, numU;
		
		public void FindVowels(string a)
		{
			char[] g = a.ToCharArray();
			for (int i = 0; i < g.Length; i++) {
				switch (g[i]) {
					case 'a':
						numA++;
						break;
						
					case 'e':
						numE++;
						break;
					case 'o':
						numO++;
						break;
					case 'i':
						numI++;
						break;
					case 'u':
						numU++;
						break;							
				}
			}
			Console.WriteLine("amount of a: " + numA);
			Console.WriteLine("amount of e: " + numE);
			Console.WriteLine("amount of o: " + numO);
			Console.WriteLine("amount of i: " + numI);
			Console.WriteLine("amount of u: " + numU);
		}
	}
		
}
		
		

