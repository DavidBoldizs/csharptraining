/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.11.
 * Time: 17:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace array
{
	public class StringTest
	{
		
		public void createstringarray() {
			
			string myStrA = "The quick brown fox jumps over the lazy dog";
			string[] mystraarray = myStrA.Split(' ');
			Console.WriteLine("array: length: {0}", mystraarray.Length);
			for(int i = 0; i < mystraarray.Length; i++){
				Console.WriteLine(mystraarray[i]);
			}
			Console.ReadLine();
			
		}
	}
}
