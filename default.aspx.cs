using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ManagementSuite.Web.UI;
using ManagementSuite.Web.UI.Controls;

public partial class _Default : UIPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //FooterLiteral.Text = GetFooterLinks("").ToLower();
        MyAccountHL.NavigateUrl = "http://DreamStudio.com";
        MyAccountHL.Text = "&copy; " + DateTime.Now.Year.ToString() + " DreamStudio Interactive, Inc.";
        MyAccountHL.CssClass = "tinytext";
    }
}
