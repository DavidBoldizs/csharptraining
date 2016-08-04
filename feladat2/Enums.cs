/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.12.
 * Time: 15:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat2
{
	public class Enums
	{
		enum Days
		{
			Mon,
			Tue,
			Wed,
			Thu,
			Fri,
			Sat,
			Sun}

		;
	
		public Enums()
		{
		}
		public void DoEnums()
		{
			int WeekStart = (int)Days.Mon;
			int WeekEnd = (int)Days.Sun;
			Console.WriteLine("Monday: {0}", WeekStart);
			Console.WriteLine("Sunday: {0}", WeekEnd);
			
			Console.ReadKey();
		}
	}
}
 
