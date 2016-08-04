/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.02.
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tutorial
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Converter
	{
		
		
		public void Convert()
		{
			int i = 75;
			float f = 53.005f;
			double d = 2345.7652;
			bool b = true;

			Console.WriteLine(i.ToString());
			Console.WriteLine(f.ToString());
			Console.WriteLine(d.ToString());
			Console.WriteLine(b.ToString());
		}
		
		public void ConvertParams(int i, float f, double d)
		{
			Console.WriteLine(i.ToString());
			Console.WriteLine(f.ToString());
			Console.WriteLine(d.ToString());
		}
		
		public void DoCasting()
		{
			double d = 5673.74; 
			int i;
         
			// cast double to int.
			i = (int)d;
			Console.WriteLine(i);
			Console.ReadKey();
		}
	}
}
