using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelManager.Data
{
    [Table("Cadres")]
    public class Cadre : Employe
    {
        public Cadre()
        {
            this.Statut = StatutEmploye.Cadre;
        }

        [Required]
        public decimal SalaireMensuel { get; set; }
    }
}
