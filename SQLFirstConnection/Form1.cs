using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLFirstConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ExcNQ($"INSERT INTO TbEitems(Name,Price,Description) " +
                  $" VALUES('{txtName.Text}',{txtPrice.Text},'{txtDesc.Text}')");

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ExcNQ($"  Update  TbEitems" +
                  $"  set Name='{txtNameToUpdate.Text}' , Price={TxtPriceToUpdate.Text} , Description='{txtDescToUpdate.Text}'" +
                  $"  where BarCode={txtBarCodeToUpdate.Text}");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExcNQ($"  Delete TbEitems " +
                  $"  where BarCode={txtBarCodeD.Text}");
        }
        private void ExcNQ(string comTxt)
        {
            string conSTR = @"Data Source=EQCOMPUTER\SQLEXPRESS;Initial Catalog=FirstRelation;Integrated Security=True";//DBמשתנה של נתוני ה 
            SqlConnection con = new SqlConnection(conSTR);//פעולת החיבור
            SqlCommand com = new SqlCommand(comTxt, con);//פעולת ההוראה 
            con.Open();
            int result = com.ExecuteNonQuery();
            con.Close();
            ShowItems();
            MessageBox.Show((result == 1 ? " " : "Not ") + "Succeeded");
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            ShowItems();
        }
        private void ShowItems()
        {
            string Output = "";
            string conSTR = @"Data Source=EQCOMPUTER\SQLEXPRESS;Initial Catalog=FirstRelation;Integrated Security=True";
            SqlConnection con = new SqlConnection(conSTR);
            string orderby;
            if (rdbBarcode.Checked)
                orderby = "BarCode";
            else if (rdbName.Checked)
                orderby = "Name";
             else
                orderby = "Price";

            SqlCommand com = new SqlCommand(
                $"Select * " +
                $" from TbEitems " +
                $" Order by {orderby}", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
                Output += reader["BarCode"] + "," + reader["Name"] + "," + reader["Price"] + "," + reader["Description"] + "\n";
            con.Close();
            lblResult.Text = Output;
            ShowDGVItems();
        }
        private void ShowDGVItems()
        {
            string Output = "";
            string conSTR = @"Data Source=EQCOMPUTER\SQLEXPRESS;Initial Catalog=FirstRelation;Integrated Security=True";
            SqlConnection con = new SqlConnection(conSTR);
            string orderby;
            if (rdbBarcode.Checked)
                orderby = "BarCode";
            else if (rdbName.Checked)
                orderby = "Name";
            else
                orderby = "Price";

            SqlCommand com = new SqlCommand(
                $"Select * " +
                $" from TbEitems " +
                $" Order by {orderby}", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            DataTable Items = new DataTable();
            Items.Load(reader);
            dgvItems.DataSource = Items;
            con.Close();
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void rdbBarcode_CheckedChanged(object sender, EventArgs e)
        {
            ShowItems();
        }
    }
}
