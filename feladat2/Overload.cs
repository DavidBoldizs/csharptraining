/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.13.
 * Time: 15:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat2
{
	public class Overload
	{
		private double length;
		private double breadth;
		private double height;

		public double getVolume()
		{
			return length * breadth * height;
		}
      
		public void setLength(double len)
		{
			length = len;
		}

		public void setBreadth(double bre)
		{
			breadth = bre;
		}

		public void setHeight(double hei)
		{
			height = hei;
		}
      
      
		public static Overload operator+(Overload b, Overload c)
		{
			Overload box = new Overload();
			box.length = b.length + c.length;
			box.breadth = b.breadth + c.breadth;
			box.height = b.height + c.height;
			return box;
		}

   

   
		public void DoOverload()
		{
			Overload Box1 = new Overload();   
			Overload Box2 = new Overload();   
			Overload Box3 = new Overload();   
			double volume = 0.0;    

         
			Box1.setLength(6.0);
			Box1.setBreadth(7.0);
			Box1.setHeight(5.0);

        
			Box2.setLength(12.0);
			Box2.setBreadth(13.0);
			Box2.setHeight(10.0);

        
			volume = Box1.getVolume();
			Console.WriteLine("Volume of Box1 : {0}", volume);

         
			volume = Box2.getVolume();
			Console.WriteLine("Volume of Box2 : {0}", volume);

         
			Box3 = Box1 + Box2;

        
			volume = Box3.getVolume();
			Console.WriteLine("Volume of Box3 : {0}", volume);
			Console.ReadKey();
		}
	}
}