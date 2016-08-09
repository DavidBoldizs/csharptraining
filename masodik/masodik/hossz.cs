
using System;

namespace masodik
{
	
	public class hossz
	{
		static int maximum(int x,int y)
{
return (x>y?x:y);
}
public void GetLongest()
{
Console.WriteLine("Leghosszabb :");
Console.WriteLine(maximum(4,3));
}
	}
}
