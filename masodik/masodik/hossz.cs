/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.08.14.
 * Time: 13:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace masodik
{
/// <summary>
	/// Két érték közül a nagyobbad adja vissza.
	/// </summary>
	public class hossz
	{
		static int maximum(int x,int y)
{
return (x>y?x:y);
}
public void GetLongest()
{
Console.WriteLine("Nagyobb :");
Console.WriteLine(maximum(4,3));
}
	}
}