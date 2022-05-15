/*
 * Created by SharpDevelop.
 * User: tikam
 * Date: 4/17/2022
 * Time: 3:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_201401039
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
			this.kodebarang = new System.Windows.Forms.Label();
			this.namabarang = new System.Windows.Forms.Label();
			this.hargabeli = new System.Windows.Forms.Label();
			this.hargajual = new System.Windows.Forms.Label();
			this.jumlah = new System.Windows.Forms.Label();
			this.satuan = new System.Windows.Forms.Label();
			this.kode_barang = new System.Windows.Forms.TextBox();
			this.nama_barang = new System.Windows.Forms.TextBox();
			this.harga_beli = new System.Windows.Forms.TextBox();
			this.harga_jual = new System.Windows.Forms.TextBox();
			this.jumlah_barang = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.insert = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.refresh = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.formpencarian = new System.Windows.Forms.TextBox();
			this.satuan_barang = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// kodebarang
			// 
			this.kodebarang.Location = new System.Drawing.Point(16, 23);
			this.kodebarang.Name = "kodebarang";
			this.kodebarang.Size = new System.Drawing.Size(71, 20);
			this.kodebarang.TabIndex = 0;
			this.kodebarang.Text = "Kode Barang";
			// 
			// namabarang
			// 
			this.namabarang.Location = new System.Drawing.Point(16, 63);
			this.namabarang.Name = "namabarang";
			this.namabarang.Size = new System.Drawing.Size(81, 20);
			this.namabarang.TabIndex = 2;
			this.namabarang.Text = "Nama Barang";
			// 
			// hargabeli
			// 
			this.hargabeli.Location = new System.Drawing.Point(16, 103);
			this.hargabeli.Name = "hargabeli";
			this.hargabeli.Size = new System.Drawing.Size(71, 20);
			this.hargabeli.TabIndex = 3;
			this.hargabeli.Text = "Harga Beli";
			// 
			// hargajual
			// 
			this.hargajual.Location = new System.Drawing.Point(16, 143);
			this.hargajual.Name = "hargajual";
			this.hargajual.Size = new System.Drawing.Size(71, 20);
			this.hargajual.TabIndex = 4;
			this.hargajual.Text = "Harga Jual";
			// 
			// jumlah
			// 
			this.jumlah.Location = new System.Drawing.Point(16, 183);
			this.jumlah.Name = "jumlah";
			this.jumlah.Size = new System.Drawing.Size(71, 20);
			this.jumlah.TabIndex = 5;
			this.jumlah.Text = "Jumlah";
			// 
			// satuan
			// 
			this.satuan.Location = new System.Drawing.Point(16, 223);
			this.satuan.Name = "satuan";
			this.satuan.Size = new System.Drawing.Size(71, 20);
			this.satuan.TabIndex = 6;
			this.satuan.Text = "Satuan";
			// 
			// kode_barang
			// 
			this.kode_barang.Location = new System.Drawing.Point(103, 23);
			this.kode_barang.Name = "kode_barang";
			this.kode_barang.Size = new System.Drawing.Size(171, 20);
			this.kode_barang.TabIndex = 7;
			// 
			// nama_barang
			// 
			this.nama_barang.Location = new System.Drawing.Point(103, 60);
			this.nama_barang.Name = "nama_barang";
			this.nama_barang.Size = new System.Drawing.Size(417, 20);
			this.nama_barang.TabIndex = 8;
			// 
			// harga_beli
			// 
			this.harga_beli.Location = new System.Drawing.Point(103, 103);
			this.harga_beli.Name = "harga_beli";
			this.harga_beli.Size = new System.Drawing.Size(171, 20);
			this.harga_beli.TabIndex = 9;
			this.harga_beli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Harga_beliKeyPress);
			// 
			// harga_jual
			// 
			this.harga_jual.Location = new System.Drawing.Point(103, 143);
			this.harga_jual.Name = "harga_jual";
			this.harga_jual.Size = new System.Drawing.Size(171, 20);
			this.harga_jual.TabIndex = 10;
			this.harga_jual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Harga_jualKeyPress);
			// 
			// jumlah_barang
			// 
			this.jumlah_barang.Location = new System.Drawing.Point(103, 180);
			this.jumlah_barang.Name = "jumlah_barang";
			this.jumlah_barang.Size = new System.Drawing.Size(171, 20);
			this.jumlah_barang.TabIndex = 11;
			this.jumlah_barang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Jumlah_barangKeyPress);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.DataMember = "dftpesan";
			this.dataGridView1.Location = new System.Drawing.Point(16, 257);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(504, 170);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// insert
			// 
			this.insert.Location = new System.Drawing.Point(306, 183);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(70, 20);
			this.insert.TabIndex = 14;
			this.insert.Text = "Insert";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.Button1Click);
			// 
			// update
			// 
			this.update.Location = new System.Drawing.Point(306, 219);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(70, 20);
			this.update.TabIndex = 15;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.UpdateClick);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(382, 183);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(70, 20);
			this.delete.TabIndex = 16;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.DeleteClick);
			// 
			// refresh
			// 
			this.refresh.Location = new System.Drawing.Point(382, 219);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(70, 19);
			this.refresh.TabIndex = 17;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = true;
			this.refresh.Click += new System.EventHandler(this.RefreshClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(304, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Pencarian Kode / Nama Barang";
			// 
			// formpencarian
			// 
			this.formpencarian.Location = new System.Drawing.Point(305, 137);
			this.formpencarian.Name = "formpencarian";
			this.formpencarian.Size = new System.Drawing.Size(214, 20);
			this.formpencarian.TabIndex = 19;
			this.formpencarian.TextChanged += new System.EventHandler(this.FormpencarianTextChanged);
			// 
			// satuan_barang
			// 
			this.satuan_barang.FormattingEnabled = true;
			this.satuan_barang.Location = new System.Drawing.Point(104, 219);
			this.satuan_barang.Name = "satuan_barang";
			this.satuan_barang.Size = new System.Drawing.Size(169, 21);
			this.satuan_barang.TabIndex = 20;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 451);
			this.Controls.Add(this.satuan_barang);
			this.Controls.Add(this.formpencarian);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.update);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.jumlah_barang);
			this.Controls.Add(this.harga_jual);
			this.Controls.Add(this.harga_beli);
			this.Controls.Add(this.nama_barang);
			this.Controls.Add(this.kode_barang);
			this.Controls.Add(this.satuan);
			this.Controls.Add(this.jumlah);
			this.Controls.Add(this.hargajual);
			this.Controls.Add(this.hargabeli);
			this.Controls.Add(this.namabarang);
			this.Controls.Add(this.kodebarang);
			this.Name = "MainForm";
			this.Text = "PV_201401039";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox formpencarian;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox satuan_barang;
		private System.Windows.Forms.TextBox jumlah_barang;
		private System.Windows.Forms.TextBox harga_jual;
		private System.Windows.Forms.TextBox harga_beli;
		private System.Windows.Forms.TextBox nama_barang;
		private System.Windows.Forms.TextBox kode_barang;
		private System.Windows.Forms.Label satuan;
		private System.Windows.Forms.Label jumlah;
		private System.Windows.Forms.Label hargajual;
		private System.Windows.Forms.Label hargabeli;
		private System.Windows.Forms.Label namabarang;
		private System.Windows.Forms.Label kodebarang;
	}
}
