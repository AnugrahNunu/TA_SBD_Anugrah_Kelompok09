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
    public partial class Dashboard : System.Web.UI.Page
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
            cmd.CommandText = "SELECT nama AS \"Nama\", age AS \"Age\", weight AS \"Weight\", speciality AS \"Style\", division as \"Division\", name_coach as \"Coach\", name_camp as \"Camp\", position as \"Rank\" FROM FighterDB WHERE VISIBLE=1 ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void FighterDB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fighter.aspx");
        }

        protected void RankDB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rank.aspx");
        }

        protected void CoachDB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Coach.aspx");
        }

        protected void CampDB_Click(object sender, EventArgs e)
        {
            Response.Redirect("CampTraining.aspx");
        }

        protected void Refresh_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "SELECT nama AS \"Nama\", age AS \"Age\", weight AS \"Weight\", speciality AS \"Style\", division as \"Division\", name_coach as \"Coach\", name_camp as \"Camp\", position as \"Rank\" FROM FighterDB WHERE VISIBLE=1 ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT nama AS \"Nama\", age AS \"Age\", weight AS \"Weight\", speciality AS \"Style\", division as \"Division\", name_coach as \"Coach\", name_camp as \"Camp\", position as \"Rank\" FROM FighterDB WHERE VISIBLE=1 AND nama LIKE '%" + txtSearchName.Text.ToString() + "%'";
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