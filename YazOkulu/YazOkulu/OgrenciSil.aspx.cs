using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OGRID"]);
        Response.Write(x);
        EntityOgrenci ent=new EntityOgrenci();
        ent.ID = x;
        BLLOgrenci.OgrenciSilBLL(ent.ID);
        Response.Redirect("OgrenciListesi.aspx");
    }
}