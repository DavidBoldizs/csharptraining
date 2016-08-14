/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.08.14.
 * Time: 13:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace masodik
{
	/// <summary>
	/// A forduló összpontszáma alapján eldönti a végeredményt.
	/// </summary>
	public class foci
	{
		
		public void GetResult()
		{
			Console.WriteLine("Add meg a forduló összpontszámát");
			int w =Convert.ToInt32(Console.ReadLine());
			
		
		switch (w)
		{
			case 0:
				Console.WriteLine("Vereség");
				break;
			case 1:
				Console.WriteLine("Döntetlen");
				break;
			case 3:
				Console.WriteLine("Győzelem!");
				break;
			default:
				Console.WriteLine("Hibás adat");
				break;
		}
	}
}
}
