/*
 * Created by SharpDevelop.
 * User: boldizsdavid
 * Date: 2016.08.09.
 * Time: 13:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace masodik
{
	/// <summary>
	/// Description of beolvas.
	/// </summary>
	public class beolvas
	{
		
		public void GetRight()
		{
			while(true){
				
			
			Console.WriteLine("Adj meg egy kettővel osztható, 10 és 100 közötti számot!");
			int m =Convert.ToInt32(Console.ReadLine());
			
			
			if( m % 2 == 0 && 10< m && m <100)
				
			{
				Console.WriteLine("Helyes válasz!");
			
			}
			  
			else
				
			   {
			   	Console.WriteLine("Próbálkozz újra!");
			   }
			break;
			}
		
}
}
}