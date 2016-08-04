/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.06.30.
 * Time: 19:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace RectangleApplication
{
   class Rectangle 
   {
      // member variables
      double length;
      double width;
      public void Acceptdetails()
      {
         length = 4.5;    
         width = 3.5;
      }
      
      public double GetArea()
      {
         return length * width; 
      }
      
      public void Display()
      {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }
   
   class ExecuteRectangle 
   {
      static void Main(string[] args) 
      {
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine(); 
      }
   }
}
}
