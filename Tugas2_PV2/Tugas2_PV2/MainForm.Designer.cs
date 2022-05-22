/*
 * Created by SharpDevelop.
 * User: tikam
 * Date: 22/05/2022
 * Time: 15:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas2_PV2
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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnopenupload = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnsaveupload = new System.Windows.Forms.Button();
			this.btnsavedownload = new System.Windows.Forms.Button();
			this.btnopendownload = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.input_id = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.pictureBox2.Location = new System.Drawing.Point(417, 63);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(235, 125);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// btnopenupload
			// 
			this.btnopenupload.BackColor = System.Drawing.Color.White;
			this.btnopenupload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnopenupload.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnopenupload.ForeColor = System.Drawing.Color.Teal;
			this.btnopenupload.Location = new System.Drawing.Point(55, 233);
			this.btnopenupload.Name = "btnopenupload";
			this.btnopenupload.Size = new System.Drawing.Size(89, 24);
			this.btnopenupload.TabIndex = 4;
			this.btnopenupload.Text = "Open File";
			this.btnopenupload.UseVisualStyleBackColor = false;
			this.btnopenupload.Click += new System.EventHandler(this.BtnopenuploadClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(55, 321);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(597, 286);
			this.dataGridView1.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label3.Location = new System.Drawing.Point(55, 286);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(596, 35);
			this.label3.TabIndex = 9;
			this.label3.Text = "Data dari Database \"pvfile\" Table \"tablefile\"";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label2.Location = new System.Drawing.Point(417, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(235, 31);
			this.label2.TabIndex = 10;
			this.label2.Text = "Tes Download File";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnsaveupload
			// 
			this.btnsaveupload.BackColor = System.Drawing.Color.White;
			this.btnsaveupload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnsaveupload.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsaveupload.ForeColor = System.Drawing.Color.Teal;
			this.btnsaveupload.Location = new System.Drawing.Point(201, 233);
			this.btnsaveupload.Name = "btnsaveupload";
			this.btnsaveupload.Size = new System.Drawing.Size(89, 24);
			this.btnsaveupload.TabIndex = 11;
			this.btnsaveupload.Text = "Save File";
			this.btnsaveupload.UseVisualStyleBackColor = false;
			this.btnsaveupload.Click += new System.EventHandler(this.BtnsaveuploadClick);
			// 
			// btnsavedownload
			// 
			this.btnsavedownload.BackColor = System.Drawing.Color.White;
			this.btnsavedownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnsavedownload.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsavedownload.ForeColor = System.Drawing.Color.Teal;
			this.btnsavedownload.Location = new System.Drawing.Point(563, 233);
			this.btnsavedownload.Name = "btnsavedownload";
			this.btnsavedownload.Size = new System.Drawing.Size(89, 24);
			this.btnsavedownload.TabIndex = 13;
			this.btnsavedownload.Text = "Save File";
			this.btnsavedownload.UseVisualStyleBackColor = false;
			this.btnsavedownload.Click += new System.EventHandler(this.BtnsavedownloadClick);
			// 
			// btnopendownload
			// 
			this.btnopendownload.BackColor = System.Drawing.Color.White;
			this.btnopendownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnopendownload.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnopendownload.ForeColor = System.Drawing.Color.Teal;
			this.btnopendownload.Location = new System.Drawing.Point(418, 233);
			this.btnopendownload.Name = "btnopendownload";
			this.btnopendownload.Size = new System.Drawing.Size(89, 24);
			this.btnopendownload.TabIndex = 12;
			this.btnopendownload.Text = "Open File";
			this.btnopendownload.UseVisualStyleBackColor = false;
			this.btnopendownload.Click += new System.EventHandler(this.BtnopendownloadClick);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(418, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "input id gambar untuk di load";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label6.Location = new System.Drawing.Point(55, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(235, 31);
			this.label6.TabIndex = 16;
			this.label6.Text = "Tes Upload File";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.pictureBox1.Location = new System.Drawing.Point(55, 63);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(235, 152);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// input_id
			// 
			this.input_id.Location = new System.Drawing.Point(564, 188);
			this.input_id.Name = "input_id";
			this.input_id.Size = new System.Drawing.Size(87, 20);
			this.input_id.TabIndex = 17;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.FileName = "saveFileDialog";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(716, 646);
			this.Controls.Add(this.input_id);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnsavedownload);
			this.Controls.Add(this.btnopendownload);
			this.Controls.Add(this.btnsaveupload);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnopenupload);
			this.Controls.Add(this.pictureBox2);
			this.Name = "MainForm";
			this.Text = "Tugas2_PV2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.TextBox input_id;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnopendownload;
		private System.Windows.Forms.Button btnsavedownload;
		private System.Windows.Forms.Button btnsaveupload;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnopenupload;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}
