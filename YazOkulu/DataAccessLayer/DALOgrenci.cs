using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (OGRAD, OGRSOYAD, OGRNUMARA, OGRFOTO, OGRSIFRE) Values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.AD);
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from TBLOGRENCI", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["OGRID"].ToString());
                ent.AD = dr["OGRAD"].ToString();
                ent.SOYAD = dr["OGRSOYAD"].ToString();
                ent.NUMARA = dr["OGRNUMARA"].ToString();
                ent.FOTOGRAF = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("delete from TBLOGRENCI where OGRID=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("select * from TBLOGRENCI where OGRID=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.AD = dr["OGRAD"].ToString();
                ent.SOYAD = dr["OGRSOYAD"].ToString();
                ent.NUMARA = dr["OGRNUMARA"].ToString();
                ent.FOTOGRAF = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5=new SqlCommand("Update TBLOGRENCI set OGRAD=@p1, OGRSOYAD=@p2, OGRNUMARA=@p3, OGRFOTO=@p4, OGRSIFRE=@p5 where OGRID=@p6", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", deger.AD);
            komut5.Parameters.AddWithValue("@p2", deger.SOYAD);
            komut5.Parameters.AddWithValue("@p3", deger.NUMARA);
            komut5.Parameters.AddWithValue("@p4", deger.FOTOGRAF);
            komut5.Parameters.AddWithValue("@p5", deger.SIFRE);
            komut5.Parameters.AddWithValue("@p6", deger.ID);
            return komut5.ExecuteNonQuery() > 0;
        }

    }
}
