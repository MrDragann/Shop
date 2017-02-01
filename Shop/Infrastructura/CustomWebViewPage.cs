using IServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Shop.Infrastructura
{
    public class CustomWebViewPage : WebViewPage
    {
        public CustomWebViewPage()
        {
            User = WebUser.CurrentUser;
        }

        public new ModelUser User { get; set; }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class CustomWebViewPage<T> : WebViewPage<T>
    {
        public CustomWebViewPage()
        {
            User = WebUser.CurrentUser;
        }
        public new ModelUser User { get; set; }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}