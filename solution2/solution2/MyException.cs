/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.16.
 * Time: 10:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace solution2
{
	public class MyException
	{
	int result;
   public MyException()
      {
         result = 0;
      }
      public void division(int num1, int num2)
      {
         try
         {
            result = num1 / num2;
         }
         catch (DivideByZeroException e)
         {
            Console.WriteLine("Exception caught: {0}", e);
         }
         finally
         {
            Console.WriteLine("Result: {0}", result);
         }
      }
      public void DoException()
      {
         MyException e = new MyException();
         e.division(25, 0);
         Console.ReadKey();
	}
}
}