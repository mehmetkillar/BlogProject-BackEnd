using System;
using System.Collections.Generic;
using System.Text;

namespace MKProject.UdemyBlog.Business.StringInfos
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost:54111";
        public const string Audience = "http://localhost:5000";
        public const string SecurityKey = "mehmetmehmetmehmet1";
        public const double Expires = 40;
    }
}
