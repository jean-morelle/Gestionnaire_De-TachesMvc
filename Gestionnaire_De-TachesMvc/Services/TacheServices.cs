using Gestionnaire_De_TachesMvc.Models;
using Gestionnaire_De_TachesMvc.Repertory;

namespace Gestionnaire_De_TachesMvc.Services
{
    public class TacheServices : ITacheServices
    {
        private readonly ITacheRepertory repertory;

        public TacheServices( ITacheRepertory repertory)
        {
            this.repertory = repertory;
        }

        public void Create(Taches tache)
        {
           repertory.Create(tache);
        }

        public void Delete(int Id)
        {
            repertory.Delete(Id);
        }

        public Taches GetByTache(int id)
        {
           return repertory.GetById(id);
        }

        public IEnumerable<Taches> GetTaches()
        {
            return repertory.GetAll();
        }

        public void Update(Taches tache)
        {
          repertory.Update(tache);
        }
    }
}
