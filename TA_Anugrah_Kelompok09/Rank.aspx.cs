using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TA_Anugrah_Kelompok09
{
    public partial class Rank : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=  DESKTOP-ILGRLJN; Initial Catalog = TugasAkhir; Integrated Security = True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }

        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT id_rank AS \"ID\", position AS \"Rank\", Division FROM rank WHERE VISIBLE=1";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void Refresh_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "SELECT id_rank AS \"ID\", position AS \"Rank\", Division FROM rank WHERE VISIBLE=1";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void Dashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIdRank.Text == "" || txtPosition.Text == "" || txtDivision.Text == "" || txtIdFighter.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Seluruh Form Terlebih Dulu </span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Insert Into Rank(id_rank, position, division, id_fighter, visible)values('" + txtIdRank.Text + "', '" + txtPosition.Text.ToString() + "', '" + txtDivision.Text.ToString() + "',  '" + txtIdFighter.Text + "', 1 )";
                cmd.Connection = con;
                try { cmd.ExecuteNonQuery(); DataShow(); }
                catch (Exception)
                {
                    Response.Write("<span style= 'color:white; font-weight: bold;'> Sesuaikan Dengan Format Yang Ada </span>");

                }
            }
        }

        protected void btnSoftDelete_Click(object sender, EventArgs e)
        {
            if (txtIdRank.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Kolom ID Terlebih Dulu</span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "update Rank set visible = 0 where id_rank = " + txtIdRank.Text;
                cmd.Connection = con;
                try { cmd.ExecuteNonQuery(); DataShow(); }
                catch (Exception)
                {
                    Response.Write("<span style= 'color:white; font-weight: bold;'> Masukan ID Berupa Angka</span>");

                }
            }
        }

        protected void btnHardDelete_Click(object sender, EventArgs e)
        {
            if (txtIdRank.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Kolom ID Terlebih Dulu</span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Delete from Rank where id_rank= " + txtIdRank.Text;
                cmd.Connection = con;
                try { cmd.ExecuteNonQuery(); DataShow(); }
                catch (Exception)
                {
                    Response.Write("<span style= 'color:white; font-weight: bold;'> Masukan ID Berupa Angka</span>");

                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdRank.Text == "" || txtPosition.Text == "" || txtDivision.Text == "" || txtIdFighter.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Seluruh Form Terlebih Dulu </span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Update Rank set position='" + txtPosition.Text.ToString() + "', division='" + txtDivision.Text.ToString() + "', id_fighter='" + txtIdFighter.Text + "', visible=1  WHERE id_rank='" + txtIdRank.Text + "'";
                cmd.Connection = con;
                try { cmd.ExecuteNonQuery(); DataShow(); }
                catch (Exception)
                {
                    Response.Write("<span style= 'color:white; font-weight: bold;'> Sesuaikan Dengan Format Yang Ada </span>");

                }
            }
        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtIdRank.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Kolom ID Terlebih Dulu</span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "update Rank set visible = 1 where id_rank = " + txtIdRank.Text;
                cmd.Connection = con;
                try { cmd.ExecuteNonQuery(); DataShow(); }
                catch (Exception)
                {
                    Response.Write("<span style= 'color:white; font-weight: bold;'> Masukan ID Berupa Angka</span>");

                }
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtIdRank.Text = null;
            txtPosition.Text = null;
            txtDivision.Text = null;
            txtIdFighter.Text = null;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT id_rank AS \"ID\", position AS \"Rank\", Division FROM rank WHERE VISIBLE=1 AND position LIKE '%" + txtSearchPosition.Text.ToString() + "%' OR division like '%" + txtSearchDivision.Text.ToString() + "%'";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }
    }
}