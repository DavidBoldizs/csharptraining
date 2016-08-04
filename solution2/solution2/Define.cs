/*
 * Created by SharpDevelop.
 * User: boldizs
 * Date: 2016.07.15.
 * Time: 16:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
#define DEBUG
#define VC_V10
using System;
public class Define
{
	public void DoDefine()
   {
      #if (DEBUG && !VC_V10)
         Console.WriteLine("DEBUG is defined");
      #elif (!DEBUG && VC_V10)
         Console.WriteLine("VC_V10 is defined");
      #elif (DEBUG && VC_V10)
         Console.WriteLine("DEBUG and VC_V10 are defined");
      #else
         Console.WriteLine("DEBUG and VC_V10 are not defined");
      #endif
      Console.ReadKey();
	}
}
