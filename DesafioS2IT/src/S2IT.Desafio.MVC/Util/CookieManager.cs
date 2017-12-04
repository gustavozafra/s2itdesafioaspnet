using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S2IT.Desafio.MVC
{
    public static class CookieManager
    {
        public static long UsuarioId
        {
            get
            {
                return Int64.Parse(HttpContext.Current.Session["userid"].ToString());
            }
            set
            {
                HttpContext.Current.Session["userid"] = value;
            }
        }
    }
}