using Gestionnaire_De_TachesMvc.Models;

namespace Gestionnaire_De_TachesMvc.Repertory
{
    public interface ITacheRepertory
    {
        IEnumerable<Taches> GetAll();

        Taches GetById(int Id);

        void Create(Taches tache);

        void Update(Taches tache);

        void Delete(int Id);
    }
}
