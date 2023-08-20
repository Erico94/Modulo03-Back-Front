using Semana03.Livraria.Interface;
using Semana03.Livraria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Livraria.Service
{
    public class PersistenciaArquivoService : IPersistenciaFatura, IPersistenciaLivro
    {
        public void SalvarFatura(Fatura fatura)
        {
            Console.WriteLine("Salvando em arquivo...");
            Console.WriteLine("Livro : " + fatura.livro);
            Console.WriteLine("Quantidade: " + fatura.quantidade);
        }

        public void SalvarLivro(Livro livro)
        {
            Console.WriteLine("Salvando livro " + livro.nome + " no formato PDF...");
        }
    }
}
