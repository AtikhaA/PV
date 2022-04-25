/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 12/18/2021
 * Time: 2:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace Tugas1_PV2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = pv2_tugas1; Uid= root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ReadData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from artist";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void InsertData(){
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="insert into artist values('"+name.Text+"','"+year.Text+"','"+label.Text+"')";
				myadapter.SelectCommand= mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void ChangeData(){
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText = "update artist set name='"+name.Text+"', year='"+year.Text+"', label='"+label.Text+"' where year ='"+year.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void DeleteData(){
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="delete from artist where year='"+year.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			InsertData();
		}
			
		void BtnChangeClick(object sender, EventArgs e)
		{
			ChangeData();
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			DeleteData();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			name.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			year.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			label.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
		}
	}
}
