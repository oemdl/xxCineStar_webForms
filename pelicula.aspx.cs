using System;

namespace xxCineStar_webForms
{
    public partial class pelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;
            string idd = Request.QueryString["id"];
            if (idd != null && int.TryParse(idd, out id))
            {
                fvPelicula.DataSource = new dao.PeliculaDAO().getPelicula(id);
                fvPelicula.DataBind();
            }
            else Response.Redirect("index.aspx");
        }
    }
}