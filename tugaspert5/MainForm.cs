/*
 * Created by SharpDevelop.
 * User: Athika
 * Date: 23/02/2022
 * Time: 16.02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculator
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
		void Btn_tambahClick(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1=int.Parse(txt_bil1.Text);
			bil2=int.Parse(txt_bil2.Text);
			hasil=bil1+bil2;
			txt_hasil.Text=hasil.ToString();
		}
		void Btn_kurangClick(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1=int.Parse(txt_bil1.Text);
			bil2=int.Parse(txt_bil2.Text);
			hasil=bil1-bil2;
			txt_hasil.Text=hasil.ToString();
		}
		void Btn_kaliClick(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1=int.Parse(txt_bil1.Text);
			bil2=int.Parse(txt_bil2.Text);
			hasil=bil1*bil2;
			txt_hasil.Text=hasil.ToString();
		}
		void Btn_bagiClick(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1=int.Parse(txt_bil1.Text);
			bil2=int.Parse(txt_bil2.Text);
			hasil=bil1/bil2;
			txt_hasil.Text=hasil.ToString();
		}
		void Button1Click(object sender, EventArgs e)
		{
			txt_bil1.Clear();
			txt_bil2.Clear();
			txt_hasil.Text = "";
		}
		
	}
}
