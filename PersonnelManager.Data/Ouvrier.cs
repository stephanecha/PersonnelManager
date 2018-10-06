using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelManager.Data
{
    [Table("Ouvriers")]
    public class Ouvrier : Employe
    {
        public Ouvrier()
        {
            this.Statut = StatutEmploye.Ouvrier;
        }

        [Required]
        public decimal TauxHoraire { get; set; }
    }
}
