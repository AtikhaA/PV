/*
 * Created by SharpDevelop.
 * User: tikam
 * Date: 4/25/2022
 * Time: 4:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas1_PV2
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.year = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.TextBox();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 18);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(502, 210);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 250);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Artist";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 284);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Year";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 316);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Label";
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(94, 250);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(300, 20);
			this.name.TabIndex = 5;
			// 
			// year
			// 
			this.year.Location = new System.Drawing.Point(94, 284);
			this.year.Name = "year";
			this.year.Size = new System.Drawing.Size(300, 20);
			this.year.TabIndex = 6;
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(94, 316);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(300, 20);
			this.label.TabIndex = 7;
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(422, 250);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(65, 20);
			this.btnInsert.TabIndex = 8;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(422, 280);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(65, 26);
			this.btnChange.TabIndex = 9;
			this.btnChange.Text = "Change";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.BtnChangeClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(422, 316);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(65, 20);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 354);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.label);
			this.Controls.Add(this.year);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "Tugas1_PV2";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.TextBox label;
		private System.Windows.Forms.TextBox year;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
