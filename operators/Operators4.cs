/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.09.
 * Time: 15:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace operators
{
   public class Operators4
   {
   	int a, b, c;
   		
			
    public Operators4()
    {
    	Console.WriteLine("Operators4 is created");
			Console.WriteLine("Enter the first number");
			a = Convert.ToInt32(Console.ReadLine());
	
			Console.WriteLine("Enter the second number");
			b = Convert.ToInt32(Console.ReadLine());
			
    }
    
    public void DoBitwise()
      {
      
         
         c = a & b;             
         Console.WriteLine("Value of c is {0}", c );
         
         c = a | b;             
         Console.WriteLine("Value of c is {0}", c);
         
         c = a ^ b;            
         Console.WriteLine("Value of c is {0}", c);
         
         c = ~a;               
         Console.WriteLine("Value of c is {0}", c);
         
         c = a << 2;     
         Console.WriteLine("Value of c is {0}", c);
         
         c = a >> 2;     
         Console.WriteLine("Value of c is {0}", c);
         Console.ReadLine();
      }
   }
}