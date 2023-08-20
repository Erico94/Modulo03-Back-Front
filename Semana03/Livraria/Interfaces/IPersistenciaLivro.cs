using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Livraria.Interfaces
{
    public interface IPersistenciaLivro
    {
        void SalvarLivro(Livro livro);
    }
}
