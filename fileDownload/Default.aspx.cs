using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fileDownload
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var theValue = button.Attributes["Name"].ToString();
                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + theValue);
                Response.TransmitFile(Server.MapPath("~/Content/" + theValue));
                Response.End();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var theValue = button.Attributes["Name"].ToString();
            Response.Clear();
            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + theValue);
            Response.TransmitFile(Server.MapPath("~/Content/" + theValue));
            Response.End();
        }
    }
}