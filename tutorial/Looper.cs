/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.02.
 * Time: 11:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tutorial
{
	/// <summary>
	/// Description of Looper.
	/// </summary>
	public class Looper {
		public Looper()
		{
		}
		
		public void MakeForLoop() {
			for (int i = 0; i < 10; i++) {
				Console.WriteLine("Hey! " + i);
				//itt hozzáadok 2-t
				//i = i +2;
			}
		}
		
		public void MakeWhileLoop() {
			int i = 0;
			while(i < 20) {
				Console.WriteLine("while " + i);
				i = i + 3;
			}
		}
		
		public void MakeWhileLoop2(int max) {
			int i = 0;
			while(i < max) {
				Console.WriteLine("param " + i);
				 i ++;
			}
		}
	}
}
