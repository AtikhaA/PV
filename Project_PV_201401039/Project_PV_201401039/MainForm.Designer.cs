/*
 * Created by SharpDevelop.
 * User: tikam
 * Date: 14/05/2022
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project_PV_201401039
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tb_programstudi = new System.Windows.Forms.TextBox();
			this.tb_fakultas = new System.Windows.Forms.TextBox();
			this.tb_angkatan = new System.Windows.Forms.TextBox();
			this.tb_email = new System.Windows.Forms.TextBox();
			this.tb_nim = new System.Windows.Forms.TextBox();
			this.tb_nama = new System.Windows.Forms.TextBox();
			this.tb_ips1 = new System.Windows.Forms.TextBox();
			this.comboBox_status = new System.Windows.Forms.ComboBox();
			this.tb_ips2 = new System.Windows.Forms.TextBox();
			this.tb_ips3 = new System.Windows.Forms.TextBox();
			this.tb_ipk = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.formpencarian = new System.Windows.Forms.TextBox();
			this.btn_insert = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(281, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 61);
			this.label1.TabIndex = 0;
			this.label1.Text = "DIREKTORI MAHASISWA SEMESTER 4";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(31, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(31, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(31, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "NIM";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(31, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 24);
			this.label5.TabIndex = 4;
			this.label5.Text = "Angkatan";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(31, 182);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 24);
			this.label6.TabIndex = 5;
			this.label6.Text = "Fakultas";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label7.Location = new System.Drawing.Point(31, 208);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 24);
			this.label7.TabIndex = 6;
			this.label7.Text = "Program Studi";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label8.Location = new System.Drawing.Point(31, 233);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 24);
			this.label8.TabIndex = 7;
			this.label8.Text = "Status";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label9.Location = new System.Drawing.Point(31, 261);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 24);
			this.label9.TabIndex = 8;
			this.label9.Text = "IP Semester 1";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label10.Location = new System.Drawing.Point(31, 287);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 24);
			this.label10.TabIndex = 9;
			this.label10.Text = "IP Semester 2";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(31, 314);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(94, 24);
			this.label11.TabIndex = 10;
			this.label11.Text = "IP Semester 3";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label12.Location = new System.Drawing.Point(31, 338);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(94, 24);
			this.label12.TabIndex = 11;
			this.label12.Text = "IPK";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tb_programstudi
			// 
			this.tb_programstudi.Location = new System.Drawing.Point(133, 210);
			this.tb_programstudi.Name = "tb_programstudi";
			this.tb_programstudi.Size = new System.Drawing.Size(316, 20);
			this.tb_programstudi.TabIndex = 12;
			// 
			// tb_fakultas
			// 
			this.tb_fakultas.Location = new System.Drawing.Point(133, 184);
			this.tb_fakultas.Name = "tb_fakultas";
			this.tb_fakultas.Size = new System.Drawing.Size(316, 20);
			this.tb_fakultas.TabIndex = 13;
			// 
			// tb_angkatan
			// 
			this.tb_angkatan.Location = new System.Drawing.Point(133, 158);
			this.tb_angkatan.Name = "tb_angkatan";
			this.tb_angkatan.Size = new System.Drawing.Size(70, 20);
			this.tb_angkatan.TabIndex = 14;
			// 
			// tb_email
			// 
			this.tb_email.Location = new System.Drawing.Point(133, 132);
			this.tb_email.Name = "tb_email";
			this.tb_email.Size = new System.Drawing.Size(316, 20);
			this.tb_email.TabIndex = 15;
			// 
			// tb_nim
			// 
			this.tb_nim.Location = new System.Drawing.Point(133, 106);
			this.tb_nim.Name = "tb_nim";
			this.tb_nim.Size = new System.Drawing.Size(145, 20);
			this.tb_nim.TabIndex = 16;
			// 
			// tb_nama
			// 
			this.tb_nama.Location = new System.Drawing.Point(133, 80);
			this.tb_nama.Name = "tb_nama";
			this.tb_nama.Size = new System.Drawing.Size(316, 20);
			this.tb_nama.TabIndex = 17;
			// 
			// tb_ips1
			// 
			this.tb_ips1.Location = new System.Drawing.Point(133, 263);
			this.tb_ips1.Name = "tb_ips1";
			this.tb_ips1.Size = new System.Drawing.Size(70, 20);
			this.tb_ips1.TabIndex = 18;
			// 
			// comboBox_status
			// 
			this.comboBox_status.FormattingEnabled = true;
			this.comboBox_status.Location = new System.Drawing.Point(133, 236);
			this.comboBox_status.Name = "comboBox_status";
			this.comboBox_status.Size = new System.Drawing.Size(190, 21);
			this.comboBox_status.TabIndex = 19;
			// 
			// tb_ips2
			// 
			this.tb_ips2.Location = new System.Drawing.Point(133, 289);
			this.tb_ips2.Name = "tb_ips2";
			this.tb_ips2.Size = new System.Drawing.Size(70, 20);
			this.tb_ips2.TabIndex = 20;
			// 
			// tb_ips3
			// 
			this.tb_ips3.Location = new System.Drawing.Point(133, 315);
			this.tb_ips3.Name = "tb_ips3";
			this.tb_ips3.Size = new System.Drawing.Size(70, 20);
			this.tb_ips3.TabIndex = 21;
			// 
			// tb_ipk
			// 
			this.tb_ipk.Location = new System.Drawing.Point(133, 341);
			this.tb_ipk.Name = "tb_ipk";
			this.tb_ipk.Size = new System.Drawing.Size(145, 20);
			this.tb_ipk.TabIndex = 22;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label13.Location = new System.Drawing.Point(494, 133);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 24);
			this.label13.TabIndex = 23;
			this.label13.Text = "Cari Nama/NIM";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// formpencarian
			// 
			this.formpencarian.Location = new System.Drawing.Point(494, 160);
			this.formpencarian.Name = "formpencarian";
			this.formpencarian.Size = new System.Drawing.Size(316, 20);
			this.formpencarian.TabIndex = 24;
			this.formpencarian.TextChanged += new System.EventHandler(this.FormpencarianTextChanged);
			// 
			// btn_insert
			// 
			this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_insert.Location = new System.Drawing.Point(494, 190);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(74, 25);
			this.btn_insert.TabIndex = 25;
			this.btn_insert.Text = "Insert";
			this.btn_insert.UseVisualStyleBackColor = false;
			this.btn_insert.Click += new System.EventHandler(this.Btn_insertClick);
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btn_delete.Location = new System.Drawing.Point(574, 190);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(74, 25);
			this.btn_delete.TabIndex = 26;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.Btn_deleteClick);
			// 
			// btn_update
			// 
			this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btn_update.Location = new System.Drawing.Point(654, 190);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(74, 25);
			this.btn_update.TabIndex = 27;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = false;
			this.btn_update.Click += new System.EventHandler(this.Btn_updateClick);
			// 
			// btn_refresh
			// 
			this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btn_refresh.Location = new System.Drawing.Point(734, 190);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(74, 25);
			this.btn_refresh.TabIndex = 28;
			this.btn_refresh.Text = "Refresh";
			this.btn_refresh.UseVisualStyleBackColor = false;
			this.btn_refresh.Click += new System.EventHandler(this.Btn_refreshClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(34, 381);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(774, 138);
			this.dataGridView1.TabIndex = 29;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(835, 543);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_refresh);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.formpencarian);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.tb_ipk);
			this.Controls.Add(this.tb_ips3);
			this.Controls.Add(this.tb_ips2);
			this.Controls.Add(this.comboBox_status);
			this.Controls.Add(this.tb_ips1);
			this.Controls.Add(this.tb_nama);
			this.Controls.Add(this.tb_nim);
			this.Controls.Add(this.tb_email);
			this.Controls.Add(this.tb_angkatan);
			this.Controls.Add(this.tb_fakultas);
			this.Controls.Add(this.tb_programstudi);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Project_PV_201401039";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_refresh;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.TextBox formpencarian;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tb_ipk;
		private System.Windows.Forms.TextBox tb_ips3;
		private System.Windows.Forms.TextBox tb_ips2;
		private System.Windows.Forms.ComboBox comboBox_status;
		private System.Windows.Forms.TextBox tb_ips1;
		private System.Windows.Forms.TextBox tb_nama;
		private System.Windows.Forms.TextBox tb_nim;
		private System.Windows.Forms.TextBox tb_email;
		private System.Windows.Forms.TextBox tb_angkatan;
		private System.Windows.Forms.TextBox tb_fakultas;
		private System.Windows.Forms.TextBox tb_programstudi;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
