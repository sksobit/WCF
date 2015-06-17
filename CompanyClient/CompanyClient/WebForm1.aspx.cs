using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CompanyClient.CompanyService;

namespace CompanyClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyPublicServiceClient companyPublicServiceClient = new CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            Label1.Text = companyPublicServiceClient.GetPublicInformation();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyConfidentialServiceClient companyConfidentialServiceClient = new CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
            Label2.Text = companyConfidentialServiceClient.GetConfidentialInformation();
        }
    }
}