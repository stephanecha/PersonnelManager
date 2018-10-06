using System.Collections.Generic;

namespace PersonnelManager.Data
{
    public interface IDataReleve
    {
        void EnregistrerReleveMensuel(ReleveMensuel releveMensuel);

        IEnumerable<ReleveMensuel> GetListeRelevesMensuels(int idOuvrier);

        ReleveMensuel GetReleveMensuel(int idReleveMensuel);
    }
}
