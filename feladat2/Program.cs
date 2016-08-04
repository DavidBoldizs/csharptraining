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
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("enums ");
			Enums e = new Enums();
			e.DoEnums();
			
			Console.Write("Classes: ");
			Classes b = new Classes();
			b.DoClasses();
			
			Console.Write("Constructors:");
			Const c = new Const();
			Console.WriteLine("length before: {0}" , c.getLength());
			c.setLength(99);
			Console.WriteLine("length after: {0}" , c.getLength());
			c.MakeLine();
			
			
			
			Console.Write("Inheritance:");
			Inherit i = new Inherit();
			i.getArea();
			i.MakeRectangle();
			
			
			
			Console.Write("Polymorphism:");
			Poly p = new Poly();
			p.DoPrinting();
			
			Console.Write("Overloading:");
			Overload o = new Overload();
			o.DoOverload();
			
			Console.Write("Press any key to continue . . . ");
			Console.Write("Destructors:");
			Dest d = new Dest();
			d.getLength();
			d.MakeLine2();
			
			Console.Write("Static members:");
			Staticmem s = new Staticmem();
			Console.WriteLine("initial value: " + s.getNum());
			s.DoStatic();
		}
	}
}