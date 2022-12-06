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
    public partial class Fighter : System.Web.UI.Page
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
            cmd.CommandText = "SELECT id_fighter AS \"ID\", nama AS \"Name\", age, weight, speciality AS \"Style\" FROM fighter WHERE VISIBLE=1 ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void Dashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

        protected void Refresh_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "SELECT id_fighter AS \"ID\", nama AS \"Name\", age, weight, speciality AS \"Style\" FROM fighter WHERE VISIBLE=1 ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIdFighter.Text == "" || txtNamaFighter.Text == "" || txtAgeFighter.Text == "" || txtWeight.Text == "" || txtSpeciality.Text == "" || txtIdRank.Text == "" || txtIdCoach.Text == "" || txtIdCamp.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Seluruh Form Terlebih Dulu </span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Insert Into Fighter(id_fighter, nama, age, weight, speciality, id_rank, id_coach, id_camp, visible)values('" + txtIdFighter.Text + "', '" + txtNamaFighter.Text.ToString() + "', '" + txtAgeFighter.Text.ToString() + "','" + txtWeight.Text.ToString() + "',  '" + txtSpeciality.Text.ToString() + "',  '" + txtIdRank.Text + "',  '" + txtIdCoach.Text + "',  '" + txtIdCamp.Text + "', 1 )";
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
            if (txtIdFighter.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Kolom ID Terlebih Dulu</span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "update fighter set visible = 0 where id_fighter = " + txtIdFighter.Text;
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
            if (txtIdFighter.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Kolom ID Terlebih Dulu</span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Delete from Fighter where id_fighter= " + txtIdFighter.Text;
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

            if (txtIdFighter.Text == "" || txtNamaFighter.Text == "" || txtAgeFighter.Text == "" || txtWeight.Text == "" || txtSpeciality.Text == "" || txtIdRank.Text == "" || txtIdCoach.Text == "" || txtIdCamp.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Seluruh Form Terlebih Dulu </span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Update Fighter set nama='" + txtNamaFighter.Text.ToString() + "', age='" + txtAgeFighter.Text.ToString() + "', weight='" + txtWeight.Text.ToString() + "', speciality='" + txtSpeciality.Text.ToString() + "', id_rank='" + txtIdRank.Text + "', id_coach='" + txtIdCoach.Text + "', id_camp='" + txtIdCamp.Text + "', visible=1  WHERE id_fighter='" + txtIdFighter.Text + "'";
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
            if (txtIdFighter.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Kolom ID Terlebih Dulu</span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "update fighter set visible = 1 where id_fighter = " + txtIdFighter.Text;
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
            txtIdFighter.Text = null;
            txtNamaFighter.Text = null;
            txtAgeFighter.Text = null;
            txtWeight.Text = null;
            txtSpeciality.Text = null;
            txtIdRank.Text = null;
            txtIdCoach.Text = null;
            txtIdCamp.Text = null;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT id_fighter AS \"ID\", nama AS \"Name\", age, weight, speciality AS \"Style\" FROM fighter WHERE VISIBLE=1 AND nama LIKE '%" + txtSearchName.Text.ToString() + "%' OR speciality like '%" + txtSearchStyle.Text.ToString() + "%'";
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