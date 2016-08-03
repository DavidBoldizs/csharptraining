/*
 * Created by SharpDevelop.
 * User: Boldizs Dávid
 * Date: 2016.08.02.
 * Time: 10:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace winapp
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label plusLeftLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown sum;
		private System.Windows.Forms.Label minusLeftLabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label minusRightLabel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown difference;
		private System.Windows.Forms.Label timesLeftLabel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label timesRightLabel;
		private System.Windows.Forms.NumericUpDown product;
		private System.Windows.Forms.Label dividedLeftLabel;
		private System.Windows.Forms.Label dividedRightLabel;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.NumericUpDown quotient;
			
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
			{
		
			}
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.plusLeftLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.sum = new System.Windows.Forms.NumericUpDown();
			this.minusLeftLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.minusRightLabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.difference = new System.Windows.Forms.NumericUpDown();
			this.timesLeftLabel = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.timesRightLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.product = new System.Windows.Forms.NumericUpDown();
			this.dividedLeftLabel = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.dividedRightLabel = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.quotient = new System.Windows.Forms.NumericUpDown();
			this.startButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(272, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 30);
			this.label1.TabIndex = 0;
			this.label1.Click += new System.EventHandler(this.timeLabelClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(209, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Time Left";
			// 
			// plusLeftLabel
			// 
			this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.plusLeftLabel.Location = new System.Drawing.Point(51, 75);
			this.plusLeftLabel.Name = "plusLeftLabel";
			this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
			this.plusLeftLabel.TabIndex = 2;
			this.plusLeftLabel.Text = "?\r\n";
			this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(117, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 50);
			this.label3.TabIndex = 3;
			this.label3.Text = "+";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(236, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 50);
			this.label4.TabIndex = 4;
			this.label4.Text = "=";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(183, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 50);
			this.label5.TabIndex = 5;
			this.label5.Text = "?";
			// 
			// sum
			// 
			this.sum.Location = new System.Drawing.Point(302, 85);
			this.sum.Name = "sum";
			this.sum.Size = new System.Drawing.Size(100, 20);
			this.sum.TabIndex = 2;
			// 
			// minusLeftLabel
			// 
			this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.minusLeftLabel.Location = new System.Drawing.Point(51, 144);
			this.minusLeftLabel.Name = "minusLeftLabel";
			this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
			this.minusLeftLabel.TabIndex = 7;
			this.minusLeftLabel.Text = "?\r\n";
			this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(117, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 50);
			this.label7.TabIndex = 8;
			this.label7.Text = "-";
			// 
			// minusRightLabel
			// 
			this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.minusRightLabel.Location = new System.Drawing.Point(183, 144);
			this.minusRightLabel.Name = "minusRightLabel";
			this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
			this.minusRightLabel.TabIndex = 9;
			this.minusRightLabel.Text = "?";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label9.Location = new System.Drawing.Point(236, 144);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 50);
			this.label9.TabIndex = 10;
			this.label9.Text = "=";
			// 
			// difference
			// 
			this.difference.Location = new System.Drawing.Point(302, 154);
			this.difference.Name = "difference";
			this.difference.Size = new System.Drawing.Size(100, 20);
			this.difference.TabIndex = 3;
			// 
			// timesLeftLabel
			// 
			this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.timesLeftLabel.Location = new System.Drawing.Point(51, 218);
			this.timesLeftLabel.Name = "timesLeftLabel";
			this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
			this.timesLeftLabel.TabIndex = 12;
			this.timesLeftLabel.Text = "?\r\n";
			this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.Location = new System.Drawing.Point(117, 218);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 50);
			this.label8.TabIndex = 13;
			this.label8.Text = "*";
			// 
			// timesRightLabel
			// 
			this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.timesRightLabel.Location = new System.Drawing.Point(183, 218);
			this.timesRightLabel.Name = "timesRightLabel";
			this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
			this.timesRightLabel.TabIndex = 14;
			this.timesRightLabel.Text = "?";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label11.Location = new System.Drawing.Point(236, 218);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 50);
			this.label11.TabIndex = 15;
			this.label11.Text = "=";
			// 
			// product
			// 
			this.product.Location = new System.Drawing.Point(302, 228);
			this.product.Name = "product";
			this.product.Size = new System.Drawing.Size(100, 20);
			this.product.TabIndex = 4;
			// 
			// dividedLeftLabel
			// 
			this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dividedLeftLabel.Location = new System.Drawing.Point(51, 289);
			this.dividedLeftLabel.Name = "dividedLeftLabel";
			this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
			this.dividedLeftLabel.TabIndex = 17;
			this.dividedLeftLabel.Text = "?\r\n";
			this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label13.Location = new System.Drawing.Point(117, 289);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 50);
			this.label13.TabIndex = 18;
			this.label13.Text = "/";
			// 
			// dividedRightLabel
			// 
			this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dividedRightLabel.Location = new System.Drawing.Point(183, 289);
			this.dividedRightLabel.Name = "dividedRightLabel";
			this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
			this.dividedRightLabel.TabIndex = 19;
			this.dividedRightLabel.Text = "?";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label15.Location = new System.Drawing.Point(236, 289);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(60, 50);
			this.label15.TabIndex = 20;
			this.label15.Text = "=";
			// 
			// quotient
			// 
			this.quotient.Location = new System.Drawing.Point(302, 299);
			this.quotient.Name = "quotient";
			this.quotient.Size = new System.Drawing.Size(100, 20);
			this.quotient.TabIndex = 5;
			// 
			// startButton
			// 
			this.startButton.AutoSize = true;
			this.startButton.Location = new System.Drawing.Point(209, 327);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(79, 23);
			this.startButton.TabIndex = 1;
			this.startButton.Text = "Start the quiz";
			this.startButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 362);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.quotient);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.dividedRightLabel);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.dividedLeftLabel);
			this.Controls.Add(this.product);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.timesRightLabel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.timesLeftLabel);
			this.Controls.Add(this.difference);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.minusRightLabel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.minusLeftLabel);
			this.Controls.Add(this.sum);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.plusLeftLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "winapp";
			((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "winapp";
			((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		this.ResumeLayout(false);
		{
		}
	}
}
}