using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Livraria.Interface
{
    public interface IPersistenciaFatura
    {
        public void SalvarFatura(Fatura fatura);
    }
}
