/*
 * Created by SharpDevelop.
 * User: Boldizs Dávid
 * Date: 2016.08.02.
 * Time: 13:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace app2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		    Random randomizer = new Random();
		    
		    int addend1;
		    int addend2;
		    
		    int minuend;
            int subtrahend;
            
            int multiplicand;
            int multiplier;
            
            int dividend;
            int divisor;


		     int timeLeft;
		public MainForm()
		{
			
			InitializeComponent();{
			}
			}
			
			public void StartTheQuiz()
{

    addend1 = randomizer.Next(51);
    addend2 = randomizer.Next(51);

    label1.Text = addend1.ToString();
    label11.Text = addend2.ToString();

    sum.Value = 0;
    
     minuend = randomizer.Next(1, 101);
    subtrahend = randomizer.Next(1, minuend);
    label5.Text = minuend.ToString();
    label13.Text = subtrahend.ToString();
    difference.Value = 0;
    
     multiplicand = randomizer.Next(2, 11);
    multiplier = randomizer.Next(2, 11);
    label6.Text = multiplicand.ToString();
    label14.Text = multiplier.ToString();
    product.Value = 0;
    
     divisor = randomizer.Next(2, 11);
    int temporaryQuotient = randomizer.Next(2, 11);
    dividend = divisor * temporaryQuotient;
    label4.Text = dividend.ToString();
    label12.Text = divisor.ToString();
    quotient.Value = 0;
    
    timeLeft = 30;
    timeLabel.Text = "30 seconds"; 
    timer1.Start();
}
		private void Button1Click(object sender, EventArgs e)
		{
		 StartTheQuiz();
    button1.Enabled = false;     
		}
		void Label18Click(object sender, EventArgs e)
		{
	
		}
		void Timer1Tick(object sender, EventArgs e)
		{
	 if (timeLeft > 0)
    {
        timeLeft = timeLeft - 1;
        timeLabel.Text = timeLeft + " seconds";
		}
			 else
    {
        timer1.Stop();
        timeLabel.Text = "Time's up!";
        MessageBox.Show("You didn't finish in time.", "Sorry!");
        sum.Value = addend1 + addend2;
        difference.Value = minuend - subtrahend;
        product.Value = multiplicand * multiplier;
         quotient.Value = dividend / divisor;
        button1.Enabled = true;
			 }
		}
			 private bool CheckTheAnswer()
{
    if ((addend1 + addend2 == sum.Value)
    	&& (minuend - subtrahend == difference.Value)&& (multiplicand * multiplier == product.Value)
        && (dividend / divisor == quotient.Value))
        return true;
    else
        return false;
}
			 private void timer1_Tick(object sender, EventArgs e)
{
    if (CheckTheAnswer())
    {
        timer1.Stop();
        MessageBox.Show("You got all the answers right!",
                        "Congratulations!");
        button1.Enabled = true;
    }
    else if (timeLeft > 0)
    {
       timeLeft--;
        timeLabel.Text = timeLeft + " seconds";
    }
    else
    {
        timer1.Stop();
        timeLabel.Text = "Time's up!";
        MessageBox.Show("You didn't finish in time.", "Sorry!");
        sum.Value = addend1 + addend2;
        difference.Value = minuend - subtrahend;
         product.Value = multiplicand * multiplier;
             quotient.Value = dividend / divisor;

        button1.Enabled = true;
    }
}
		void Label4Click(object sender, EventArgs e)
		{
		
		}
	}
	}
	