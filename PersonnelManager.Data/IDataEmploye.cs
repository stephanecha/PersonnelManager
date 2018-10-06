using System.Collections.Generic;

namespace PersonnelManager.Data
{
    public interface IDataEmploye
    {
        void EnregistrerOuvrier(Ouvrier ouvrier);

        void EnregistrerCadre(Cadre cadre);

        IEnumerable<Cadre> GetListeCadres();

        IEnumerable<Ouvrier> GetListeOuvriers();

        Ouvrier GetOuvrier(int idOuvrier);

        Cadre GetCadre(int idCadre);
    }
}
