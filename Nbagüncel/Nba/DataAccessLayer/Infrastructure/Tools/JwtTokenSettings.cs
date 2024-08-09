using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure.Tools
{
    public class JwtTokenSettings
    {
        public const string Issuer = "http://localhost";
        public const string Audince = "http://localhost";
        public const string Key = "atalayatalayatalay";
        public const int Expire = 30;

    }
}
