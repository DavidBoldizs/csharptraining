/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.12.
 * Time: 18:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat2
{
	public class Inherit
	{
		
		public void setWidth(int w)
		{
			width = w;
		}
		public void setHeight(int h)
		{
			height = h;
		}
		protected int width;
		protected int height;
   

   
   
		public int getArea()
		{ 
			return (width * height); 
		}
   
   
		public void MakeRectangle()
		{
			Inherit Rect = new Inherit();

			Rect.setWidth(5);
			Rect.setHeight(7);

			Console.WriteLine("Total area: {0}", Rect.getArea());
			Console.ReadKey();
		}
	}
}
