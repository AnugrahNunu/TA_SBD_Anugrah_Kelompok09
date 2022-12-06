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
    public partial class Coach : System.Web.UI.Page
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
            cmd.CommandText = "SELECT id_coach AS \"ID\", name_coach AS \"Name\", age_coach AS \"Age\", career AS \"Career\" FROM coach WHERE VISIBLE=1 ";
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
            cmd.CommandText = "SELECT id_coach AS \"ID\", name_coach AS \"Name\", age_coach AS \"Age\", career AS \"Career\" FROM coach WHERE VISIBLE=1 ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIdCoach.Text == "" || txtNameCoach.Text == "" || txtAgeCoach.Text  == "" || txtCareer.Text ==  "" || txtIdFighter.Text== "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Seluruh Form Terlebih Dulu </span>");
            }   
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Insert Into coach(id_coach, name_coach, age_coach, career, id_fighter, visible)values('" + txtIdCoach.Text + "', '" + txtNameCoach.Text.ToString() + "', '" + txtAgeCoach.Text.ToString() + "','" + txtCareer.Text.ToString() + "',  '" + txtIdFighter.Text + "', 1 )";
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
            if (txtIdCoach.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Kolom ID Terlebih Dulu</span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "update coach set visible = 0 where id_coach = " + txtIdCoach.Text;
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
            if (txtIdCoach.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Kolom ID Terlebih Dulu</span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Delete from coach where id_coach= " + txtIdCoach.Text;
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
            if (txtIdCoach.Text == "" || txtNameCoach.Text == "" || txtAgeCoach.Text == "" || txtCareer.Text == "" || txtIdFighter.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Seluruh Form Terlebih Dulu </span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Update coach set name_coach='" + txtNameCoach.Text.ToString() + "', age_coach='" + txtAgeCoach.Text.ToString() + "', career='" + txtCareer.Text.ToString() + "', id_fighter='" + txtIdFighter.Text + "', visible=1  WHERE id_coach='" + txtIdCoach.Text + "'";
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
            if (txtIdCoach.Text == "")
            {
                Response.Write("<span style= 'color:white; font-weight: bold;'> Isi Kolom ID Terlebih Dulu</span>");
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "update coach set visible = 1 where id_coach = " + txtIdCoach.Text;
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
            txtIdCoach.Text = null;
            txtNameCoach.Text = null;
            txtAgeCoach.Text = null;
            txtCareer.Text = null;
            txtIdFighter.Text = null;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT id_coach AS \"ID\", name_coach AS \"Name\", age_coach AS \"Age\", career AS \"Career\" FROM coach WHERE VISIBLE=1 AND name_coach LIKE '%" + txtSearchName.Text.ToString() + "%' OR age_coach like '%" + txtSearchAge.Text.ToString() + "%'";
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