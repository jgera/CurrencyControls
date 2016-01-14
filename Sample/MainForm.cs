/*
 * Created by SharpDevelop.
 * User: emarti
 * Date: 05.02.2014
 * Time: 18:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sample
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainForm_Load(object sender, EventArgs e)
		{
			
		}
		
		void MainForm_Shown(object sender, EventArgs e)
		{
			currencyTextBox2.Focus();
		}
		
		void Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(currencyTextBox1.Text);
		}
		
		void Button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(currencyTextBox1.TextNoFormatting);
		}

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(currencyLabel1.Value.ToString());

            currencyTextBox2.Value = 1.1;
            currencyLabel1.Value = currencyTextBox1.Value;
            //currencyCombobox1.Value = currencyTextBox1.Value;
            //currencyDomainUpdown1.Value = currencyTextBox1.Value;
        }
    }
}
