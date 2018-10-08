using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonnelManager.Dal.Data;
using PersonnelManager.Dal.Entites;

namespace PersonnelManager.Business.Tests
{
    class FauxDataEmploye : IDataEmploye
    {
        public void EnregistrerCadre(Cadre cadre)
        {
        }

        public void EnregistrerOuvrier(Ouvrier ouvrier)
        {
        }

        public Cadre GetCadre(int idCadre)
        {
            return null;
        }

        public IEnumerable<Cadre> GetListeCadres()
        {
            return null;
        }

        public IEnumerable<Ouvrier> GetListeOuvriers()
        {
            return null;
        }

        public Ouvrier GetOuvrier(int idOuvrier)
        {
            return null;
        }
    }
}
