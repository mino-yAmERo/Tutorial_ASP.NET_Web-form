using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicASPweb.WebTutorial
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmessage.Text += "<br/>";
            lblmessage.Text += "Page load event handled. <br />";

            if (Page.IsPostBack)
            {
                lblmessage.Text += "Page post back event handled.<br/>";
            }
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

        protected void Page_Init(object sender, EventArgs e)
        {
            lblmessage.Text += "Page initialization event handled.<br/>";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            lblmessage.Text += "Page prerender event handled. <br/>";
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
    }
}