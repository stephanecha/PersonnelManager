using System.Collections.Generic;

namespace PersonnelManager.Data
{
    public interface IDataPeriode
    {
        void EnregistrerPeriode(Periode periode);

        IEnumerable<Periode> GetListePeriodes();

        Periode GetPeriode(int idPeriode);
    }
}
