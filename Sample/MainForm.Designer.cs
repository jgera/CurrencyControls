/*
 * Created by SharpDevelop.
 * User: emarti
 * Date: 05.02.2014
 * Time: 18:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sample
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.currencyLabel1 = new CurrencyTextBox.CurrencyLabel();
            this.currencyTextBox2 = new CurrencyTextBox.CurrencyTextBox();
            this.currencyTextBox1 = new CurrencyTextBox.CurrencyTextBox();
            this.currencyCombobox1 = new CurrencyTextBox.CurrencyCombobox();
            this.currencyDomainUpdown1 = new CurrencyTextBox.CurrencyDomainUpdown();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please, input number for currency";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "TextNoFormatting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Text";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // currencyLabel1
            // 
            this.currencyLabel1.AutoSize = true;
            this.currencyLabel1.Location = new System.Drawing.Point(25, 195);
            this.currencyLabel1.Name = "currencyLabel1";
            this.currencyLabel1.Size = new System.Drawing.Size(37, 13);
            this.currencyLabel1.TabIndex = 6;
            this.currencyLabel1.Text = "₹ 1.00";
            this.currencyLabel1.Value = 1D;
            // 
            // currencyTextBox2
            // 
            this.currencyTextBox2.Location = new System.Drawing.Point(28, 97);
            this.currencyTextBox2.Name = "currencyTextBox2";
            this.currencyTextBox2.Size = new System.Drawing.Size(234, 20);
            this.currencyTextBox2.TabIndex = 2;
            this.currencyTextBox2.Text = "₹ 0.00";
            this.currencyTextBox2.Value = 0D;
            // 
            // currencyTextBox1
            // 
            this.currencyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currencyTextBox1.Location = new System.Drawing.Point(28, 40);
            this.currencyTextBox1.Name = "currencyTextBox1";
            this.currencyTextBox1.Size = new System.Drawing.Size(234, 29);
            this.currencyTextBox1.TabIndex = 0;
            this.currencyTextBox1.Text = "₹ 12,345.00";
            this.currencyTextBox1.Value = 12345D;
            // 
            // currencyCombobox1
            // 
            this.currencyCombobox1.FormattingEnabled = true;
            this.currencyCombobox1.Location = new System.Drawing.Point(77, 192);
            this.currencyCombobox1.Name = "currencyCombobox1";
            this.currencyCombobox1.Size = new System.Drawing.Size(121, 21);
            this.currencyCombobox1.TabIndex = 7;
            // 
            // currencyDomainUpdown1
            // 
            this.currencyDomainUpdown1.Location = new System.Drawing.Point(78, 234);
            this.currencyDomainUpdown1.Name = "currencyDomainUpdown1";
            this.currencyDomainUpdown1.Size = new System.Drawing.Size(120, 20);
            this.currencyDomainUpdown1.TabIndex = 8;
            this.currencyDomainUpdown1.Text = "currencyDomainUpdown1";
            this.currencyDomainUpdown1.Value = 1D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 360);
            this.Controls.Add(this.currencyDomainUpdown1);
            this.Controls.Add(this.currencyCombobox1);
            this.Controls.Add(this.currencyLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currencyTextBox1);
            this.Name = "MainForm";
            this.Text = "Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private CurrencyTextBox.CurrencyTextBox currencyTextBox2;
		private System.Windows.Forms.Label label1;
		private CurrencyTextBox.CurrencyTextBox currencyTextBox1;
        private System.Windows.Forms.Button button3;
        private CurrencyTextBox.CurrencyLabel currencyLabel1;
        private CurrencyTextBox.CurrencyCombobox currencyCombobox1;
        private CurrencyTextBox.CurrencyDomainUpdown currencyDomainUpdown1;
    }
}
