using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonnelManager.Data;

namespace PersonnelManager.Services
{
    public class Salaire
    {
        public Salaire(DateTime mois, Employe employe)
        {

        }

        public DateTime Mois { get; set; }

        public Employe Employe { get; set; }


        public decimal SalaireTotal { get; set; }
    }
}
