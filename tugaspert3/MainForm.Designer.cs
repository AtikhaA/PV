/*
 * Created by SharpDevelop.
 * User: Athika
 * Date: 23/02/2022
 * Time: 16.02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_tambah;
		private System.Windows.Forms.Button btn_kurang;
		private System.Windows.Forms.Button btn_kali;
		private System.Windows.Forms.Button btn_bagi;
		private System.Windows.Forms.TextBox txt_bil1;
		private System.Windows.Forms.TextBox txt_bil2;
		private System.Windows.Forms.TextBox txt_hasil;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_tambah = new System.Windows.Forms.Button();
			this.btn_kurang = new System.Windows.Forms.Button();
			this.btn_kali = new System.Windows.Forms.Button();
			this.btn_bagi = new System.Windows.Forms.Button();
			this.txt_bil1 = new System.Windows.Forms.TextBox();
			this.txt_bil2 = new System.Windows.Forms.TextBox();
			this.txt_hasil = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bilangan 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(112, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kalkulator";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(22, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Bilangan 2";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(22, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hasil";
			// 
			// btn_tambah
			// 
			this.btn_tambah.Location = new System.Drawing.Point(47, 191);
			this.btn_tambah.Name = "btn_tambah";
			this.btn_tambah.Size = new System.Drawing.Size(75, 23);
			this.btn_tambah.TabIndex = 7;
			this.btn_tambah.Text = "Tambah";
			this.btn_tambah.UseVisualStyleBackColor = true;
			this.btn_tambah.Click += new System.EventHandler(this.Btn_tambahClick);
			// 
			// btn_kurang
			// 
			this.btn_kurang.Location = new System.Drawing.Point(156, 191);
			this.btn_kurang.Name = "btn_kurang";
			this.btn_kurang.Size = new System.Drawing.Size(75, 23);
			this.btn_kurang.TabIndex = 8;
			this.btn_kurang.Text = "Kurang";
			this.btn_kurang.UseVisualStyleBackColor = true;
			this.btn_kurang.Click += new System.EventHandler(this.Btn_kurangClick);
			// 
			// btn_kali
			// 
			this.btn_kali.Location = new System.Drawing.Point(47, 231);
			this.btn_kali.Name = "btn_kali";
			this.btn_kali.Size = new System.Drawing.Size(75, 23);
			this.btn_kali.TabIndex = 9;
			this.btn_kali.Text = "Kali";
			this.btn_kali.UseVisualStyleBackColor = true;
			this.btn_kali.Click += new System.EventHandler(this.Btn_kaliClick);
			// 
			// btn_bagi
			// 
			this.btn_bagi.Location = new System.Drawing.Point(156, 231);
			this.btn_bagi.Name = "btn_bagi";
			this.btn_bagi.Size = new System.Drawing.Size(75, 23);
			this.btn_bagi.TabIndex = 10;
			this.btn_bagi.Text = "Bagi";
			this.btn_bagi.UseVisualStyleBackColor = true;
			this.btn_bagi.Click += new System.EventHandler(this.Btn_bagiClick);
			// 
			// txt_bil1
			// 
			this.txt_bil1.Location = new System.Drawing.Point(121, 52);
			this.txt_bil1.Name = "txt_bil1";
			this.txt_bil1.Size = new System.Drawing.Size(125, 20);
			this.txt_bil1.TabIndex = 11;
			// 
			// txt_bil2
			// 
			this.txt_bil2.Location = new System.Drawing.Point(121, 85);
			this.txt_bil2.Name = "txt_bil2";
			this.txt_bil2.Size = new System.Drawing.Size(125, 20);
			this.txt_bil2.TabIndex = 12;
			// 
			// txt_hasil
			// 
			this.txt_hasil.Location = new System.Drawing.Point(121, 131);
			this.txt_hasil.Name = "txt_hasil";
			this.txt_hasil.Size = new System.Drawing.Size(125, 20);
			this.txt_hasil.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 294);
			this.Controls.Add(this.txt_hasil);
			this.Controls.Add(this.txt_bil2);
			this.Controls.Add(this.txt_bil1);
			this.Controls.Add(this.btn_bagi);
			this.Controls.Add(this.btn_kali);
			this.Controls.Add(this.btn_kurang);
			this.Controls.Add(this.btn_tambah);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
