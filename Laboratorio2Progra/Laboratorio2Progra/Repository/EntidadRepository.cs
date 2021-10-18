using Laboratorio2Progra.Data;
using Laboratorio2Progra.Dominio;
using Laboratorio2Progra.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2Progra.Repository
{
    public class EntidadRepository : IEntidad
    {
        private ApplicationDbContext app;

        public EntidadRepository(ApplicationDbContext app)
        {
            this.app = app;
        }

        public ICollection<Entidad> Listardatos()
        {
            return app.persona.ToList();
        }

        public void Save(Entidad E)
        {
            app.Add(E);
            app.SaveChanges();
        }
    }
}
