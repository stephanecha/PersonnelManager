using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonnelManager.Data;

namespace PersonnelManager.Models
{
    public class ListeRelevesViewModel
    {
        public int IdOuvrier { get; set; }

        public IEnumerable<ReleveMensuel> RelevesMensuels { get; set; }

        public IEnumerable<Periode> PeriodesOuvertes { get; set; }
    }
}