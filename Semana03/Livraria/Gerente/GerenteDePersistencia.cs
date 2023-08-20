using Semana03.Livraria.Interface;
using Semana03.Livraria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Livraria.Gerente
{
    public class GerenteDePersistencia
    {
        public IPersistenciaFatura _iPersistenciaFatura;
        public IPersistenciaLivro _iPersistenciaLivro;

        public GerenteDePersistencia(IPersistenciaFatura persistenciaFatura, IPersistenciaLivro persistenciaLivro)
        {
            this._iPersistenciaFatura = persistenciaFatura;
            this._iPersistenciaLivro = persistenciaLivro;
        }
    }
}
