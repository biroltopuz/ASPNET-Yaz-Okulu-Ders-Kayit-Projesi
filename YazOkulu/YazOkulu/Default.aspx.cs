using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.AD = TxtAd.Text;
        ent.SOYAD = TxtSoyad.Text;
        ent.NUMARA = TxtNumara.Text;
        ent.SIFRE = TxtSifre.Text;
        ent.FOTOGRAF = TxtFoto.Text;
        BLLOgrenci.OgrenciEkleBLL(ent);
    }
}