using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaDL.Helpers
{
    public static class SqlHelper
    {
        private static readonly string _connectionStr =
               @"Server=DESKTOP-GTVND9D;Database=ProniaProjectDB;Trusted_Connection=True;TrustServerCertificate=True;";

        
        public static string GetConnectionString(string _connectionStr)
        {
            return _connectionStr;
        }

        internal static string? GetConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}
