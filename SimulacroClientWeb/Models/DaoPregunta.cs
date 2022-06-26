using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimulacroClientWeb.Models
{
    public class DaoPregunta
    {
        public void preguntasIns(preguntas pregunta)
        {
            using (var db = new ModelExamen())
            {
                db.preguntas.Add(pregunta);
                db.SaveChanges();
            }
        }
    }
}