using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static MyResponse Test(MyClass request)
        {
            return new MyResponse()
            {
                Code = 200,
                Message = "Success",
                Result = Guid.NewGuid().ToString("N"),
                Data = request,
            };
        }

        [WebMethod]
        public static string Test2()
        {
            return "Test";
        }
    }
}