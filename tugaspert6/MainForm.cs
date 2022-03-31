/*
 * Created by SharpDevelop.
 * User: User
 * Date: 03/12/2021
 * Time: 22:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace tubes_LabSMDB
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = tubes_smdb; Uid= root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from karyawan";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void InsertData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText="insert into karyawan values('"+kode_barangTextBox.Text+"','"+nama_barangTextBox.Text+"','"+harga_jualTextBox.Text+"','"+harga_beliTextBox.Text+"','"+Jumlah_barangTextBox.Text+"','"+satuan_barangTextBox.Text+"')";
				myadapter.SelectCommand= mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void UpdateData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText = "update karyawan set ID_Karyawan='"+kode_barangTextBox.Text+"',Nama_Depan='"+nama_barangTextBox.Text+"',Nama_Belakang='"+harga_jualTextBox.Text+"',Alamat='"+harga_beliTextBox.Text+"',Kode_Pos='"+Jumlah_barangTextBox.Text+"',No_Telepon='"+satuan_barangTextBox.Text+"' where ID_Karyawan ='"+kode_barangTextBox.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void DeleteData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText="delete from karyawan where ID_Karyawan='"+kode_barangTextBox.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void ResetData(){
			kode_barangTextBox.Text="";
			nama_barangTextBox.Text="";
			harga_jualTextBox.Text="";
			harga_beliTextBox.Text="";
			Jumlah_barangTextBox.Text="";
			satuan_barangTextBox.Text="";
		}

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			ReadData();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			InsertData();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			UpdateData();		
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			DeleteData();		
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			kode_barangTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			nama_barangTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			harga_jualTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			harga_beliTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();	
			Jumlah_barangTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();	
			satuan_barangTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();				
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			ResetData();			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			Application.Exit();		
		}
		
		
		
	}
}
