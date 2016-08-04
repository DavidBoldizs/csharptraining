/*
 * Created by SharpDevelop.
 * User: boldizsdavid
 * Date: 2016.08.03.
 * Time: 13:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace consoleapp
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Class1
	{
	//ez itt apa kommentje	
		enum Days
		{
			Sun,
			Mon,
			tue,
			Wed,
			thu,
			Fri,
			Sat}

		;

		public void DoWeekdays()
		{
			int WeekdayStart = (int)Days.Mon;
			int WeekdayEnd = (int)Days.Fri;
			Console.WriteLine("Monday: {0}", WeekdayStart);
			Console.WriteLine("Friday: {0}", WeekdayEnd);
			Console.ReadKey();
		}
	}
}
