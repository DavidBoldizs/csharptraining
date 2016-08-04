/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.11.
 * Time: 13:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace array
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("array ");
			arrays a = new arrays();
			a.DoArray();
			
			StringTest s = new StringTest();
			s.createstringarray();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}