using Gestionnaire_De_TachesMvc.Models;

namespace Gestionnaire_De_TachesMvc.Services
{
    public interface ITacheServices
    {
        IEnumerable<Taches> GetTaches();

        Taches GetByTache(int id);

        void Create (Taches tache);

        void Delete (int Id);

        void Update (Taches tache);
    }
}
