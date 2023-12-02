using System;

namespace xxCineStar_webForms
{
    public partial class peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (id != null && ( id == "cartelera" || id == "estrenos") )
            {
                rptPeliculas.DataSource = new dao.PeliculaDAO().getPeliculas( id == "cartelera" ? 1 : 2);
                rptPeliculas.DataBind();
            }
            else Response.Redirect("index.aspx");
        }
    }
}