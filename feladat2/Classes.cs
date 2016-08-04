/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.12.
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat2
{
	class Classes
	{
		
	 	
		public double length;
		public double breadth;
		public double height;
		
		public Classes(double a, double b, double c) {
			Console.WriteLine("I am ttt");
			length = a;
			breadth = b;
			height = c;
		}
		
		public Classes() {
			Console.WriteLine("I am alive");
		}
	 
		 
		public void DoClasses()
		{
		 		
			Classes Box1 = new Classes(1,2,3);
			Box1.PrintBox();
			Classes Box2 = new Classes();   
			double volume = 0.0;  

           
			Box1.height = 5.0;
			Box1.length = 6.0;
			Box1.breadth = 7.0;

           
//			Box2.height = 10.0;
//			Box2.length = 12.0;
//			Box2.breadth = 13.0;
//           
            
			volume = Box1.height * Box1.length * Box1.breadth;
			Console.WriteLine("Volume of Box1 : {0}", volume);

            
//			volume = Box2.height * Box2.length * Box2.breadth;
//			Console.WriteLine("Volume of Box2 : {0}", volume);
			Console.ReadKey();
		}
		
		public void PrintBox()  {
			Console.WriteLine("Box : {0} - {1} - {2}", length, breadth, height);
		}
		
		
	}
}