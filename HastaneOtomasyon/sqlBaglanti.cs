using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneOtomasyon
{
    class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=MUSTAFA;Initial Catalog=Db_Hastane;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
