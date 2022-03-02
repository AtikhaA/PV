/*
 * Created by SharpDevelop.
 * User: Athika
 * Date: 02/03/2022
 * Time: 15.16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TugasPertemuan4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Name : Form
	{
		public Name()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello " + this.textBox1.Text + ", NIM " + this.textBox2.Text + ", Kelas " + this.textBox3.Text + ", Mata Kuliah " + this.textBox4.Text);
		}
	}
}
