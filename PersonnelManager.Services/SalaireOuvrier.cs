using System;
using PersonnelManager.Data;

namespace PersonnelManager.Services
{
    public class SalaireOuvrier : Salaire
    {
        public SalaireOuvrier(DateTime mois, Employe employe)
            : base(mois, employe)
        {
        }

        public decimal NombreHeures { get; set; }

        public decimal TauxHoraire { get; set; }
    }
}
