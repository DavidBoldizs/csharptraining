/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.12.
 * Time: 17:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat2
{
	public class Staticmem
	{
		public static int num = 5;
		private int nnn;
		
		public void increment() {
			nnn++;
		}
		
		public int GetMyNumer() {
			return nnn;
		}
		
		
		public void count()
		{
			num++;
		}
		public static void counter()
		{
			num++;
		}
		public int getNum()
		{
			return num;
		}
   
		public void DoStatic()
		{
			Staticmem s1 = new Staticmem();
			Staticmem s2 = new Staticmem();
			Staticmem s3 = new Staticmem();
			s1.count();
			s1.count();
			s1.count();
			s2.count();
			s2.count();
			s2.count();
			Staticmem.counter();
			Staticmem.counter();
			Staticmem.counter();
			s1.increment();
			s2.increment();
			s2.increment();
			Console.WriteLine("Variable num for s1: {0}", s1.getNum());
			Console.WriteLine("Variable num for s2: {0}", s2.getNum());
			Console.WriteLine("Variable num for s3: {0}", s3.getNum());
			
			Console.WriteLine("Variable nnn for s1: {0}", s1.GetMyNumer());
			Console.WriteLine("Variable nnn for s2: {0}", s2.GetMyNumer());
			Console.WriteLine("Variable nnn for s3: {0}", s3.GetMyNumer());
			Console.ReadKey();
		}
	}
}
