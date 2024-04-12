using Gestionnaire_De_TachesMvc.Data;
using Gestionnaire_De_TachesMvc.Models;

namespace Gestionnaire_De_TachesMvc.Repertory
{
    public class TacheRepertory : ITacheRepertory
    {
        private readonly ApplicationDbContext applicationDb;

        public TacheRepertory( ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }

        public void Create(Taches tache)
        {
            applicationDb.taches.Add(tache);
        }

        public void Delete(int Id)
        {
            applicationDb.taches.Remove(GetById(Id));
            applicationDb.SaveChanges();
        }

        public IEnumerable<Taches> GetAll()
        {
            return applicationDb.taches;
        }

        public Taches GetById(int Id)
        {
            return applicationDb.taches.Find(Id);
        }

        public void Update(Taches tache)
        {
            applicationDb.taches.Update(tache);
            applicationDb.SaveChanges();
        }
    }
}
