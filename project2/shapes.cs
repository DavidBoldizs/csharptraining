
using System;

namespace project2
{
	
	public class shapes
	{
		double side; double breadth; double length; double radius; double height; double breadthfortriangle;
		public void DoShaping()
		{
        shapes c = new shapes();
         while (true)
         {
        Console.WriteLine("Select Shape: (R)ectangle, (C)ircle, (S)quare, (T)riangle:");
        var key = Console.ReadKey();
       
        
        switch (key.Key)
        {
            case ConsoleKey.R:
                c.Rectangle();
                break;
            case ConsoleKey.C:
                c.Circle();
                break;
            case ConsoleKey.S:
                c.Square();
                break;
            case ConsoleKey.T:
                c.Triangle();
                break;
        }
         }}
         
	   public void Rectangle()  
        {  
            Console.WriteLine("Enter the Length for Rectangle");  
            length = double.Parse(Console.ReadLine());  
            Console.WriteLine("Enter the breadth for Rectangle");  
            breadth = double.Parse(Console.ReadLine());  

            Console.WriteLine("Area of rectangle is :{0}", length * breadth);  
        }  
        public void Circle()  
        {  
            Console.WriteLine("Enter the Radius of the Circle");  
            radius = double.Parse(Console.ReadLine());  

            Console.WriteLine("Area of Circle is:{0}", 3.14 * radius * radius);  
        }  
        public void Square()  
        {  
            Console.WriteLine("Enter the side of a square");  
            side = double.Parse(Console.ReadLine());  

            Console.WriteLine("Area of Square is:{0}", side * side);  
        }  
         public void Triangle()  
        {  
            Console.WriteLine("Enter the Breadth for Triangle ");  
            breadthfortriangle = double.Parse(Console.ReadLine());  
            Console.WriteLine("Enter the Hieght for Triangle ");  
            height = double.Parse(Console.ReadLine());    
            Console.WriteLine("Area of Triangle is:{0}", (breadthfortriangle * height) / 2);  
        }  
		
		}
	}
