using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }
        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if (p.BASOGRID != 0 && p.BASDERSID != 0)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
