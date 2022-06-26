using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimulacroClientWeb.Models
{
    public class DaoExamen
    {
        public List<examenes> examenesQry()
        {
            List<examenes> list = new List<examenes>();

            using (var db = new ModelExamen())
            {
                var query = from n in db.examenes select n;

                foreach (var a in query)
                {
                    examenes examen = a;

                    list.Add(examen);
                }
            }

            return list;
        }

        public void examenesIns(examenes examen)
        {
            using (var db = new ModelExamen())
            {
                db.examenes.Add(examen);
                db.SaveChanges();
            }
        }
    }
}