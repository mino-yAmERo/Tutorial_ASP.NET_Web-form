using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Web.Services;

namespace BasicASPweb.WebTutorial
{
    public partial class WebForm1 : System.Web.UI.Page 
    {
        public String mystr;
        public int i;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = i+1;
            lblmessage.Text += "<br/>";
            lblmessage.Text += "Page load event handled. <br />";
            
            if (Page.IsPostBack)
            {
                
                lblmessage.Text += "Page post back event handled.<br/>";
                if (System.Web.HttpContext.Current.Session["str"] != null) {
                    this.Session["count"] = (int)this.Session["count"] + 1;
                    btnstr.Attributes.Add("class", " disabled");
                    lblsession.Text = "Hello, " + this.Session["count"] + " times " + (String)this.Session["str"];
                    
                } 
            } else
            {
                this.Session["count"] = count;
            }

            
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            lblmessage.Text += "Page initialization event handled.<br/>";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            lblmessage.Text += "Page prerender event handled. <br/>";
        }

        protected void convertToUpper(object sender, EventArgs e)
        {
            string str = myTxt.Value;
            if (myTxt.Value == "")
            {
                txtLog.InnerHtml = "Your input cannot be empty";
                Console.WriteLine("Hello");
                myTxt.Value = "";
                return;
            }
            else
            {
                txtLog.InnerHtml = str.ToUpper();
            }
        }
        protected void btnclick_Click(object sender, EventArgs e)
        {
            lblmessage.Text += "Button click event handled. <br/>";
        }
        protected void btnclick_Reset(object sender, EventArgs e)
        {
            lblmessage.Text = "";
        }
        protected void btnclick_Show(object sender, EventArgs e)
        {
            lblmessage.Text += "Button Show/Hide click event handled. <br/>";

            if (lblmessage.CssClass == " ")
            {
                lblmessage.CssClass = lblmessage.CssClass.Replace(" ", "d-none");
                btnShow.CssClass = btnShow.CssClass.Replace("btn-danger", "btn-primary");
                btnShow.Text = "Show";
            }
            else
            {
                lblmessage.CssClass = lblmessage.CssClass.Replace("d-none", " ");
                btnShow.CssClass = btnShow.CssClass.Replace("btn-primary", "btn-danger");
                btnShow.Text = "Hide";
            }
            
        }
        protected void btnstr_Click(object sender, EventArgs e)
        {
            //Set Session from input box
            this.mystr = txtstr.Value;
            this.Session["str"] = txtstr.Value;
            this.lblsession.Text = "Welcome, "+(String)this.Session["str"];
            txtstr.Value = " ";
        }
        [WebMethod]
        public static List<userInfoModel> CreateDataSet()
        {
            MySql.Data.MySqlClient.MySqlConnection objConn = new MySql.Data.MySqlClient.MySqlConnection();
            MySql.Data.MySqlClient.MySqlCommand objCmd = new MySql.Data.MySqlClient.MySqlCommand();
            MySql.Data.MySqlClient.MySqlDataAdapter dtAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter();

            DataSet ds = new DataSet();
            System.Data.DataTable dt = new DataTable();
            String strConnString, strSQL;

            strConnString = "Server=184.168.102.44;User Id=nutthabhas; Password=off11294; Database=my_db;Pooling=false";

            strSQL = "SELECT * FROM UserInfo";

            objConn.ConnectionString = strConnString;

            objCmd.Connection = objConn;
            objCmd.CommandText = strSQL;
            objCmd.CommandType = CommandType.Text;

            dtAdapter.SelectCommand = objCmd;
            dtAdapter.Fill(dt);
            dtAdapter = null;

            List<userInfoModel> lsUserInfo = new List<userInfoModel>();
            foreach(System.Data.DataRow row in dt.Rows)
            {
                lsUserInfo.Add(new userInfoModel
                {
                    id = Convert.ToInt32(row["UserID"]),
                    name = row["Username"].ToString()
                    
                }); 
            }

            return lsUserInfo; //*** Return DataSet ***//

        }

        
    }
    public class userInfoModel
    {
        public int id { get; set;  } 
        public string name { get; set;  } 

    }
}