using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_1920_T1
{
    public partial class cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se cookie já existe
            HttpCookie cookie = Request.Cookies["SI_T1"];
            if (cookie != null)
                divAviso.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            divAviso.Visible = false;
            HttpCookie novo = new HttpCookie("SI_T1");
            novo.Value = "Aceitou";
            novo.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Add(novo);
        }
    }
}