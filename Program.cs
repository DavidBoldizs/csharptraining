/*
 * Created by SharpDevelop.
 * User: boldizsdavid
 * Date: 2016.08.03.
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace consoleapp
{
	class Program
	{
		public static void Main(string[] args)
		{
			 string fname, lname;
			 fname = "David";
			 lname = "Boldizs";
			 
			 string fullname = fname + lname;
			  Console.WriteLine("Full Name: {0}", fullname);
			  
			  char[] letters = { 'H', 'e', 'l', 'l','o' };
			  string greetings = new string(letters);
			  Console.WriteLine("Greetings {0}", greetings);
			         
			 DateTime localDate = DateTime.Now;
			 
			 Class1 d = new Class1();
			 d.DoWeekdays();
			 
			 Class2 c = new Class2();
			 c.DoConversion();

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}