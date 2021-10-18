using Laboratorio2Progra.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2Progra.Service
{
    public interface IEntidad
    {
        void Save(Entidad E);

        ICollection<Entidad> Listardatos();
    }
}
