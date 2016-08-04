/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.13.
 * Time: 15:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace feladat2
{
	public interface ITransactions
   {
      void showTransaction();
      double getAmount();
   }
   
   public class Interface : ITransactions
   {
      private string tCode;
      private string date;
      private double amount;
      public Interface()
      {
         tCode = " ";
         date = " ";
         amount = 0.0;
      }
      
      public Interface(string c, string d, double a)
      {
         tCode = c;
         date = d;
         amount = a;
      }
      
      public double getAmount()
      {
         return amount;
      }
      
      public void showTransaction()
      {
         Console.WriteLine("Transaction: {0}", tCode);
         Console.WriteLine("Date: {0}", date);
         Console.WriteLine("Amount: {0}", getAmount());
      }
   }
   class Tester
   {
   	public void DoTransactions()
      {
         Interface t1 = new Interface("001", "8/10/2012", 78900.00);
         Interface t2 = new Interface("002", "9/10/2012", 451900.00);
         t1.showTransaction();
         t2.showTransaction();
         Console.ReadKey();
	}
}
}