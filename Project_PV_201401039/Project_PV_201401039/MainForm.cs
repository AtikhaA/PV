/*
 * Created by SharpDevelop.
 * User: tikam
 * Date: 14/05/2022
 * Time: 17:16
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
using System.Data.OleDb;

namespace Project_PV_201401039
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = Localhost; Database = projectpv; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBox_status.Items.Add("Aktif");
			comboBox_status.Items.Add("Tidak Aktif");
		}
		
		public void readdata(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from dirma";
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
		
		public void insertdata(){
			try{
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "insert into dirma values('"+tb_nama.Text+"','"+tb_nim.Text+"','"+tb_email.Text+"','"+tb_angkatan.Text+"','"+tb_fakultas.Text+"','"+tb_programstudi.Text+"','"+comboBox_status.Text+"','"+tb_ips1.Text+"','"+tb_ips2.Text+"','"+tb_ips3.Text+"','"+tb_ipk.Text+"')";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readdata();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void updatedata(){
			try{
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "update dirma set nama = '"+tb_nama.Text+"',nim = '"+tb_nim.Text+"',email = '"+tb_email.Text+"',angkatan = '"+tb_angkatan.Text+"',fakultas = '"+tb_fakultas.Text+"',jurusan = '"+tb_programstudi.Text+"',status = '"+comboBox_status.Text+"',ips1 = '"+tb_ips1.Text+"',ips2 = '"+tb_ips2.Text+"',ips3 = '"+tb_ips3.Text+"',ips3 = '"+tb_ipk.Text+"' where nim = '"+tb_nim.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readdata();
				}
				co.Close();
			}
			catch(Exception ex){
					MessageBox.Show(ex.ToString());
			}
		}
		
		public void deletedata(){
			try{
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "delete from dirma where nim = '"+tb_nim.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readdata();
				}
				co.Close();
			}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
		}
		
		public void finddata(){
			try{
				co.Open();
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from dirma where nim like '%"+formpencarian.Text+"%' or nama like '%"+formpencarian.Text+"%'";
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
		
		
		void Btn_insertClick(object sender, EventArgs e)
		{
			double ips1, ips2, ips3, ipk;
			ips1 = double.Parse(this.tb_ips1.Text);
			ips2 = double.Parse(this.tb_ips2.Text);
			ips3 = double.Parse(this.tb_ips3.Text);
			ipk = (ips1+ips2+ips3)/3;
			this.tb_ipk.Text = ipk.ToString();
			insertdata();
		}
		
		void Btn_deleteClick(object sender, EventArgs e)
		{
			deletedata();
		}
		
		void Btn_updateClick(object sender, EventArgs e)
		{
			double ips1, ips2, ips3, ipk;
			ips1 = double.Parse(this.tb_ips1.Text);
			ips2 = double.Parse(this.tb_ips2.Text);
			ips3 = double.Parse(this.tb_ips3.Text);
			ipk = (ips1+ips2+ips3)/3;
			this.tb_ipk.Text = ipk.ToString();
			updatedata();
		}
		
		void Btn_refreshClick(object sender, EventArgs e)
		{
			readdata();
		}
		
		void FormpencarianTextChanged(object sender, EventArgs e)
		{
			finddata();
		}
		
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			tb_nama.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			tb_nim.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			tb_email.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			tb_angkatan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			tb_fakultas.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			tb_programstudi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			comboBox_status.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			tb_ips1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			tb_ips2.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			tb_ips3.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
			tb_ipk.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
		}
	}
}
