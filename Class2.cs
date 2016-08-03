/*
 * Created by SharpDevelop.
 * User: boldizsdavid
 * Date: 2016.08.03.
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace consoleapp
{
	/// <summary>
	/// Description of Class2.
	/// </summary>
	public class Class2
	{
		public void DoConversion()
      {
         int i = 75;
         float f = 53.005f;
         double d = 2345.7652;
         bool b = true;

         Console.WriteLine(i.ToString());
         Console.WriteLine(f.ToString());
         Console.WriteLine(d.ToString());
         Console.WriteLine(b.ToString());
         Console.ReadKey();
	}
}
}