using System.Collections.Generic;
using System.Data;
using xxCineStar_webForms.bean;
using xxCineStar_webForms.db;

namespace xxCineStar_webForms.dao
{
    public class PeliculaDAO
    {
        Db db = new Db("cnCineStar");

        internal object getPelicula(int id)
        {
            db.Sentencia("sp_getPelicula " + id);
            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula(db.getDataRow()));
            return peliculas;
            //return db.getDataTable();
        }

        internal object getPeliculas(int id)
        {
            db.Sentencia( "sp_getPeliculas " +  id );
            DataTable dt = db.getDataTable();
            
            if (dt != null || dt.Rows.Count > 0)
            {
                List<Pelicula> peliculas = new List<Pelicula>();
                foreach (DataRow dr in dt.Rows)
                    peliculas.Add( new Pelicula(dr) );

                return peliculas;
            }
           
            return null;
        }

    }
}