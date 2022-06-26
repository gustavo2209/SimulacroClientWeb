using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimulacroClientWeb.Models
{
    public class DaoRespuestas
    {
        public void respuestasIns(respuestas respuesta)
        {
            using (var db = new ModelExamen())
            {
                db.respuestas.Add(respuesta);
                db.SaveChanges();
            }
        }
    }
}