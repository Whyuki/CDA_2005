using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomainePersistance
{
    public interface IPersistanceFournisseur
    {
        int InsertFournisseur(sFournisseur fournisseur);
        bool UpdateFournisseur(sFournisseur fournisseur);
        bool DeleteFournisseur(sFournisseur fournisseur);
        sFournisseur GetFournisseur(int id);
        Dictionary<int, string> GetListFournisseurs();
    }
}
