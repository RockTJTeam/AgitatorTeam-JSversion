using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Agitator.Business.Helper
{
    public class ShowMessageHelper
    {
        /// <summary>
        /// 弹出页面消息框
        /// </summary>
        /// <param name="msg"></param>
        public static void ShowMessageBox(string msg, string url = "")
        {
            msg = HttpUtility.HtmlDecode(msg);
            HttpContext.Current.Response.Write(MessageBox(msg, url));
        }

        public static string MessageBoxBackPage(string mess)
        {
            return MessageBox(mess, string.Empty, "history.go(-1);");
        }

        public static string MessageBox(string msg, string surl, string other = "")
        {
            string mask = "<script>var lurl = '{loca}';if('{message}'!=''){ alert('{message}');}if(lurl.length > 1){ location.href = lurl;} {othop} </script>";

            StringBuilder sb = new StringBuilder(mask);

            if (msg != null)
                sb.Replace("{message}", msg.Replace("'", @"\'").Replace("\r", "").Replace("\n", ""));

            sb.Replace("{loca}", surl);
            sb.Replace("{othop}", other);

            // throw new Exception(sout);

            return sb.ToString();
        }
    }
}
