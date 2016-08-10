/*
 * Created by SharpDevelop.
 * User: boldizsdavid
 * Date: 2016.08.08.
 * Time: 9:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace masodik
{
	class Program
	{
		struct alma
		{
			public string szin;
			public string meret;
			public string fajta;
		}
		enum csapatok {
	Ferencváros,	
	Videoton,	
    DVSCTEVA,	
	MTK,	
	SwietelskyHaladás,	
	Újpest,	
    Paks,	
	Honvéd,	
	DiósgyőriVTK,	
	Vasas,	
	PuskásAkadémia,	
	BékéscsabaElőre}
			;
			
		public static void Main(string[] args)
		{
			double a=4;
			double b=5;
			int ceruza=12;
			int ház=120;
			
			string egy="valami";
			int i=egy.Length;
			
			string kettő="masodik";
			int f=kettő.Length;
			
			for(csapatok k=csapatok.Ferencváros; k<csapatok.BékéscsabaElőre; k++)
			{
				Console.WriteLine(k);
			}
			Console.ReadKey(true);
			
			if(ceruza<ház) {
				Console.WriteLine("a ház nagyobb mint a ceruza");
			} else {
				Console.WriteLine("a ceruza nagyobb mint a ház");
			}
			Console.ReadKey(true);
			
			double sq = a * a + b * b; 
			double c = Math.Sqrt(sq);
			Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
				Console.ReadKey(true);
			Console.WriteLine(egy);
			Console.WriteLine(i);
			Console.ReadKey(true);
			Console.WriteLine(kettő);
			Console.WriteLine(f);
			Console.ReadKey(true);
			
			int [] numbers;
			numbers = new int[]{1,2,3,4,5,6,7,8,9,10};
			int max = numbers[0];
            for(int x=0;x<numbers.Length;x++)
            	
            	if(numbers[x] > max)
            		max=numbers[x];
            Console.WriteLine("1,2,3,4,5,6,7,8,9,10");
            Console.WriteLine("Legnagyobb elem :" + max);
            Console.ReadKey(true);
            
            alma q=new alma();
            q.fajta="gyumolcs";
            q.meret="kicsi";
            q.szin="piros";
            Console.WriteLine("Az alma egy:");
            Console.WriteLine(q.meret); 
            Console.WriteLine(q.szin);
            Console.WriteLine(q.fajta);
            Console.ReadKey(true);
            
            foci y=new foci();
            y.GetResult();
            Console.ReadKey(true);
            
            beolvas u=new beolvas();
            u.GetRight();
            u.GetSum();
            Console.ReadKey(true);
            
            hossz l= new hossz();
            l.GetLongest();
            	
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}