/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.15.
 * Time: 16:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace solution2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Define d = new Define();
			d.DoDefine();
			
			MyException e = new MyException();
			e.DoException();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}