/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.11.
 * Time: 13:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace array
{
	/// <summary>
	/// Description of arrays.
	/// </summary>
	public class arrays
	{
		public arrays()
		{
		}
		public void DoArray()
		{

			int[] n = new int[20]; 
         
			for (int i = 0; i < n.Length; i++) {
				n[i] = i * 2;
				Console.WriteLine("Element[{0}] = {1}", i, n[i]);
			}
         
		
			int[] m = new int[10];
			int total = 0;
			for (int j = 0; j < m.Length; j++) {
				m[j] = n[j] * n[j];
				total += m[j];

				Console.WriteLine("NewElement[{0}] = {1}  => {2}", j, m[j], n[j]);
			}
			Console.WriteLine("total: {0} ", total);
			
         
        
	
		}
	}
}