using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1
{
    public partial class Webform1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblInfo.Visible = false;
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LblInfo.Visible = true;
                LblInfo.Text += "<br/> Registration Done!!!";
                LblInfo.Text += "CustomerName:" + TxtName.Text;
                LblInfo.Text += "<br/> CustomerMobile:" + TxtMobile.Text;
                LblInfo.Text += "<br/> Email:" + TxtEmail.Text;
                LblInfo.Text += "<br/> Password:" + TxtPassword.Text;
            }
           
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
          
            args.IsValid = TxtName.Text.Length >= 6;
        }
    }
}