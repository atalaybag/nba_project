using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure.Tools
{
    public class JwtTokenResponse
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }

        public JwtTokenResponse(string token,DateTime expireDate)
        {
            ExpireDate = expireDate;
            Token = token;
        }
    }
}
