using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Server=127.0.0.1;Database=DbYazOkulu;User Id=DbYazOkulu;Password=BRuNLm3@$bBTWi");
    }
}